﻿<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Contact.aspx.cs" Inherits="SES.VTTEN.WEB.Contact" Title="Untitled Page" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <br />
    <div class="field" style="color: #2c82ad; font-size: 12px; margin: 30px 0; font-weight: bold;">
        THÔNG TIN LIÊN HỆ</div>
    <div class="field_book">
        <span class="span_120">Họ tên(*) :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtFullName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="abc" runat="server"
            ControlToValidate="txtFullName" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Giới tính :</span>
        <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal" Width="120px">
            <asp:ListItem Selected="True" Value="Ông">Nam</asp:ListItem>
            <asp:ListItem Value="Bà">Nữ</asp:ListItem>
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
                        ControlToValidate="DOB" co ErrorMessage=" ***"></asp:RequiredFieldValidator>--%>
    </div>
    <div class="field_book">
        <span class="span_120">Email(*) :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="abc" runat="server"
            ControlToValidate="txtEmail" ErrorMessage=" ***"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ValidationExpression="^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$"
            ID="RegularExpressionValidator2" ValidationGroup="abc" ControlToValidate="txtEmail"
            runat="server" ErrorMessage="Please input E-mail"></asp:RegularExpressionValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Quốc gia(*) :</span>
        <asp:TextBox runat="server" ID="txtCountry" CssClass="input_book_250" ValidationGroup="abc"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="abc" runat="server"
            ControlToValidate="txtCountry" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Địa chỉ :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtAddress" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Số điện thoại(*) :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtPhone" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="abc" runat="server"
            ControlToValidate="txtPhone" ErrorMessage=" ***"></asp:RequiredFieldValidator>
    </div>
    <div class="field_book">
        <span class="span_120">Số Fax :</span>
        <asp:TextBox CssClass="input_book_250" ID="txtFaxNo" runat="server"></asp:TextBox>
    </div>
    <div class="field_book">
        <span class="span_120">Nội dung :</span>
        <asp:TextBox ID="txtOtherRequest" TextMode="MultiLine" CssClass="textarea_book" runat="server"></asp:TextBox>
    </div>
    <div class="field" style="color: #2c82ad; font-size: 12px; margin: 5px 0; font-weight: bold;">
        THÔNG TIN KHÁC</div>
    <div class="field_book">
        <span class="span_120">Bạn biết chúng tôi từ</span>
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
        <span class="span_120">Mã bảo mật</span>
        <div style="float: left">
            <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
        </div>
        <div style="float: left; margin-left:2px;">
            <cc1:CaptchaControl ID="CaptchaControl1" BackColor="#d5e6d6" runat="server" Width="100px" CaptchaWidth="150"
                CaptchaHeight="31" />
        </div>
    </div>
    <div class="field_book">
        <span class="span_120">&nbsp;</span>
        <asp:Button ID="btnBooking" ValidationGroup="abc" runat="server" CssClass="button_submit"
            Text="Send" OnClick="btSend_Click" />
        <asp:Button ID="btnReset" runat="server" CssClass="button_submit" Text="Reset" />
    </div>
</asp:Content>
