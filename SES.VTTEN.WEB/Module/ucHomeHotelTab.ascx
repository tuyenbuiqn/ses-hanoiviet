<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomeHotelTab.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomeHotelTab" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css" media="screen">
    .menux
    {
        padding: 0;
        clear: both;
    }
    .menux li
    {
        display: inline;
    }
    .menux li a
    {
    	margin-top:3px;
       
        padding: 5px;
        float: left;
        text-decoration: none;
        border-top: 2px solid #1D87D6;
        border-left: 1px solid #ccf;
        border-right: 1px solid #ccf;
        color: #1D87D6;
        font-weight: bold;
        margin-right:2px;
    }
    .menux li.active a
    {
        background-color:#F4F4F4;
        color:#1D87D6;
    }
    .contentx
    {
        float: left;
        clear: both;
        border: 1px solid #ccf;
       background-color:#F4F4F4;
        padding: 0;
        width: 713px;
    }
</style>
<div id="Khung2" style="float:left;">
    <div class="VDTE-Caption" style="float:left;">
        <a href="/Tour-Category/14/Vietnam-Package-Tours.aspx" title="Vietnam Package Tours">
            Top Hotels & Resort </a>
    </div>
    <div class="noidung">
        <ul id="menux" class="menux">
            <asp:Repeater ID="rptDesHome" runat="server">
                <ItemTemplate>
                    <%#MakeTab(Eval("DestinationID").ToString())%>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        <asp:Repeater ID="rptDesContent" OnItemDataBound="rptDesContent_ItemDataBound" runat="server">
            <ItemTemplate>
                <div id="HotelTab<%#Eval("DestinationID") %>" class="contentx">
                    <div id="Slide">
                        <asp:Repeater ID="rptHotelItem" runat="server">
                            <ItemTemplate>
                                <div class="SImage">
                                    <div class="Slidepart">
                                        <div class="SPC">
                                            <a class="Slidepartcaption" href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>">
                                                <%#Eval("Title") %></a></div>
                                        <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>">
                                            <div class="Slidepartimage">
                                                <img class="SLPI" src="/Media/<%#Eval("HotelImage") %>" /></div>
                                        </a>
                                        <div class="SPPrice">
                                            <%#StarRate(Eval("StarRates").ToString())%>
                                        </div>
                                        <div class="SPPrice">
                                            <a class="price" href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>">
                                                From
                                                <%#Eval("HotelStartPrice") %>$</a></div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
