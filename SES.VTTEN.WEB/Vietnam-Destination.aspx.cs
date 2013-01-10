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
    public partial class Vietnam_Destination : System.Web.UI.Page
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

                rptDestinationCatDataSource();

                Page.Title = "Vietnam Destination" + Ultility.Webtile();
               

            }
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptDestinationCatDataSource()
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new DestinationBL().SelectAll().DefaultView;

            CollectionPager1.BindToControl = rptDestinationCat;
            rptDestinationCat.DataSource = CollectionPager1.DataSourcePaged;
            rptDestinationCat.DataBind();
        }

    }
}
