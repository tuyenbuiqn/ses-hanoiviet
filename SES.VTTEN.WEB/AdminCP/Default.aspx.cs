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
  
namespace SES.VTTEN.WEB.AdminCP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["Username"] != null)
            {
                lblUsername.Text = Session["Username"].ToString();
                SetPermission(Session["Permission"].ToString());
            }
            else Response.Redirect("Login.aspx");
            //Session[UsersDO.USERNAME_FIELD] = "admin";
           //Session[UsersDO.USERID_FIELD] = 1;

            if(Request.QueryString.Count == 0)
            {
                Control MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                phSubNav.Controls.Add(MnuPage);
                hplDestination.CssClass = "active";
            }
            else
            {
                
                Control CtrlPage = LoadControl("PageUC/uc" + Request.QueryString["Page"] + ".ascx");
                Control MnuPage = null;
                phPageControl.Controls.Add(CtrlPage);
                switch(Request.QueryString["Page"].ToString())
                {
                    case "Destination" :
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnu" + Request.QueryString["Page"] + ".ascx");
                        break;
                    case "ListDestination":
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                        break;
                    case "Tour":
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                        break;

                    case "TourType":
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                        break;
                    case "ListTourType":
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                        break;


                    case "ListTour":
                        hplDestination.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuDestination.ascx");
                        break;
                
                    case "Hotel":
                        hplHotel.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnHotel.ascx");
                        break;
                    case "ListHotel":
                        hplHotel.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnHotel.ascx");
                        break;
                    case "Service":
                        hplService.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuService.ascx");
                        break;
                    case "ListService":
                        hplService.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuService.ascx");
                        break;
                    case "News":
                        hplNews.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuNews.ascx");
                        break;
                    case "ListNews":
                        hplNews.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuNews.ascx");
                        break;
                    case "Content":
                        hplContent.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuContent.ascx");
                        break;

                    case "Review":
                        hplContent.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuContent.ascx");
                        break;

                    case "ListReview":
                        hplContent.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuContent.ascx");
                        break;

                    case "FooterTag":
                        hplContent.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuContent.ascx");
                        break;
                    case "ListContent":
                        hplContent.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuContent.ascx");
                        break;
                        //ALbum
                    case "ListVideoAlbum":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuQLAlbum.ascx");
                        break;
                    case "Album":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuQLAlbum.ascx");
                        break;
                    case "ListImgAlbum":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuQLAlbum.ascx");
                        break;
                    case "Slide":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuQLAlbum.ascx");
                        break;
                    case "ListSlide":
                        hplAlbum.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuQLAlbum.ascx");
                        break;
                    


                        //Hinh anh - video
                    case "TourImages":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "ListTourImages":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "Video":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "AddMultiImg":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "AlbumDetails":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "ImageDetail":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    case "ListVideoAlbums":
                        hplMedia.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuMedia.ascx");
                        break;
                    
                   
                 //
                    case "Customer":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "ListCustomer":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "ChatContent":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "ListChatContent":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "Contact":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "ListContact":
                        hplSupport.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuSupport.ascx");
                        break;
                    case "Adverts":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "ListAdvert":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "Link":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "ListLink":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "ListHotdeal":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "HotDeal":
                        hplAdvert.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuAdvert.ascx");
                        break;
                    case "User":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                    case "ListUser":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                    case "Module":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                    case "ListModule":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                    case "ListConfig":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                    case "Config":
                        hplConfig.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuConfig.ascx");
                        break;
                        // Booking tour
                    case "ListBooking":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                    case "ListCustomizeTour":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                    case "ListHotelBooking":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                    case "Booking":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                    case "CustomizeTour":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                    case "HotelBooking":
                        hplBooking.CssClass = "active";
                        MnuPage = LoadControl("MenuUC/ucMnuBooking.ascx");
                        break;
                }
                phSubNav.Controls.Add(MnuPage);
            }
        }

        protected void SetPermission(string permission)
        {
            if (permission == "admin")
            { }
            else if (permission == "support")
            {
                hplConfig.Visible = false;
                hplDestination.Visible = false;
                hplAdvert.Visible = false;
                hplMedia.Visible = false;
            }

        }
    }
}
