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
    public partial class ucContent : System.Web.UI.UserControl
    {
        ContentDO objcontent = new ContentDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cbContentType, new ContentTypeBL().SelectAll(), ContentTypeDO.TITLE_FIELD, ContentTypeDO.CONTENTTYPEID_FIELD);
            if (Request.QueryString["ContentID"] != null)
            {
                objcontent.ContentID = int.Parse(Request.QueryString["ContentID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objcontent = new ContentBL().Select(objcontent);
            txtDes.Text = objcontent.Description;
            txtDetail.Text = objcontent.ContentDetail;
            txtMetaDes.Text = objcontent.MetaDes;
            txtMetaTag.Text = objcontent.MetaTag;
            txtOder.Text = objcontent.OrderID.ToString();
            txtTitle.Text = objcontent.Title;
            txtURL.Text = objcontent.Alias;
            cbActive.Checked = objcontent.Published;
            cbContentType.Value = objcontent.ContentTypeID.ToString();
            cbisFrontPage.Checked = objcontent.IsFrontPage;
            if (!string.IsNullOrEmpty(objcontent.ContentImage))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objcontent.ContentImage;
            }
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objcontent.ContentID <= 0)
            {
                new ContentBL().Insert(objcontent);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListContent");
            }
            else
            {
                new ContentBL().Update(objcontent);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListContent");
            }
            
        }

        private void setobject()
        {
            objcontent.Description = txtDes.Text;
            objcontent.ContentDetail = txtDetail.Text;
            objcontent.MetaDes = txtMetaDes.Text;
            objcontent.MetaTag = txtMetaTag.Text;
            try
            {
                objcontent.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objcontent.Published = cbActive.Checked;
            objcontent.Title = txtTitle.Text;
            objcontent.Alias = Functions.Change_AV(txtTitle.Text);
            objcontent.ContentTypeID = int.Parse(cbContentType.Value.ToString());
            objcontent.IsFrontPage = cbisFrontPage.Checked;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objcontent.ContentImage = FileName;
            }
        }

    }
}