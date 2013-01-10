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
    public partial class ucChatContent : System.Web.UI.UserControl
    {
        ChatContentDO objChatContent = new ChatContentDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cbUser, UsersDO.USERID_FIELD, UsersDO.USERNAME_FIELD, new UsersBL().SelectAll());
            if (Request.QueryString["ChatContentID"] != null)
            {
                objChatContent.ChatContentID = int.Parse(Request.QueryString["ChatContentID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objChatContent = new ChatContentBL().Select(objChatContent);
            txtContent.Text = objChatContent.ChatContent;
            txtCustomer.Text = objChatContent.CustomerName;
            cbUser.SelectedIndex = objChatContent.UserID;
            txtTimeEnd.Text = objChatContent.TimeEnd.ToString();
            txtTimeStart.Text = objChatContent.TimeStart.ToString();
        }
    }
}