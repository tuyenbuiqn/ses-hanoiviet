using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }
        
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        
        public string Duration(string day, string night)
        {

            if (day == "1" || day == "0")
                day = day + " day";
            else day = day + " days";
            if (night == "1" || night == "0")
                night = night + " night";
            else night = night + " nights";
            return day + " " + night;
        }
        
        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                string SearchQuery = Request.QueryString["ID"].ToString();
                int DesID = 0;
                int TourTypeID = 0;
                int TourGiaTourID = 0; 
                int DurationID = 0;
                DesID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                TourTypeID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                TourGiaTourID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                DurationID = int.Parse(SearchQuery);

                bindatalist(new TourBL().SearchGiaTour(DesID, TourTypeID, TourGiaTourID, DurationID));

                Page.Title = "Search results" + Ultility.Webtile();
            }
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        public int CurrentPage
        {
            get
            {
                // look for current page in ViewState
                object o = this.ViewState["_CurrentPage"];
                if (o == null)
                    return 0;	// default to showing the first page
                else
                    return (int)o;
            }

            set
            {
                this.ViewState["_CurrentPage"] = value;
            }
        }

        private void bindatalist(DataTable dt)
        {
            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = dt.DefaultView;

            CollectionPager1.BindToControl = rptTourCat;
            if (dt.Rows.Count > 0)
            {
                rptTourCat.DataSource = CollectionPager1.DataSourcePaged;
                rptTourCat.DataBind();
            }
        }
    }
}
