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
    public partial class ucTourCateLeftMenu : System.Web.UI.UserControl
    {
        TourTypeBL tourtypeBL = new TourTypeBL();
        string Module = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsolutePath;
            if (!url.Equals("/Contact.aspx"))
            {
                url = url.Substring(1, url.Length - 1);
                Module = url.Substring(0, url.IndexOf("/"));
            }
            if (Module == "Travel-Guides" || Module == "Travel-Guide")
            {
                rptChildGuide.DataSource = new ContentBL().SelectNumberType(100, 1);
                rptChildGuide.DataBind();
                rptChildGuide.Visible = true;
            }
            if (Module == "Hotel-Category" || Module == "Hotel" || Module == "Hotel-Booking")
            {
                rptHotel.DataSource = new DestinationBL().SelectHotelCat();
                rptHotel.DataBind();
                rptHotel.Visible = true;
            }
            if (Module == "Vietnam-Destination" || Module == "Destination" )
            {
                rptChildDestination.DataSource = new DestinationBL().SelectHotelCat();
                rptChildDestination.DataBind();
                rptChildDestination.Visible = true;
            }
            rptParentTourType.DataSource = tourtypeBL.SelectAllParentHomePublish(true, true);
            rptParentTourType.DataBind();
        }

        protected void rptParentTourType_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;

                DataTable dtMenuChild = tourtypeBL.SelectByTopIDOnlyChild(int.Parse(drv["TourTypeID"].ToString()));

                Repeater rptChildTourType = (Repeater)item.FindControl("rptChildTourType");
                if (Module == "Tour-Category" || Module == "Tour" || Module == "Tour-Booking")
                {
                    rptChildTourType.Visible = true;
                    rptChildTourType.DataSource = dtMenuChild;
                    rptChildTourType.DataBind();
                }
                else
                    rptChildTourType.Visible = false;
            }
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}