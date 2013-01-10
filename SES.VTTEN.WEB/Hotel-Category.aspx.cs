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
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB
{
    public partial class Hotel_Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());
                rptHotelCatDataSource(DestinationID);
                DestinationDO objTT = new DestinationBL().Select(new DestinationDO { DestinationID = DestinationID });
                lblCatName.Text = objTT.Title;
                if(DestinationID==0)
                    lblCatName.Text = "Vietnam";
                Page.Title = lblCatName.Text + Ultility.Webtile();
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                meta.Content = objTT.Description;
                Page.Header.Controls.Add(meta);

            }
        }
        public string StarRate(string s)
        {
            int n = int.Parse(s);
            return Ultility.StarRateHome(n);
        }
        protected void rptHotelCatDataSource(int DestinationID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new HotelBL().SelectbyDestination(DestinationID).DefaultView;

            CollectionPager1.BindToControl = rptHotelCat;
            rptHotelCat.DataSource = CollectionPager1.DataSourcePaged;
            rptHotelCat.DataBind();
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        //public int CurrentPage
        //{
        //    get
        //    {
        //        // look for current page in ViewState
        //        object o = this.ViewState["_CurrentPage"];
        //        if (o == null)
        //            return 0;	// default to showing the first page
        //        else
        //            return (int)o;
        //    }

        //    set
        //    {
        //        this.ViewState["_CurrentPage"] = value;
        //    }
        //}

        //protected void cmdPrev_Click(object sender, ImageClickEventArgs e)
        //{
        //    CurrentPage -= 1;

        //    // Reload control
        //    LoadRPT();
        //}
        //protected void cmdNext_Click(object sender, ImageClickEventArgs e)
        //{
        //    CurrentPage += 1;
        //    LoadRPT();
        //}

        //private void bindatalist(DataTable dt)
        //{

        //    PagedDataSource objPds = new PagedDataSource();
        //    objPds.DataSource = dt.DefaultView;
        //    objPds.AllowPaging = true;
        //    objPds.PageSize = 8;
        //    objPds.CurrentPageIndex = CurrentPage;
        //    cmdPrev.Visible = !objPds.IsFirstPage;
        //    cmdNext.Visible = !objPds.IsLastPage;
        //    if (dt.Rows.Count > 0)
        //    {

        //        rptHotelCat.DataSource = objPds;
        //        rptHotelCat.DataBind();
        //    }
        //}
    }
}
