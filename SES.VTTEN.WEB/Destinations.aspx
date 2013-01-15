<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Destinations.aspx.cs" Inherits="SES.VTTEN.WEB.Destinations" Title="Untitled Page" %>
    <%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <asp:Repeater ID="rptDestinationCat" runat="server">
        <ItemTemplate>
            <div class="tourcatx">
                <div class="tourcatxy">
                    <div class="tittourcatx">
                        <h2>
                            <a style="font-size: 15px; color: #118074" href="/Destination/<%#Eval("DestinationID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title") %></a>
                    </div>
                </div>
                <div class="texttourcatx">
                    <div class="imgtourcatx">
                        <a href="/Destination/<%#Eval("DestinationID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                            <img title="<%#Eval("Title") %>" src="/Media/<%#Eval("DestinationImage") %>" width="180px"
                                height="103px"></a></div>
                    <div class="contenttourcatx">
                        <div class="contenttourcatx1">
                            <%#WordCut(Eval("Description").ToString())%><a href="/Destination/<%#Eval("DestinationID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                Xem tiếp </a>
                        </div>
                        <div class="contenttourcatx2">
                            <div class="contenttourcatx3" style="width: 100%;">
                                <span style="float: right;"><a href='/Tour-Destination/<%#Eval("DestinationID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>'>
                                    Tour in this Destination </a>| <a style="color: #648293; font-weight: bold;" href="/Custom-Tour/0/Customize-your-own-trips.aspx">
                                        Customize this tour </a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="width: 100%; margin: 20px 0; float: right; font-size: 12px;">
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
