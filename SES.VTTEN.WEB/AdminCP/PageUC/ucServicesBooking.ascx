<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucServicesBooking.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucServicesBooking" %>
<h2>
    Chi tiết đặt dịch vụ</h2>
<div class="bookbox">
    <h3 class="booktitle">
        Thông tin khách đặt dịch vụ</h3>
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
        Thông tin dịch vụ</h3>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Tên dịch vụ</span>
            <asp:Label runat="server" ID="lblHotelName" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Số người</span>
            <asp:Label runat="server" ID="lblAdult" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
           <span class="book-lable">Loại thanh toán</span>
            <asp:Label runat="server" ID="lblBillingOption" CssClass="book-content" Text=""></asp:Label>
        </div>
        <div class="book-right">
            <span class="book-lable">Yêu cầu khác</span>
            <asp:Label runat="server" ID="lblOtherRequest" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    
    
     <h3 class="booktitle tour-more">
        Ngày tới</h3>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Arrival date</span>
            <asp:Label runat="server" ID="lblArrival" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
    <div class="booktour">
        <div class="book-left">
            <span class="book-lable">Air corp</span>
            <asp:Label runat="server" ID="lblAirCorp" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
      <div class="booktour">
        <div class="book-left">
           <span class="book-lable">Arrival City</span>
            <asp:Label runat="server" ID="lblArrivalCity" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
       <div class="booktour">
        <div class="book-left">
           <span class="book-lable">Time</span>
            <asp:Label runat="server" ID="lblTime" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
     <div class="booktour">
        <div class="book-left">
           <span class="book-lable" style="width:250px;">Biết thông tin tour qua kênh:</span>
            <asp:Label runat="server" ID="lblInfo" CssClass="book-content" Text=""></asp:Label>
        </div>
    </div>
</div>
