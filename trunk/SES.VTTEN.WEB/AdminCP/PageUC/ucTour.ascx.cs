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
    public partial class ucTour : System.Web.UI.UserControl
    {
        TourDO objtour = new TourDO();
        TourScheduleDO objtoursche = new TourScheduleDO();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cbTourType, new TourTypeBL().SelectAll(), TourTypeDO.TITLE_FIELD, TourTypeDO.TOURTYPEID_FIELD);
            cblDestination.DataSource = new DestinationBL().SelectAll();
            cblDestination.DataTextField = DestinationDO.TITLE_FIELD;
            cblDestination.DataValueField = DestinationDO.DESTINATIONID_FIELD;
            cblDestination.DataBind();
            if (Request.QueryString["TourID"] != null)
            {
                objtour.TourID = int.Parse(Request.QueryString["TourID"].ToString());
                initForm();
                table3.Visible = true;
            }
        }

        private void initForm()
        {
            objtour = new TourBL().Select(objtour);
            txtDes.Text = objtour.Description;
            txtMetaDes.Text = objtour.MetaDes;
            txtMetaTag.Text = objtour.MetaTag;
            txtDurationDay.Text = objtour.DurationDay.ToString();
            txtDurationNight.Text = objtour.DurationNight.ToString();
            cbIsSaleOff.Checked = objtour.IsSaleOff;
            cbIsOutPromotion.Checked = objtour.IsOutPromotion;
            txtAllPrice.Text = objtour.TourAllPrice;
            txtPrice.Text = objtour.TourPrice.ToString();
            txtTitle.Text = objtour.Title;
            txtTourCode.Text = objtour.TourCode;
            txtURL.Text = objtour.Alias;
            txtOder.Text = objtour.OrderID.ToString();
            txtNotes.Text = objtour.Notes;
            RadioButtonList1.SelectedIndex = objtour.TourCategoryID;
            cbActive.Checked = objtour.Published;
            cbTourType.Value = objtour.TourTypeID.ToString();
            cbisFrontPage.Checked = objtour.IsFrontPage;
            cbIsMenu.Checked = objtour.IsMenu;
            cbIsInboundTour.Checked = objtour.IsInboundTour;
            chkLaLichKhoiHanh.Checked = objtour.LichKhoiHanh;
            txtPriceUSD.Text = objtour.TourPriceUSD.ToString();
            if (objtour.ModuleID != null)
            {
                ddlViTri.SelectedValue = objtour.ModuleID.ToString();
            }
            if (!string.IsNullOrEmpty(objtour.TourImage))
            {
                hplImage1.Visible = true;
                hplImage1.NavigateUrl = "~/Media/" + objtour.TourImage;
                hplImage2.Visible = true;
                hplImage2.NavigateUrl = "~/Media/" + objtour.TourImage;
            }

            foreach (ListItem Item in cblDestination.Items)
            {
                if (new TourDestinationBL().Select1(objtour.TourID, int.Parse(Item.Value)))
                {
                    Item.Selected = true;
                }
            }
        }
        
        int i;
        
        protected void btSave_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objtour.TourID <= 0)
            {
                i = new TourBL().Insert(objtour);
                foreach (ListItem Item in cblDestination.Items)
                {

                    if (Item.Selected == true)
                    {

                        TourDestinationDO objtourdes = new TourDestinationDO();
                        objtourdes.DestinationID = int.Parse(Item.Value);
                        objtourdes.TourID = i;
                        if (!new TourDestinationBL().Select1(i, int.Parse(Item.Value)))
                        {
                            new TourDestinationBL().Insert(objtourdes);
                        }
                    }
                }
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListTour");
            }
            else
            {
                i = new TourBL().Update(objtour);
                i = objtour.TourID;
                new TourDestinationBL().DeletebyFK(objtour.TourID);
                foreach (ListItem Item in cblDestination.Items)
                {

                    if (Item.Selected == true)
                    {

                        TourDestinationDO objtourdes = new TourDestinationDO();
                        objtourdes.DestinationID = int.Parse(Item.Value);
                        objtourdes.TourID = i;
                        if (!new TourDestinationBL().Select1(i, int.Parse(Item.Value)))
                        {
                            new TourDestinationBL().Insert(objtourdes);
                        }
                    }
                }
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListTour");
            }
        }

        private void SetObject()
        {
            objtour.Alias = Functions.Change_AV(txtTitle.Text);
            objtour.Description = txtDes.Text;
            objtour.DurationDay = int.Parse(txtDurationDay.Text);
            objtour.DurationNight = int.Parse(txtDurationNight.Text);
            objtour.IsSaleOff = cbIsSaleOff.Checked;
            objtour.IsOutPromotion = cbIsOutPromotion.Checked;
            objtour.MetaDes = txtMetaDes.Text;
            objtour.MetaTag = txtMetaTag.Text;
            objtour.TourAllPrice = txtAllPrice.Text;
            objtour.Notes = txtNotes.Text;
            objtour.TourCategoryID = RadioButtonList1.SelectedIndex;
            objtour.ModuleID = int.Parse(ddlViTri.SelectedValue);
            if (txtPriceUSD.Text == "")
            {
                objtour.TourPriceUSD = 0;
            }
            else
            {
                objtour.TourPriceUSD = int.Parse(txtPriceUSD.Text);
            }
            objtour.LichKhoiHanh = chkLaLichKhoiHanh.Checked;
            try
            {
                objtour.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            
            objtour.Published = cbActive.Checked;
            objtour.Title = txtTitle.Text;
         
            try
            {
                objtour.TourTypeID = int.Parse(cbTourType.Value.ToString());
            }
            catch { }

            objtour.TourCode = txtTourCode.Text;
            objtour.IsFrontPage = cbisFrontPage.Checked;
            objtour.IsMenu = cbIsMenu.Checked;
            objtour.IsInboundTour = cbIsInboundTour.Checked;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objtour.TourImage = FileName;
            }

            if (!string.IsNullOrEmpty(fulImageFull.FileName))
            {
                string FileName = string.Format("{0}{1}", "full" + fulImageFull.FileName.Substring(0, fulImageFull.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImageFull.FileName.Substring(fulImageFull.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImageFull.SaveAs(SaveLocation);
                objtour.ImageFull = FileName;
            }
            if (txtPrice.Text == "")
            {
                objtour.TourPrice = 0;
            }
            if (!String.IsNullOrEmpty(txtPrice.Text))
            {
                objtour.TourPrice = double.Parse(txtPrice.Text);
            }
        }
    }
}