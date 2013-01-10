﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListHotelBooking.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListHotelBooking" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<h2 style="text-align: left;">
    Danh sách Hotel booking</h2>

<div style="width: 100%; float: left; height: auto;">
   <div style="line-height:30px; height:30px; width:100%;">
    <asp:CheckBox runat="server" ID="cboListAll" Text="Xem toàn bộ" AutoPostBack="true"
            oncheckedchanged="cboListAll_CheckedChanged" /></div>
    <div style="width: 30%; float: left; height: auto;">
 
        <dxwtl:ASPxTreeList ID="treeCategory" ClientInstanceName="treeCategory" runat="server"
            AutoGenerateColumns="False" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
            CssPostfix="Soft_Orange" KeyFieldName="HotelID"
            Width="95%" EnableCallbacks="False" EnableTheming="False">
            <Styles CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="Soft_Orange">
            </Styles>
            <Images ImageFolder="~/App_Themes/SoftOrange/{0}/">
                <CollapsedButton Height="13px" Url="~/App_Themes/SoftOrange/TreeList/CollapsedButton.png"
                    Width="13px" />
                <ExpandedButton Height="13px" Url="~/App_Themes/SoftOrange/TreeList/ExpandedButton.png"
                    Width="13px" />
                <CustomizationWindowClose Height="18px" Width="18px" />
            </Images>
            <SettingsText LoadingPanelText="" />
            <SettingsLoadingPanel Text="" />
            <SettingsPager Mode="ShowPager" PageSize="100">
                <AllButton Text="All">
                    <Image Height="19px" Width="28px" />
                </AllButton>
                <FirstPageButton>
                    <Image Height="19px" Width="23px" />
                </FirstPageButton>
                <LastPageButton>
                    <Image Height="19px" Width="23px" />
                </LastPageButton>
                <NextPageButton Text="Next &gt;">
                </NextPageButton>
                <PrevPageButton Text="&lt; Prev">
                    <Image Height="19px" Width="19px" />
                </PrevPageButton>
            </SettingsPager>
            <Settings SuppressOuterGridLines="True" />
            <SettingsBehavior AllowFocusedNode="True" />
            <Columns>
                <dxwtl:TreeListDataColumn Caption="Tên khách sạn" Name="HotelID" VisibleIndex="1">
                    <DataCellTemplate>
                        <%#FindLink(Eval("HotelID").ToString())%>
                    </DataCellTemplate>
                </dxwtl:TreeListDataColumn>
                <dxwtl:TreeListTextColumn Caption="HotelID" FieldName="HotelID" Visible="False"
                    VisibleIndex="1">
                </dxwtl:TreeListTextColumn>
            </Columns>
        </dxwtl:ASPxTreeList>
    </div>
      
<table style="border: 0px;" width="70%">
    <tr>
        <td>
            <asp:GridView ID="gvHotelBooking" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="BookingID" OnPageIndexChanging="gvHotelBooking_PageIndexChanging" OnRowDeleting="gvHotelBooking_RowDeleting"
                OnSelectedIndexChanged="gvHotelBooking_SelectedIndexChanged" AllowPaging="True" PageSize="50">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                   <asp:BoundField DataField="HotelName" HeaderText="Tên khách sạn đặt" />
                    <asp:TemplateField HeaderText="Ngày đi dự kiến">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblArrivalDate" Text='<%#Eval("ArrivalDate","{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="FullName" HeaderText="Khách đặt" />
                     <asp:BoundField DataField="PhoneNo" HeaderText="Điện thoại" />
                     <asp:BoundField DataField="Email" HeaderText="Email" />
                    
                    <asp:TemplateField HeaderText="Thao tác">
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" ToolTip="Xem chi tiết" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("BookingID") %>'
                                CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:GridView>
        </td>
    </tr>
</table>
</div>