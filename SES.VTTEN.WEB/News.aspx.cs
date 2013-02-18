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
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsDO objN = new NewsDO();
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int NewsID = int.Parse(Request.QueryString["ID"].ToString());
                string Page = Request.QueryString["P"].ToString();
                try
                {
                    objN = new NewsBL().Select(new NewsDO { NewsID = NewsID });
                }
                catch (Exception)
                {
                }
                if (objN.ModuleID == 0)
                {
                    hplModul.NavigateUrl = "/Travel-News/0/Default.aspx";
                    hplModul.ToolTip = "Blog du lịch";
                    hplModul.Text = "Blog du lịch";
                }
                else if (objN.ModuleID == 1)
                {
                    hplModul.NavigateUrl = "/Travel-News/1/Default.aspx";
                    hplModul.ToolTip = "Lịch khởi hành";
                    hplModul.Text = "Lịch khởi hành";
                }
                else if (objN.ModuleID == 2)
                {
                    hplModul.NavigateUrl = "/Travel-News/2/Default.aspx";
                    hplModul.ToolTip = "Khám phá du lịch";
                    hplModul.Text = "Khám phá du lịch";
                }
                else if (objN.ModuleID == 3)
                {
                    hplModul.NavigateUrl = "/Travel-News/3/Default.aspx";
                    hplModul.ToolTip = "Tư vấn du lịch";
                    hplModul.Text = "Tư vấn du lịch";
                }
                else if (objN.ModuleID == 4)
                {
                    hplModul.NavigateUrl = "/Travel-News/4/Default.aspx";
                    hplModul.ToolTip = "Máy bay";
                    hplModul.Text = "Dịch vụ » Máy bay";
                }
                else if (objN.ModuleID == 5)
                {
                    hplModul.NavigateUrl = "/Travel-News/5/Default.aspx";
                    hplModul.ToolTip = "Tầu";
                    hplModul.Text = "Dịch vụ » Tầu";
                }
                else if (objN.ModuleID == 6)
                {
                    hplModul.NavigateUrl = "/Travel-News/6/Default.aspx";
                    hplModul.ToolTip = "Thuê xe du lịch";
                    hplModul.Text = "Dịch vụ » Thuê xe du lịch";
                }

                NewsDetailDataSource(NewsID);

            }

        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void NewsDetailDataSource(int NewsID)
        {
            NewsDO objNews = new NewsDO();
            objNews.NewsID = NewsID;

            objNews = new NewsBL().Select(objNews);

            lblNewsTitle.Text = objNews.Title;

            Page.Title = lblNewsTitle.Text + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objNews.Description;
            Page.Header.Controls.Add(meta);

            lblDescription.Text = objNews.Detail;
            hplIMG.Attributes.Add("title", objNews.Title);
            hplIMG.NavigateUrl = imgRV.ImageUrl = "/Media/" + objNews.NewsImage;

            rptRelatedReview.DataSource = new DataView(new NewsBL().SelectbyNumber(), "NewsID<>" + objNews.NewsID, "", DataViewRowState.CurrentRows);
            rptRelatedReview.DataBind();
        }
    }
}
