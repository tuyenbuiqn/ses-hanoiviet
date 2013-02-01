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
    public partial class ucSearch : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ultility.ddlDatabinder(ddlDestinations, "DestinationID", "Title", new DestinationBL().SelectAll(), "--Chọn điểm đến--");
                Ultility.ddlDatabinder(ddlTourType, "TourTypeID", "Title", new TourTypeBL().SelectAll(), "--Chọn danh mục--");
            }
        }

        protected void lnkTimKiem_Click(object sender, EventArgs e)
        {
            int DesID = 0;
            if (ddlDestinations.SelectedIndex > 0)
                DesID = int.Parse(ddlDestinations.SelectedValue.ToString());
            int TourTypeID = 0;
            if (ddlTourType.SelectedIndex > 0)
                TourTypeID = int.Parse(ddlTourType.SelectedValue.ToString());
            int TourGiaTourID = 0;
            if (ddlTourCat.SelectedIndex > 0)
                TourGiaTourID = ddlTourCat.SelectedIndex;
            int DurationID = 0;
            if (ddlDuration.SelectedIndex > 0)
                DurationID = ddlDuration.SelectedIndex;

            Response.Redirect("/Search/" + DesID + "-" + TourTypeID + "-" + TourGiaTourID + "-" + DurationID + "/Vietnam-Travel.aspx");
        }
    }
}