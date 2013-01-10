<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Hanoiviettravel_VN.Homepage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hanoiviettravel</title>
    <link rel="Stylesheet" type="text/css" href="css/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrap">
        <div class="inner">
            <div class="detail">
                <div id="head">
                    <div class="logo-out">
                        <div class="logo-left">
                            <a href="#">
                                <img src="../image/logo.png" class="logo" alt="hanoiviettravel" />
                            </a><span class="hanoiviettravel">Hanoi Viet Travel </span>
                        </div>
                        <div class="logo-right">
                            <span class="haytanhuong">HÃY TẬN HƯỞNG</span> <span class="tungphutgiay">TỪNG PHÚT
                                GIÂY</span>
                        </div>
                    </div>
                    <ul class="toplink">
                        <li><a href="#">Trang Chủ</a></li>
                        <li><a href="#">Giới thiệu</a></li>
                        <li><a href="#">Diễn đàn</a></li>
                        <li><a href="#">Thông tin cần thiết</a></li>
                    </ul>
                    <div class="foot-head">
                    </div>
                </div>
                <div class="under">
                    <div class="box divTimKiemTour">
                        <div class="box-title">
                            <p>
                                TÌM KIẾM TOUR</p>
                        </div>
                        <div class="detail-box">
                            <table class="TimKiemTour">
                                <tr>
                                    <td colspan="2">
                                        <asp:RadioButton Checked="true" ID="rbttrongnuoc" runat="server" />
                                        &nbsp; <span style="font-weight: bold;">Trong nước</span>
                                        <asp:RadioButton Checked="true" ID="rbtnuocngoai" runat="server" />
                                        &nbsp; <span style="font-weight: bold;">Nước ngoài</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 55px;">
                                        <span class="text">Khởi hành:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlkhoihanh" CssClass="ddl" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="Tp.Hồ Chí Minh" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="text">Nơi đến:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlNoiDen" CssClass="ddl" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="Tp.Hà Nội" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="text">Giá tour:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlGiaTour" CssClass="ddl" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="10.000.000" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="text">Thời gian:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlNgay" Width="40px" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="01" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp;
                                        <asp:DropDownList ID="ddlThang" Width="40px" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="01" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                        &nbsp;
                                        <asp:DropDownList ID="ddlNam" Width="40px" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="2013" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="text">Loai tour</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlLoaiTour" class="ddlkhoihanh" runat="server">
                                            <asp:ListItem Text="Trong nước" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                    <td>
                                        <asp:LinkButton CssClass="lnk" ID="lnkTimKiem" runat="server">
                                            <img alt="Tìm Kiếm" src="/image/TimKiem.png" />
                                        </asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="box divTinKhuyenMai">
                        <div class="box-title">
                            <p>
                                TIN KHUYẾN MẠI</p>
                        </div>
                        <div class="detail-box">
                            <img alt="Tin Khuyen Mai" src="image/TinKhuyenMai.png" width="190" height="125" />
                            <p style="color: Red;">
                                Kỳ Nghỉ 3 Ngày 2 Đêm Dành Cho 2 Người Tại Khách Sạn 4 Sao Sammy Đà Lạt, Loại Phòng
                                Deluxe
                            </p>
                        </div>
                    </div>
                    <div class="box divAlbum">
                        <div class="box-title">
                            <p>
                                ALBUM ẢNH</p>
                        </div>
                        <div class="detail-box">
                            <img alt="AlBum" class="albumImgBig" src="/image/Allbum1.png" width="190" height="125" />
                            <p>
                                <img alt="AlBum" class="albumImgSmall" src="/image/Allbum2.png" width="60" height="57" />
                                <img alt="AlBum" class="albumImgSmall" src="/image/Allbum3.png" width="60" height="57" />
                                <img alt="AlBum" class="albumImgSmall" src="/image/Allbum4.png" width="60" height="57" />
                            </p>
                        </div>
                    </div>
                    <div class="box divHoTroOnLine">
                        <div class="box-title">
                            <p>
                                HỖ TRỢ TRỰC TUYẾN</p>
                        </div>
                        <div class="detail-box">
                            <img alt="HoTroOnLine" src="/image/HoTroOnline.png" width="190" />
                            <p class="CongCuHoTro">
                                <a href="#" title="LiveChat">
                                    <img alt="HoTroOnLine" src="/image/LiveChat.png" /></a> <a href="#" title="sky">
                                        <img alt="HoTroOnLine" src="/image/sky.png" /></a> <a href="#" title="yahoo">
                                            <img alt="HoTroOnLine" src="/image/yahoo.png" /></a>
                            </p>
                            <p class="Mobile" style="background: url(/image/Mobile.png) no-repeat;">
                                (+84)0986.786.577
                            </p>
                        </div>
                    </div>
                </div>
                <div id="ListTour">
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                    <div class="ListTourBox">
                        <p class="ListTourBox-title">
                            <a href="#" title="title">Tây Ban Nha - Thụy Sĩ - Pháp - Ý - Vatican </a>
                        </p>
                        <div class="ImagesTour">
                            <a href="#" title="prev">
                                <img class="imgListTourBox-prev" alt="prev" src="/image/prev-button.png" />
                            </a><a href="#" title="ImgTour">
                                <img class="imgListTourBox" alt="ImgTour" src="/image/ImgTour.png" />
                            </a><a href="#" title="next">
                                <img class="imgListTourBox-next" alt="next" src="/image/next-button.png" />
                            </a>
                        </div>
                        <div class="Time-Price-ListTourBox">
                            <p class="Time-ListTourBox">
                                3 DAYS / 2 NIGHTS
                            </p>
                            <p class="Price-ListTourBox">
                                2.300.000đ
                            </p>
                        </div>
                        <div class="MoTa-ListTourBox">
                            <p>
                                Đà Lạt vào xuân đẹp vô ngần, cảnh sắc trong lành mát mẻ níu chân du khách...
                            </p>
                        </div>
                    </div>
                </div>
                <div id="footer">
                    <div id="copyright">
                        <p class="company">
                            CÔNG TY TNHH DU LỊCH HÀ NỘI VIỆT TRAVEL</p>
                        <p>
                            Trụ sở chính : No 007 , 261/1 Yen Duyen Road, Hoang Mai Dis Hanoi city</p>
                        <p>
                            Phone : ++84(4)3.9999981 Hotline : ++84 943627667</p>
                        <p>
                            Emergency lines : 24 / 24 : ++84.943627667 Ms Lan</p>
                        <p>
                            Email: booking@hanoiviettravel.com, Skype: nguyenlaneliz Yahoo : lannguyen_1981</p>
                    </div>
                    <div class="footerRight">
                        <div id="MenuBottom">
                            <ul class="bottomlink">
                                <li class="liTop"><a href="#">Trang Chủ</a></li>
                                <li><a href="#">Khuyến mãi</a></li>
                                <li><a href="#">Du lịch</a></li>
                                <li><a href="#">Khách sạn</a></li>
                                <li><a href="#">Dịch vụ khách hang</a></li>
                            </ul>
                        </div>
                        <img alt="DoiTac" src="/image/imgDoiTac.png" />
                        <p class="textCopyright">
                            © 2009 Hanoi VietTravel.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
