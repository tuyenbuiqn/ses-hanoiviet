﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucConfig.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucConfig" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<h2>
    Tùy chỉnh cấu hình hệ thống</h2>
<table width="100%">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" ValidationGroup="submitGrp" Width="179px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"
                ErrorMessage="*** Cần nhập tiêu đề" ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr id="trDes" runat="server" visible="true">
        <td class="style8">
            <asp:Label ID="lblChiTiet" runat="server" Text="Chi tiết"></asp:Label>
            :
        </td>
        <td>
            <asp:TextBox ID="txtDescription" runat="server" Width="90%">
            </asp:TextBox>
        </td>
    </tr>
    <tr id="trSupport" runat="server" visible="false">
        <td class="style8">
            Trình bày:
        </td>
        <td class="style9">
            <CKEditor:CKEditorControl FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images"
                BasePath="/ckeditor/" ID="txtCK" runat="server" FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images"
                Height="300px" Width="90%"></CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr runat="server" id="trPopup" visible="false">
        <td>
            Tùy chỉnh trạng thái Pop-up:
        </td>
        <td>
            <asp:CheckBox ID="chkpopup" runat="server" Text="Hiện" />
        </td>
    </tr>
    <%-- <tr id="trPopup" runat="server" visible="false">
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank">[Xem ảnh]</asp:HyperLink>
        </td>
    </tr>--%>
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Lưu" ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Hủy" />
        </td>
    </tr>
</table>
