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
    public partial class ucListTourType : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            tlTourType.DataSource = new TourTypeBL().SelectAll();
            tlTourType.DataBind();
            tlTourType.ExpandToLevel(3);
            //Selectnode();
        }

        //private void Selectnode()
        //{
        //    TreeListNodeIterator iterator = tlTourType.CreateNodeIterator();
        //    TreeListNode node;
        //    int i = 0;
        //    while (true)
        //    {
        //        node = iterator.GetNext();
        //        if (node == null) break;
        //        if (node.HasChildren)
        //        {
        //            tlTourType.FindNodesByFieldValue("ParentID", node.Key);
        //        }
        //        i++;
        //        if (i == 1)
        //        {
        //            tlTourType.FindDataCellTemplateControl(node.Key, (TreeListDataColumn)tlTourType.Columns[8], "btUp").Visible = false;
        //        }
        //        //if (i % 10)
        //        //{
        //        //    tlTourType.FindDataCellTemplateControl(node.Key, (TreeListDataColumn)tlTourType.Columns[8], "btDown").Visible = false;
        //        //}
        //    }
        //    if (!(i % 10 == 1))
        //    {
        //        tlTourType.FindDataCellTemplateControl(tlTourType.FindNodeByFieldValue("TourTypeID", i).Key, (TreeListDataColumn)tlTourType.Columns[8], "btDown").Visible = false;
        //    }
        //    else
        //        tlTourType.FindDataCellTemplateControl(tlTourType.FindNodeByFieldValue("TourTypeID", i).Key, (TreeListDataColumn)tlTourType.Columns[8], "btUp").Visible = false;
        //}
        protected void tlTourType_StartNodeEditing(object sender, DevExpress.Web.ASPxTreeList.TreeListNodeEditingEventArgs e)
        {
            int id = 0;
            if (int.TryParse(tlTourType.EditingNodeKey, out id))
            {
                Response.Redirect("Default.aspx?Page=TourType&TourTypeID=" + id.ToString());
            }
        }

        protected void tlTourType_NodeDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
        {
            new TourTypeBL().Delete(new TourTypeDO() { TourTypeID = int.Parse(tlTourType.FocusedNode.Key) });
            Response.Redirect("Default.aspx?Page=ListTourType");
        }

        protected void tlTourType_NodeUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListTourType");
        }

        protected void btup_Click(object sender, EventArgs e)
        {
            TourTypeDO obj1 = new TourTypeBL().Select(new TourTypeDO() { TourTypeID = int.Parse(tlTourType.FocusedNode.Key) });
            int i;
            for (i = 1; i < obj1.OrderID; i++)
            {
                int id = obj1.OrderID - i;
                if (new TourTypeBL().Selectby(id, obj1.ParentID).TourTypeID > 0)
                    break;
            }
            TourTypeDO obj2 = new TourTypeBL().Selectby(obj1.OrderID - i, obj1.ParentID);
            i = obj1.OrderID;
            obj1.OrderID = obj2.OrderID;
            obj2.OrderID = i;
            new TourTypeBL().Update(obj1);
            new TourTypeBL().Update(obj2);
            BindData();
        }

        protected void btdown_Click(object sender, EventArgs e)
        {
            TourTypeDO obj1 = new TourTypeBL().Select(new TourTypeDO() { TourTypeID = int.Parse(tlTourType.FocusedNode.Key) });
            int i = 0;
            do
            {
                i++;
            }
            while (!(new TourTypeBL().Selectby(obj1.OrderID + i, obj1.ParentID).TourTypeID > 0));
            TourTypeDO obj2 = new TourTypeBL().Selectby(obj1.OrderID + i, obj1.ParentID);
            i = obj1.OrderID;
            obj1.OrderID = obj2.OrderID;
            obj2.OrderID = i;
            new TourTypeBL().Update(obj1);
            new TourTypeBL().Update(obj2);
            BindData();
        }


        //protected void tlTourType_HtmlRowPrepared(object sender, TreeListHtmlRowEventArgs e)
        //{
        //    if (e.RowKind == TreeListRowKind.Data)
        //    {
        //        Selectnode();
        //    }
        //}

    }
}