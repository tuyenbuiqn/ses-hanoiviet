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
    public partial class ucNews : System.Web.UI.UserControl
    {
        NewsDO objnew = new NewsDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["NewsID"] != null)
            {
                objnew.NewsID = int.Parse(Request.QueryString["NewsID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objnew = new NewsBL().Select(objnew);
            txtDes.Text = objnew.Description;
            txtDetail.Text = objnew.Detail;
            txtMetaDes.Text = objnew.MetaDes;
            txtMetaTag.Text = objnew.MetaTag;
            txtOder.Text = objnew.OrderID.ToString();
            txtTitle.Text = objnew.Title;
            txtURL.Text = objnew.Alias;
            cbActive.Checked = objnew.Published;
            cbisFrontPage.Checked = objnew.IsFrontPage;
            if (!string.IsNullOrEmpty(objnew.NewsImage))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objnew.NewsImage;
            }
            ddlModulNews.SelectedValue = objnew.ModuleID.ToString();
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            Setobject();
            if (objnew.NewsID <= 0)
            {
                new NewsBL().Insert(objnew);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListNews");
            }
            else
            {
                new NewsBL().Update(objnew);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListNews");
            }
            
        }

        private void Setobject()
        {
            objnew.Description = txtDes.Text;
            objnew.Detail = txtDetail.Text;
            objnew.MetaDes = txtMetaDes.Text;
            objnew.MetaTag = txtMetaTag.Text;
            try
            {
                objnew.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objnew.Published = cbActive.Checked;
            objnew.Title = txtTitle.Text;
            objnew.Alias = Functions.Change_AV(txtTitle.Text);
            objnew.IsFrontPage = cbisFrontPage.Checked;
            objnew.ModuleID = int.Parse(ddlModulNews.SelectedValue);
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objnew.NewsImage = FileName;
            }
        }
    }
}