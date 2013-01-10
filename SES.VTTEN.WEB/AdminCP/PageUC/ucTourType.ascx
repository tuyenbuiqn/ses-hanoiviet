<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTourType.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucTourType" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>

<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbTourCat.SetValue(value);
        pcTourCat.Hide();
    }
</script>
<h2>
Tour category</h2>
<table width="100%">
<tr>
    <td>
        <p style="width: 120px; margin: 0">
            Tên Loại tour:</p>
    </td>
    <td>
        <asp:TextBox ID="txtTitle" runat="server" Width="235px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
            ErrorMessage="Tên danh mục không để trống" ControlToValidate ="txtTitle"></asp:RequiredFieldValidator>
    </td>
    <td>
        <p style="width: 120px; margin: 0">
            URL:</p>
    </td>
    <td colspan="3">
        <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
<td>
            Thuộc loại:
        </td>
        <td>
            <div style="float: left; margin-top: 5px; margin-right: 5px;">
                <dxe:ASPxComboBox ID="cbParent" ClientEnabled="false" ClientInstanceName="cbTourCat"
                    runat="server">
                </dxe:ASPxComboBox>
            </div>
            <div style="float: left;">
                <dxe:ASPxButton ID="btnChon" Width="100px" runat="server" Text="Chọn" AutoPostBack="False"
                    CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="Soft_Orange">
                    <ClientSideEvents Click="function(s, e) { pcTourCat.Show();}" />
                </dxe:ASPxButton>
            </div>
            <div style="font-family: Arial; font-size: small">
                <asp:CheckBox ID="cbRoot" runat="server" />
                <asp:Label ID="lbRoot" runat="server" Text="Thư mục mẹ"></asp:Label>
            </div>
        </td>
    <td>
       
    </td>
    <td colspan="3">
       
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
        <td>
        Hiện trang chủ
    </td>
    <td>
        <asp:CheckBox ID="ckbIsHomepage" runat="server" />
    </td>
</tr>
<tr>
    <td style="vertical-align: middle">
        Thông tin khác:
    </td>
    <td colspan="5">
        <asp:TabContainer ID="tcDetail" runat="server" ActiveTabIndex="0" Width="100%">
            <asp:TabPanel runat="server" HeaderText="Mô tả" ID="TabPanel1">
                <HeaderTemplate>
                    Mô tả
                </HeaderTemplate>
                <ContentTemplate>
                    <asp:TextBox ID="txtDes" runat="server" Height="62px" TextMode="MultiLine" Width="100%"></asp:TextBox>
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
                CssPostfix="Soft_Orange" OnClick="btCancel_Click">
            </dxe:ASPxButton>
        </div>
    </td>
</tr>
</table>
<dxpc:ASPxPopupControl ID="pcTourCat" runat="server" ClientInstanceName="pcTourCat"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/TourTypeTL.aspx" HeaderText="Chọn loại cha"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>

