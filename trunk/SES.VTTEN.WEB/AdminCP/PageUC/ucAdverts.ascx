<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAdverts.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucAdverts" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<style type="text/css">
    .style1
    {
        height: 26px;
    }
</style>
<h2>
    Quảng cáo</h2>
<table id="table1" runat="server" width="100%">
    <tr>
        <td style="width: 100px;">
            Tiêu đề:
        </td>
        <td>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        </td>
        <td style="width: 100px;">
            Active:
        </td>
        <td>
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="width: 100px;">
            Ngày bắt đầu:
        </td>
        <td>
            <dxe:ASPxDateEdit ID="txtDateStart" runat="server">
            </dxe:ASPxDateEdit>
        </td>
        <td style="width: 200px;">
            Ngày kết thúc:
        </td>
        <td>
            <dxe:ASPxDateEdit ID="txtDateEnd" runat="server">
            </dxe:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td class="style1">
            Media:
        </td>
        <td>
            <asp:DropDownList ID="cbMedia" runat="server">
            </asp:DropDownList>
        </td>
        <td style="width: 100px;">
            Đường dẫn:
        </td>
        <td>
            <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            Thứ tự:
        </td>
        <td>
            <asp:TextBox ID="txtOrder" runat="server"></asp:TextBox>
        </td>
        <td style="width: 100px;">
            Vị trí:
        </td>
        <td>
            <asp:CheckBox ID="cbLeft" runat="server" Text="Trái" />
        </td>
    </tr>
    <tr>
        <td>
            File:
        </td>
        <td colspan="3">
            <asp:FileUpload ID="fuMedia" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Mã HTML:
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtHTMLContent" runat="server" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td colspan="3">
            <div style="float: left; margin-right: 10px; margin-top: 10px;">
                <dxe:ASPxButton ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange" OnClick="btSave_Click">
                </dxe:ASPxButton>
            </div>
            <div style="margin-top: 10px;">
                <dxe:ASPxButton ID="btCancel" runat="server" Text="Hủy" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange">
                </dxe:ASPxButton>
            </div>
        </td>
    </tr>
</table>
