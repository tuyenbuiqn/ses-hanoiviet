using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucFooterTag : System.Web.UI.UserControl
    {
        FooterTagDO objfooter = new FooterTagDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            objfooter = new FooterTagBL().SelectTop();
            txtTag.Text = objfooter.Tag;
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            objfooter.Tag = txtTag.Text;
            new FooterTagBL().Update(objfooter);
        }
    }
}