<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Tour.aspx.cs" Inherits="SES.VTTEN.WEB.Tour" Title="Untitled Page" %>
<%@ Register src="Module/ucTourDetail.ascx" tagname="ucTourDetail" tagprefix="uc1" %>
<%@ Register src="Module/ucRelatedTour.ascx" tagname="ucRelatedTour" tagprefix="uc2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="DanhSachTour-title">
        <div>
            <p>
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <div class="divTourDetail">
        <uc1:ucTourDetail ID="ucTourDetail1" runat="server" />
   </div>
   <p style="float: left; width: 100%; font-size: 14px; margin-bottom: 20px; font-weight: bold; text-transform: uppercase;">Các tour liên quan</p>
   <div class="TourLienQuan">
        <uc2:ucRelatedTour ID="ucRelatedTour1" runat="server" />
   </div>
</asp:Content>
