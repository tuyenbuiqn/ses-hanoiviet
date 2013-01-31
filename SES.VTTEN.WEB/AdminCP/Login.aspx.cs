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
using System.Net.Mail;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using SES.VTTEN.BL;
using SES.VTTEN.DO;  

namespace SES.VTTEN.WEB.AdminCP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["Option"] == "Logout")
            {
                Session.RemoveAll();
                Functions.Alert("Bạn đã thoát khỏi hệ thống thành công!", "Login.aspx");
            }
            if (Request.QueryString["UID"] != null)
            {
                UserBL.PublicAccountSoapClient UBL = new UserBL.PublicAccountSoapClient();
                UserBL.UsersDO objUser = new UserBL.UsersDO();
                //if(Functions.Email(username.Value.Trim()))
                //{
                //    objUser.Email = username.Value.Trim();
                //    objUser.Pasword = Functions.EncryptMd5(password.Value.Trim());
                //    objUser = new UsersBL().LoginbyEmail(objUser);
                //}
                //else
                objUser.UserID = int.Parse(Request.QueryString["UID"]);
                objUser = UBL.Select(objUser);
                if (objUser.Pasword == Request.QueryString["Pass"])
                {
                    Session["Username"] = objUser.Username;
                    Session["UserID"] = objUser.UserID;
                    if (objUser.IsAdmin == true)
                        Session["Permission"] = "admin";
                    else if (objUser.IsSuportOnline == true)
                        Session["Permission"] = "support";
                    Response.Redirect("http://vn.hanoiviettravel.com.vn/AdminCP/Default.aspx");

                }

            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            UserBL.PublicAccountSoapClient UBL = new UserBL.PublicAccountSoapClient();



            UserBL.UsersDO objUser = new UserBL.UsersDO();
            //if(Functions.Email(username.Value.Trim()))
            //{
            //    objUser.Email = username.Value.Trim();
            //    objUser.Pasword = Functions.EncryptMd5(password.Value.Trim());
            //    objUser = new UsersBL().LoginbyEmail(objUser);
            //}
            //else
            objUser.Username = txtUsername.Text.Trim();
            objUser.Pasword = Functions.EncryptMd5(txtPassword.Text.Trim());
            objUser = UBL.SelectLogin(objUser);
            if (objUser.UserID >= 1)
            {
                if (rdoEn.Checked)
                {
                    Response.Redirect("http://hanoiviettravel.com/AdminCP/Login.aspx?UID="+ objUser.UserID.ToString() + "&Pass="+objUser.Pasword);
                }
                else
                {
                    Session["Username"] = txtUsername.Text.Trim();
                    Session["UserID"] = objUser.UserID;
                    objUser = UBL.Select(objUser);
                    if (objUser.IsAdmin == true)
                        Session["Permission"] = "admin";
                    else if (objUser.IsSuportOnline == true)
                        Session["Permission"] = "support";
                    Functions.Alert("Chào mừng bạn " + txtUsername.Text + " đã đăng nhập thành công!");
                    Response.Redirect("Default.aspx");
                }
            }
            else
                if (txtUsername.Text.Trim().Equals(ConfigurationManager.AppSettings["UserName"])
                    && txtPassword.Text.Equals(ConfigurationManager.AppSettings["Password"]))
                {
                    Session["Username"] = txtUsername.Text;
                    Response.Write("Chào mừng bạn" + txtUsername.Text + "đã quay lại");
                    Response.Redirect("Default.aspx");
                }
        }

        

        //protected void btnRegister_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Signup.aspx");
        //}
    }
}
