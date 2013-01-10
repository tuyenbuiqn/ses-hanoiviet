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
    public partial class ucHomeHotelTab : System.Web.UI.UserControl
    {
        int k = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DestinationBL().SelectHome(6);
            rptDesHome.DataSource = dt;
            rptDesHome.DataBind();
            rptDesContent.DataSource = dt;
            rptDesContent.DataBind();
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        public string StarRate(string s)
        {
            int n = int.Parse(s);
            return Ultility.StarRateHome(n);
        }
        public string MakeTab(string s)
        {
            
            int id = int.Parse(s);
            string f="";
            DestinationDO obj = new DestinationDO { DestinationID = id };
            obj = new DestinationBL().Select(obj);
            if (k == 0) 
                f = "<li class='active'><a href='#HotelTab" + obj.DestinationID.ToString() + "'>" + obj.Title + "</a></li>";
            else
                f = "<li><a href='#HotelTab" + obj.DestinationID.ToString() + "'>" + obj.Title + "</a></li>";
            k++;
            return f;
        }

        protected void rptDesContent_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;

                DataTable dtHotelHomeDes = new HotelBL().SelectbyDesHome(int.Parse(drv[DestinationDO.DESTINATIONID_FIELD].ToString()), 4);



                Repeater rptMenuChild = (Repeater)item.FindControl("rptHotelItem");
                rptMenuChild.DataSource = dtHotelHomeDes;
                rptMenuChild.DataBind();

               
            }
        }
    }
}