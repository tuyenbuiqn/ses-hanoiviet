<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomepageTourCate.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomepageTourCate" %>
<div class="list-tour-box-inbound">
    <asp:Repeater runat="server" ID="rptCategoryInboundTour" OnItemDataBound="rptCategoryInboundTour_IntemDataBound">
        <ItemTemplate>
            <div class="ListTourBox">
                <ul id="carouselTour_<%#Eval("TourTypeID") %>" class="jcarousel-skin-tango">
                    <asp:Repeater runat="server" ID="rptInboundTour">
                        <ItemTemplate>
                            <li>
                                <p class="ListTourBox-title">
                                    <a href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>' title='<%#Eval("Title") %>'>
                                        <%#Eval("Title") %></a></p>
                                <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>' title='<%#Eval("Title") %>'>
                                    <img class="imgListTourBox" alt='<%#Eval("Title") %>' src='/Media/<%#Eval("TourImage") %>' />
                                </a>
                                <div class="Time-Price-ListTourBox">
                                    <p class="Time-ListTourBox">
                                       <%#Eval("DurationDay") %> DAYS / <%#Eval("DurationNight") %> NIGHTS
                                    </p>
                                    <p class="Price-ListTourBox">
                                        <%#Eval("TourPrice") %> đ
                                    </p>
                                </div>
                                <div class="MoTa-ListTourBox">
                                    <p>
                                        <%#WordCut(Eval("MetaDes").ToString())%>
                                    </p>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="list-tour-box-inbound">
    <asp:Repeater runat="server" ID="rptCategoryOutboundTour" OnItemDataBound="rptCategoryOutboundTour_IntemDataBound">
        <ItemTemplate>
            <div class="ListTourBox">
                <ul id="carouselTourOut_<%#Eval("TourTypeID") %>" class="jcarousel-skin-tango">
                    <asp:Repeater runat="server" ID="rptOutboundTour">
                        <ItemTemplate>
                            <li>
                                <p class="ListTourBox-title">
                                    <a href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>' title='<%#Eval("Title") %>'>
                                        <%#Eval("Title") %></a></p>
                                <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>' title='<%#Eval("Title") %>'>
                                    <img class="imgListTourBox" alt='<%#Eval("Title") %>' src='/Media/<%#Eval("TourImage") %>' />
                                </a>
                                <div class="Time-Price-ListTourBox">
                                    <p class="Time-ListTourBox">
                                       <%#Eval("DurationDay") %> DAYS / <%#Eval("DurationNight") %> NIGHTS
                                    </p>
                                    <p class="Price-ListTourBox">
                                        <%#Eval("TourPrice") %> đ
                                    </p>
                                </div>
                                <div class="MoTa-ListTourBox">
                                    <p>
                                        <%#WordCut(Eval("MetaDes").ToString())%>
                                    </p>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
