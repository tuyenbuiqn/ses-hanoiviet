<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListCustomizeTour.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListCustomizeTour" %>
<h2 style="text-align: left;">
    Danh sách Customize Tour</h2>
<table style="border: 0px;" width="100%">
    <tr>
        <td>
            <asp:GridView ID="gvCustomizeTour" runat="server" AutoGenerateColumns="False" BackColor="White"
                BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Width="100%"
                DataKeyNames="CustomizeTourID" OnPageIndexChanging="gvCustomizeTour_PageIndexChanging" OnRowDeleting="gvCustomizeTour_RowDeleting"
                OnSelectedIndexChanged="gvCustomizeTour_SelectedIndexChanged" AllowPaging="True" PageSize="50">
                <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                <Columns>
                    <asp:TemplateField HeaderText="Ngày đặt">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblCustomizeTourDate" Text='<%#Eval("CusDate","{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
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
                            <asp:ImageButton ID="btDelete" runat="server" CommandArgument='<%#Eval("CustomizeTourID") %>'
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
