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
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB
{
    public partial class Services_Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Ultility.ddlDatabinder(ddlCountry, "NationID", "NationName", new NationBL().SelectAll());

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
            body += "<h2>Bạn nhận được email liên hệ từ khách hàng: " + txtFullName.Text + "</h2>";
            body += "<h4>Thông tin liên của khách hàng</h4>";
            body += "<table>";

            body += "<tr><td style='width:100px;'>Họ tên:</td><td style='font-weight:bold;padding-left:5px;'>" + sGioiTinh + " " + txtFullName.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Email:</td><td style='font-weight:bold;padding-left:5px;'>" + txtEmail.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Địa chỉ:</td><td style='font-weight:bold;padding-left:5px;'>" + txtAddress.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Điện thoại:</td><td style='font-weight:bold;padding-left:5px;'>" + txtPhone.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Fax:</td><td style='font-weight:bold;padding-left:5px;'>" + txtFaxNo.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Ngày sinh:</td><td style='font-weight:bold;padding-left:5px;'>" + ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text + "</td></tr>";
            body += "</table>";

            body += "<h4>Thông tin đặt dịch vụ</h4>";
            body += "<p> Ngày đặt:" + DateTime.Now + "</p>";
            body += "<p> Số người:" + txtNoPerson.Text + "</p>";
            body += "<p> Checkin:" + txtCheckin.Text + "</p>";
            body += "<p>Checkout:" + txtCheckout.Text + "</p>";
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
            objBK.HotelID = 0;
            objBK.ServicesID = int.Parse(ddlRoomCat.SelectedValue);
            objBK.Address = txtAddress.Text;
            objBK.NumberPerson = int.Parse(txtNoPerson.Text);
            objBK.Checkin = txtCheckin.Date;
            objBK.Checkout = txtCheckout.Date;
            objBK.TypeOfRoom = 0;
            if (rdoBilling.SelectedIndex == 0) objBK.BillingOption = false;
            else objBK.BillingOption = true;

            objBK.OtherRequest = txtOtherRequest.Text;
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
            objBK.ArrivalCiy = txtArrivalCity.Text;
            objBK.TimeLocal = txtTimeArrival.Text;

            new BookingBL().Insert(objBK);
            Ultility.sendsMails(txtFullName.Text, SetMailBody(), "Thông tin đặt phòng từ khách hàng " + txtFullName.Text, 1, int.Parse(Request.QueryString["ID"].ToString()));
            Ultility.Alert("Thanks for choosing us, we will contact soon!", "/Default.aspx");
        }
    }
}