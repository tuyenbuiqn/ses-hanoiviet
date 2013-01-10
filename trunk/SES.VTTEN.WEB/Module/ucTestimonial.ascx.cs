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

namespace SES.VTTEN.WEB.Module
{
    public partial class ucTestimonial : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new CustomerReviewBL().SelectHome(1);
            if (dt.Rows.Count > 0)
            {
                lblTitle.Text = dt.Rows[0][CustomerReviewDO.TITLE_FIELD].ToString();
                lblDes.Text = dt.Rows[0][CustomerReviewDO.DESCRIPTION_FIELD].ToString();
                hplTripAd.NavigateUrl = dt.Rows[0][CustomerReviewDO.TRIPADVISORLINK_FIELD].ToString();
                hplRv.NavigateUrl = "/Travel-Review/" + dt.Rows[0][CustomerReviewDO.CUSTOMERREVIEWID_FIELD].ToString() + "/" + Ultility.Change_AV(dt.Rows[0][CustomerReviewDO.ALIAS_FIELD].ToString());
                
            }
        }
    }
}