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
    public partial class ucListCustomizeTour : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Permission"].ToString()=="admin")
                gvCustomizeTourDataSource();
        }

        protected void gvCustomizeTourDataSource()
        {
            gvCustomizeTour.DataSource = new CustomizeTourBL().SelectAll();
            gvCustomizeTour.DataBind();
        }
        protected void gvCustomizeTour_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomizeTour.PageIndex = e.NewPageIndex;
            gvCustomizeTourDataSource();
        }

        protected void gvCustomizeTour_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new CustomizeTourBL().Delete(new CustomizeTourDO { CustomizeTourID = Convert.ToInt32(gvCustomizeTour.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvCustomizeTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustomizeTourID = Convert.ToInt32(gvCustomizeTour.DataKeys[gvCustomizeTour.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=CustomizeTour&CustomizeTourID=" + CustomizeTourID.ToString());
        }
    }
}