<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCustomizeTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucCustomizeTour" %>
<style type="text/css">
    .bookbox
    {
        width: 100%;
        float: left;
    }
    .booktitle
    {
        font-size: 15px;
        color: #2c82ad;
        font-weight: bold;
    }
    .booktour
    {
        width: 100%;
        margin: 5px;
        float: left;
    }
    .book-left
    {
        width: 400px;
        float: left;
        margin-right: 10px;
        padding: 3px;
        border-bottom: 1px dashed #333;
    }
    .book-right
    {
        width: 400px;
        float: left;
        border-bottom: 1px dashed #333;
        padding: 3px;
    }
    .book-lable
    {
        margin-left: 15px;
        float: left;
        width: 135px;
        font-weight: bold;
    }
    .book-content
    {
        float: left;
        width: 250px;
        font-weight: bold;
        color: #D64C21;
    }
    .tour-more
    {
        margin-top: 10px;
        float: left;
    }
    .book2-left
    {
        width: 820px;
        float: left;
        overflow:hidden;
        padding:3px;
    }
    .book2-lable
    {
        width: 250px;
        float: left;
        padding: 3px;
        border-bottom: 1px dashed #333;
        font-weight:bold;
    }
    .book2-content
    {
        width: 550px;
        float: left;
        padding: 3px;
        border-bottom: 1px dashed #333;
        font-weight: bold;
        color: #D64C21;
    }
</style>
<h2>
    Chi tiết customize tour</h2>
<div class="bookbox">
    <h3 class="booktitle">
        Thông tin khách đặt tour</h3>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Họ tên</span>
            <asp:Label runat="server" ID="lblFullName" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Email</span>
            <asp:Label runat="server" ID="lblEmail" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Ngày sinh</span>
            <asp:Label runat="server" ID="lblNgaySinh" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Địa chỉ</span>
            <asp:Label runat="server" ID="lblDiaChi" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Giới tính</span>
            <asp:Label runat="server" ID="lblGioiTInh" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Điện thoại</span>
            <asp:Label runat="server" ID="lblDienThoai" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Quốc tịch</span>
            <asp:Label runat="server" ID="lblCountry" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Fax</span>
            <asp:Label runat="server" ID="lblFax" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <h3 class="booktitle tour-more">
        Trip Information</h3>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Ngày đi</span>
            <asp:Label runat="server" ID="lblArrival" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Số người lớn</span>
            <asp:Label runat="server" ID="lblAdult" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Ngày đến</span>
            <asp:Label runat="server" ID="lblDeparture" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Số trẻ nhỏ</span>
            <asp:Label runat="server" ID="lblChildren" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Loại khách sạn</span>
            <asp:Label runat="server" ID="lblHotelCat" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Loại thanh toán</span>
            <asp:Label runat="server" ID="lblBillingOption" CssClass="book-content" Text=""></asp:Label></div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Yêu cầu khác</span>
            <asp:Label runat="server" ID="lblOtherRequest" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Place to visit</span>
            <asp:Label runat="server" ID="lblPlaceToVisit" CssClass="book-content" Text=""></asp:Label></div>
    </div>
    <h3 class="booktitle tour-more">
        Travel Arrangement</h3>
           <div class="book2-left">
        <span class="book2-lable">Transport</span>
        <asp:Label runat="server" ID="lblTransport" CssClass="book2-content" Text=""></asp:Label>
    </div>
    <div class="book2-left">
        <span class="book2-lable">Preferred type of programme</span>
        <asp:Label runat="server" ID="lblTourProgramme" CssClass="book2-content" Text=""></asp:Label>
    </div>
    <div class="book2-left">
        <span class="book2-lable">Accommodation </span>
        <asp:Label runat="server" ID="lblAccommodation" CssClass="book2-content" Text=""></asp:Label>
    </div>
     <div class="book2-left">
        <span class="book2-lable">Meals </span>
        <asp:Label runat="server" ID="lblMeal" CssClass="book2-content" Text=""></asp:Label>
    </div>
</div>
