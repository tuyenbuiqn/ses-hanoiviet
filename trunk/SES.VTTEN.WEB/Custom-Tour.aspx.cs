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
    public partial class Custom_Tour : System.Web.UI.Page
    {
        CustomizeTourDO objCusTour = new CustomizeTourDO();
        DestinationBL desBL = new DestinationBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cblCenter.DataSource = desBL.SelectByRegions(2);
                cblCenter.DataBind();

                cblNorth.DataSource = desBL.SelectByRegions(1);
                cblNorth.DataBind();

                cblSouth.DataSource = desBL.SelectByRegions(3);
                cblSouth.DataBind();
            }

            //DOB
            for (int i = 1; i <= 31; i++)
                ddlDay.Items.Add("" + i);

            for (int i = 1; i <= 12; i++)
                ddlMonth.Items.Add("" + i);

            for (int i = 1900; i <= DateTime.Now.Year; i++)
                ddlYear.Items.Add("" + i);
        }

        

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            SetObject();
            new CustomizeTourBL().Insert(objCusTour);
            Ultility.sendsMail(txtFullName.Text, SetMailBody(), "Thông tin đặt customize tour - " + txtFullName.Text);
            Ultility.Alert("Thanks for choosing us, we will contact soon!", "/Default.aspx");
        }
        private string SetMailBody()
        {
            string body = "";
            body += "<h2>Bạn nhận được email Customize Tour từ khách hàng: " + txtFullName.Text + "</h2>";
            body += "<h4>Thông tin liên hệ của khách hàng</h4>";
            body += "<table>";

            body += "<tr><td style='width:100px;'>Họ tên:</td><td style='font-weight:bold;padding-left:5px;'>" + rdoGender.SelectedValue + " " + txtFullName.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Email:</td><td style='font-weight:bold;padding-left:5px;'>" + txtEmail.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Địa chỉ:</td><td style='font-weight:bold;padding-left:5px;'>" + txtAddress.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Điện thoại:</td><td style='font-weight:bold;padding-left:5px;'>" + txtPhone.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Fax:</td><td style='font-weight:bold;padding-left:5px;'>" + txtFaxNo.Text + "</td></tr>";
            body += "<tr><td style='width:100px;'>Ngày sinh:</td><td style='font-weight:bold;padding-left:5px;'>" + ddlDay.Text + "/" + ddlMonth.Text + "/" + ddlYear.Text + "</td></tr>";
            body += "</table>";

            body += "<h4>Thông tin Customize Tour</h4>";
            body += "<p> Ngày đặt:" + DateTime.Now + "</p>";
            body += "<p> Ngày đến:" + txtArrivalDate.Text + "</p>";
            body += "<p> Ngày đi:" + txtDateDepart.Text + "</p>";
            body += "<p> Số người lớn:" + txtAdultNo.Text + "</p>";
            body += "<p> Số trẻ em:" + txtChildNo.Text + "</p>";
            body += "<p>Yêu cầu thêm:" + txtOtherRequest.Text + "</p>";

            string sPlaceToVisit = "";
            foreach (ListItem item in cblNorth.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }
            foreach (ListItem item in cblCenter.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }
            foreach (ListItem item in cblSouth.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }
            body += "<p>Nơi muốn đi:" + sPlaceToVisit + "</p>";

            body += "<h4>Thông tin thêm</h4>";
            body += "<p>Where did you hear about us:" + ddlHear.Text + "</p>";

            body += "<br /><br /> <h3>Vui lòng cập nhật lại phần quản trị để xem đầy đủ thông tin hơn!</h3>";
            body += "<br /><br /> <h3>Đây là email tự động, vui lòng không trả lời thư này!</h3>";

            return body;
        }
        protected void SetObject()
        {
            objCusTour.CusDate = DateTime.Now;

            //Customer information
            objCusTour.FullName = txtFullName.Text;
            if (rdoGender.SelectedIndex == 0) objCusTour.Gender = false;
            else objCusTour.Gender = true;
            objCusTour.Address = txtAddress.Text;

            string DOB = ddlMonth.SelectedValue + "/" + ddlDay.SelectedValue + "/" + ddlYear.SelectedValue;
            objCusTour.DateOfBirth = Convert.ToDateTime(DOB);
            objCusTour.Email = txtEmail.Text;
            objCusTour.Country = txtCountry.Text;
            objCusTour.PhoneNo = txtPhone.Text;
            objCusTour.FaxNo = txtFaxNo.Text;

            //Trip Information
            objCusTour.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            objCusTour.DepartureDate = Convert.ToDateTime(txtDateDepart.Text);
            objCusTour.AdultNo = int.Parse(txtAdultNo.Text);
            objCusTour.ChildNo = int.Parse(txtChildNo.Text);
            objCusTour.HotelCat = int.Parse(ddlHotelCat.SelectedValue);

            //Travel Arrangement
            objCusTour.Transport = rdTransport.SelectedValue;
            //objCusTour.Transport
            string sTourProgramme = "";
            foreach (ListItem cBox in chblTourProgramme.Items)
            {
                if (cBox.Selected)
                {
                    sTourProgramme += cBox.Text + ", ";
                }
            }
            sTourProgramme += txtTourProgramme.Text;
            objCusTour.TourProgramme = sTourProgramme;

            //objCusTour.Accommodation
            string sAccommodation = "";
            foreach (ListItem cBox in chblAccommodation.Items)
            {
                if (cBox.Selected)
                {
                    sAccommodation += cBox.Text + ", ";
                }
            }
            objCusTour.Accommodation = sAccommodation;

            //objCusTour.Meals
            string sMeal = "";
            foreach (ListItem cBox in chblMeal.Items)
            {
                if (cBox.Selected)
                {
                    sMeal += cBox.Text + ", ";
                }
            }

            string sPlaceToVisit = "";
            foreach (ListItem item in cblNorth.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }
            foreach (ListItem item in cblCenter.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }
            foreach (ListItem item in cblSouth.Items)
            {
                if (item.Selected)
                    sPlaceToVisit += item.Text + ", ";
            }

            sMeal += txtFood.Text;
            objCusTour.Meals = sMeal;
            objCusTour.PlaceToVisit = sPlaceToVisit;
            //OTHER INFORMATION
            if (rdoBilling.SelectedIndex == 0) objCusTour.BillingOption = false;
            else objCusTour.BillingOption = true;
            objCusTour.OtherRequest = txtOtherRequest.Text;
            objCusTour.InformationSource = ddlHear.Text;
        }
    }
}
