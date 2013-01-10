using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SES.VTTEN.DO;
using SES.VTTEN.BL;
namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucCustomizeTour : System.Web.UI.UserControl
    {
        CustomizeTourDO objBook = new CustomizeTourDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["CustomizeTourID"]))
            {
                int CustomizeTourID = int.Parse(Request.QueryString["CustomizeTourID"].ToString());
                objBook.CustomizeTourID = CustomizeTourID;
                InitForm();
            }

        }

        protected void InitForm()
        {
            objBook = new CustomizeTourBL().Select(objBook);
            //Thông tin khách hàng
            lblFullName.Text = objBook.FullName;
            if (objBook.Gender == true)
                lblGioiTInh.Text = "Nữ";
            else lblGioiTInh.Text = "Nam";
            lblNgaySinh.Text = objBook.DateOfBirth.ToShortDateString();
            lblEmail.Text = objBook.Email;
            lblDienThoai.Text = objBook.PhoneNo;
            lblDiaChi.Text = objBook.Address;
            lblFax.Text = objBook.FaxNo;
            lblCountry.Text = objBook.Country.ToString();

            // Tour
            lblAdult.Text = objBook.AdultNo.ToString();
            lblChildren.Text = objBook.ChildNo.ToString();
            lblDeparture.Text = objBook.DepartureDate.ToShortDateString();
            if (objBook.HotelCat == 0)
                lblHotelCat.Text = "Standard";
            else if (objBook.HotelCat == 1)
                lblHotelCat.Text = "Superior";
            else if (objBook.HotelCat == 2)
                lblHotelCat.Text = "Deluxe";
            else if (objBook.HotelCat == 3)
                lblHotelCat.Text = "Luxury";

            if (objBook.BillingOption == false) lblBillingOption.Text = "Bank transfer";
            else lblBillingOption.Text = "Credit Card";

            //

            lblArrival.Text = objBook.ArrivalDate.ToShortDateString();
            //lblInfo.Text = objBook.InformationSource;

            lblTransport.Text = objBook.Transport;
            lblAccommodation.Text = objBook.Accommodation;
            lblMeal.Text = objBook.Meals;
            lblTourProgramme.Text = objBook.TourProgramme;
            lblPlaceToVisit.Text = objBook.PlaceToVisit;
        }
    }
}