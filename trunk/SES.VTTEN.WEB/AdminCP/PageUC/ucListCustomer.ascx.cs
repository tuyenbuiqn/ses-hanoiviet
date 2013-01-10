using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListCustomer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            gvCustomer.DataSource = new CustomerBL().SelectAll();
            gvCustomer.DataBind();
        }

        protected void gvCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomer.PageIndex = e.NewPageIndex;
            LoadCustomer();
        }

        protected void gvCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new CustomerBL().Delete(new CustomerDO { CustomerID = Convert.ToInt32(gvCustomer.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustomerID = Convert.ToInt32(gvCustomer.DataKeys[gvCustomer.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Customer&CustomerID=" + CustomerID.ToString());
        }
    }
}