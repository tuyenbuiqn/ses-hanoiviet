<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucReview.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucReview" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<style type="text/css">
    .style1
    {
        width: 253px;
    }
    .tablet
    {
        border-collapse: collapse;
    }
    .tablet td
    {
        border: 1px solid #CCC;
        padding: 0 0.5em;
    }
</style>
<h2>
    Customer Review</h2>
<table class="tablet" width="100%">
    <tr>
        <td>
            <p style="width: 120px; margin: 0">
                Tiêu đề:</p>
        </td>
        <td class="style1">
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
            Hiện trang đầu:
        </td>
        <td class="style1">
            <asp:CheckBox ID="cbisFrontPage" runat="server" />
        </td>
                <td>
            Ảnh đại diện:
        </td>
        <td>
            <asp:FileUpload ID="fulImage" runat="server" />
            <asp:HyperLink Target="_blank" ID="hplImage" runat="server">[Xem ảnh]</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            Review từ TripAdvisor</td>
        <td class="style1">
            <asp:CheckBox ID="chkIsTripAdvisor" runat="server" />
        </td>
                <td>
                    TripAdvisor Link</td>
        <td>
            <asp:TextBox ID="txtTripLink" runat="server" Width="358px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="vertical-align: middle">
            Thông tin khác:
        </td>
        <td colspan="3">
            <asp:TabContainer ID="tcDetail" runat="server" ActiveTabIndex="0" Width="100%">
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
              
            </asp:TabContainer>
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
