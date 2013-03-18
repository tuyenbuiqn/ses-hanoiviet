<%@ Page Title="" Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="Intro.aspx.cs" Inherits="SES.VTTEN.WEB.Intro" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DanhSachTour-title">
    <div>
        <p>
            <asp:Label ID="lblTitle" runat="server" Text="Giới thiệu"></asp:Label></p>
    </div>
    <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    
</div>
    <br />
    <div style="float: left; width: 100%;">
        <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>