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
    public partial class ucImageDetail : System.Web.UI.UserControl
    {
        cmsAlbumDetailDO objAlbum = new cmsAlbumDetailDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(ddlAlbum, cmsAlbumDO.ALBUMID_FIELD, cmsAlbumDO.TITLE_FIELD, new cmsAlbumBL().SelectAll());
            if (!string.IsNullOrEmpty(Request.QueryString["ImageID"]))
            {
                int ImageID = int.Parse(Request.QueryString["ImageID"].ToString());
                objAlbum.AlbumDetailID = ImageID;
                InitForm();
            }
        }

        private void InitForm()
        {
            objAlbum = new cmsAlbumDetailBL().Select(objAlbum);
            txtTitle.Text = objAlbum.Title;
            txtDescription.Text = objAlbum.Description;
            if (new cmsAlbumBL().Select(new cmsAlbumDO { AlbumID = objAlbum.AlbumID }).Type == true)
            {
                hplImage.NavigateUrl = "~/Media/" + objAlbum.Url;
            }
            else
                txtVideo.Text = "http://youtu.be/" + objAlbum.Url;
            ddlAlbum.SelectedValue = objAlbum.AlbumID.ToString();
            txtOrder.Text = objAlbum.OrderID.ToString();
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
        protected void SetObject()
        {
            objAlbum.Title = txtTitle.Text;
            objAlbum.Description = txtDescription.Text;
            objAlbum.AlbumID = int.Parse(ddlAlbum.SelectedValue);
            if (fuImage.HasFile && txtVideo.Text == "")
            {
                objAlbum.Url = UploadFile(fuImage);
            }
            else if (!fuImage.HasFile && txtVideo.Text != "")
            {
                string s = txtVideo.Text;

                objAlbum.Url = s.Substring(s.LastIndexOf("/") + 1);
            }
            if (txtOrder.Text != "")
                objAlbum.OrderID = int.Parse(txtOrder.Text);
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objAlbum.AlbumDetailID <= 0)
            {
                new cmsAlbumDetailBL().Insert(objAlbum);

            }
            else
            {
                new cmsAlbumDetailBL().Update(objAlbum);

            }
            Ultility.Alert("Cập nhật thành công", "Default.aspx?Page=AlbumDetails");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
        }
    }
}