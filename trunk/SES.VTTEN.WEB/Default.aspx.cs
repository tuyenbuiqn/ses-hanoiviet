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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataView(new TourBL().SelectOutPromotion(),"IsFrontPage=1","",DataViewRowState.CurrentRows).ToTable();
            if ((dt != null) && (dt.Rows.Count > 0))
            {
                imgPromo.ImageUrl = "/Media/" + dt.Rows[0][TourDO.TOURIMAGE_FIELD].ToString();
                hpKM.NavigateUrl = "/Tour/" + dt.Rows[0]["TourID"].ToString() + "/" + Ultility.Change_AV(dt.Rows[0][TourDO.TITLE_FIELD].ToString());
                imgPromo.AlternateText = dt.Rows[0][TourDO.TITLE_FIELD].ToString();
                lblPromo.Text = dt.Rows[0][TourDO.TITLE_FIELD].ToString();
            }
            Page.Title = Ultility.Webtile();
        }
    }
}