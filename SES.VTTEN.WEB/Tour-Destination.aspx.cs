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
    public partial class Tour_Destination : System.Web.UI.Page
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
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());
                //bindatalist(new TourBL().SelectbyTourType(TourTypeID));
                
                //TourTypeDO objTT = new TourTypeBL().Select(new TourTypeDO { TourTypeID = TourTypeID });
                //lblCatName.Text = objTT.Title;
                //TourDestinationDO objTD = new TourDestinationBL().SelectbyDestination(DestinationID);
                DestinationDO objD = new DestinationBL().Select(new DestinationDO { DestinationID = DestinationID });
                lblCatName.Text = objD.Title;

                //DataTable dt = new TourDestinationBL().SelectbyDestination(DestinationID);
                //int TourID = int.Parse(dt.Rows[0].ItemArray[1].ToString());

                rptTourCatDataSource(DestinationID);

                Page.Title = objD.Title + Ultility.Webtile();
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                meta.Content = objD.Description;
                Page.Header.Controls.Add(meta);

            }
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptTourCatDataSource(int DestinationID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new TourBL().SelectbyDes(DestinationID).DefaultView ;

            CollectionPager1.BindToControl = rptTourCat;
            rptTourCat.DataSource = CollectionPager1.DataSourcePaged;
            rptTourCat.DataBind();
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

        //        rptTourCat.DataSource = objPds;
        //        rptTourCat.DataBind();
        //    }
        //}




    }
}
