<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Customer-Reviews.aspx.cs" Inherits="SES.VTTEN.WEB.Customer_Reviews"
    Title="Untitled Page" %>

<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <h1 class="travel-h1">
        <span>Customer Reviews </span>
    </h1>
    <div class="thinline7">
    </div>
    <asp:Repeater ID="rptReview" runat="server">
        <ItemTemplate>
            <div class="tourcatx">
                <div class="tourcatxy">
                    <div class="tittourcatx">
                        <h2>
                            <a style="font-size: 15px; color: #118074" href="/Travel-Review/<%#Eval("CustomerReviewID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title") %></a>
                    </div>
                </div>
                <div class="texttourcatx">
                    <div class="imgtourcatx">
                        <a href="/Travel-Review/<%#Eval("CustomerReviewID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                            <img title="<%#Eval("Title") %>" src="/Media/<%#Eval("ReviewImg") %>" width="180px"
                                height="103px"></a></div>
                    <div class="contenttourcatx">
                        <div class="contenttourcatx1">
                            <%#WordCut(Eval("Description").ToString())%><a href="/Travel-Review/<%#Eval("CustomerReviewID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                Read More </a>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="width: 100%; float: left; margin-top: 10px;">
        <div style="float: left; margin-left: 0xp;">
            <asp:ImageButton ID="cmdPrev" Visible="false" OnClick="cmdPrev_Click" runat="server"
                ImageUrl="~/images/prevpage.png" /></div>
        <div style="float: right; margin-right: 0px;">
            <asp:ImageButton ID="cmdNext" Visible="false" OnClick="cmdNext_Click" runat="server"
                ImageUrl="~/images/nextpage.png" /></div>
    </div>
</asp:Content>
