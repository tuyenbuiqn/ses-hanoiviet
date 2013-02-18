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
    public partial class ucServicesBooking : System.Web.UI.UserControl
    {
        BookingDO objBook = new BookingDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["BookingID"]))
            {
                int BookingID = int.Parse(Request.QueryString["BookingID"].ToString());
                objBook.BookingID = BookingID;
                InitForm();
            }
        }

        protected void InitForm()
        {
            objBook = new BookingBL().Select(objBook);
            //Thông tin khách hàng
            lblFullName.Text = objBook.FullName;
            if (objBook.Gender == true)
                lblGioiTInh.Text = "Nữ";
            else lblGioiTInh.Text = "Nam";
            lblNgaySinh.Text = objBook.DayOfBirth.ToShortDateString();
            lblEmail.Text = objBook.Email;
            lblDienThoai.Text = objBook.PhoneNo;
            lblDiaChi.Text = objBook.Address;
            lblFax.Text = objBook.FaxNo;
            lblCountry.Text = new NationBL().Select(new NationDO { NationID = objBook.Country }).NationName;

            // Tour
            lblAdult.Text = objBook.AdultNo.ToString();
            //lblChildren.Text = objBook.ChildNo.ToString();
            if (objBook.ServicesID == 1)
            {
                lblHotelName.Text = "Đặt Máy bay";
            }
            else if (objBook.ServicesID == 2)
            {
                lblHotelName.Text = "Đặt Tầu";
            }
            else if (objBook.ServicesID == 3)
            {
                lblHotelName.Text = "Thuê xe dịch vụ";
            }
            else 
            {
                lblHotelName.Text = "";
            }
            lblDeparture.Text = objBook.DepartureDate.ToShortDateString();
            //if (objBook.HotelCat == 0)
            //    lblHotelCat.Text = "Standard";
            //else if (objBook.HotelCat == 1)
            //    lblHotelCat.Text = "Superior";
            //else if (objBook.HotelCat == 2)
            //    lblHotelCat.Text = "Deluxe";
            //else if (objBook.HotelCat == 3)
            //    lblHotelCat.Text = "Luxury";

            if (objBook.BillingOption == false) lblBillingOption.Text = "Bank transfer";
            else lblBillingOption.Text = "Credit Card";

            //

            lblArrival.Text = objBook.ArrivalDate.ToShortDateString();
            lblAirCorp.Text = objBook.AirCorp;
            //lblFightNo.Text = objBook.FlightNo;
            lblArrivalCity.Text = objBook.ArrivalCiy;
            lblTime.Text = objBook.TimeLocal;
            lblInfo.Text = objBook.InformationSource;
        }
    }
}