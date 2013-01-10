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
    public partial class ucLink : System.Web.UI.UserControl
    {
        LinkDO objLink = new LinkDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["LinkID"] != null)
            {
                objLink.LinkID = int.Parse(Request.QueryString["LinkID"]);
                initform();
            }
        }

        private void initform()
        {
            objLink = new LinkBL().Select(objLink);
            txtDetail.Text = objLink.Detail;
            cbActive.Checked = objLink.Published;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objLink.LinkID <= 0)
                new LinkBL().Insert(objLink);
            else
                new LinkBL().Update(objLink);
            Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListLink"); 
        }

        private void setobject()
        {
            objLink.Detail = txtDetail.Text;
            objLink.Published = cbActive.Checked;
        }
    }
}