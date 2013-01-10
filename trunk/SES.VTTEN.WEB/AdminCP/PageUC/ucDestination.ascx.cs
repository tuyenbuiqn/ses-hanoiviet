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
using CKEditor.NET;
namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucDestination : System.Web.UI.UserControl
    {
        DestinationDO objDes = new DestinationDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Functions.DevCboDatabinder(cbParent, new DestinationBL().SelectAll(), DestinationDO.TITLE_FIELD,DestinationDO.DESTINATIONID_FIELD);
            if (Request.QueryString["DestinationID"] != null)
            {
                objDes.DestinationID = int.Parse(Request.QueryString["DestinationID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objDes = new DestinationBL().Select(objDes);
            txtDes.Text = objDes.Description;
            
            txtDetail.Text = objDes.Detail;
            txtMetaDes.Text = objDes.MetaDes;
            txtMetaTag.Text = objDes.MetaTag;
            txtOder.Text = objDes.OrderID.ToString();
           
            txtTitle.Text = objDes.Title;
            txtURL.Text = objDes.Alias;
            cbActive.Checked = objDes.Published;
            cbisFrontPage.Checked = objDes.IsFrontPage;
            if (!string.IsNullOrEmpty(objDes.DestinationImage))
            {
                hplImage.Visible = true;
                hplImage.NavigateUrl = "~/Media/" + objDes.DestinationImage;
            }

            ddlRegions.SelectedValue = objDes.Regions.ToString();
        }

        protected void btSave_Click(object sender, EventArgs e) 
        {
            SetObject();
            if (objDes.DestinationID <= 0)
            {
                new DestinationBL().Insert(objDes);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListDestination");
            }
            else
            {
                new DestinationBL().Update(objDes);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListDestination");
            }
            
        }

        private void SetObject()
        {
            objDes.Title = txtTitle.Text;
            objDes.MetaDes = txtMetaDes.Text;
            objDes.MetaTag = txtMetaTag.Text;
            
            objDes.Detail = txtDetail.Text;
            objDes.Description = txtDes.Text;
            objDes.IsFrontPage = cbisFrontPage.Checked;
            objDes.Published = cbActive.Checked;
            if (!string.IsNullOrEmpty(fulImage.FileName))
            {
                string FileName = string.Format("{0}{1}", fulImage.FileName.Substring(0, fulImage.FileName.LastIndexOf(".")) + "-" + DateTime.Now.ToString("dd-MM-yyyy-hhmmss"), fulImage.FileName.Substring(fulImage.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImage.SaveAs(SaveLocation);
                objDes.DestinationImage = FileName;
            }
            objDes.Regions = int.Parse(ddlRegions.SelectedValue);

            try
            {
                objDes.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objDes.Alias = Functions.Change_AV(txtTitle.Text);
            
        }
        protected void btCancel_Click(object sender, EventArgs e)
        {

        }


    }
}