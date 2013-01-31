<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SES.VTTEN.WEB.Default" %>

<%@ Register Src="Module/ucSupportOnline.ascx" TagName="ucSupportOnline" TagPrefix="uc1" %>
<%@ Register Src="Module/ucHomepageAlbums.ascx" TagName="ucHomepageAlbums" TagPrefix="uc2" %>
<%@ Register Src="Module/ucHomeTopTour.ascx" TagName="ucHomeTopTour" TagPrefix="uc3" %>
<%@ Register Src="Module/ucHomepageTourCate.ascx" TagName="ucHomepageTourCate" TagPrefix="uc4" %>
<%@ Register src="Module/ucSearch.ascx" tagname="ucSearch" tagprefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="under">
        <div class="box divTimKiemTour">
            <uc5:ucSearch ID="ucSearch1" runat="server" />
        </div>
        <div class="box divTinKhuyenMai">
            <div class="box-title">
                <p>
                    <a href="/Promotions/0/Default.aspx">TOUR KHUYẾN MẠI</a> </p>
            </div>
            <div class="detail-box">
            <asp:HyperLink ID="hpKM" runat="server">
                <asp:Image ID="imgPromo" runat="server" />
                </asp:HyperLink>
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
