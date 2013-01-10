<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListModule.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListModule" %>
    <h2>List module</h2>
<asp:GridView ID="gvModule" runat="server" AutoGenerateColumns="False" BackColor="White"
    BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
    DataKeyNames="ModuleID" OnPageIndexChanging="gvModule_PageIndexChanging" OnRowDeleting="gvModule_RowDeleting"
    OnSelectedIndexChanged="gvModule_SelectedIndexChanged" AllowPaging="True">
    <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
    <Columns>
        <asp:TemplateField HeaderText="STT">
            <ItemTemplate>
                <%# Container.DataItemIndex + 1 %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="ModuleID" HeaderText="STT" Visible="false">
            <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="ModuleName" HeaderText="Tên" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("ModuleID") %>'
                    CommandName="Delete" ImageUrl="~/AdminCP/images/delete_16x16.gif" OnClientClick="return confirm('Có muốn xóa bản ghi này? Nhấn OK để xóa!')" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
</asp:GridView>
