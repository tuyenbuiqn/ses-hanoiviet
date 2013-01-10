<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHotDeal.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucHotDeal" %>
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
    .style2
    {
        width: 232px;
    }
    .style3
    {
        height: 26px;
        width: 232px;
    }
</style>
<table id="table1" runat="server" width="100%">
    <h2 style="text-align: left">
        HotDeal</h2>
    <tr>
        <td style="width: 100px;">
            Tiêu đề:
        </td>
        <td class="style2" >
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*" ValidationGroup="sm"></asp:RequiredFieldValidator>
        </td>
        <td style="width: 100px;">
            Active:
        </td>
        <td >
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="width: 100px;">
            Ngày bắt đầu:
        </td>
        <td class="style2">
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
             Mã khởi hành:</td>
        <td class="style3">
            <asp:DropDownList ID="cbTour" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="cbTour" ErrorMessage="*" ValidationGroup="sm"></asp:RequiredFieldValidator>
        </td>
        <td class="style1" colspan="2">
           Giá Người lớn:
            <asp:TextBox ID="txtAdultPrice" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtAdultPrice" ErrorMessage="*" ValidationGroup="sm"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Giá Trẻ em:
            <asp:TextBox ID="txtChildPrice" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtChildPrice" ErrorMessage="*" ValidationGroup="sm"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Nội dung:
        </td>
        <td colspan="3">
            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDepDes" runat="server"></CKEditor:CKEditorControl>
        </td>
    </tr>
     <tr>
        <td>
        </td>
        <td colspan="3">
            <div style="float: left; margin-right: 10px; margin-top: 10px;">
                <dxe:ASPxButton ID="btSave" runat="server" Text="Lưu" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css"
                    CssPostfix="Soft_Orange" OnClick="btSave_Click" ValidationGroup="sm">
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