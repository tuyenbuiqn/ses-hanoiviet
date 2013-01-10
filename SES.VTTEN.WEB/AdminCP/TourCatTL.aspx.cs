using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.AdminCP
{
    public partial class TourCatTL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tlTourCat.DataSource = new TourCategoryBL().SelectAll();
            tlTourCat.DataBind();
            tlTourCat.ExpandToLevel(3);
        }
    }
}
