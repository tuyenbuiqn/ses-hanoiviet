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
    public partial class LichKhoiHanh : System.Web.UI.Page
    {
        TourTypeDO objTT = new TourTypeDO();
        TourTypeDO objTD = new TourTypeDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Lịch khởi hành";
            HtmlMeta metaDesc = new HtmlMeta();
            metaDesc.Name = "description";
            metaDesc.Content = "Lịch khởi hành - hanoiviettravel";
            Page.Header.Controls.Add(metaDesc);

            HtmlMeta metaKey = new HtmlMeta();
            metaKey.Name = "keywords";
            metaKey.Content = "Lịch khởi hành- hanoiviettravel";
            Page.Header.Controls.Add(metaKey);
            Page.Title = "Lịch khởi hành- hanoiviettravel";
        }
    }
}