<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListHotel.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListHotel" %>
    <%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<h2 style="text-align: left;">
    Danh sách khách sạn</h2>
<div style="width: 100%; float: left; height: auto;">
    <div style="width: 30%; float: left; height: auto;">
        <dxwtl:aspxtreelist id="treeCategory" clientinstancename="treeCategory" runat="server"
            autogeneratecolumns="False" cssfilepath="~/App_Themes/SoftOrange/{0}/styles.css"
            csspostfix="Soft_Orange" keyfieldname="DestinationID" parentfieldname="ParentID"
            width="95%" enablecallbacks="False" enabletheming="False">
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
                <dxwtl:TreeListDataColumn Caption="Danh mục" Name="DestinationID" VisibleIndex="1">
                    <DataCellTemplate>
                        <%#FindLink(Eval("DestinationID").ToString())%>
                    </DataCellTemplate>
                </dxwtl:TreeListDataColumn>
                <dxwtl:TreeListTextColumn Caption="DestinationID" FieldName="DestinationID" Visible="False"
                    VisibleIndex="1">
                </dxwtl:TreeListTextColumn>
            </Columns>
        </dxwtl:aspxtreelist>
    </div>
    <div style="width: 70%; float: left; height: auto;">
        <table style="border: 0px;" width="100%">
            <tr>
                <td>
                    <asp:GridView ID="gvHotel" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                        DataKeyNames="HotelID" OnPageIndexChanging="gvHotel_PageIndexChanging" OnSelectedIndexChanged="gvHotel_SelectedIndexChanged"
                        AllowPaging="True" OnRowDeleting="gvHotel_RowDeleting">
                        <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField DataField="HotelID" HeaderText="HotelID" Visible="False">
                                <HeaderStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Title" HeaderText="Tên khách sạn" >
                                <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="HotelStartPrice" HeaderText="Giá" />
                            <asp:BoundField DataField="StarRates" HeaderText="Hạng" />
                            <asp:CheckBoxField DataField="Published" HeaderText="Active" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                                    <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("HotelID") %>'
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
</div>
