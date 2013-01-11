<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Tour.aspx.cs" Inherits="SES.VTTEN.WEB.Tour" Title="Untitled Page" %>
<%@ Register src="Module/ucTourDetail.ascx" tagname="ucTourDetail" tagprefix="uc1" %>
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
</asp:Content>
