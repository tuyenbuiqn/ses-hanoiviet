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
    public partial class ucTourImages : System.Web.UI.UserControl
    {
        MediaDO objMedia = new MediaDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Functions.ddlDatabinder(cbDestination, DestinationDO.DESTINATIONID_FIELD, DestinationDO.TITLE_FIELD, new DestinationBL().SelectAll());
                Functions.ddlDatabinder(cbHotel, HotelDO.HOTELID_FIELD, HotelDO.TITLE_FIELD, new HotelBL().SelectAll());
                Functions.ddlDatabinder(cbTour, TourDO.TOURID_FIELD, TourDO.TITLE_FIELD, new TourBL().SelectAll());
            }
            if (Request.QueryString["MediaID"] != null)
            {
                objMedia.MediaID = int.Parse(Request.QueryString["MediaID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objMedia = new MediaBL().Select(objMedia);

            txtDetail.Text = objMedia.Description;
            txtOrder.Text = objMedia.OrderID.ToString();
            if (!string.IsNullOrEmpty(objMedia.MediaFile))
                hplImage.NavigateUrl = "~/Media/" + objMedia.MediaFile;
            txtTitle.Text = objMedia.Title;
            txtURL.Text = objMedia.MediaUrl;
            cbActive.Checked = objMedia.Published;
            //cbType.Checked = objMedia.MediaType;
            try
            {
                cbDestination.SelectedValue = objMedia.DestinationID.ToString();
            }
            catch
            {
                cbDestination.SelectedValue = "0";
            }
            try
            {
                cbHotel.SelectedValue = objMedia.HotelID.ToString();
            }
            catch
            {
                cbHotel.SelectedValue = "0";
            }
            txtMetaTag.Text = objMedia.MetaTag;
            try
            {
                cbTour.SelectedValue = objMedia.TourID.ToString();
            }
            catch 
            {
                cbTour.SelectedValue = "0";
            }
            
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objMedia.MediaID <= 0)
            {
                objMedia.DateUpload = DateTime.Now;
                new MediaBL().Insert(objMedia);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListTourImages");
            }
            else
            {
                new MediaBL().Update(objMedia);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListTourImages");
            }

        }

        private void setobject()
        {
            objMedia.Description = txtDetail.Text;
            objMedia.DestinationID = int.Parse(cbDestination.SelectedValue); ;
            objMedia.HotelID = int.Parse(cbHotel.SelectedValue);
            objMedia.MediaType = true;
            objMedia.TourID = int.Parse(cbTour.SelectedValue);
            objMedia.MediaUrl = Functions.Change_AV(txtTitle.Text);
            objMedia.MetaTag = txtMetaTag.Text;

            try
            {
                objMedia.OrderID = int.Parse(txtOrder.Text);

            }
            catch { }

            objMedia.Published = cbActive.Checked;
            //objMedia.TourID = int.Parse(cbTour.SelectedValue);
            objMedia.Title = txtTitle.Text;

            if (!string.IsNullOrEmpty(fuMedia.FileName))
            {
                string FileName = string.Format("{0}{1}", fuMedia.FileName.Substring(0, fuMedia.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fuMedia.FileName.Substring(fuMedia.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fuMedia.SaveAs(SaveLocation);
                objMedia.MediaFile = FileName;
            }
        }
    }
}