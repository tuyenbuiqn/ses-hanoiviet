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
    public partial class ucListAdvert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadAdvert();
        }

        private void LoadAdvert()
        {
            gvAdvert.DataSource = new AdvertBL().SelectAll();
            gvAdvert.DataBind();
        }

        protected void gvAdvert_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAdvert.PageIndex = e.NewPageIndex;
            LoadAdvert();
        }

        protected void gvAdvert_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new AdvertBL().Delete(new AdvertDO { AdvertID = Convert.ToInt32(gvAdvert.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvAdvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AdvertID = Convert.ToInt32(gvAdvert.DataKeys[gvAdvert.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Adverts&AdvertID=" + AdvertID.ToString());
        }
    }
}