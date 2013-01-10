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
    public partial class ucAddMultiImg : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cboAlbum, cmsAlbumDO.ALBUMID_FIELD, cmsAlbumDO.TITLE_FIELD, new cmsAlbumBL().SelectByType(true));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int AlbumID = int.Parse(cboAlbum.SelectedValue.ToString());
            initObject(fuImage1, txtTitle1.Text, AlbumID);
            initObject(fuImage2, txtTitle2.Text, AlbumID);
            initObject(fuImage3, txtTitle3.Text, AlbumID);
            initObject(fuImage4, txtTitle4.Text, AlbumID);
            initObject(fuImage5, txtTitle5.Text, AlbumID);
            Functions.Alert("Cập nhật thành công!", "Default.aspx?Page=AlbumDetails");
        }

        private void initObject(FileUpload fulImage, string title, int AlbumID)
        {
            if (string.IsNullOrEmpty(title)) return;
            cmsAlbumDetailDO objArt = new cmsAlbumDetailDO();
            objArt.Title = title;
            objArt.AlbumID = AlbumID;
            if (!string.IsNullOrEmpty(fulImage.FileName))
                objArt.Url = UploadFile(fulImage, title);

            new cmsAlbumDetailBL().Insert(objArt);
        }
        private string UploadFile(FileUpload fulImages, string title)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {
                string FileName = string.Format("{0}{1}", Functions.Change_AV(title) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }
    }
}