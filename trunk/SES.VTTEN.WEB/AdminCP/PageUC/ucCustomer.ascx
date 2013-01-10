<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCustomer.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucCustomer" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<h2>
    Khách hàng</h2>
<table width="100%">
    <tr>
        <td>
            <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="2" 
                Width="100%" >
                <asp:TabPanel runat="server" HeaderText="Thông tin chung" ID="TabPanel1">
                    <HeaderTemplate>
                        Thông tin chung
                    </HeaderTemplate>
                    <ContentTemplate>
                        <p style="float:left; width:100px;" > Họ và tên:</p><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <br />
                        <p style="float:left; width:100px;" > Passport:</p><asp:TextBox  ID="txtPassport" runat="server"></asp:TextBox>
                        <br />
                        <p style="float:left; width:100px;" > IDCard:</p><asp:TextBox  ID="txtIDCard" runat="server"></asp:TextBox>
                        <br />
                        <p style="float:left; width:100px;" > Ngày sinh:</p><asp:TextBox  ID="txtBirthday" runat="server"></asp:TextBox>
                        <br />
                        <p style="float:left; width:100px;" > Nghề nghiệp:</p><asp:TextBox  ID="txtJob" runat="server"></asp:TextBox>
                        <br />
                        <p style="float:left; width:100px;" > Giới tính:</p><asp:CheckBox ID="cbGender" runat="server" Text="Male" />
                        <br />
                        <p style="float:left; width:100px;" > Trẻ em:</p><asp:CheckBox ID="cbAdult" runat="server" Text="Có" />
                        <br />
                        <p style="float:left; width:100px;" > Quốc tịch:</p><asp:DropDownList ID="cbNational" runat="server"></asp:DropDownList>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel runat="server" HeaderText="Thông tin liên lạc" ID="tabpanel2">
                <HeaderTemplate>
                Thông tin liên lạc
                </HeaderTemplate>
                <ContentTemplate>
                <p style="float:left; width:50px;" > Địa chỉ:</p><asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
                <br />
                <p style="float:left; width:50px;" >Phone:</p><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                 <br />
                <p style="float:left; width:50px;" >Email:</p><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                 <br />
                <p style="float:left; width:50px;" >Yahoo:</p><asp:TextBox ID="txtYahoo" runat="server"></asp:TextBox>
                <br />
                <p style="float:left; width:50px;" >Skype:</p><asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
                <br />
                <p style="float:left; width:50px;" >Mobile:</p><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel runat="server" HeaderText="Thông tin liên lạc" ID="tabpanel3">
                <HeaderTemplate>
                Thông tin khác
                </HeaderTemplate>
                <ContentTemplate>
                <p style="float:left; width:150px;" > Thông tin khác:</p><asp:TextBox ID="txtOtherInfo" TextMode="MultiLine" Width="500px" runat="server"></asp:TextBox>
                <br />
                <p style="float:left; width:150px;" >Ngày kỉ niệm:</p><asp:TextBox ID="txtAnniversary" runat="server"></asp:TextBox>
                 <br />
                <p style="float:left; width:150px;" >Anniversary Info:</p><asp:TextBox ID="txtAnniversaryInfo" Width="500px" TextMode="MultiLine" runat="server"></asp:TextBox>
                </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </td>
    </tr>
    <tr>
        <td>
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
