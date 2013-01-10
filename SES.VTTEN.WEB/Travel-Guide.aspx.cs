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
    public partial class Travel_Guide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ContentID = int.Parse(Request.QueryString["ID"].ToString());

                ContentDetailDataSource(ContentID);

            }

        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void ContentDetailDataSource(int ContentID)
        {
            ContentDO objContent = new ContentDO();
            objContent.ContentID = ContentID;

            objContent = new ContentBL().Select(objContent);

            lblContentName.Text = objContent.Title;

            Page.Title = objContent.Title + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objContent.MetaDes;
            Page.Header.Controls.Add(meta);


           
            lblDescription.Text = objContent.ContentDetail;

            rptRelatedContent.DataSource = new DataView(new ContentBL().SelectNumberType(10, 1), "ContentID<>" + objContent.ContentID, "", DataViewRowState.CurrentRows);
            rptRelatedContent.DataBind();


        }
    }
}
