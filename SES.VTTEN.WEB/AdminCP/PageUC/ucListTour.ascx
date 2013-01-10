<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListTour" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>



<h2 style="text-align: left;">
    Danh sách tour</h2>
<div style="width: 100%; float: left; height: auto;">
    <div style="width: 30%; float: left; height: auto;">
        <dxwtl:ASPxTreeList ID="treeCategory" ClientInstanceName="treeCategory" runat="server"
            AutoGenerateColumns="False" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
            CssPostfix="Soft_Orange" KeyFieldName="TourTypeID" ParentFieldName="ParentID"
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
                <dxwtl:TreeListDataColumn Caption="Danh mục" Name="TourTypeID" VisibleIndex="1">
                    <DataCellTemplate>
                        <%#FindLink(Eval("TourTypeID").ToString())%>
                    </DataCellTemplate>
                </dxwtl:TreeListDataColumn>
                <dxwtl:TreeListTextColumn Caption="TourTypeID" FieldName="TourTypeID" Visible="False"
                    VisibleIndex="1">
                </dxwtl:TreeListTextColumn>
            </Columns>
        </dxwtl:ASPxTreeList>
</div>
    <div style="width: 70%; float: left; height: auto;">
        <asp:GridView Font-Size="12px" EnableViewState="False" ID="gvTour" runat="server"
            AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="1" Width="100%" DataKeyNames="TourID" OnPageIndexChanging="gvTour_PageIndexChanging"
            OnRowDeleting="gvTour_RowDeleting" OnSelectedIndexChanged="gvTour_SelectedIndexChanged"
            AllowPaging="True" PageSize="20">
            <Columns>
                <asp:BoundField DataField="TourID" HeaderText="TourID" Visible="True">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Title" ItemStyle-HorizontalAlign="Left" HeaderText="Tên tour">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="TourCode" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="90px" HeaderText="Code">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="TourPrice" ItemStyle-HorizontalAlign="Right" Visible="True" HeaderText="Giá tour" />
                <asp:BoundField DataField="MetaDes" Visible="false" HeaderText="Mô tả" />
                <asp:TemplateField ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:ImageButton ID="bnEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                        <asp:ImageButton ID="bnDelete" runat="server" CommandArgument='<%#Eval("TourID") %>'
                            CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
                    </ItemTemplate>
                    <ItemStyle Width="50px"></ItemStyle>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
    </div>
</div>
