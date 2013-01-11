<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Travel-Guide.aspx.cs" Inherits="SES.VTTEN.WEB.Travel_Guide" Title="Untitled Page" %>

<%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <h1 class="travel-h1">
        <asp:Label runat="server" ID="lblContentName" Text=""></asp:Label>
    </h1>
    <div class="thinline7">
    </div>
    <div class="contentourdt1">
        <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
    </div>
    <div class="toursub2">
        <h3>
            MORE INFORMATIONS</h3>
        <div class="thinline7">
        </div>
    </div>
    <div class="toursub3">
        <asp:Repeater runat="server" ID="rptRelatedContent">
            <ItemTemplate>
                <div class="in1toursub10">
                    <a href='/Travel-Guide/<%#Eval("ContentID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                        title='<%#Eval("Title")%>'>
                        + <%#Eval("Title")%>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
