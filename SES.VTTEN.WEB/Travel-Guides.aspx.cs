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
    public partial class Travel_Guides : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ContentTypeID = int.Parse(Request.QueryString["ID"].ToString());
                rptContentCatDataSource(ContentTypeID);
                ContentTypeDO objTT = new ContentTypeBL().Select(new ContentTypeDO { ContentTypeID = ContentTypeID });
                lblCatName.Text = objTT.Title;

                Page.Title = objTT.Title + Ultility.Webtile();
                

            }
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptContentCatDataSource(int ContentTypeID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new ContentBL().SelectNumberType(100, ContentTypeID).DefaultView; ;

            CollectionPager1.BindToControl = rptContentCat;
            rptContentCat.DataSource = CollectionPager1.DataSourcePaged;
            rptContentCat.DataBind();
        }

    }
}
