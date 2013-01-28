<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSearch.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucSearch" %>
<div class="box-title">
    <p>TÌM KIẾM TOUR</p>
</div>
<div class="detail-box">
    <table class="TimKiemTour">
        <tr>
            <td>
                <span class="text">Loại tour:</span>
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
                <span class="text">Giá tour:</span>
            </td>
            <td>
                <asp:DropDownList ID="ddlGiaTour" CssClass="ddl" class="ddlkhoihanh" runat="server">
                    <asp:ListItem Text="--Chọn giá--" Value="0" Selected="False"></asp:ListItem>
                    <asp:ListItem Text="Nhỏ hớn 2 triệu" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2 triệu - 4 triệu" Value="2"></asp:ListItem>
                    <asp:ListItem Text="4 triệu - 6 triệu" Value="3"></asp:ListItem>
                    <asp:ListItem Text="6 triệu - 8 triệu" Value="4"></asp:ListItem>
                    <asp:ListItem Text="8 triệu - 10 triệu" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Lớn hơn 10 triệu" Value="6"></asp:ListItem>
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