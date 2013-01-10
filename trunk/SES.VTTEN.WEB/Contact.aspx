<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true"
    CodeBehind="Contact.aspx.cs" Inherits="SES.VTTEN.WEB.Contact" Title="Untitled Page" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="Module/ucTourCateLeftMenu.ascx" TagName="ucTourCateLeftMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSearchTour.ascx" TagName="ucSearchTour" TagPrefix="uc2" %>
<%@ Register Src="Module/ucSendContact.ascx" TagName="ucSendContact" TagPrefix="uc3" %>
<%@ Register Src="Module/ucRelatedTour.ascx" TagName="ucRelatedTour" TagPrefix="uc4" %>
<%@ Register Src="Module/ucHotTours.ascx" TagName="ucHotTours" TagPrefix="uc5" %>
<%@ Register Src="Module/ucTopStarRatesHotels.ascx" TagName="ucTopStarRatesHotels"
    TagPrefix="uc6" %>
<%@ Register Src="Module/ucLeftBanner.ascx" TagName="ucLeftBanner" TagPrefix="uc7" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="Module/ucRightBanner.ascx" TagName="ucRightBanner" TagPrefix="uc8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/tourstyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Panel">
        <div class="menuleftmain1">
            <uc1:ucTourCateLeftMenu ID="ucTourCateLeftMenu1" runat="server" />
            <uc7:ucLeftBanner ID="ucLeftBanner1" runat="server" />
        </div>
        <div class="left-content">
            <div class="content">
                <h1>
                    CONTACT US
                </h1>
                <div class="thinline7">
                </div>
                <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
                    CONTACT INFORMATION</div>
                <div class="field_book">
                    <span class="span_120">Full name :</span>
                    <asp:TextBox CssClass="input_book_250" ID="txtFullName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="abc" runat="server"
                        ControlToValidate="txtFullName" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                </div>
                <div class="field_book">
                    <span class="span_120">Gender :</span>
                    <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal" Width="120px">
                        <asp:ListItem Selected="True" Value="Ông">Male</asp:ListItem>
                        <asp:ListItem Value="Bà">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="field_book">
                    <span class="span_120">Day of Birth :</span>
                    <%--<dxe:ASPxDateEdit ID="txtDOB" CssClass="input_book_100" Width="102px" runat="server">
                    </dxe:ASPxDateEdit>--%>
                    &nbsp;<asp:DropDownList ID="ddlDay" runat="server" Width="40px" ValidationGroup="DOB">
                    </asp:DropDownList>
                    &nbsp&nbsp<asp:DropDownList ID="ddlMonth" runat="server" Width="40px" ValidationGroup="DOB">
                    </asp:DropDownList>
                    &nbsp&nbsp<asp:DropDownList ID="ddlYear" runat="server" Width="60px" ValidationGroup="DOB">
                    </asp:DropDownList>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="abc" runat="server"
                        ControlToValidate="DOB" co ErrorMessage=" ***"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="field_book">
                    <span class="span_120">Email :</span>
                    <asp:TextBox CssClass="input_book_250" ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="abc" runat="server"
                        ControlToValidate="txtEmail" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"
                        ID="RegularExpressionValidator2" ValidationGroup="abc" ControlToValidate="txtEmail"
                        runat="server" ErrorMessage="Please input E-mail"></asp:RegularExpressionValidator>
                </div>
                <div class="field_book">
                    <span class="span_120">Country :</span>
                    <asp:TextBox runat="server" ID="txtCountry" CssClass="input_book_250" ValidationGroup="abc"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="abc" runat="server"
                        ControlToValidate="txtCountry" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                </div>
                <div class="field_book">
                    <span class="span_120">Address :</span>
                    <asp:TextBox CssClass="input_book_250" ID="txtAddress" runat="server"></asp:TextBox>
                </div>
                <div class="field_book">
                    <span class="span_120">Phone No :</span>
                    <asp:TextBox CssClass="input_book_250" ID="txtPhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="abc" runat="server"
                        ControlToValidate="txtPhone" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                </div>
                <div class="field_book">
                    <span class="span_120">Fax No :</span>
                    <asp:TextBox CssClass="input_book_250" ID="txtFaxNo" runat="server"></asp:TextBox>
                    <div class="CheckForm">
                        abc</div>
                </div>
                <div class="field_book">
                    <span class="span_120">Other requests :</span>
                    <asp:TextBox ID="txtOtherRequest" TextMode="MultiLine" CssClass="textarea_book" runat="server"></asp:TextBox>
                </div>
                <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
                    OTHER INFORMATION</div>
                <div class="field_book">
                    <span class="span_120">Where did you hear about us?</span>
                    <asp:DropDownList CssClass="input_book_120" ID="ddlHear" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Just cruizing</asp:ListItem>
                        <asp:ListItem>Search Engine</asp:ListItem>
                        <asp:ListItem>Internet</asp:ListItem>
                        <asp:ListItem>Via a friend</asp:ListItem>
                        <asp:ListItem>Travel Guide</asp:ListItem>
                        <asp:ListItem>Advertizing</asp:ListItem>
                        <asp:ListItem>Link</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ValidationGroup="abc" runat="server"
                        ControlToValidate="ddlHear" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                </div>
                <div class="field_book">
                    <span class="span_120">&nbsp;</span>
                    <asp:Button ID="btnBooking" ValidationGroup="abc" runat="server" CssClass="button_submit"
                        Text="Send" OnClick="btSend_Click" />
                    <asp:Button ID="btnReset" runat="server" CssClass="button_submit" Text="Reset" />
                </div>
            </div>
        </div>
        <div class="mainR">
            <uc2:ucSearchTour ID="ucSearchTour1" runat="server" />
            <uc3:ucSendContact ID="ucSendContact1" runat="server" />
            <%--  <div class="modul2">
                <div class="modul1in">
                    <div class="titmodul1">
                        Hot Promotion</div>
                </div>
                <div class="modul1list">
                    <ul>
                        <li><a href="http://www.southpacifictravel.com.vn/tours/indochina_tours/152/Halong_Bai_Tu_Long_junk.aspx">
                            Halong Bai Tu Long junk </a></li>
                    </ul>
                </div>
            </div>--%>
            <uc6:ucTopStarRatesHotels ID="ucTopStarRatesHotels1" runat="server" />
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner1" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>
