<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SES.VTTEN.WEB.Default" %>

<%@ Register Src="Module/ucSupportOnline.ascx" TagName="ucSupportOnline" TagPrefix="uc1" %>
<%@ Register Src="Module/ucHomepageAlbums.ascx" TagName="ucHomepageAlbums" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        <!--Album-->
        <uc2:ucHomepageAlbums ID="ucHomepageAlbums1" runat="server" />
        <!--End Album-->
        <!--Support online-->
        <uc1:ucSupportOnline ID="ucSupportOnline1" runat="server" />
        <!--End Support online-->
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
</asp:Content>
