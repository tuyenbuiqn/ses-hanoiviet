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
    public partial class ucTourCat : System.Web.UI.UserControl
    {
        TourCategoryDO objTourCat = new TourCategoryDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["TourCategoryID"] != null)
            {
                objTourCat.TourCategoryID = int.Parse(Request.QueryString["TourCategoryID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objTourCat = new TourCategoryBL().Select(objTourCat);
            txtDes.Text = objTourCat.Description;
            txtMetaDes.Text = objTourCat.MetaDes;
            txtMetaTag.Text = objTourCat.MetaTag;
            txtOder.Text = objTourCat.OrderID.ToString();
            txtTitle.Text = objTourCat.Title;
            txtURL.Text = objTourCat.Alias;
            cbActive.Checked = objTourCat.Published;
            cbParent.Value = objTourCat.ParentID.ToString();
            cbisFrontPage.Checked = objTourCat.IsFrontPage;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objTourCat.TourCategoryID <= 0)
            {
                new TourCategoryBL().Insert(objTourCat);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListTourCat");
            }
            else
            {
                new TourCategoryBL().Update(objTourCat);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListTourCat");
            }
            
        }

        private void SetObject()
        {
            objTourCat.Description = txtDes.Text;
            objTourCat.MetaDes = txtMetaDes.Text;
            objTourCat.MetaTag = txtMetaTag.Text;
            try
            {
                objTourCat.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objTourCat.Published = cbActive.Checked;
            objTourCat.Title = txtTitle.Text;
            objTourCat.Alias = Functions.Change_AV(txtTitle.Text);
            objTourCat.IsFrontPage = cbisFrontPage.Checked;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objTourCat.TourCatImage = FileName;
            }
            if (cbRoot.Checked)
                objTourCat.ParentID = 0;
            else
            {
                if (!string.IsNullOrEmpty(cbParent.Text))
                    objTourCat.ParentID = int.Parse(cbParent.Value.ToString());
            }
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}