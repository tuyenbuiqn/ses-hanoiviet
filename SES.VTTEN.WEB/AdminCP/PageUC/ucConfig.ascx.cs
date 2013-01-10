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
using SES.VTTEN.DO;
using SES.VTTEN.BL;


namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucConfig : System.Web.UI.UserControl
    {
        ConfigDO objConfig = new ConfigDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ConfigID"] != null)
            {
                objConfig.ConfigID = int.Parse(Request.QueryString["ConfigID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objConfig = new ConfigBL().Select(objConfig);

            txtTitle.Text = objConfig.ConfigCode;
            // Không sử dụng CKEditor
            if (objConfig.ConfigID == 1 || objConfig.ConfigID == 2 )
            {
                trDes.Visible = true;
                trSupport.Visible = false;
                txtDescription.Text = objConfig.ConfigValue;
            }
            else if (objConfig.ConfigID == 6)
            {
                trDes.Visible = false;
                trSupport.Visible = false;
                trPopup.Visible = true;
                if (objConfig.ConfigValue == "1")
                    chkpopup.Checked = true;
                else
                    chkpopup.Checked = false;
            }
            // Sử dụng CKEditor
            else if (objConfig.ConfigID == 3 || objConfig.ConfigID == 4)
            {
                trDes.Visible = false;
                trSupport.Visible = true;
                txtCK.Text = objConfig.ConfigValue;
            }

            else
            {
                trDes.Visible = false;
                trSupport.Visible = true;
                txtCK.Text = objConfig.ConfigValue;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            initObject();
            if (objConfig.ConfigID <= 0)
            {
                new ConfigBL().Insert(objConfig);
            }
            else
            {
                new ConfigBL().Update(objConfig);
            }
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=ListConfig");
        }

        private void initObject()
        {
            objConfig.ConfigCode = txtTitle.Text;
            // Không sử dụng CKEditor
            if (objConfig.ConfigID == 1 || objConfig.ConfigID == 2)
            {
                objConfig.ConfigValue = txtDescription.Text;
            }
            // Sử dụng CKEditor
            else if (objConfig.ConfigID == 3 || objConfig.ConfigID == 4)
            {
                objConfig.ConfigValue = txtCK.Text;
            }
            else if (objConfig.ConfigID == 6)
            {
                if (chkpopup.Checked==true)
                {
                    objConfig.ConfigValue = "1";
                }
                else objConfig.ConfigValue = "0";
            }
            else
            {
                objConfig.ConfigValue = txtCK.Text;
            }


        }
        private string UploadFile(FileUpload fulImages)
        {
            if (fulImages.HasFile)
            {
                string FileName = "popupCHTG.jpg";
                if (objConfig.ConfigID == 6)
                    FileName = "banner-logo.jpg";
                if (objConfig.ConfigID == 7)
                    FileName = "bannerright.jpg";
                if (objConfig.ConfigID == 9)
                    FileName = "long-logo-kma.jpg";
                if (objConfig.ConfigID == 11)
                    FileName = "popupKMA.jpg";

                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                if (System.IO.File.Exists(SaveLocation))
                    System.IO.File.Delete(SaveLocation);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListConfig");
        }
    }
}