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

namespace SES.VTTEN.WEB.Module
{
    public partial class ucSearchTour : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ultility.ddlDatabinder(ddlDestination, "DestinationID", "Title", new DestinationBL().SelectAll(), "Destination");
                Ultility.ddlDatabinder(ddlTourType, "TourTypeID", "Title", new TourTypeBL().SelectAll(), "Please select");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int DesID = 0;
            if (ddlDestination.SelectedIndex > 0)
                DesID = int.Parse(ddlDestination.SelectedValue.ToString());
            int TourTypeID = 0;
            if (ddlTourType.SelectedIndex > 0)
                TourTypeID = int.Parse(ddlTourType.SelectedValue.ToString());
            int TourCatID = 0;
            if (ddlTourCat.SelectedIndex > 0)
                TourCatID = ddlTourCat.SelectedIndex;
            int DurationID = 0;
            if (ddlDuration.SelectedIndex > 0)
                DurationID = ddlDuration.SelectedIndex;

            Response.Redirect("/Search/" + DesID + "-" + TourTypeID + "-" + TourCatID + "-" + DurationID + "/Vietnam-Travel.aspx");

        }
        
    }
}