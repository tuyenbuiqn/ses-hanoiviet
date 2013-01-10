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
    public partial class ucListTourImages : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Functions.ddlDatabinder(ddlTour, TourDO.TOURID_FIELD, TourDO.TITLE_FIELD, new TourBL().SelectAll());
            }
            dlImagesDataSource();
        }

        protected void dlImagesDataSource()
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 50; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new MediaBL().SelectByTourID(0).DefaultView;

            CollectionPager1.BindToControl = dlImages;
            dlImages.DataSource = CollectionPager1.DataSourcePaged;
            dlImages.DataBind();
        }
        protected void dlImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ImageID = int.Parse(dlImages.DataKeys[dlImages.SelectedIndex].ToString());
            Response.Redirect("Default.aspx?Page=TourImages&MediaID=" + ImageID.ToString());
        }

        protected void dlImages_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            int PLID = int.Parse(dlImages.DataKeys[e.Item.ItemIndex].ToString());
            new MediaBL().Delete(new MediaDO { MediaID = PLID });

            Functions.Alert("Xóa thành công", "Default.aspx?Page=ListTourImages");
        }

        protected void ddlTour_SelectedIndexChanged(object sender, EventArgs e)
        {


            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 50; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new MediaBL().SelectByTourID(int.Parse(ddlTour.SelectedValue)).DefaultView;

            CollectionPager1.BindToControl = dlImages;
            dlImages.DataSource = CollectionPager1.DataSourcePaged;
            dlImages.DataBind();
        }

     
    }
}