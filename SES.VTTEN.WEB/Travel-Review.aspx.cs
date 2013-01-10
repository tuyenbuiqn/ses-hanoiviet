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
    public partial class Travel_Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int CustomerReviewID = int.Parse(Request.QueryString["ID"].ToString());

                CustomerReviewDetailDataSource(CustomerReviewID);

            }

        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        protected void CustomerReviewDetailDataSource(int CustomerReviewID)
        {
            CustomerReviewDO objCustomerReview = new CustomerReviewDO();
            objCustomerReview.CustomerReviewID = CustomerReviewID;

            objCustomerReview = new CustomerReviewBL().Select(objCustomerReview);

            lblReviewTitle.Text = objCustomerReview.Title;

            Page.Title = lblReviewTitle.Text + Ultility.Webtile();
            HtmlMeta meta = new HtmlMeta();
            meta.Name = "description";
            meta.Content = objCustomerReview.Description;
            Page.Header.Controls.Add(meta);



            lblDescription.Text = objCustomerReview.Detail;
           
            hplIMG.Attributes.Add("title", objCustomerReview.Title);
            hplIMG.NavigateUrl = imgRV.ImageUrl = "/Media/" + objCustomerReview.ReviewImg;

            rptRelatedReview.DataSource = new DataView(new CustomerReviewBL().SelectAll(), "CustomerReviewID<>" + objCustomerReview.CustomerReviewID, "", DataViewRowState.CurrentRows);
            rptRelatedReview.DataBind();


        }
    }
}
