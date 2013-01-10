using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.DO;
using SES.VTTEN.BL;
using System.Data;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucHotDeal : System.Web.UI.UserControl
    {
        HotDealDO objHotdeal = new HotDealDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Functions.ddlDatabinder(cbHotel, HotelDO.HOTELID_FIELD, HotelDO.TITLE_FIELD, new HotelBL().SelectAll());
            Functions.ddlDatabinder(cbTour, TourDepartureDO.TOURDEPARTUREID_FIELD, TourDepartureDO.DEPARTURECODE_FIELD, new TourDepartureBL().SelectAll());
            if (Request.QueryString["HotDealID"] != null)
            {
                objHotdeal.HotDealID = int.Parse(Request.QueryString["HotDealID"]);
                initForm();
            }
        }

        private void initForm()
        {
            objHotdeal = new HotDealBL().Select(objHotdeal);
            txtDateEnd.Date = objHotdeal.DateEnd;
            txtDateStart.Date = objHotdeal.DateStart;
            txtDepDes.Text = objHotdeal.Description;
            txtTitle.Text = objHotdeal.Title;
            cbTour.SelectedIndex = objHotdeal.TourDepartureID;
            cbActive.Checked = objHotdeal.Published;
            txtChildPrice.Text = objHotdeal.ChildPrice;
            txtAdultPrice.Text = objHotdeal.AdultPrice;
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objHotdeal.HotDealID <= 0)
            {
                new HotDealBL().Insert(objHotdeal);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListHotDeal");
            }
            else
            {
                new HotDealBL().Update(objHotdeal);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListHotDeal");
            }
        }

        private void setobject()
        {
            if (!String.IsNullOrEmpty(txtDateStart.Text))
            {
                objHotdeal.DateStart = txtDateStart.Date;
            }
            if(!String.IsNullOrEmpty(txtDateEnd.Text))
            {
                objHotdeal.DateEnd = txtDateEnd.Date;
            }
            objHotdeal.Description = txtDepDes.Text;
            objHotdeal.Published = cbActive.Checked;
            objHotdeal.Title = txtTitle.Text;
            objHotdeal.TourDepartureID = int.Parse(cbTour.SelectedValue);
            objHotdeal.ChildPrice = txtChildPrice.Text;
            objHotdeal.AdultPrice = txtAdultPrice.Text;
        }
    }
}