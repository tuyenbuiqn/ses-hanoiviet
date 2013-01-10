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

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucReview : System.Web.UI.UserControl
    {
        CustomerReviewDO objCR = new CustomerReviewDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["CustomerReviewID"] != null)
            {
                objCR.CustomerReviewID = int.Parse(Request.QueryString["CustomerReviewID"]);
                initForm();
            }
        }
        private void initForm()
        {
            objCR = new CustomerReviewBL().Select(objCR);
            cbisFrontPage.Checked = objCR.IsFrontPage;
            txtTitle.Text = objCR.Title;
            txtDetail.Text = objCR.Detail;
            txtDes.Text = objCR.Description;
            txtURL.Text = objCR.Alias;
            txtTripLink.Text = objCR.TripAdvisorLink;
            chkIsTripAdvisor.Checked = objCR.TripAdvisor;
            if (!string.IsNullOrEmpty(objCR.ReviewImg))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "/Media/" + objCR.ReviewImg;
            }
            else
                hplImage.Visible = false;
        }
        protected void btSave_Click(object sender, EventArgs e)
        {
            setobject();
            if (objCR.CustomerReviewID <= 0)
            {
                new CustomerReviewBL().Insert(objCR);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListReview");
            }
            else
            {
                new CustomerReviewBL().Update(objCR);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListReview");
            }
        }

        private void setobject()
        {
            objCR.Description = txtDes.Text;
            objCR.Detail = txtDetail.Text;
            objCR.Title = txtTitle.Text;
            objCR.Alias = Functions.Change_AV(txtTitle.Text);
            objCR.IsFrontPage = cbisFrontPage.Checked;
            objCR.TripAdvisor = chkIsTripAdvisor.Checked;
            objCR.TripAdvisorLink = txtTripLink.Text;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objCR.ReviewImg = FileName;
            }
        }
    }
}