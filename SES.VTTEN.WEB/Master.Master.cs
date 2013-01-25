using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using System.Data;

namespace SES.VTTEN.WEB
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    //         <script type="text/javascript">
    //    jQuery(document).ready(function () {
    //        jQuery('#carouselTour').jcarousel({
    //            scroll:1
    //        });
    //    });
    //</script>

            string scr = "<script type='text/javascript'> jQuery(document).ready(function () {";
            DataTable dtcatcarou = new TourTypeBL().GetTourCateHomepage(true);
            foreach (DataRow dr in dtcatcarou.Rows)
            {
                scr += "jQuery('#carouselTour_" + dr[TourTypeDO.TOURTYPEID_FIELD].ToString() + "').jcarousel({ scroll:1});";
            
            }
            scr += "  });</script>";
            lblscr.Text = scr;

            string scrOut = "<script type='text/javascript'> jQuery(document).ready(function () {";
            DataTable dtcatcarouOut = new TourTypeBL().GetTourCateHomepage(false);
            foreach (DataRow dr in dtcatcarouOut.Rows)
            {
                scrOut += "jQuery('#carouselTourOut_" + dr[TourTypeDO.TOURTYPEID_FIELD].ToString() + "').jcarousel({ scroll:1});";
            }
            scrOut += "  });</script>";
            lblscrOut.Text = scrOut;

            rptListVNTour.DataSource = new TourTypeBL().SelectByTopID(1);
            rptListVNTour.DataBind();
        }
    }
}