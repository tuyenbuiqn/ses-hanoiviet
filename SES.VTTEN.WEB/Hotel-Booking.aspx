<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Hotel-Booking.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel_Booking" Title="Untitled Page" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/tourstyle.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
        function AcceptTermsCheckBoxValidation(oSrouce, args) {
            var myCheckBox = document.getElementById('<%= chkAgree.ClientID %>');
            if (!myCheckBox.checked) {
                args.IsValid = false;
            }
            else {
                args.IsValid = true;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <h1 class="travel-h1">
        <span>HOTEL BOOKING FORM </span>
    </h1>
    <div class="thinline7">
    </div>
    <div class="contentourdt1">
        <div class="field" style="color: #2c82ad; font-size: 12px; margin: 15px 0; font-weight: bold;">
            THÔNG TIN KHÁCH SẠN</div>
        <div class="field_book">
            <span class="span_1000"><strong>Tên khách sạn</strong> :
                <asp:HyperLink CssClass="linktour" ID="hplTourName" Target="_blank" runat="server">
                    <asp:Label ID="lblTourName" runat="server" Text="Label"></asp:Label>
                </asp:HyperLink>
            </span><span class="span_1000">
                <asp:Label ID="lblTourDes" runat="server" Text="Label"></asp:Label>
            </span>
        </div>
        <div class="field_book">
            <span class="span_200">Loại phòng muốn đặt:</span>
            <asp:DropDownList CssClass="input_book_180" ID="ddlRoomCat" runat="server">
                <asp:ListItem>Phòng đơn</asp:ListItem>
                <asp:ListItem>Phòng đôi</asp:ListItem>
                <asp:ListItem>Phòng ba</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="field_book">
            <span class="span_200">Số phòng :</span>
            <asp:TextBox ID="txtRoomNo" CssClass="input_book_100" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="abc" runat="server"
                ControlToValidate="txtRoomNo" ErrorMessage=" ***"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revNumber" runat="server" ControlToValidate="txtRoomNo"
                ErrorMessage="Please input a number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        </div>
        <div class="field_book">
            <span class="span_200">Số người :</span>
            <asp:TextBox ID="txtNoPerson" CssClass="input_book_100" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="abc" runat="server"
                ControlToValidate="txtNoPerson" ErrorMessage=" ***"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNoPerson"
                ErrorMessage="Please input a number" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        </div>
        <div class="field_book">
            <span class="span_200">Ngày đến : </span>
            <dxe:ASPxDateEdit ID="txtCheckin" CssClass="input_book_100" Width="102px" runat="server">
            </dxe:ASPxDateEdit>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="abc" runat="server"
                ControlToValidate="txtCheckin" ErrorMessage=" ***"></asp:RequiredFieldValidator>
        </div>
        <div class="field_book">
            <span class="span_200">Ngày đi : </span>
            <dxe:ASPxDateEdit ID="txtCheckout" CssClass="input_book_100" Width="102px" runat="server">
            </dxe:ASPxDateEdit>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ValidationGroup="abc" runat="server"
                ControlToValidate="txtCheckout" ErrorMessage=" ***"></asp:RequiredFieldValidator>
        </div>
        <div class="field_book">
            <span class="span_200">Hình thức thanh toán:</span>
            <asp:RadioButtonList ID="rdoBilling" runat="server" RepeatDirection="Horizontal"
                Width="200px">
                <asp:ListItem>Bank transfer</asp:ListItem>
                <asp:ListItem>Credit Card</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="field_book">
            <span class="span_120">Các yêu cầu khác :</span>
            <asp:TextBox ID="txtOtherRequest" TextMode="MultiLine" CssClass="textarea_book" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
        THÔNG TIN LIÊN HỆ</div>
    <div class="field_book">
        <span class="span_120">Họ tên :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtFullName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="abc" runat="server"
            ControlToValidate="txtFullName" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Giới tính :</span>
        <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal" Width="120px">
            <asp:ListItem Selected="True">Nam</asp:ListItem>
            <asp:ListItem>Nữ</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div class="field_book">
        <span class="span_120">Ngày sinh :</span>
        <%--<dxe:ASPxDateEdit ID="txtDOB" CssClass="input_book_100" Width="102px" runat="server">
                    </dxe:ASPxDateEdit>--%>
        &nbsp;<asp:DropDownList ID="ddlDay" runat="server" Width="40px" ValidationGroup="DOB">
        </asp:DropDownList>
        &nbsp&nbsp<asp:DropDownList ID="ddlMonth" runat="server" Width="40px" ValidationGroup="DOB">
        </asp:DropDownList>
        &nbsp&nbsp<asp:DropDownList ID="ddlYear" runat="server" Width="60px" ValidationGroup="DOB">
        </asp:DropDownList>
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
        <span class="span_120">Quốc gia :</span>
        <asp:DropDownList CssClass="input_book_100" ID="ddlCountry" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="abc" runat="server"
            ControlToValidate="ddlCountry" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Địa chỉ :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtAddress" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Điện thoại :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtPhone" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="abc" runat="server"
            ControlToValidate="txtPhone" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Số Fax :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtFaxNo" runat="server"></asp:TextBox>
    </div>
    <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
        THÔNG TIN CHUYẾN BAY</div>
    <div class="field_book">
        <span class="span_120">Ngày bay:</span>
        <dxe:ASPxDateEdit ID="txtArrivalDate" CssClass="input_book_100" Width="120px" runat="server">
        </dxe:ASPxDateEdit>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="abc" runat="server"
            ControlToValidate="txtArrivalDate" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Hãng hàng không :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtAircop" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Chuyến bay số :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtFlightNo" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Arrival City :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtArrivalCity" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Time (Local):</span>
        <asp:TextBox CssClass="input_book_250" ID="txtTimeArrival" runat="server"></asp:TextBox>
    </div>
    <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
        THÔNG TIN KHÁC</div>
    <div class="field_book">
        <span class="span_120">Bạn biết chúng tôi qua đâu?</span>
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
        <asp:CheckBox ID="chkAgree" Text="Tôi đã đọc, và đồng ý tuân theo điều khoản đăng ký *" runat="server" />
        <asp:CustomValidator ID="ValTerms" ClientValidationFunction="AcceptTermsCheckBoxValidation"
            runat="server" ErrorMessage="Please Accept Terms & Condition." ValidationGroup="abc"> </asp:CustomValidator>
    </div>
    <div class="field_book">
        <span class="span_120">&nbsp;</span>
        <asp:Button ID="btnBooking" ValidationGroup="abc" runat="server" CssClass="button_submit"
            Text="Booking" OnClick="btnBooking_Click" />
        <asp:Button ID="btnReset" runat="server" CssClass="button_submit" Text="Reset" />
    </div>
</asp:Content>
