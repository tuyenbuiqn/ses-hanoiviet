<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Travel-Guides.aspx.cs" Inherits="SES.VTTEN.WEB.Travel_Guides" Title="Untitled Page" %>

<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<%@ Register Src="Module/ucRelatedTour.ascx" TagName="ucRelatedTour" TagPrefix="uc4" %>
<%@ Register src="Module/ucBreadcrumb.ascx" tagname="ucBreadcrumb" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucbreadcrumb id="ucBreadcrumb1" runat="server" />
    <h1 class="travel-h1">
        <asp:Label runat="server" ID="lblCatName" Text=""></asp:Label>
    </h1>
    <div class="thinline7">
    </div>
    <asp:Repeater ID="rptContentCat" runat="server">
        <ItemTemplate>
            <div class="tourcatx">
                <div class="tourcatxy">
                    <div class="tittourcatx">
                        <h2>
                            <a style="font-size: 15px; color: #118074" title="<%#Eval("Title") %>" href="/Travel-Guide/<%#Eval("ContentID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title") %></a>
                    </div>
                </div>
                <div class="texttourcatx">
                    <div class="imgtourcatx">
                        <a title="<%#Eval("Title") %>" href="/Travel-Guide/<%#Eval("ContentID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                            <img title="<%#Eval("Title") %>" alt="<%#Eval("Title") %>" src="/Media/<%#Eval("ContentImage") %>" width="180px"
                                height="103px"></a></div>
                    <div class="contenttourcatx">
                        <div class="contenttourcatx1">
                            <%#WordCut(Eval("Description").ToString())%><a title="click here to read more" href="/Travel-Guide/<%#Eval("ContentID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                Read More </a>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="width: 100%; margin: 20px 0; float: right;">
        <div class="collection">
            <cp:CollectionPager LabelText="Page:&amp;nbsp;&amp;nbsp;" FirstText="&amp;nbsp;&amp;nbsp;<<"
                BackText="< &amp;nbsp;" LastText=">>" NextText=">" ShowFirstLast="True" ControlCssClass="collectionpager"
                PagingMode="PostBack" runat="server" BackNextLinkSeparator="" BackNextLocation="Right"
                PageNumbersDisplay="Numbers" ResultsLocation="None" BackNextDisplay="HyperLinks"
                ID="CollectionPager1" BackNextButtonStyle="" BackNextStyle="margin-left:5px;"
                ControlStyle="" PageNumbersSeparator="&amp;nbsp;" ShowLabel="True">
            </cp:CollectionPager>
            <div class="collectPage">
            </div>
        </div>
    </div>
</asp:Content>
