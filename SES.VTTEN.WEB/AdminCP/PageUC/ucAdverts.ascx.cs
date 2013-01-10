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
    public partial class ucAdverts : System.Web.UI.UserControl
    {
        AdvertDO objAdvert = new AdvertDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(cbMedia, MediaDO.MEDIAID_FIELD, MediaDO.TITLE_FIELD, new MediaBL().SelectAll());
            if (Request.QueryString["AdvertID"] != null)
            {
                objAdvert.AdvertID = int.Parse(Request.QueryString["AdvertID"]);
                initForm();
            }  
        }

        private void initForm()
        {
            objAdvert = new AdvertBL().Select(objAdvert);
            txtDateEnd.Text = objAdvert.TimeExpire.ToString();
            txtDateStart.Text = objAdvert.TimeStart.ToString();
            txtHTMLContent.Text = objAdvert.HTMLContent;
            txtTitle.Text = objAdvert.Title;
            cbActive.Checked = objAdvert.Published;
            cbMedia.SelectedValue = objAdvert.MediaID.ToString();
            txtURL.Text = objAdvert.Location;
            cbLeft.Checked = objAdvert.isLeft;
            txtOrder.Text = objAdvert.OrderID.ToString();
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setObject();
            if (objAdvert.AdvertID <= 0)
            {
                new AdvertBL().Insert(objAdvert);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListAdvert");
            }
            else
            {
                new AdvertBL().Update(objAdvert);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListAdvert"); 
            }
            
        }

        private void setObject()
        {
            
            objAdvert.MediaID = int.Parse(cbMedia.SelectedValue);
            objAdvert.Published = cbActive.Checked;
            if (!String.IsNullOrEmpty(txtDateEnd.Text))
            {
                objAdvert.TimeExpire = DateTime.Parse(txtDateEnd.Text);
            }
            if (!String.IsNullOrEmpty(txtDateStart.Text))
            {
                objAdvert.TimeStart = DateTime.Parse(txtDateStart.Text);
            }
            objAdvert.Title = txtTitle.Text;
            if (!string.IsNullOrEmpty(fuMedia.FileName))
            {
                string FileName = string.Format("{0}{1}", fuMedia.FileName.Substring(0, fuMedia.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fuMedia.FileName.Substring(fuMedia.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fuMedia.SaveAs(SaveLocation);
                objAdvert.HTMLContent = FileName;
            }
            try
            {
                objAdvert.OrderID = int.Parse(txtOrder.Text);
            }
            catch { }
            objAdvert.Location = txtURL.Text;
            objAdvert.isLeft = cbLeft.Checked;
        }
    }
}