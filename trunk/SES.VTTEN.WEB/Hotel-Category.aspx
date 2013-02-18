<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Hotel-Category.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel_Category" Title="Untitled Page" %>

<%@ Register src="Module/ucHotelList.ascx" tagname="ucHotelList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="DanhSachTour-title">
        <div>
            <p>
                <a href="/Default.aspx" title="Trang chủ">Trang chủ</a>&nbsp;» &nbsp;
                <a href="/Hotel-Category/0/Default.aspx" title="Danh sách khách sạn">Dịch vụ</a>&nbsp;» &nbsp;
                <a href="/Hotel-Category/0/Default.aspx" title="Danh sách khách sạn">Khách sạn</a>&nbsp;» &nbsp;
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <uc1:ucHotelList ID="ucHotelList1" runat="server" />
</asp:Content>
