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

namespace SES.VTTEN.WEB
{
    public partial class Travel_News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlMeta metaDesc = new HtmlMeta();
            metaDesc.Name = "description";
            metaDesc.Content = "Tin tức du lịch - hanoiviettravel";
            Page.Header.Controls.Add(metaDesc);

            HtmlMeta metaKey = new HtmlMeta();
            metaKey.Name = "keywords";
            metaKey.Content = "Tin tức du lịch - hanoiviettravel";
            Page.Header.Controls.Add(metaKey);

            Page.Title = "Tin tức du lịch - hanoiviettravel";
        }
    }
}
