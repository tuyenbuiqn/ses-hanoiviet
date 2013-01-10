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
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListReview : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomerReview();
        }

        private void LoadCustomerReview()
        {
            gvCustomerReview.DataSource = new CustomerReviewBL().SelectAll();
            gvCustomerReview.DataBind();
        }
        protected void gvCustomerReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustomerReviewID = Convert.ToInt32(gvCustomerReview.DataKeys[gvCustomerReview.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Review&CustomerReviewID=" + CustomerReviewID.ToString());
        }

        protected void gvCustomerReview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomerReview.PageIndex = e.NewPageIndex;
            LoadCustomerReview();
        }

        protected void gvCustomerReview_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new CustomerReviewBL().Delete(new CustomerReviewDO { CustomerReviewID = Convert.ToInt32(gvCustomerReview.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 80, new char[] { ' ', '.', ',', ';' }) + "...";
        }
    }
}