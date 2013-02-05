<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSearch.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucSearch" %>
<div class="box-title">
    <p>TÌM KIẾM TOUR</p>
</div>
<div class="detail-box">
    <table class="TimKiemTour">
        <tr>
            <td>
                <span class="text">Danh mục:</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlTourType" CssClass="ddl" class="ddlkhoihanh" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 55px;">
                <span class="text">Điểm đến:</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlDestinations" CssClass="ddl" class="ddlkhoihanh" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        
          <tr>
            <td>
                <span class="text">Loại Tour:</span>
            </td>
            <td>
                  <asp:DropDownList ID="ddlTourCat" class="ddl" runat="server">
                        <asp:ListItem>--Chọn loại tour--</asp:ListItem>
                        <asp:ListItem Value="0">Superior</asp:ListItem>
                        <asp:ListItem Value="1">Deluxe</asp:ListItem>
                        <asp:ListItem Value="2">Luxury</asp:ListItem>
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <span class="text">Thời gian:</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlDuration" CssClass="ddl" runat="server">
                    <asp:ListItem Selected="True" Value="0" Text="--Chọn thời gian--"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Ít hơn 3 ngày"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Từ 3 đến 8 ngày"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Từ 8 đến 12 ngày"></asp:ListItem>
                    <asp:ListItem Value="4" Text="Từ 12 đến 16 ngày"></asp:ListItem>
                    <asp:ListItem Value="5" Text="Nhiều hơn 16 ngày"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:LinkButton CssClass="lnk"  ID="lnkTimKiem" runat="server" 
                    onclick="lnkTimKiem_Click">
                    <img alt="Tìm Kiếm" src="/image/TimKiem.png" />
                </asp:LinkButton>
            </td>
        </tr>
    </table>
</div>