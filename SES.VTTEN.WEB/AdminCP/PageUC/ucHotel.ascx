<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHotel.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucHotel" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<style type="text/css">
    .style1
    {
        width: 121px;
    }
    .style2
    {
        width: 222px;
    }
    .style4
    {
        width: 111px;
    }
    .style5
    {
        width: 109px;
    }
    .style6
    {
        width: 97px;
    }
</style>

<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbDestination.SetValue(value);
        pcDestination.Hide();
    }
</script>

<h2>
    Khách sạn</h2>
<table width="100%">
    <tr>
        <td class="style6">
            Tên khách sạn:
        </td>
        <td class="style2">
            <asp:TextBox ID="txtTitle" runat="server" Width="235px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ErrorMessage="***" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
        </td>
        <td class="style4">
            URL:
        </td>
        <td>
            <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Địa điểm:
        </td>
        <td class="style2">
            <div style="float: left;">
                <dxe:ASPxComboBox ID="cbDestination" ClientEnabled="false" ClientInstanceName="cbDestination"
                    runat="server" Height="16px" Width="89px">
                </dxe:ASPxComboBox>
            </div>
            <div style="float: left;">
                <dxe:ASPxButton ID="btnChonDestination" Width="98px" runat="server" Text="Chọn" AutoPostBack="False"
                    CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="Soft_Orange"
                    Height="16px">
                    <ClientSideEvents Click="function(s, e) { pcDestination.Show();}" />
                </dxe:ASPxButton>
            </div>
        </td>
        <td class="style5">
            Ảnh đại diện:
        </td>
        <td class="style1">
            <asp:FileUpload ID="fulImage" runat="server" />
            <asp:HyperLink runat="server" Target="_blank" ID="hplImage" Text="[Xem ảnh]" Visible="false"></asp:HyperLink>
        </td>
            
    </tr>
    <tr>
        <td class="style6">
            Thứ tự:
        </td>
        <td class="style2">
            <asp:TextBox ID="txtOder" runat="server" Width="75px"></asp:TextBox>
            Hiện trang đầu:
            <asp:CheckBox ID="cbisFrontPage" runat="server" />
        </td>
        <td class="style4">
            Hạng:
        </td>
        <td>
            <asp:TextBox ID="txtRate" runat="server" Width="63px"></asp:TextBox>
            Active:
            <asp:CheckBox ID="cbActive" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="style6">
            Giá
        </td>
        <td class="style2">
            <asp:TextBox ID="txtStartPrice" runat="server" Width="75px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revNumber" runat="server" ControlToValidate="txtStartPrice"
                ErrorMessage="Dạng số" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="***"
                ControlToValidate="txtStartPrice"></asp:RequiredFieldValidator>
        </td>
        <td class="style4">
            Top Hotel
        </td>
        <td>
            <asp:CheckBox runat="server" ID="cbIsMenu" />
        </td>
    </tr>
    
    <tr>
        <td style="vertical-align: middle" class="style6">
            Thông tin khác:
        </td>
        <td colspan="3">
            <asp:TabContainer ID="tcDetail" runat="server" ActiveTabIndex="0" Width="100%">
                <asp:TabPanel runat="server" HeaderText="Short Description" ID="TabPanel1">
                    <HeaderTemplate>
                        Short Description
                    </HeaderTemplate>
                    <ContentTemplate>
                        <asp:TextBox ID="txtDes" runat="server" Height="62px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Description">
                    <ContentTemplate>
                        <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDetail" runat="server"></CKEditor:CKEditorControl>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel5" runat="server" HeaderText="Information">
                    <ContentTemplate>
                        
                        <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtContactInfo" runat="server"></CKEditor:CKEditorControl>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="Recommended">
                 <ContentTemplate>
                <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtMetaDes" runat="server"></CKEditor:CKEditorControl>
                </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Meta Tags">
                    <ContentTemplate>
                        Tags:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtMetaTag" runat="server" Width="100%"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </td>
    </tr>
    <tr>
        <td class="style6">
        </td>
        <td colspan="3">
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
<dxpc:ASPxPopupControl ID="pcDestination" runat="server" ClientInstanceName="pcDestination"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/DestinationTL.aspx" HeaderText="Chọn danh mục cha"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>
