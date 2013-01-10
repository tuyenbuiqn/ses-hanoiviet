using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucCustomer : System.Web.UI.UserControl
    {
        CustomerDO objcustomer = new CustomerDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cbNational, NationDO.NATIONID_FIELD, NationDO.NATIONNAME_FIELD, new NationBL().SelectAll());
            if (Request.QueryString["CustomerID"] != null)
            {
                objcustomer.CustomerID = int.Parse(Request.QueryString["CustomerID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objcustomer = new CustomerBL().Select(objcustomer);
            txtAdress.Text = objcustomer.Address;
            txtAnniversary.Text = objcustomer.OtherAnniversary.ToString();
            txtAnniversaryInfo.Text = objcustomer.AnniversaryInfo;
            txtBirthday.Text = objcustomer.BirthDay.ToString();
            txtEmail.Text = objcustomer.Email;
            txtIDCard.Text = objcustomer.IDCard;
            txtJob.Text = objcustomer.Jobs;
            txtMobile.Text = objcustomer.Mobile;
            txtName.Text = objcustomer.CustomerName;
            txtOtherInfo.Text = objcustomer.OtherInfo;
            txtPassport.Text = objcustomer.Passport;
            txtPhone.Text = objcustomer.Phone;
            txtSkype.Text = objcustomer.Skype;
            txtYahoo.Text = objcustomer.Yahoo;
            cbAdult.Checked = objcustomer.IsAdult;
            cbGender.Checked = objcustomer.Gender;
            cbNational.SelectedIndex = objcustomer.NationalID;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objcustomer.CustomerID <= 0)
            {
                new CustomerBL().Insert(objcustomer);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListCustomer");
            }
            else
            {
                new CustomerBL().Update(objcustomer);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListCustomer");
            }
            
        }

        private void setobject()
        {
            objcustomer.Address = txtAdress.Text;
            objcustomer.AnniversaryInfo = txtAnniversaryInfo.Text;           
            objcustomer.CustomerName = txtName.Text;
            objcustomer.Email = txtEmail.Text;
            objcustomer.Gender = cbGender.Checked;
            objcustomer.IDCard = txtIDCard.Text;
            objcustomer.IsAdult = cbAdult.Checked;
            objcustomer.Jobs = txtJob.Text;
            objcustomer.Mobile = txtMobile.Text;
            objcustomer.NationalID = cbNational.SelectedIndex;
            try
            {
                objcustomer.BirthDay = DateTime.Parse(txtBirthday.Text);
                
            }
            catch { }
            try
            {
                objcustomer.OtherAnniversary = DateTime.Parse(txtAnniversary.Text);

            }
            catch { }
            
            objcustomer.OtherInfo = txtOtherInfo.Text;
            objcustomer.Passport = txtPassport.Text;
            objcustomer.Phone = txtPhone.Text;
            objcustomer.Skype = txtSkype.Text;
            objcustomer.Yahoo = txtYahoo.Text;
        }
    }
}