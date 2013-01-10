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
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucAlbum : System.Web.UI.UserControl
    {
        cmsAlbumDO objAlbum = new cmsAlbumDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["AlbumID"]))
            {
                objAlbum.AlbumID = int.Parse(Request.QueryString["AlbumID"].ToString());
                InitForm();
            }
        }

        private void InitForm()
        {
            objAlbum = new cmsAlbumBL().Select(objAlbum);
            txtTitle.Text = objAlbum.Title;
            txtDescription.Text = objAlbum.Description;
            if (objAlbum.Type)
                rdImgAlbum.Checked = true;
            else rdVideoAlbum.Checked = true;

            if (!string.IsNullOrEmpty(objAlbum.AlbumImg))
                hplImage.NavigateUrl = "~/Media/" + objAlbum.AlbumImg;
            txtOrderID.Text = objAlbum.OrderID.ToString();
        }

        protected void SetObject()
        {
            objAlbum.Title = txtTitle.Text;
            objAlbum.OrderID = int.Parse( txtOrderID.Text);
            objAlbum.Description = txtDescription.Text;
            if (rdImgAlbum.Checked == true)
                objAlbum.Type = true;
            else if (rdVideoAlbum.Checked == true)
                objAlbum.Type = false;
            else objAlbum.Type = true;
            if (fuImage.HasFile)
            {
                objAlbum.AlbumImg = UploadFile(fuImage);
            }
        }
        private string UploadFile(FileUpload fulImage)
        {
            if (fuImage.HasFile)
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(txtTitle.Text) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objAlbum.AlbumID > 0)
                new cmsAlbumBL().Update(objAlbum);
            else
                new cmsAlbumBL().Insert(objAlbum);
            Functions.Alert("Cập nhật thành công!!", "Default.aspx?Page=ListImgAlbum");
 
        }
    }
}