<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLink.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucLink" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<h2>
    Link</h2>
<table>
    <tr>
        <td>
            Nội dung
        </td>
        <td>
            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDetail" runat="server"></CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td>
            Hiển thị
        </td>
        <td>
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <dxe:ASPxButton ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                CssPostfix="Soft_Orange" OnClick="btSave_Click">
            </dxe:ASPxButton>
        </td>
    </tr>
</table>
