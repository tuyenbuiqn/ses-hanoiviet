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
    public partial class Tour_Category : System.Web.UI.Page
    {
        string sReturn = "";
        TourTypeDO objTT = new TourTypeDO();
        TourTypeDO objTD = new TourTypeDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourTypeID = int.Parse(Request.QueryString["ID"].ToString());
                if (TourTypeID == 0)
                {
                    lblTitle.Text = "Danh sách tour";
                }
                else
                {
                    lblTitle.Text = "<a href=\"/Default.aspx\" title=\"Trang chủ\">Trang chủ</a>" + TourCate(TourTypeID);
                }
                if (!IsPostBack)
                {
                    try
                    {
                        objTD = new TourTypeBL().Select(new TourTypeDO { TourTypeID = TourTypeID });
                    }
                    catch (Exception)
                    {
                    }
                    if (objTD != null)
                    {
                        HtmlMeta metaDesc = new HtmlMeta();
                        metaDesc.Name = "description";
                        metaDesc.Content = objTD.Description;
                        Page.Header.Controls.Add(metaDesc);

                        HtmlMeta metaKey = new HtmlMeta();
                        metaKey.Name = "keywords";
                        metaKey.Content = objTD.Alias;
                        Page.Header.Controls.Add(metaKey);

                        Page.Title = objTD.Title;
                    }
                }
            }
            
        }
        public string TourCate(int TourTypeID)
        {
            try
            {
                objTT = new TourTypeBL().Select(new TourTypeDO { TourTypeID = TourTypeID });
            }
            catch (Exception)
            {
            }
            
            if (objTT.ParentID == 0)
            {
                sReturn = " » " + "<a href=\"/Tour-Category/" + objTT.TourTypeID.ToString() + "/" + objTT.Alias.ToString() + ".aspx\" title=\"" + objTT.Alias.ToString() + "\">" + objTT.Title.ToString() + "</a>" + sReturn;
            }
            else
            {
                sReturn = " » " + "<a href=\"/Tour-Category/" + objTT.TourTypeID.ToString() + "/" + objTT.Alias.ToString() + ".aspx\" title=\"" + objTT.Alias.ToString() + "\">" + objTT.Title.ToString() + "</a>" + sReturn;
                TourCate(objTT.ParentID);
            }
            return sReturn;
        }
    }
}
