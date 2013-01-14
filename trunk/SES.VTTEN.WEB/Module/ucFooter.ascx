<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFooter.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucFooter" %>
<div id="footer">
    <div id="copyright">
        <asp:Literal runat="server" ID="ltrFooter"></asp:Literal>
    </div>
    <div class="footerRight">
        <div id="MenuBottom">
            <ul class="bottomlink">
                <li class="liTop"><a href="/Default.aspx" title="Hanoi vietravel">Trang Chủ</a></li>
                <li><a href="/Promotions/0/Default.aspx" title="Tour khuyến mãi">Khuyến mãi</a></li>
                <li><a href="/Tour-Category/0/Vietnam.aspx" title="Thông tin du lịch">Du lịch</a></li>
                <li><a href="/Hotel-Category/0/Default.aspx" title="Thông tin khách sạn">Khách sạn</a></li>
                <li><a href="/Contact.aspx" title="Liên hệ với chúng tôi">Dịch vụ khách hàng</a></li>
            </ul>
        </div>
        <img alt="DoiTac" src="/image/imgDoiTac.png" title="Cổng thanh toán" />
        <p class="textCopyright">
            © 2009 Hanoi VietTravel.
        </p>
    </div>
</div>
