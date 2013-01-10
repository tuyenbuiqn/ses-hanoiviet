using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucHomeTourCategory : System.Web.UI.UserControl
    {
        TourTypeBL tourtypeBL = new TourTypeBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptParentCate.DataSource = tourtypeBL.SelectAllParentHomePublish(true, true);
            rptParentCate.DataBind();
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        protected void rptParentCate_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;


                DataTable dtMenuChild = tourtypeBL.SelectByTopIDOnlyChild(int.Parse(drv["TourTypeID"].ToString()));
                DataTable dtCateChildHomepage = tourtypeBL.SelectByTopIDOnlyChildHomepage(int.Parse(drv["TourTypeID"].ToString()));

                Repeater rptMenuChild = (Repeater)item.FindControl("rptMenuChild");
                rptMenuChild.DataSource = dtMenuChild;
                rptMenuChild.DataBind();

                Repeater rptCategoryChildHomepage = (Repeater)item.FindControl("rptCategoryChildHomepage");
                rptCategoryChildHomepage.DataSource = dtCateChildHomepage;
                rptCategoryChildHomepage.DataBind();

            }
        }
        protected void rptCategoryChildHomepage_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;

                DataTable dtTopNews = new TourBL().SelectTourByParentAndRecordNumber(int.Parse(drv["TourTypeID"].ToString()), 1);
                DataTable dtOther = new TourBL().SelectTourByParentAndRecordNumber(int.Parse(drv["TourTypeID"].ToString()), 5);     

                Repeater rptTopNews = (Repeater)item.FindControl("rptTopNews");
                rptTopNews.DataSource = dtTopNews;
                rptTopNews.DataBind();


                Repeater rptTopToursList = (Repeater)item.FindControl("rptTopToursList");
                rptTopToursList.DataSource = new DataView(dtOther,"TourID <>" + dtTopNews.Rows[0]["TourID"].ToString(),"",DataViewRowState.CurrentRows);
                rptTopToursList.DataBind();

            }
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 260, new char[] { ' ', '.', ',', ';' }) + "...";
        }


    }
}