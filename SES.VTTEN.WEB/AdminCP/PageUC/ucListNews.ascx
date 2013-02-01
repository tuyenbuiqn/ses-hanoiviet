<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListNews.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListNews" %>
<h2 style="text-align: left;">
    Danh sách tin</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="NewsID" OnPageIndexChanging="gvNews_PageIndexChanging" OnRowDeleting="gvNews_RowDeleting"
                OnSelectedIndexChanged="gvNews_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="NewsID" HeaderText="Mã" ItemStyle-Width="5%" Visible="true">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Title" HeaderText="Tựa đề" ItemStyle-Width="20%" ItemStyle-HorizontalAlign="Left"/>
                    <asp:BoundField DataField="Description" HeaderText="Mô tả"  ItemStyle-HorizontalAlign="Justify" ItemStyle-Width="60%" />
                    <asp:BoundField DataField="Published" HeaderText="Trạng thái" ItemStyle-Width="5%"/>
                    <asp:BoundField DataField="ModuleID" HeaderText="Thuộc modul" ItemStyle-Width="5%"/>
                    <asp:TemplateField ItemStyle-Width="5%" HeaderText="Action">
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("NewsID") %>'
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
