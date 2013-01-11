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
using System.Text;
using System.Drawing;
using System.Web.Caching;

namespace SES.VTTEN.WEB
{
    public partial class Tour_Booking : System.Web.UI.Page
    {
        TourDO objTour = new TourDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourID = int.Parse(Request.QueryString["ID"].ToString());
               
                objTour.TourID = TourID;
                objTour = new TourBL().Select(objTour);
                lblTourName.Text = objTour.Title + " (" + objTour.DurationDay + " days " + objTour.DurationNight + " nights)";
                lblTourName.Font.Bold = true;
                hplTourName.NavigateUrl = "/Tour/" + objTour.TourID.ToString() + "/" + Ultility.Change_AV(objTour.Alias);
                lblTourDes.Text = WordCut(objTour.MetaDes);
                Page.Title = "TRAVEL BOOKING FORM - " + objTour.Title + Ultility.Webtile();
                if (!IsPostBack)
                    Ultility.ddlDatabinder(ddlCountry, "NationID", "NationName", new NationBL().SelectAll());
            }

            //DOB
            for (int i = 1; i <= 31; i++)
                ddlDay.Items.Add("" + i);

            for (int i = 1; i <= 12; i++)
                ddlMonth.Items.Add("" + i);

            for (int i = 1900; i <= DateTime.Now.Year; i++)
                ddlYear.Items.Add("" + i);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }
        private string SetMailBody()
        {
            string sGioiTinh = "";
            if (rdoGender.SelectedValue.Equals("Male"))
                sGioiTinh = "Ông";
            if (rdoGender.SelectedValue.Equals("Female"))
                sGioiTinh = "Bà";
            string body = "";
            body += "<h2>Bạn nhận được email đặt Tour từ khách hàng: " + txtFullName.Text + "</h2>";
            body += "<h4>Thông tin liên hệ của khách hàng</h4>";
            body += "<table>";

            body += "<tr><td style='width:100px;'>Họ tên:</td><td style='font-weight:bold;padding-left:5px;'>" + sGioiTinh + " " + txtFullName.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Email:</td><td style='font-weight:bold;padding-left:5px;'>" + txtEmail.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Địa chỉ:</td><td style='font-weight:bold;padding-left:5px;'>" + txtAddress.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Điện thoại:</td><td style='font-weight:bold;padding-left:5px;'>" + txtPhone.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Fax:</td><td style='font-weight:bold;padding-left:5px;'>" + txtFaxNo.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Ngày sinh:</td><td style='font-weight:bold;padding-left:5px;'>" + ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text + "</td></tr>";
            body += "</table>";

            body += "<h4>Thông tin đặt tour</h4>";
            body += "<p> Ngày đặt:" + DateTime.Now + "</p>";
            body += "<p> Tên tour:" + objTour.Title + "</p>";
            body += "<p> Ngày đến:" + txtArrivalDate.Text + "</p>";
            body += "<p> Ngày đi:" + txtDateDepart.Text + "</p>";
            body += "<p> Số người lớn:" + txtAdultNo.Text + "</p>";
            body += "<p> Số trẻ em:" + txtChildNo.Text + "</p>";
            body += "<p>Yêu cầu thêm:" + txtOtherRequest.Text + "</p>";

            body += "<h4>Thông tin thêm</h4>";
            body += "<p>Where did you hear about us:" + ddlHear.Text + "</p>";
            body += "<h4>* Lưu ý: Định dạng ngày tháng(MM/dd/yyyy)</h4>";

            body += "<br /><br /> <h3>Vui lòng cập nhật lại phần quản trị để xem đầy đủ thông tin hơn!</h3>";
            body += "<br /><br /> <h3>Đây là email tự động, vui lòng không trả lời thư này!</h3>";

            return body;
        }
        protected void btnBooking_Click(object sender, EventArgs e)
        {
            BookingDO objBK = new BookingDO();
            objBK.BookingDate = DateTime.Now;
            objBK.TourID = int.Parse(Request.QueryString["ID"].ToString());
            objBK.Address = txtAddress.Text;
            objBK.AdultNo = int.Parse(txtAdultNo.Text);
            objBK.ChildNo = int.Parse(txtChildNo.Text);
            objBK.DepartureDate = txtDateDepart.Date;
            objBK.HotelCat = ddlHotelCat.SelectedIndex;
            if (rdoBilling.SelectedIndex == 0) objBK.BillingOption = false;
            else objBK.BillingOption = true;
            objBK.OtherRequest = txtOtherRequest.Text;
            objBK.InformationSource = ddlHear.Text;
            objBK.FullName = txtFullName.Text;
            if (rdoGender.SelectedIndex == 0) objBK.Gender = false;
            else objBK.Gender = true;

            string DOB = ddlMonth.SelectedValue + "/" + ddlDay.SelectedValue + "/" + ddlYear.SelectedValue;
            objBK.DayOfBirth = Convert.ToDateTime(DOB);
            objBK.Email = txtEmail.Text;
            objBK.Country = int.Parse(ddlCountry.SelectedValue.ToString());
            objBK.Address = txtAddress.Text;
            objBK.PhoneNo = txtPhone.Text;
            objBK.FaxNo = txtFaxNo.Text;
            objBK.ArrivalDate = txtArrivalDate.Date;
            objBK.AirCorp = txtAircop.Text;
            objBK.FlightNo = txtFlightNo.Text;
            objBK.ArrivalCiy = txtArrivalCity.Text;
            objBK.TimeLocal = txtTimeArrival.Text;

            new BookingBL().Insert(objBK);
            Ultility.sendsMails(txtFullName.Text, SetMailBody(), "Thông tin đặt tour từ khách hàng", 0, int.Parse(Request.QueryString["ID"].ToString()));
            Ultility.Alert("Thanks for choosing us, we will contact soon!", "/Default.aspx");

        }

    }
}
