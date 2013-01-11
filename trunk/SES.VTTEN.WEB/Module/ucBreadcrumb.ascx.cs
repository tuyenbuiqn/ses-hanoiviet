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

namespace SES.VTTEN.WEB.Module
{
    public partial class ucBreadcrumb : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsolutePath;
            url = url.Substring(1, url.Length - 1);
            string url1 = url.Replace(".", "/");
            string Module = url1.Substring(0, url1.IndexOf("/"));

            if (Module.Equals("Tour-Booking"))
            {
                TourDO objTour = new TourDO();
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int TourID = int.Parse(Request.QueryString["ID"]);

                    objTour.TourID = TourID;
                    objTour = new TourBL().Select(objTour);
                    lblTitle.Text = "<a href='/Tour-Booking/" + TourID + "/" + FriendlyUrl(objTour.Alias) + "' title ='" + objTour.Title + "'> Booking: " + objTour.Title + "</a>";
                }
            }
            else if (Module.Equals("Custom-Tour"))
            {
                lblTitle.Text = "<a href='/Custom-Tour.aspx' title='customize tour'> Customize tour</a>";
            }
            else if (Module.Equals("Hotel-Booking"))
            {
                HotelDO objHotel = new HotelDO();
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int hotelID = int.Parse(Request.QueryString["ID"]);

                    objHotel.HotelID = hotelID;
                    objHotel = new HotelBL().Select(objHotel);
                    lblTitle.Text = "<a href='/Hotel-Booking/" + hotelID + "/" + FriendlyUrl(objHotel.Alias) + "' title ='" + objHotel.Title + "'> Booking: " + objHotel.Title + "</a>";
                }
            }
            else if (Module.Equals("Travel-Guides"))
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int ContentTypeID = int.Parse(Request.QueryString["ID"].ToString());
                    ContentTypeDO objTT = new ContentTypeBL().Select(new ContentTypeDO { ContentTypeID = ContentTypeID });
                    lblTitle.Text = "<a href='/Travel-Guides/" + ContentTypeID + "/default.aspx' title='" + objTT.Title + "'>" + objTT.Title + "</a>";
               }
            }
            else if (Module.Equals("Travel-Guide"))
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    ContentDO objContent = new ContentDO();
                    int ContentTypeID = int.Parse(Request.QueryString["ID"].ToString());
                    objContent.ContentID = ContentTypeID;
                    objContent = new ContentBL().Select(objContent);
                    lblTitle.Text = "<a href='/Travel-Guides/1/default.aspx' title = 'travel-guides'>Travel Guides » </a>";
                    lblTitle.Text += "<a href='/Travel-Guide/" + ContentTypeID + "/" + FriendlyUrl(objContent.Title) + "' title='" + objContent.Title + "'>" + objContent.Title + "</a>";
                }
            }
            else if (Module.Equals("Contact"))
            {
                lblTitle.Text = "<a href='/Contact.aspx' title='contact us'> Liên hệ</a>";
            }
            else if (Module.Equals("About"))
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    ContentDO objContent = new ContentDO();
                    int ContentTypeID = int.Parse(Request.QueryString["ID"].ToString());
                    objContent.ContentID = ContentTypeID;
                    objContent = new ContentBL().Select(objContent);
                    lblTitle.Text = "<a href='/About/" + ContentTypeID + "/" + FriendlyUrl(objContent.Title) + "' title='" + objContent.Title + "'>" +   objContent.Title + "</a>";
                }
            }
            else if (Module.Equals("Albums"))
            {
                lblTitle.Text = "<a href='/Albums/0/vietnam-photo.aspx' title='Vietnam Travel Photos'> Vietnam Travel Photos</a>";
            }
        }
        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }
    }
}