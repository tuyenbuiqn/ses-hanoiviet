<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="Travel-News.aspx.cs" Inherits="SES.VTTEN.WEB.Travel_News" Title="Untitled Page" %>

<%@ Register src="Module/ucTravelNews.ascx" tagname="ucTravelNews" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="DanhSachTour-title">
        <div>
            <p>
                Tin tức du lịch
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <uc1:ucTravelNews ID="ucTravelNews1" runat="server" />
</asp:Content>

