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

namespace SES.VTTEN.WEB.Module
{
    public partial class ucTravelNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }

        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ModulID = int.Parse(Request.QueryString["ID"].ToString());
                rptHotelCatDataSource(ModulID);
                
            }
        }

        public string StarRate(string s)
        {
            int n = int.Parse(s);
            return Ultility.StarRateHome(n);
        }

        protected void rptHotelCatDataSource(int ModulID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new NewsBL().SelectNewsByModulID(ModulID).DefaultView;

            CollectionPager1.BindToControl = rptHotelCat;
            rptHotelCat.DataSource = CollectionPager1.DataSourcePaged;
            rptHotelCat.DataBind();
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 500, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void rptHotelCat_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            Panel pnlAction = (Panel)e.Item.FindControl("pnlAction");
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int ModulID = int.Parse(Request.QueryString["ID"].ToString());
                if ((ModulID == 4) || (ModulID == 5) || (ModulID == 6))
                {
                    pnlAction.Visible = true;
                }
                else
                {
                    pnlAction.Visible = false;
                }
            }
        }
    }
}