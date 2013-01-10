<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucModule.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucModule" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<h2>
    Module</h2>
<div style="width: 100%">
    <div style="width: 100px; float: left">
        Tên module:</div>
    <div style="width: auto">
        <asp:TextBox runat="server" ID="txtTitle" Width="200px"></asp:TextBox></div>
</div>
<br />
<div style="width: 100%">
    <div style="width: 100px; float: left">
        Video hiển thị:</div>
    <div style="width: auto">
        <asp:DropDownList ID="ddvideo" runat="server">
        </asp:DropDownList>
    </div>
</div>
<br />
<div>
    <dxe:ASPxButton ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
        CssPostfix="Soft_Orange" OnClick="btSave_Click">
    </dxe:ASPxButton>
</div>
