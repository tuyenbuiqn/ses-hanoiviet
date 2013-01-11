﻿using System;
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

namespace SES.VTTEN.WEB.Module
{
    public partial class ucRelatedTour : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourID = int.Parse(Request.QueryString["ID"].ToString());

                rptRelatedTourDataSource(TourID);
            }

        }
        public string Duration(string day, string night)
        {

            if (day == "1" || day == "0")
                day = day + " day";
            else day = day + " days";
            if (night == "1" || night == "0")
                night = night + " night";
            else night = night + " nights";
            return day + " " + night;
        }
        protected void rptRelatedTourDataSource(int TourID)
        {
            int TourTypeID = int.Parse(new TourBL().Select(new TourDO{TourID = TourID}).TourTypeID.ToString());

            DataTable dtOther = new TourBL().SelectTourByParentAndRecordNumber(TourTypeID,5);
            rptRelatedTours.DataSource = new DataView(dtOther, "TourID <>" + TourID, "", DataViewRowState.CurrentRows);
            rptRelatedTours.DataBind();
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}