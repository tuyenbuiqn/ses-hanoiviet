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
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int NewsID = int.Parse(Request.QueryString["ID"].ToString());

                NewsDetailDataSource(NewsID);

            }

        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void NewsDetailDataSource(int NewsID)
        {
            NewsDO objNews = new NewsDO();
            objNews.NewsID = NewsID;

            objNews = new NewsBL().Select(objNews);

            lblNewsTitle.Text = objNews.Title;

            Page.Title = lblNewsTitle.Text + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objNews.Description;
            Page.Header.Controls.Add(meta);



            lblDescription.Text = objNews.Detail;

            hplIMG.Attributes.Add("title", objNews.Title);
            hplIMG.NavigateUrl = imgRV.ImageUrl = "/Media/" + objNews.NewsImage;

            rptRelatedReview.DataSource = new DataView(new NewsBL().SelectbyNumber(), "NewsID<>" + objNews.NewsID, "", DataViewRowState.CurrentRows);
            rptRelatedReview.DataBind();


        }
    }
}
