<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Hotel-Category.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel_Category" Title="Untitled Page" %>

<%@ Register src="Module/ucHotelList.ascx" tagname="ucHotelList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="DanhSachTour-title">
        <div>
            <p>
                Khách sạn tại
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <uc1:ucHotelList ID="ucHotelList1" runat="server" />
</asp:Content>
