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
using System.Net.Configuration;
using System.Net;
using System.Net.Mail;
using System.IO;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Contact Us" + Ultility.Webtile();
            
            //DOB
            for (int i = 1; i <= 31; i++)
                ddlDay.Items.Add("" + i);

            for (int i = 1; i <= 12; i++)
                ddlMonth.Items.Add("" + i);

            for (int i = 1900; i <= DateTime.Now.Year; i++)
                ddlYear.Items.Add("" + i);
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
            body += "<h4>Thông tin liên hệ của khách hàng</h4>";
            body += "<table>";

            body += "<tr><td style='width:100px;'>Họ tên:</td><td style='font-weight:bold;padding-left:5px;'>" + sGioiTinh + " " + txtFullName.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Email:</td><td style='font-weight:bold;padding-left:5px;'>" + txtEmail.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Địa chỉ:</td><td style='font-weight:bold;padding-left:5px;'>" + txtAddress.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Điện thoại:</td><td style='font-weight:bold;padding-left:5px;'>" + txtPhone.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Fax:</td><td style='font-weight:bold;padding-left:5px;'>" + txtFaxNo.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Ngày sinh:</td><td style='font-weight:bold;padding-left:5px;'>" + ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Quốc tịch:</td><td style='font-weight:bold;padding-left:5px;'>" + txtCountry.Text + "</td></tr>";
            body += "</table>";

            body += "<h4>Nội dung liên hệ</h4>";
            body += "<p>" + txtOtherRequest.Text + "</p>";

            body += "<h4>Thông tin thêm</h4>";
            body += "<p>Where did you hear about us:" + ddlHear.Text + "</p>";
            body += "<br /><h4>* Lưu ý: Định dạng ngày tháng(MM/dd/yyyy)</h4>";
            body += "<br /> <h3>Đây là email tự động, vui lòng không trả lời thư này!</h3>";
            return body;
        }
        protected void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = txtFullName.Text;
                String bd = SetMailBody();
                String title = "Liên hệ từ khách hàng - " + DateTime.Now.ToShortDateString() ;
                Ultility.sendsMail(ten, bd, title);

                Ultility.Alert("Gửi liên hệ thành công!!!", "/Default.aspx");
            }
            catch
            {
            }
        }
    }
}
