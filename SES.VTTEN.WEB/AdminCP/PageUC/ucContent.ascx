﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucContent.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucContent" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<h2>
    Content</h2>
<table width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Tiêu đề:</p>
        </td>
        <td>
            <asp:TextBox ID="txtTitle" runat="server" Width="235px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="*" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
        </td>
        <td>
            <p style="width: 120px; margin: 0">
                URL:</p>
        </td>
        <td>
            <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Loại thông tin:
        </td>
        <td>
            <div style="float: left; margin-top: 5px; margin-right: 5px;">
                <dxe:ASPxComboBox ID="cbContentType" ClientInstanceName="cbContentType" runat="server">
                </dxe:ASPxComboBox>
            </div>
        </td>
                <td>
            Hiện trang đầu:
        </td>
        <td>
            <asp:CheckBox ID="cbisFrontPage" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Thứ tự:
        </td>
        <td>
            <asp:TextBox ID="txtOder" runat="server" Width="309px"></asp:TextBox>
        </td>
        <td>
            Active:
        </td>
        <td>
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Ảnh đại diện:
        </td>
        <td colspan="3">
            <asp:FileUpload ID="fulImage" runat="server" />
            <asp:HyperLink runat="server" Target="_blank" ID="hplImage" Text="[Xem ảnh]" Visible="false"></asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td style="vertical-align: middle">
            Thông tin khác:
        </td>
        <td colspan="5">
            <asp:TabContainer ID="tcDetail" runat="server" ActiveTabIndex="1" Width="100%">
                <asp:TabPanel runat="server" HeaderText="Mô tả" ID="TabPanel1">
                    <HeaderTemplate>
                        Mô tả
                    </HeaderTemplate>
                    <ContentTemplate>
                        <asp:TextBox ID="txtDes" runat="server" Height="62px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Chi tiết">
                    <ContentTemplate>
                        <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDetail" runat="server"></CKEditor:CKEditorControl>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Meta Tags">
                    <ContentTemplate>
                        Tags:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtMetaTag" runat="server" Width="50%"></asp:TextBox>
                        <br />
                        Description:&nbsp;
                        <asp:TextBox ID="txtMetaDes" runat="server" Width="50%"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td colspan="5">
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
