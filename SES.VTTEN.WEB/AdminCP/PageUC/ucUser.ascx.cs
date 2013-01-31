using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.DO;
using SES.VTTEN.BL;
using System.Data;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucUser : System.Web.UI.UserControl
    {
        UserBL.UsersDO objuser = new UserBL.UsersDO();
        UserBL.PublicAccountSoapClient UBL = new UserBL.PublicAccountSoapClient();

        UserDestinationDO objUserDes = new UserDestinationDO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                chblDestinationDataSource();

            if (Request.QueryString["UserID"] != null)
            {
                objUserDes.UserID = objuser.UserID = int.Parse(Request.QueryString["UserID"]);
                initForm();
            }

        }

        private void chblDestinationDataSource()
        {
            chblDestination.DataSource = new DestinationBL().SelectAll();
            chblDestination.DataBind();
        }
        private void initForm()
        {
            objuser = UBL.Select(objuser);
            txtEmail.Text = objuser.Email;
            txtPassword.Text = objuser.Pasword;
            txtUsername.Text = objuser.Username;
            cbActive.Checked = objuser.IsActive;
            cbAdmin.Checked = objuser.IsAdmin;
            cbSupporter.Checked = objuser.IsSuportOnline;

            DataTable dtDestination = new UserDestinationBL().SelectByUserID(objuser.UserID);
            /*
             ListItem oListItem = DropDownList1.Items.FindByValue("yourValue");
                if(oListItem != null)
                DropDownList1.SelectedValue = oListItem.Value;

             */
            if (dtDestination.Rows.Count > 0)
            {
                for (int i = 0; i < dtDestination.Rows.Count; i++)
                {
                    chblDestination.Items.FindByValue(dtDestination.Rows[i]["DestinationID"].ToString()).Selected = true;
                }
            }

        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objuser.UserID <= 0)
            {
                objuser.UserID = UBL.Insert(objuser);
                foreach (ListItem item in chblDestination.Items)
                {
                    if (item.Selected == true)
                    {
                        objUserDes.DestinationID = int.Parse(item.Value);
                        objUserDes.UserID = objuser.UserID;
                        new UserDestinationBL().Insert(objUserDes);
                    }
                }
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListUser");
            }
            else
            {
                UBL.Update(objuser);
                new UserDestinationBL().DeleteByUserID(objUserDes.UserID);
                foreach (ListItem item in chblDestination.Items)
                {
                    if (item.Selected == true)
                    {
                        objUserDes.DestinationID = int.Parse(item.Value);
                        new UserDestinationBL().Insert(objUserDes);
                    }
                }
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListUser");
            }

        }

        private void setobject()
        {
            objuser.Username = txtUsername.Text;
            if (txtPassword.Text != "")
                objuser.Pasword = Functions.EncryptMd5(txtPassword.Text);
            objuser.Email = txtEmail.Text;
            objuser.IsActive = cbActive.Checked;
            objuser.IsAdmin = cbAdmin.Checked;
            objuser.IsSuportOnline = cbSupporter.Checked;
            objuser.GroupID = 2;


        }
    }
}