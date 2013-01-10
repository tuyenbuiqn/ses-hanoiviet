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
    public partial class ucListTour : System.Web.UI.UserControl
    {
        string gvUniqueID = String.Empty;
        int gvNewPageIndex = 0;
        int gvEditIndex = -1;
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadTour();
            LoadTLData();
        }

        private void LoadTLData()
        {
            treeCategory.DataSource = new TourTypeBL().SelectAll();
            treeCategory.DataBind();
            treeCategory.ExpandToLevel(3);


        }

        private void LoadTour()
        {
            if (Request.QueryString["TourTypeID"] != null)
            {
                gvTour.DataSource = new TourBL().SelectbyTourType(int.Parse(Request.QueryString["TourTypeID"].ToString()));

            }
            else gvTour.DataSource = new TourBL().SelectAll();
            gvTour.DataBind();

        }
        protected void gvTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TourID = Convert.ToInt32(gvTour.DataKeys[gvTour.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Tour&TourID=" + TourID.ToString());
        }

        protected void gvTour_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTour.PageIndex = e.NewPageIndex;
            LoadTour();
        }

        protected void gvTour_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new TourBL().Delete(new TourDO { TourID = Convert.ToInt32(gvTour.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvTour_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            GridViewRow row = e.Row;
            if (row.DataItem == null)
            {
                return;
            }

            //Find Child GridView control
            GridView gv = new GridView();
            gv = (GridView)row.FindControl("gvTourDeparture");

            //Check if any additional conditions (Paging, Sorting, Editing, etc) to be applied on child GridView
            if (gv.UniqueID == gvUniqueID)
            {
                gv.PageIndex = gvNewPageIndex;
                gv.EditIndex = gvEditIndex;
                Page.ClientScript.RegisterStartupScript(GetType(), "Expand", "<SCRIPT LANGUAGE='javascript'>expandcollapse('div" + ((DataRowView)e.Row.DataItem)["TourID"].ToString() + "','one');</script>");
            }

            //Prepare the query for Child GridView by passing the KhachSan ID of the parent row
            //TourDepartureDO objTourDep = new TourDepartureDO();
            //objTourDep = new TourDepartureBL().Select(new TourDepartureDO { TourID = Convert.ToInt32(((DataRowView)e.Row.DataItem)["TourID"]) });
            gv.DataSource = new TourDepartureBL().SelectbyFK(Convert.ToInt32(((DataRowView)e.Row.DataItem)["TourID"]));
            gv.DataBind();
        }
      
        public string FindLink(string id)
        {
            int ids = int.Parse(id);
            //DataTable dtx = new cmsCategoryBL().SelectOne(ids);
            string url = "";
            //if (dtx.Rows[0]["Type"].ToString().Equals("Cat"))
            //{
            TourTypeDO objDes = new TourTypeDO();
            objDes.TourTypeID = int.Parse(id);
            objDes = new TourTypeBL().Select(objDes);
            if (Request.QueryString["TourTypeID"] != null)
            {
                if (id == Request.QueryString["TourTypeID"].ToString())
                {
                    return "<a href='Default.aspx?Page=ListTour&TourTypeID=" + objDes.TourTypeID + "'><b>" + objDes.Title + "</b></a>";
                }
            }
            return "<a href='Default.aspx?Page=ListTour&TourTypeID=" + objDes.TourTypeID + "'>" + objDes.Title + "</a>";




        }

    }
}