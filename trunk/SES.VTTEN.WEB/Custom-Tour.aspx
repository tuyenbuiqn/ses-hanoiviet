<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true"
    CodeBehind="Custom-Tour.aspx.cs" Inherits="SES.VTTEN.WEB.Custom_Tour" Title="TRAVEL CUSTOMIZE FORM" %>

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
<%@ Register src="Module/ucRightBanner.ascx" tagname="ucRightBanner" tagprefix="uc8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/tourstyle.css" rel="stylesheet" type="text/css" />

    <script language="javascript" type="text/javascript">
        function AcceptTermsCheckBoxValidation(oSrouce, args)
        {
            var myCheckBox = document.getElementById('<%= chkAgree.ClientID %>'); 
            if(!myCheckBox.checked)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    </script>

    <style type="text/css">
        .style1
        {
            float: left;
            padding-left: 20px;
            width: 180px;
            margin-top: 2px;
            font-weight: bold;
        }
    </style>
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
                    TRAVEL CUSTOMIZE FORM
                </h1>
                <div class="thinline7">
                </div>
                <div class="contentourdt1">
                    <div class="field" style="color: #2c82ad; float: left; font-size: 12px; margin: 15px 0;
                        font-weight: bold;">
                        Contact Information</div>
                    <div class="field_book">
                        <span class="span_120">Full name :</span>
                        <asp:TextBox CssClass="input_book_250" ID="txtFullName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtFullName" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_120">Gender :</span>
                        <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal" Width="120px">
                            <asp:ListItem Selected="True" Value="True">Male</asp:ListItem>
                            <asp:ListItem Value="False">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="field_book">
                        <span class="span_120">Day of Birth :</span>
                        <%--<dxe:ASPxDateEdit ID="txtDOB" CssClass="input_book_100" Width="102px" runat="server">
                        </dxe:ASPxDateEdit>--%>
                        &nbsp;<asp:DropDownList ID="ddlDay" runat="server" Width="40px" ValidationGroup="DOB"></asp:DropDownList>
                    &nbsp&nbsp<asp:DropDownList ID="ddlMonth" runat="server" Width="40px" ValidationGroup="DOB" ></asp:DropDownList>
                    &nbsp&nbsp<asp:DropDownList ID="ddlYear" runat="server" Width="60px" ValidationGroup="DOB"></asp:DropDownList>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtDOB" ErrorMessage=" ***"></asp:RequiredFieldValidator>--%>
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
                        <asp:TextBox CssClass="input_book_250" ID="txtCountry" runat="server"></asp:TextBox>
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
                    <div class="field" style="color: #2c82ad; float: left; font-size: 12px; margin: 15px 0;
                        font-weight: bold;">
                        Trip Information</div>
                    <div class="field_book">
                        <span class="span_200">Arrival date:</span>
                        <dxe:ASPxDateEdit ID="txtArrivalDate" CssClass="input_book_100" Width="102px" runat="server">
                        </dxe:ASPxDateEdit>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtArrivalDate" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_200">Date of Depart : </span>
                        <dxe:ASPxDateEdit ID="txtDateDepart" CssClass="input_book_100" Width="102px" runat="server">
                        </dxe:ASPxDateEdit>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtDateDepart" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_200">Number of Adults travelling :</span>
                        <asp:TextBox ID="txtAdultNo" CssClass="input_book_100" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtAdultNo" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revNumber" runat="server" ControlToValidate="txtAdultNo"
                            ErrorMessage="Please input a number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_200">Number of Children travelling :</span>
                        <asp:TextBox ID="txtChildNo" CssClass="input_book_100" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="abc" runat="server"
                            ControlToValidate="txtChildNo" ErrorMessage=" ***"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtChildNo"
                            ErrorMessage="Please input a number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_200">Hotel category you prefer:</span>
                        <asp:DropDownList CssClass="input_book_180" ID="ddlHotelCat" runat="server">
                            <asp:ListItem Value="0">Standard</asp:ListItem>
                            <asp:ListItem Value="1">Superior</asp:ListItem>
                            <asp:ListItem Value="2">Deluxe</asp:ListItem>
                            <asp:ListItem Value="3">Luxury</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="field" style="color: #2c82ad; float: left; font-size: 12px; margin: 15px 0;
                        font-weight: bold;">
                        Where would you like to visit
                    </div>
                    <div class="field_book">
                        <div class="regions">
                            <div class="regions-title">North</div>
                            <div class="regions-checkbox"> <asp:CheckBoxList runat="server" RepeatColumns="4" ID="cblNorth" DataTextField="Title" DataValueField="DestinationID" ></asp:CheckBoxList> </div>
                        </div>    
                        <div class="regions">
                            <div class="regions-title">Center</div>
                            <div class="regions-checkbox"> <asp:CheckBoxList runat="server" RepeatColumns="4" ID="cblCenter" DataTextField="Title" DataValueField="DestinationID"></asp:CheckBoxList> </div>
                        </div>  
                        <div class="regions">
                            <div class="regions-title">South</div>
                            <div class="regions-checkbox"> <asp:CheckBoxList runat="server" RepeatColumns="4" ID="cblSouth" DataTextField="Title" DataValueField="DestinationID"></asp:CheckBoxList> </div>
                        </div>  
                    </div>
                    <div class="field" style="color: #2c82ad; float: left; font-size: 12px; margin: 15px 0;
                        font-weight: bold;">
                        Travel Arrangement</div>
                    <div class="field_book">
                        <span class="style1" style="width: 400px;">Modes of transportation used for in-country
                            travel?</span>
                        <asp:RadioButtonList RepeatDirection="Horizontal" ID="rdTransport" runat="server">
                            <asp:ListItem Value="Airplane">Airplane</asp:ListItem>
                            <asp:ListItem Value="Car/Bus">Car / Bus</asp:ListItem>
                            <asp:ListItem Value="Train">Train</asp:ListItem>
                            <asp:ListItem Value="Motobike">Motobike</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="field_book">
                        <span class="style1" style="width: 400px;">Preferred type of programme?</span>
                        <asp:CheckBoxList RepeatColumns="4" RepeatDirection="Vertical" ID="chblTourProgramme"
                            runat="server" Width="407px">
                            <asp:ListItem>Classic</asp:ListItem>
                            <asp:ListItem>Homestay</asp:ListItem>
                            <asp:ListItem>Adventure</asp:ListItem>
                            <asp:ListItem>Culture</asp:ListItem>
                            <asp:ListItem>Kayaking</asp:ListItem>
                            <asp:ListItem>Trekking</asp:ListItem>
                            <asp:ListItem>History</asp:ListItem>
                            <asp:ListItem>Cycling</asp:ListItem>
                            <asp:ListItem>Cruise</asp:ListItem>
                            <asp:ListItem>Education</asp:ListItem>
                            <asp:ListItem>Motor biking</asp:ListItem>
                            <asp:ListItem>Beach/vacation</asp:ListItem>
                        </asp:CheckBoxList>
                        Other:
                        <asp:TextBox ID="txtTourProgramme" CssClass="input_book_250" runat="server"></asp:TextBox>
                    </div>
                    <div class="field_book">
                        <span class="style1" style="width: 400px;">Accommodation ?</span>
                        <asp:CheckBoxList RepeatColumns="4" RepeatDirection="Vertical" ID="chblAccommodation"
                            runat="server" Width="527px">
                            <asp:ListItem>Budget(< USD40)</asp:ListItem>
                            <asp:ListItem>Superior (>USD50)</asp:ListItem>
                            <asp:ListItem>Deluxe(>USD80)</asp:ListItem>
                            <asp:ListItem>More deluxe (>USD100)</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="field_book">
                        <span class="style1" style="width: 400px;">Meals to be included in your itinerary?</span>
                        <asp:CheckBoxList RepeatColumns="4" RepeatDirection="Vertical" ID="chblMeal" runat="server"
                            Width="527px">
                            <asp:ListItem>Breakfast</asp:ListItem>
                            <asp:ListItem>Lunch</asp:ListItem>
                            <asp:ListItem>Diner</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="field_book">
                        <span class="span_120">Food ( Special requirement - diet, allergic,...)? :</span>
                        <asp:TextBox ID="txtFood" TextMode="MultiLine" CssClass="textarea_book" runat="server"></asp:TextBox>
                    </div>
                    <div class="field" style="color: #2c82ad; float: left; font-size: 12px; margin: 5px 0;
                        font-weight: bold;">
                        OTHER INFORMATION</div>
                    <div class="field_book">
                        <span class="span_200">Billing Option:</span>
                        <asp:RadioButtonList ID="rdoBilling" runat="server" RepeatDirection="Horizontal"
                            Width="200px">
                            <asp:ListItem Value="True">Bank transfer</asp:ListItem>
                            <asp:ListItem>Credit Card</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="field_book">
                        <span class="span_120">Other requests :</span>
                        <asp:TextBox ID="txtOtherRequest" TextMode="MultiLine" CssClass="textarea_book" runat="server"></asp:TextBox>
                    </div>
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
                        <asp:CheckBox ID="chkAgree" Text="I have read and agreed with your Terms
                            & Condition *" runat="server" />
                        <asp:CustomValidator ID="ValTerms" ClientValidationFunction="AcceptTermsCheckBoxValidation"
                            runat="server" ErrorMessage="Please Accept Terms & Condition." ValidationGroup="abc"> </asp:CustomValidator>
                    </div>
                    <div class="field_book">
                        <span class="span_120">&nbsp;</span>
                        <asp:Button ID="btnBooking" ValidationGroup="abc" runat="server" CssClass="button_submit"
                            Text="Booking" OnClick="btnBooking_Click" />
                        <asp:Button ID="btnReset" runat="server" CssClass="button_submit" Text="Reset" />
                    </div>
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
