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
                int TourCatID = 0; 
                int DurationID = 0;
                DesID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                TourTypeID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                TourCatID = int.Parse(SearchQuery.Substring(0, SearchQuery.IndexOf("-")));
                SearchQuery = SearchQuery.Substring(SearchQuery.IndexOf("-") + 1);
                DurationID = int.Parse(SearchQuery);

                bindatalist(new TourBL().Search(DesID,TourTypeID,TourCatID,DurationID));
               

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

        protected void cmdPrev_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage -= 1;

            // Reload control
            LoadRPT();
        }
        protected void cmdNext_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage += 1;
            LoadRPT();
        }

        private void bindatalist(DataTable dt)
        {

            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 8;
            objPds.CurrentPageIndex = CurrentPage;
            cmdPrev.Visible = !objPds.IsFirstPage;
            cmdNext.Visible = !objPds.IsLastPage;
            if (dt.Rows.Count > 0)
            {

                rptTourCat.DataSource = objPds;
                rptTourCat.DataBind();
            }
        }
    }
}
