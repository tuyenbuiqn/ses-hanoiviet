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
            HtmlMeta metaKey = new HtmlMeta();
            if (Request.QueryString["ID"] != null)
            {
                string ID = Request.QueryString["ID"].ToString();
                if (ID == "1")
                {
                    metaDesc.Name = "description";
                    metaDesc.Content = "Lịch khởi hành - hanoiviettravel";
                    Page.Header.Controls.Add(metaDesc);

                    metaKey.Name = "keywords";
                    metaKey.Content = "Lịch khởi hành - hanoiviettravel";
                    Page.Header.Controls.Add(metaKey);

                    Page.Title = "Lịch khởi hành - hanoiviettravel";

                    lblTitle.Text = "» Lịch khởi hành";
                    hplGoc.Visible = false;
                }
                else if (ID == "0")
                {
                    lblTitle.Text = "» Blog du lịch";
                    hplGoc.NavigateUrl = "/Travel-News/0/Default.aspx";
                    hplGoc.Text = "» Tin tức du lịch";
                    hplGoc.ToolTip = "Tin tức du lịch";
                    hplGoc.Visible = true;
                }
                else if (ID == "2")
                {
                    lblTitle.Text = "» Khám phá du lịch";
                    hplGoc.NavigateUrl = "/Travel-News/0/Default.aspx";
                    hplGoc.Text = "» Tin tức du lịch";
                    hplGoc.ToolTip = "Tin tức du lịch";
                    hplGoc.Visible = true;
                }
                else if (ID == "3")
                {
                    lblTitle.Text = "» Tư vấn du lịch";
                    hplGoc.NavigateUrl = "/Travel-News/0/Default.aspx";
                    hplGoc.Text = "» Tin tức du lịch";
                    hplGoc.ToolTip = "Tin tức du lịch";
                    hplGoc.Visible = true;
                }
                else if (ID == "4")
                {
                    lblTitle.Text = "» Máy bay";
                    hplGoc.NavigateUrl = "/Hotel-Category/0/Default.aspx";
                    hplGoc.Text = "» Dịch vụ";
                    hplGoc.ToolTip = "Dịch vụ";
                    hplGoc.Visible = true;
                }
                else if (ID == "5")
                {
                    lblTitle.Text = "» Tầu";
                    hplGoc.NavigateUrl = "/Hotel-Category/0/Default.aspx";
                    hplGoc.Text = "» Dịch vụ";
                    hplGoc.ToolTip = "Dịch vụ";
                    hplGoc.Visible = true;
                }
                else if (ID == "6")
                {
                    lblTitle.Text = "» Thuê xe du lịch";
                    hplGoc.NavigateUrl = "/Hotel-Category/0/Default.aspx";
                    hplGoc.Text = "» Dịch vụ";
                    hplGoc.ToolTip = "Dịch vụ";
                    hplGoc.Visible = true;
                }
            }
            else
            {
                lblTitle.Text = "» Tin tức";
                hplGoc.NavigateUrl = "/Travel-News/0/Default.aspx";
                hplGoc.Text = "» Tin tức du lịch";
                hplGoc.ToolTip = "Tin tức du lịch";
                hplGoc.Visible = true;
            }
            metaDesc.Name = "description";
            metaDesc.Content = "Tin tức du lịch - hanoiviettravel";
            Page.Header.Controls.Add(metaDesc);

            metaKey.Name = "keywords";
            metaKey.Content = "Tin tức du lịch - hanoiviettravel";
            Page.Header.Controls.Add(metaKey);

            Page.Title = "Tin tức du lịch - hanoiviettravel";
            
        }
    }
}
