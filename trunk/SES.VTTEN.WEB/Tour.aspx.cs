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
    public partial class Tour : System.Web.UI.Page
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
                day = day + " day";
            else day = day + " days";
            if (night == "1" || night == "0")
                night = night + " night";
            else night = night + " nights";
            return day + " " + night;
        }
        protected void TourDetailDataSource(int TourID)
        {
            TourDO objTour = new TourDO();
            objTour.TourID = TourID;

            objTour = new TourBL().Select(objTour);

            lblTourName.Text = objTour.Title + " - " + Duration(objTour.DurationDay.ToString(),objTour.DurationNight.ToString());
            
            Page.Title = objTour.Title + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objTour.MetaDes;
            Page.Header.Controls.Add(meta);


            lblTourCode.Text = objTour.TourCode;
            lblPrice.Text = "US $" + objTour.TourPrice.ToString();
            lblDescription.Text = objTour.MetaDes;

            lblTourItinerary.Text = objTour.Description;

            lblTourNote.Text = objTour.Notes;
            //lblTourInclude.Text = objTour.Include;
            //lblTourNoneInclude.Text = objTour.NonInclude;
            lblTourAllPrice.Text = objTour.TourAllPrice;
            hplImg.NavigateUrl = "/Media/" + objTour.TourImage;
            ImgTour.ImageUrl = "/Media/" + objTour.TourImage;
            rpImage.DataSource = new MediaBL().SelectByObject("Tour", objTour.TourID,6);
            rpImage.DataBind();
            hplImg.Attributes.Add("rel", "tourimg");
            hplImg.Attributes.Add("title", objTour.Title);
            
            hplBooking.NavigateUrl = "/Tour-Booking/" + objTour.TourID + "/" + FriendlyUrl(objTour.Alias);
            
        }
    }
}
