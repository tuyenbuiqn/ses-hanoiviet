<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucListServicesBooking.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucListServicesBooking" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<h2 style="text-align: left;">
    Danh sách đặt dịch vụ</h2>
<div style="width: 100%; float: left; height: auto;">
    <div style="width: 100%; float: left; height: auto;">
        <table style="border: 0px;" width="100%">
            <tr>
                <td>
                    <asp:GridView ID="gvHotel" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#CC9966" BorderStyle="Solid" BorderWidth="1px" 
                        CellPadding="4" Width="100%"
                        DataKeyNames="BookingID" OnPageIndexChanging="gvHotel_PageIndexChanging" OnSelectedIndexChanged="gvHotel_SelectedIndexChanged"
                        AllowPaging="True" OnRowDeleting="gvHotel_RowDeleting" 
                        onrowdatabound="gvHotel_RowDataBound">
                        <RowStyle BackColor="White" ForeColor="#330099" HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField DataField="BookingID" HeaderText="Mã" Visible="true">
                                <HeaderStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Tên dịch vụ" >
                                <ItemStyle HorizontalAlign="Left" />
                                <ItemTemplate>
                                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ngày đặt">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblBookingDate" Text='<%#Eval("BookingDate","{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="FullName" HeaderText="Khách đặt" />
                         <asp:BoundField DataField="PhoneNo" HeaderText="Điện thoại" />
                        <asp:TemplateField HeaderText="Ngày đi dự kiến">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblArrivalDate" Text='<%#Eval("ArrivalDate","{0:d}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
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
