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
    public partial class ucTourDetail : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourID = int.Parse(Request.QueryString["ID"].ToString());

                TourDetailDataSource(TourID);

            }
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        
        public string Duration(string day, string night)
        {

            if (day == "1" || day == "0")
                day = day + " ngày";
            else day = day + " ngày";
            if (night == "1" || night == "0")
                night = night + " đêm";
            else night = night + " đêm";
            return day + " " + night;
        }
        
        protected void TourDetailDataSource(int TourID)
        {
            TourDO objTour = new TourDO();
            objTour.TourID = TourID;

            objTour = new TourBL().Select(objTour);

            lblTourName.Text = objTour.Title + " (" + Duration(objTour.DurationDay.ToString(), objTour.DurationNight.ToString()) + ")";

            Page.Title = objTour.Title + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objTour.MetaDes;
            Page.Header.Controls.Add(meta);

            lblTourCode.Text = objTour.TourCode;
            lblPrice.Text = string.Format("{0:0,000}", objTour.TourPrice);
            lblDescription.Text = objTour.MetaDes;
            lblDurationDay.Text = Duration(objTour.DurationDay.ToString(), objTour.DurationNight.ToString());

            lblTourItinerary.Text = objTour.Description;

            rpImage.DataSource = new MediaBL().SelectByObject("Tour", objTour.TourID, 3);
            rpImage.DataBind();

            hplBooking.NavigateUrl = "/Tour-Booking/" + objTour.TourID + "/" + FriendlyUrl(objTour.Alias);
            ImgDetail.ImageUrl = "/Media/" + objTour.TourImage.ToString();
            aTour.Attributes.Add("href","/Media/" + objTour.TourImage);
        }
    }
}