<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTourImages.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucTourImages" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<style type="text/css">
    .style1
    {
        height: 20px;
    }
    .style2
    {
        height: 20px;
        width: 284px;
    }
    .style3
    {
        width: 284px;
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
    Ảnh Tour</h2>
<table width="100%" class="tablet" cellpadding="0" cellspacing="0">
    <tr>
        <td class="style1">
                        Tiêu đề
        </td>
        <td class="style2">
            <asp:TextBox ID="txtTitle" runat="server" Width="267px"></asp:TextBox>
        </td>
        <td class="style1">
                        &nbsp;Active</td>
        <td class="style1">
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            URL         URL
        </td>
        <td class="style3">
            <asp:TextBox ID="txtURL" runat="server" Width="265px"></asp:TextBox>
        </td>
        <td>
                        Thứ tự
        </td>
        <td>
            <asp:TextBox ID="txtOrder" runat="server" Width="67px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            File        File</td>
        <td colspan="3">
            <asp:FileUpload ID="fuMedia" runat="server" Width="336px" /><asp:HyperLink runat="server" ID="hplImage" Text="[Xem ảnh]"></asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            Thuộc
            Tour</td>
        <td colspan="3">
            <asp:DropDownList ID="cbTour" runat="server" Width="217px" AppendDataBoundItems="true">
                <asp:ListItem Text=".: Không chọn :." Value="0"></asp:ListItem>
            </asp:DropDownList>
           </td>
    </tr>
    <tr>
        <td>
            Thuộc Hotel</td>
        <td colspan="3">
            <asp:DropDownList ID="cbHotel" runat="server" Width="217px" AppendDataBoundItems="true">
            <asp:ListItem Text=".: Không chọn :." Value="0"></asp:ListItem>
            </asp:DropDownList>
           </td>
    </tr>
    <tr>
        <td>
            Thuộc Điểm đến</td>
        <td colspan="3">
            <asp:DropDownList ID="cbDestination" runat="server" Width="217px" AppendDataBoundItems="true">
            <asp:ListItem Text=".: Không chọn :." Value="0"></asp:ListItem>
            </asp:DropDownList>
           </td>
    </tr>
    <tr>
        <td>
                        Mô tả</td>
        <td colspan="3">
            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDetail" runat="server"></CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td>
                        Meta Tag</td>
        <td colspan="3">
            <asp:TextBox ID="txtMetaTag" runat="server" Width="500px"></asp:TextBox>
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