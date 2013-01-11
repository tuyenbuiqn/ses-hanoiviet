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
    public partial class Hotel_Category : System.Web.UI.Page
    {
        DestinationDO objHT = new DestinationDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());
                try
                {
                    objHT = new DestinationBL().Select(new DestinationDO { DestinationID = DestinationID });
                }
                catch (Exception)
                {
                    
                    throw;
                }
                if (objHT != null)
                {
                    lblTitle.Text = objHT.Title;
                    if (DestinationID == 0)
                    {
                        lblTitle.Text = " Việt Nam";
                    }

                    HtmlMeta metaDesc = new HtmlMeta();
                    metaDesc.Name = "description";
                    metaDesc.Content = objHT.MetaDes;
                    Page.Header.Controls.Add(metaDesc);

                    HtmlMeta metaKey = new HtmlMeta();
                    metaKey.Name = "keywords";
                    metaKey.Content = objHT.MetaTag;
                    Page.Header.Controls.Add(metaKey);

                    Page.Title = objHT.Title;
                }
            }
        }
    }
}
