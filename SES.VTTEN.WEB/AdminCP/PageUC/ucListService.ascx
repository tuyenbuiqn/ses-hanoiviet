<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListService.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListService" %>
<h2 style="text-align: left;">
    Danh sách dịch vụ</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvService" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="ServiceID" OnPageIndexChanging="gvService_PageIndexChanging" OnRowDeleting="gvService_RowDeleting"
                OnSelectedIndexChanged="gvService_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="ServiceID" HeaderText="ServiceID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Title" HeaderText="Tựa đề" />
                    <asp:BoundField DataField="MetaDes" HeaderText="Mô tả" />
                    <asp:BoundField DataField="Published" HeaderText="Trạng thái" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ServiceID") %>'
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
