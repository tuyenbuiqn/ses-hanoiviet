using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB
{
    public partial class Hotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = new ConfigBL().Select(new ConfigDO { ConfigID = 1 }).ConfigValue.ToString();
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int HotelID = int.Parse(Request.QueryString["ID"].ToString());

                HotelDetailDataSource(HotelID);

            }

        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void HotelDetailDataSource(int HotelID)
        {
            HotelDO objHotel = new HotelDO();
            objHotel.HotelID = HotelID;

            objHotel = new HotelBL().Select(objHotel);

            try
            {
                DestinationDO objD = new DestinationDO();
                objD.DestinationID = objHotel.DestinationID;
                objD = new DestinationBL().Select(objD);
                hplKhacSanDestination.Text = objD.Title;
                hplKhacSanDestination.ToolTip = objD.Title;
                hplKhacSanDestination.NavigateUrl = "/Hotel-Category/" + objHotel.DestinationID + "/" + objD.Alias + ".aspx";
            }
            catch 
            {
            }
            
            lblHotelName.Text = objHotel.Title;
            lblHotelNameTitle.Text = objHotel.Title;
            //lblStarRate.Text = objHotel.StarRates.ToString() ;
            lblHotelPrice.Text = objHotel.HotelStartPrice.ToString();
            lblDescription.Text = objHotel.Description;

            Page.Title = objHotel.Title + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objHotel.Description;
            Page.Header.Controls.Add(meta);



            lblFullDescription.Text = objHotel.Detail;

            //lblStarRate.Text = Ultility.StarRate(objHotel.StarRates);
            lblHotelInformation.Text = objHotel.ContactInfo;
            //lblHotelNoneInclude.Text = objHotel.NonInclude;
            lblRecommended.Text = objHotel.MetaDes;
            hplImg.NavigateUrl = "/Media/" + objHotel.HotelImage;
            ImgHotel.ImageUrl = "/Media/" + objHotel.HotelImage;
            rpImage.DataSource = new MediaBL().SelectByObject("Hotel", objHotel.HotelID, 3);
            rpImage.DataBind();

            hplImg.Attributes.Add("rel", "Hotelimg");
            hplImg.Attributes.Add("title", objHotel.Title);
            hplBook.NavigateUrl = "/Hotel-Booking/" + objHotel.HotelID.ToString() + "/" + FriendlyUrl(objHotel.Alias);
            //imgHotelFull.ImageUrl = "/Media/" + objHotel.ImageFull;

        }
    }
}
