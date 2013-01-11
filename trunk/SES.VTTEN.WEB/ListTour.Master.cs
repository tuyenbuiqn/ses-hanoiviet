﻿using System;
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
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB
{
    public partial class ListTour : System.Web.UI.MasterPage
    {
        SlideBL slideBL = new SlideBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptListImage.DataSource = slideBL.SelectByCategoryID(1);
            rptListImage.DataBind();
        }
    }
}