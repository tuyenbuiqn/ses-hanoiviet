<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListAdvert.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListAdvert" %>
<h2 style="text-align: left;">
    Danh sách Advert</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvAdvert" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="AdvertID" OnPageIndexChanging="gvAdvert_PageIndexChanging" OnRowDeleting="gvAdvert_RowDeleting"
                OnSelectedIndexChanged="gvAdvert_SelectedIndexChanged"
                AllowPaging="True">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="AdvertID" HeaderText="AdvertID" Visible="False">
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Title" HeaderText="Tên quảng cáo" />
                    <asp:BoundField DataField="TimeStart" HeaderText="Ngày bắt đầu" />
                    <asp:BoundField DataField="TimeExpire" HeaderText="Ngày kết thúc" />
                    <asp:BoundField DataField="Published" HeaderText="Active" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btEdit" runat="server" CommandName="Select" ImageUrl="~/AdminCP/images/edit_16x16.gif" />
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("AdvertID") %>'
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
