﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DestinationTL.aspx.cs" Inherits="SES.VTTEN.WEB.AdminCP.DestinationTL" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<script type="text/javascript">
        function ReturnToParentPage() {
            var parentWindow = window.parent;   
            parentWindow.SelectAndClosePopup(tlDestination.GetFocusedNodeKey());
        }
    </script>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwtl:ASPxTreeList ID="tlDestination" runat="server" Width="100%" 
            AutoGenerateColumns="False" ClientInstanceName="tlDestination" 
            KeyFieldName="DestinationID" ParentFieldName="ParentID">
            <SettingsPager Mode="ShowPager">
            </SettingsPager>
            <SettingsBehavior AllowFocusedNode="True" />
            <Columns>
                <dxwtl:TreeListTextColumn FieldName="DestinationID" Visible="False" 
                    VisibleIndex="0">
                </dxwtl:TreeListTextColumn>
                <dxwtl:TreeListTextColumn FieldName="ParentID" Visible="False" VisibleIndex="0">
                </dxwtl:TreeListTextColumn>
                <dxwtl:TreeListTextColumn Caption="Tên địa danh" FieldName="Title" 
                    VisibleIndex="0">
                </dxwtl:TreeListTextColumn>
                <dxwtl:TreeListTextColumn FieldName="Description" Name="Mô tả" VisibleIndex="1">
                </dxwtl:TreeListTextColumn>
            </Columns>
        </dxwtl:ASPxTreeList>
    </div>
    <div>
        <asp:Button ID="btChon" runat="server" Text="Chọn" OnClientClick="ReturnToParentPage()" />
    
    </div>
    </form>
</body>
</html>
