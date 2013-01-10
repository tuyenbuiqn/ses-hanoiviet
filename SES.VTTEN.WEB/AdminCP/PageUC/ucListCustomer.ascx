<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListCustomer.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListCustomer" %>
<h2 style="text-align: left;">
    Danh sách Khách hàng</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvCustomer" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="CustomerID" OnPageIndexChanging="gvCustomer_PageIndexChanging" OnRowDeleting="gvCustomer_RowDeleting"
                OnSelectedIndexChanged="gvCustomer_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CustomerName" HeaderText="Tên khách hàng" />
                    <asp:BoundField DataField="Phone" HeaderText="Số điện thoại" />
                    <asp:BoundField DataField="IDCard" HeaderText="ID Card" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("CustomerID") %>'
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