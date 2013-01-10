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

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucTourType : System.Web.UI.UserControl
    {
        TourTypeDO objTourType = new TourTypeDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.DevCboDatabinder(cbParent, new TourTypeBL().SelectAll(), TourTypeDO.TITLE_FIELD, TourTypeDO.TOURTYPEID_FIELD);
            if (Request.QueryString["TourTypeID"] != null)
            {
                objTourType.TourTypeID = int.Parse(Request.QueryString["TourTypeID"].ToString());
                initForm();
            }
        }

        private void initForm()
        {
            objTourType = new TourTypeBL().Select(objTourType);
            txtDes.Text = objTourType.Description;
            
            txtOder.Text = objTourType.OrderID.ToString();
            txtTitle.Text = objTourType.Title;
            txtURL.Text = objTourType.Alias;
            cbActive.Checked = objTourType.Published;
            ckbIsHomepage.Checked = objTourType.IsHomepage;
            if (objTourType.ParentID != 0)
                cbParent.Value = objTourType.ParentID.ToString();
            else
                {
                cbParent.Text = "None";
                cbRoot.Checked = true;
                }
            
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            SetObject();
            if (objTourType.TourTypeID <= 0)
            {
                new TourTypeBL().Insert(objTourType);
                Functions.Alert("Thêm mới thành công", "Default.aspx?Page=ListTourType");
            }
            else
            {
                new TourTypeBL().Update(objTourType);
                Functions.Alert("Cập nhật thành công", "Default.aspx?Page=ListTourType");
            }

        }

        private void SetObject()
        {
            objTourType.Description = txtDes.Text;
         
            try
            {
                objTourType.OrderID = int.Parse(txtOder.Text);
            }
            catch { }
            objTourType.Published = cbActive.Checked;
            objTourType.IsHomepage = ckbIsHomepage.Checked;
            objTourType.Title = txtTitle.Text;
            objTourType.Alias = Functions.Change_AV(txtTitle.Text);
                        if (cbRoot.Checked)
                objTourType.ParentID = 0;
            else
            {
                if (!string.IsNullOrEmpty(cbParent.Text))
                    objTourType.ParentID = int.Parse(cbParent.Value.ToString());
            }
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}