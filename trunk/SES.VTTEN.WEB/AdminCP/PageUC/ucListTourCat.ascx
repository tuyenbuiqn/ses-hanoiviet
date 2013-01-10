<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListTourCat.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListTourCat" %>
<h2 style="text-align: left;">
    Danh mục Tour</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvTourCat" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="TourCategoryID" OnPageIndexChanging="gvTourCat_PageIndexChanging" OnRowDeleting="gvTourCat_RowDeleting"
                OnSelectedIndexChanged="gvTourCat_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="TourCategoryID" HeaderText="TourCategoryID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Title" HeaderText="Tên danh mục tour" />
                    <asp:BoundField DataField="OrderID" HeaderText="Thứ tự" />
                    <asp:BoundField DataField="Published" HeaderText="Active" />
                    <asp:BoundField DataField="isFrontPage" HeaderText="Hiện trang chủ" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("TourCategoryID") %>'
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