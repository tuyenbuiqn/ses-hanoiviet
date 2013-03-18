<%@ Page Title="" Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="LichKhoiHanh.aspx.cs" Inherits="SES.VTTEN.WEB.LichKhoiHanh" %>
<%@ Register src="Module/ucListLichKHoiHanh.ascx" tagname="ucListLichKHoiHanh" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="DanhSachTour-title">
    <div>
        <p>
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></p>
    </div>
    <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    
</div>
<uc1:ucListLichKHoiHanh ID="ucListLichKHoiHanh1" runat="server" />
</asp:Content>
