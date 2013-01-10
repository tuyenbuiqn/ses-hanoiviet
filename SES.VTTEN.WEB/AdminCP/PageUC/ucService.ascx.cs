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
    public partial class ucService : System.Web.UI.UserControl
    {
        ServiceDO objservice = new ServiceDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ServiceID"] != null)
            {
                objservice.ServiceID = int.Parse(Request.QueryString["ServiceID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objservice = new ServiceBL().Select(objservice);
            txtDes.Text = objservice.Description;
            txtDetail.Text = objservice.Detail;
            txtMetaDes.Text = objservice.MetaDes;
            txtMetaTag.Text = objservice.MetaTag;
            txtOder.Text = objservice.OrderID.ToString();
            txtTitle.Text = objservice.Title;
            txtURL.Text = objservice.Alias;
            cbActive.Checked = objservice.Published;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objservice.ServiceID <= 0)
            {
                new ServiceBL().Insert(objservice);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListService");
            }
            else
            {
                new ServiceBL().Update(objservice);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListService");
            }
            
        }

        private void setobject()
        {
            objservice.Description = txtDes.Text;
            objservice.Detail = txtDetail.Text;
            objservice.MetaDes = txtMetaDes.Text;
            objservice.MetaTag = txtMetaTag.Text;
            try
            {
                objservice.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objservice.Published = cbActive.Checked;
            objservice.Title = txtTitle.Text;
            objservice.Alias = Functions.Change_AV(txtTitle.Text);
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objservice.ServiceImage = FileName;
            }
        }
    }
}