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
    public partial class ucListImgAlbum : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvAlbumDataSource();
        }
        protected void gvAlbumDataSource()
        {
            gvAlbum.DataSource = new cmsAlbumBL().SelectByType(true);
            gvAlbum.DataBind();
        }
        protected void gvAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AlbumID = int.Parse(gvAlbum.DataKeys[gvAlbum.SelectedIndex].Value.ToString());
            Response.Redirect("Default.aspx?Page=Album&AlbumID=" + AlbumID.ToString());
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=Album");
        }

        protected void gvAlbum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            new cmsAlbumBL().Delete(new cmsAlbumDO { AlbumID = Convert.ToInt32(gvAlbum.DataKeys[e.RowIndex].Value) });
            Functions.Alert("Xóa thành công", "Default.aspx?Page=ListImgAlbum");
        }
    }
}