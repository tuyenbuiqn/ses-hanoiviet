﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucUser.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
    <h2>
        User&nbsp;</h2>
<table width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Username</p>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            <p style="width: 120px; margin: 0">
                Password</p>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Email</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="235px"></asp:TextBox>
        </td>
        <td>
            Hỗ trợ viên:
        </td>
        <td>
            <asp:CheckBox ID="cbSupporter" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Admin:
        </td>
        <td>
            <asp:CheckBox ID="cbAdmin" runat="server" />
        </td>
        <td>
            Active:
        </td>
        <td>
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Phụ trách vùng</td>
        <td>
            <asp:CheckBoxList runat="server" ID="chblDestination" DataTextField="Title" DataValueField="DestinationID">
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td colspan="4">
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