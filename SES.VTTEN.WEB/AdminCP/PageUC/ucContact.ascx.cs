using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucContact : System.Web.UI.UserControl
    {
        ContactDO objContact = new ContactDO();
        CustomerDO objcustomer = new CustomerDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ContactID"] != null)
            {
                objContact.ContactID = int.Parse(Request.QueryString["ContactID"]);
                initform();
            }
        }

        private void initform()
        {
            objContact = new ContactBL().Select(objContact);
            objcustomer = new CustomerBL().Select(new CustomerDO { CustomerID = objContact.CustomerID });
            txtAddress.Text = objcustomer.Address;
            txtCompany.Text = objContact.Company;
            txtCustomerName.Text = objcustomer.CustomerName;
            txtDetail.Text = objContact.Detail;
            txtEmail.Text = objcustomer.Email;
            txtFax.Text = objcustomer.Fax;
            txtPhone.Text = objcustomer.Phone;
        }
    }
}