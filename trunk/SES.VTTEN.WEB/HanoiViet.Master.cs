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

namespace SES.VTTEN.WEB
{
    public partial class HanoiViet : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptAbout.DataSource = new ContentBL().SelectNumberType(10, 2);
            rptAbout.DataBind();
            string url = Request.Url.AbsolutePath;
            lblFooter.Text = new ConfigBL().Select(new ConfigDO { ConfigID = 5 }).ConfigValue.ToString();


            if (url.Equals("/Default.aspx") || url.Equals("/default.aspx"))
            {

                //<link rel="stylesheet" type="text/css" href="" />
                // <script type="text/javascript" src="/js/preview.js"></script>
   
                ucSlideHome1.Visible = true;
                ucSlidePage1.Visible = false;

                spOnline.Visible = false;
                head.Controls.Add(CreateCssLink("~/wt-rotator.css",string.Empty));
                Page.Header.Controls.Add(CreateJavaScriptLink("~/js/preview.js"));

               

            }
            else
            {
                ucSlideHome1.Visible = false;
                ucSlidePage1.Visible = true;
                Page.Header.Controls.Add(CreateCssLink("~/wt-rotatorpage.css", string.Empty));
                Page.Header.Controls.Add(CreateJavaScriptLink("~/js/preview-page.js"));
                spOnline.Visible = true;
            }
           
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        public static HtmlLink CreateCssLink(string cssFilePath, string media)
        {
            var link = new HtmlLink();
            link.Attributes.Add("type", "text/css");
            link.Attributes.Add("rel", "stylesheet");
            link.Href = link.ResolveUrl(cssFilePath);
            return link;
        }

        public static HtmlGenericControl CreateJavaScriptLink(string scriptFilePath)
        {
            var script = new HtmlGenericControl();
            script.TagName = "script";
            script.Attributes.Add("type", "text/javascript");
            script.Attributes.Add("src", script.ResolveUrl(scriptFilePath));
            return script;
        }
    }
}
