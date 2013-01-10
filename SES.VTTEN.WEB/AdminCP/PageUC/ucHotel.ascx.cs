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
    public partial class ucHotel : System.Web.UI.UserControl
    {
        HotelDO objHotel = new HotelDO();
        HotelRoomDO objHotelRoom = new HotelRoomDO();
        RoomCatDO objRoomCat = new RoomCatDO();
        RoomTypeDO objRoomType = new RoomTypeDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cbDestination, new DestinationBL().SelectAll(), DestinationDO.TITLE_FIELD, DestinationDO.DESTINATIONID_FIELD);
            if (Request.QueryString["HotelID"] != null)
            {
                
                objHotel.HotelID = int.Parse(Request.QueryString["HotelID"].ToString());
                initForm();
            }
            if (!IsPostBack)
            {

                
                    i = objHotel.HotelID;
                   
                
                
            }
        }

        
        private void initForm()
        {
            objHotel = new HotelBL().Select(objHotel);
            txtContactInfo.Text = objHotel.ContactInfo; //information
            txtDes.Text = objHotel.Description; // short desc
            txtDetail.Text = objHotel.Detail; // hotel desc
            txtMetaDes.Text = objHotel.MetaDes; //Recormmended
            txtMetaTag.Text = objHotel.MetaTag;
            txtOder.Text = objHotel.OrderID.ToString();
            txtRate.Text = objHotel.StarRates.ToString();
            txtTitle.Text = objHotel.Title;
            txtURL.Text = objHotel.Alias;
            txtStartPrice.Text = objHotel.HotelStartPrice.ToString();
            cbActive.Checked = objHotel.Published;
            cbDestination.Value = objHotel.DestinationID.ToString();
            cbisFrontPage.Checked = objHotel.IsFrontPage;
            cbIsMenu.Checked = objHotel.IsMenu;
            if (!string.IsNullOrEmpty(objHotel.HotelImage))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objHotel.HotelImage;
            }
        }
        public int i
        {
            get
            {
                object o = ViewState["i"];
                if (!(o == null)) return (int)o;
                return 0;
                //a default
            }
            set { ViewState["i"] = value; }
        }
        protected void btSave_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objHotel.HotelID <= 0)
            {
                i = new HotelBL().Insert(objHotel);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListHotel");
            }
            else
            { 
                i = new HotelBL().Update(objHotel);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListHotel");
            }
        
            
        }

        private void SetObject()
        {
            objHotel.ContactInfo = txtContactInfo.Text;
            objHotel.Description = txtDes.Text; 
            objHotel.Detail = txtDetail.Text;
            objHotel.MetaDes = txtMetaDes.Text;
            objHotel.MetaTag = txtMetaTag.Text;
            objHotel.HotelStartPrice = int.Parse(txtStartPrice.Text);
            try
            {
                objHotel.DestinationID = int.Parse(cbDestination.Value.ToString());
               
            }
            catch { }
            try
            {
                objHotel.OrderID = int.Parse(txtOder.Text);

            }
            catch { }
            try
            {

                objHotel.StarRates = int.Parse(txtRate.Text);

            }
            catch { }
            
            objHotel.Published = cbActive.Checked;
            objHotel.Title = txtTitle.Text;
            objHotel.Alias = Functions.Change_AV(txtTitle.Text);
            objHotel.IsFrontPage = cbisFrontPage.Checked;
            objHotel.IsMenu = cbIsMenu.Checked;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objHotel.HotelImage = FileName;
            }
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {

        }

        
    
     
        private void Loaddata()
        {
            objHotelRoom = new HotelRoomBL().Select(objHotelRoom);
         
          
        }

      
    }
}