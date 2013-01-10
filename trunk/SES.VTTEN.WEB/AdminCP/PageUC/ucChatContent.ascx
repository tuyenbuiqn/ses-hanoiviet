<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChatContent.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucChatContent" %>
<h2>
    Chat Content
</h2>
<table width="100%">
    <tr>
        <td>
        Tư vấn viên:
        </td>
        <td>
        <asp:DropDownList ID="cbUser" runat="server" Enabled="false"></asp:DropDownList>
        </td>
        <td>
        Tên khách hàng
        </td>
        <td>
        <asp:TextBox ID="txtCustomer" runat="server" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        Thời gian bắt đầu:
        </td>
        <td>
         <asp:TextBox ID="txtTimeStart" runat="server" ReadOnly="true"></asp:TextBox>
        </td>
        <td>
        Thời gian kết thúc:
        </td>
        <td>
        <asp:TextBox ID="txtTimeEnd" runat="server" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        Nội dung
        </td>
        <td colspan="3">
        <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" Width="500px" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
</table>
