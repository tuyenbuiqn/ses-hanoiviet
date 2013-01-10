<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucContact.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucContact" %>
<h2>
    Contact</h2>
<table width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Company:</p>
        </td>
        <td>
            <asp:TextBox ID="txtCompany" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            <p style="width: 120px; margin: 0">
                Tên khách hàng:</p>
        </td>
        <td>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Địa chỉ:
        </td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </td>
                <td>
            Phone:
        </td>
        <td>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Fax:
        </td>
        <td>
            <asp:TextBox ID="txtFax" runat="server" Width="309px"></asp:TextBox>
        </td>
        <td>
            Email:
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="309px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="vertical-align: middle">
            Nội dung:
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtDetail" runat="server" Width="600px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>

</table>
