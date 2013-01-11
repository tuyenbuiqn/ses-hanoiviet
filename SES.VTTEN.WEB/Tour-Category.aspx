<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Tour-Category.aspx.cs" Inherits="SES.VTTEN.WEB.Tour_Category" Title="Untitled Page" %>
<%@ Register src="Module/ucTourList.ascx" tagname="ucTourList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DanhSachTour-title">
        <div>
            <p>
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label></p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <uc1:ucTourList ID="ucTourList1" runat="server" />
</asp:Content>
