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
    public partial class ListTour : System.Web.UI.MasterPage
    {
        SlideBL slideBL = new SlideBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptListImage.DataSource = slideBL.SelectByCategoryID(1);
            rptListImage.DataBind();

            rptListVNTour.DataSource = new TourTypeBL().SelectByTopID(1);//List theo du lịch trong nước
            rptListVNTour.DataBind();

            rptListENTour.DataSource = new TourTypeBL().SelectByTopID(20);//List theo du lịch nước ngoài
            rptListENTour.DataBind();

            rptListVnTourleft.DataSource = new TourTypeBL().SelectByTopID(1);//List theo du lịch trong nước
            rptListVnTourleft.DataBind();

            rptListEnTourleft.DataSource = new TourTypeBL().SelectByTopID(20);//List theo du lịch nước ngoài
            rptListEnTourleft.DataBind();

            //Ẩn hiện menu con của Du lịch việt nam
            if (Request.QueryString["P"] != null)
            {
                string TourPage = Request.QueryString["P"].ToString();
                if ((TourPage == "Tour-Category") || (TourPage == "Tour"))
                {
                    Full.Visible = true;
                }
                else
                {
                    Full.Visible = false;
                }
            }
            //end Ẩn hiện menu con của Du lịch việt nam
        }
    }
}