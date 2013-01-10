using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using DevExpress.Web.ASPxTreeList;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListDestination : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            tlDestination.DataSource = new DestinationBL().SelectAll();
            tlDestination.DataBind();
            tlDestination.ExpandToLevel(3);
            //Selectnode();
        }

        //private void Selectnode()
        //{
        //    TreeListNodeIterator iterator = tlDestination.CreateNodeIterator();
        //    TreeListNode node;
        //    int i = 0;
        //    while (true)
        //    {
        //        node = iterator.GetNext();
        //        if (node == null) break;
        //        if (node.HasChildren)
        //        {
        //            tlDestination.FindNodesByFieldValue("ParentID", node.Key);
        //        }
        //        i++;
        //        if (i == 1)
        //        {
        //            tlDestination.FindDataCellTemplateControl(node.Key, (TreeListDataColumn)tlDestination.Columns[8], "btUp").Visible = false;
        //        }
        //        //if (i % 10)
        //        //{
        //        //    tlDestination.FindDataCellTemplateControl(node.Key, (TreeListDataColumn)tlDestination.Columns[8], "btDown").Visible = false;
        //        //}
        //    }
        //    if (!(i % 10 == 1))
        //    {
        //        tlDestination.FindDataCellTemplateControl(tlDestination.FindNodeByFieldValue("DestinationID", i).Key, (TreeListDataColumn)tlDestination.Columns[8], "btDown").Visible = false;
        //    }
        //    else
        //        tlDestination.FindDataCellTemplateControl(tlDestination.FindNodeByFieldValue("DestinationID", i).Key, (TreeListDataColumn)tlDestination.Columns[8], "btUp").Visible = false;
        //}
        protected void tlDestination_StartNodeEditing(object sender, DevExpress.Web.ASPxTreeList.TreeListNodeEditingEventArgs e)
        {
            int id = 0;
            if (int.TryParse(tlDestination.EditingNodeKey, out id))
            {
                Response.Redirect("Default.aspx?Page=Destination&DestinationID=" + id.ToString());
            }
        }

        protected void tlDestination_NodeDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
        {
            new DestinationBL().Delete(new DestinationDO() { DestinationID = int.Parse(tlDestination.FocusedNode.Key)});
            Response.Redirect("Default.aspx?Page=ListDestination");
        }

        protected void tlDestination_NodeUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            Response.Redirect("Default.aspx?Page=ListDestination");
        }

        protected void btup_Click(object sender, EventArgs e)
        {
            DestinationDO obj1 = new DestinationBL().Select(new  DestinationDO() { DestinationID = int.Parse(tlDestination.FocusedNode.Key) });
            int i;
            for (i = 1; i < obj1.OrderID; i++)
            {
                int id = obj1.OrderID - i;
                if ( new DestinationBL().Selectby(id, obj1.ParentID).DestinationID >0)
                    break;
            }
            DestinationDO obj2 = new DestinationBL().Selectby(obj1.OrderID -i, obj1.ParentID);
            i = obj1.OrderID;
            obj1.OrderID = obj2.OrderID;
            obj2.OrderID = i;
            new DestinationBL().Update(obj1);
            new DestinationBL().Update(obj2);
            BindData();
        }

        protected void btdown_Click(object sender, EventArgs e)
        {
            DestinationDO obj1 = new DestinationBL().Select(new DestinationDO() { DestinationID = int.Parse(tlDestination.FocusedNode.Key) });
            int i = 0;
            do
            {
                i++;
            }
            while (!(new DestinationBL().Selectby(obj1.OrderID + i, obj1.ParentID).DestinationID > 0));
            DestinationDO obj2 = new DestinationBL().Selectby(obj1.OrderID + i, obj1.ParentID);
            i = obj1.OrderID;
            obj1.OrderID = obj2.OrderID;
            obj2.OrderID = i;
            new DestinationBL().Update(obj1);
            new DestinationBL().Update(obj2);
            BindData();
        }


        //protected void tlDestination_HtmlRowPrepared(object sender, TreeListHtmlRowEventArgs e)
        //{
        //    if (e.RowKind == TreeListRowKind.Data)
        //    {
        //        Selectnode();
        //    }
        //}




    }
}