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
    public partial class Albums : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptImagesDataSource();

        }

        protected void rptImagesDataSource()
        {
            rptImages.DataSource = new cmsAlbumBL().SelectByType(true);
            rptImages.DataBind();

        }

        public string Change_AV(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}
