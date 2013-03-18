using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;

namespace SES.VTTEN.WEB
{
    public partial class Intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblContent.Text = new ConfigBL().Select(new ConfigDO { ConfigID = 11 }).ConfigValue.ToString();
        }
    }
}