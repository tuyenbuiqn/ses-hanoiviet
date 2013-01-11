<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SES.VTTEN.WEB.Default" %>

<%@ Register Src="Module/ucSupportOnline.ascx" TagName="ucSupportOnline" TagPrefix="uc1" %>
<%@ Register Src="Module/ucHomepageAlbums.ascx" TagName="ucHomepageAlbums" TagPrefix="uc2" %>
<%@ Register Src="Module/ucHomeTopTour.ascx" TagName="ucHomeTopTour" TagPrefix="uc3" %>
<%@ Register Src="Module/ucHomepageTourCate.ascx" TagName="ucHomepageTourCate" TagPrefix="uc4" %>
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
                <asp:Image ID="imgPromo" runat="server" />
                <p style="color: Red;">
                    <asp:Label ID="lblPromo" runat="server" Text="Label"></asp:Label>
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
        <%-- <uc3:ucHomeTopTour ID="ucHomeTopTour1" runat="server" />--%>
        <uc4:ucHomepageTourCate ID="ucHomepageTourCate1" runat="server" />
    </div>
</asp:Content>
