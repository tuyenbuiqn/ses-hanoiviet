using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.DO;
using SES.VTTEN.BL;
namespace SES.VTTEN.WEB
{
    public partial class Destination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());

                DestinationDetailDataSource(DestinationID);

            }

        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void DestinationDetailDataSource(int DestinationID)
        {
            DestinationDO objDestination = new DestinationDO();
            objDestination.DestinationID = DestinationID;

            objDestination = new DestinationBL().Select(objDestination);

            lblDestinationName.Text = objDestination.Title;

            Page.Title = objDestination.Title + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objDestination.MetaDes;
            Page.Header.Controls.Add(meta);
            lblDescription.Text = objDestination.Detail;

            rptRelatedTour.DataSource = new TourBL().SelectbyDes(objDestination.DestinationID);
            rptRelatedTour.DataBind();


            rpImage.DataSource = new MediaBL().SelectByObject("Destination", objDestination.DestinationID, 6);
            rpImage.DataBind();
            hplMainIMG.Attributes.Add("rel", "tourimg");
            hplMainIMG.Attributes.Add("title", objDestination.Title);
            ImgTour.ImageUrl = "/Media/" + objDestination.DestinationImage;
            hplMainIMG.Attributes.Add("href", ImgTour.ImageUrl);


        }
    }
}
