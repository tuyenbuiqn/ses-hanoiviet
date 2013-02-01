<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTour.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucTour" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<style type="text/css">
    .style4
    {
        height: 40px;
    }
    .style5
    {
        width: 300px;
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

<script type="text/javascript">
    function SelectAndClosePopup(value) {
        cbTourType.SetValue(value);
        pcTourType.Hide();
    }
</script>

<h2>
    Tour</h2>
<div style="margin-left: 0px; margin-top: 20px; width: 100%">
    <table width="100%" class="tablet" style="border: 1px solid black;">
        <tr>
            <td>
                <p style="width: 70px; margin: 0">
                    Tên tour:</p>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtTitle" runat="server" Width="235px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ErrorMessage="****" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>
            </td>
            <td style="width:140px;">
                <p style="width: 70px; margin: 0">
                    URL:</p>
            </td>
            <td>
                <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <p style="width: 70px; margin: 0">
                    Mã tour:</p>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtTourCode" runat="server" Width="235px"></asp:TextBox>
            </td>
            <td>
                <p style="width: 70px; margin: 0">
                    Giá:</p>
            </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitle0" runat="server" ErrorMessage="****" ControlToValidate="txtPrice"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNumber" runat="server" ControlToValidate="txtPrice"
                    ErrorMessage="Dạng số" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Danh mục:
            </td>
            <td class="style5">
                <div style="float: left; margin-top: 5px; margin-right: 5px;">
                    <dxe:ASPxComboBox ID="cbTourType" ClientEnabled="false" ClientInstanceName="cbTourType"
                        runat="server">
                    </dxe:ASPxComboBox>
                </div>
                <div style="float: left;">
                    <dxe:ASPxButton ID="btnChonType" Width="100px" runat="server" Text="Chọn loại" AutoPostBack="False"
                        CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="Soft_Orange">
                        <ClientSideEvents Click="function(s, e) { pcTourType.Show();}" />
                    </dxe:ASPxButton>
                </div>
            </td>
            <td>
                Ảnh đại diện (Nhỏ):
            </td>
            <td>
                <asp:FileUpload ID="fulImage" runat="server" />
                <asp:HyperLink runat="server" Target="_blank" ID="hplImage1" Text="[Xem ảnh]" Visible="false"></asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                Thứ tự:
            </td>
            <td class="style5">
                <asp:TextBox ID="txtOder" runat="server" Width="47px"></asp:TextBox>
                &nbsp;Trang đầu:
                <asp:CheckBox ID="cbisFrontPage" runat="server" />
            &nbsp; --
                Active:
                <asp:CheckBox ID="cbActive" runat="server" />
            </td>
            <td>
                Ảnh đại diện (Ngang):
            </td>
            <td>
                <asp:FileUpload ID="fulImageFull" runat="server" />
                <asp:HyperLink runat="server" Target="_blank" ID="hplImage2" Text="[Xem ảnh]" Visible="false"></asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: middle">
                Số ngày:
            </td>
            <td class="style5">
                <asp:TextBox ID="txtDurationDay" runat="server" Width="73px"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtDurationDay" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDurationDay"
                    ErrorMessage="Số" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                &nbsp;&nbsp; Số đêm
                <asp:TextBox ID="txtDurationNight" runat="server" Width="73px"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtDurationNight" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDurationNight"
                    ErrorMessage="Số" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
            </td>
            <td>
                Tour Khuyến mãi</td>
            <td>
                <asp:CheckBox Visible="false" ID="cbIsSaleOff" runat="server" />
                &nbsp;&nbsp;&nbsp;
                
            
                <asp:CheckBox Visible="true" ID="cbIsOutPromotion" runat="server" />
            </td>
            

        </tr>
        <tr>
            <td style="vertical-align: middle">
                Loại Tour</td>
            <td class="style5">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Superior</asp:ListItem>
                    <asp:ListItem>Deluxe</asp:ListItem>
                    <asp:ListItem>Luxury</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
              </td>
            <td>
            <asp:CheckBox runat="server" Visible="false" ID="cbIsMenu" />
                &nbsp;&nbsp;&nbsp;
                Tour trong nước
            <asp:CheckBox runat="server" ID="cbIsInboundTour" />
                </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TabContainer ID="tcDetail" runat="server" ActiveTabIndex="0" Width="100%">
                    <asp:TabPanel runat="server" HeaderText="Description" ID="TabPanel1">
                        <HeaderTemplate>
                            Mô tả
                        </HeaderTemplate>
                        <ContentTemplate>
                            <asp:TextBox ID="txtMetaDes" TextMode="MultiLine" runat="server" Width="100%" Height="124px"></asp:TextBox>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Tour itinerary">
                        <HeaderTemplate>
                            Chương trình Tour
                        </HeaderTemplate>
                        <ContentTemplate>
                            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtDes" runat="server" TextMode="MultiLine" Width=""></CKEditor:CKEditorControl>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel runat="server" HeaderText="Tour Prices" ID="TabPanel6">
                        <HeaderTemplate>
                           Bảng giá
                        </HeaderTemplate>
                        <ContentTemplate>
                            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtAllPrice" runat="server" TextMode="MultiLine" Width=""></CKEditor:CKEditorControl>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="Lưu ý">
                        <ContentTemplate>
                            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/"  ID="txtNotes" runat="server"></CKEditor:CKEditorControl>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="Meta Tags">
                        <ContentTemplate>
                            Tags:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtMetaTag" TextMode="MultiLine" runat="server" Width="85%" Height="124px"></asp:TextBox>
                        </ContentTemplate>
                    </asp:TabPanel>
                    <asp:TabPanel runat="server" HeaderText="Địa điểm liên quan" ID="TabPanel5">
                        <HeaderTemplate>
                            Địa điểm liên quan
                        </HeaderTemplate>
                        <ContentTemplate>
                            <asp:CheckBoxList ID="cblDestination" runat="server" RepeatColumns="6">
                            </asp:CheckBoxList>
                        </ContentTemplate>
                    </asp:TabPanel>
                </asp:TabContainer>
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td colspan="3" class="style4">
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
        <tr>
            <td>
            </td>
            <td colspan="3" align="right">
                &nbsp;
            </td>
        </tr>
    </table>
    <table id="table3" runat="server" width="90%" visible="False">
        <tr>
            <td colspan="4">
                &nbsp;
            </td>
        </tr>
    </table>
</div>
<dxpc:ASPxPopupControl ID="pcTourType" runat="server" ClientInstanceName="pcTourType"
    CloseAction="CloseButton" ContentUrl="~/AdminCP/TourTypeTL.aspx" HeaderText="Chọn Loại tour"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Height="336px"
    Width="699px">
    <ContentCollection>
        <dxpc:PopupControlContentControl ID="PopupControlContentControl2" runat="server">
        </dxpc:PopupControlContentControl>
    </ContentCollection>
</dxpc:ASPxPopupControl>
