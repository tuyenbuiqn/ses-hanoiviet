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
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int AlbumID = int.Parse(Request.QueryString["ID"].ToString());
                rptImagesDataSource(AlbumID);
                Page.Title = new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = AlbumID }).Title.ToString();
            }

        }

        private void rptImagesDataSource(int AlbumID)
        {
            rptImages.DataSource = new cmsAlbumDetailBL().SelectByAlbumID(AlbumID);
            rptImages.DataBind();

            lblAlbum.Text = new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = AlbumID }).Title.ToString();
        }

        public string Change_AV(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}
