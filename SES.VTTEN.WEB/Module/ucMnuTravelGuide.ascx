<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMnuTravelGuide.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucMnuTravelGuide" %>
<div class="subMenuCon" id="meganavMotoring" style="opacity: 0; width: 984px; display: none;">
    <div class="con">
        <div class="bgM">
            <div class="boxL">
               <div class="heading2">
                    <h3>
                        <asp:HyperLink ID="hplVN1" runat="server">About Vietnam</asp:HyperLink>
                    </h3>
                </div>
                <p>
                    <asp:HyperLink ID="hplVN2" runat="server">
                        <asp:Image ID="imgVN" runat="server" Height="115px" Width="198px" /></asp:HyperLink></p>
                <p>
                </p>
                <p>
                    <asp:Label ID="lblVNDes" runat="server" Text="Label"></asp:Label>
                </p>
                <p>
                </p>
                <p>
                    <asp:HyperLink ID="hplVN3" runat="server">More Vietnam information</asp:HyperLink></p>
            </div>
            <div class="boxM" style="border-right: 1px solid #ccc;">
                <div class="abo1">
                    <a href="#">Vietnam Travel &amp; Events</a></div>
                <br />
                <ul class="left" style="border: none;">
                    <asp:Repeater runat="server" ID="rptTravelNews">
                        <ItemTemplate>
                            <p style="margin-top: 5px; font-weight: bold">
                                <a href='/News/<%#Eval("NewsID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'>
                                    <%#Eval("Title") %>
                                </a>
                                <p style="text-align: justify;">
                                    <%#WordCut(Eval("Description").ToString()) %></p>
                            </p>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <ul class="right">
                    <li>
                        <h3>
                            <a href="/Vietnam-Destination/1/Default.aspx">Vietnam Destinations</a></h3>
                        <p>
                            <asp:Repeater runat="server" ID="rptDestination">
                                <ItemTemplate>
                                    <a href="/Destination/<%#Eval("DestinationID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                        <%#Eval("Title") %></a><span class="divide" style="margin: 0 0.0em;">| </span>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                    </li>
                </ul>
            </div>
            <div class="boxR">
                <asp:Repeater runat="server" ID="rptPromotion">
                    <ItemTemplate>
                        <div class="heading2">
                            <a style="font-size: 15px; color: #118074" href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title") %></a>
                        </div>
                        <p>
                            <a href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'>
                                <img title="<%#Eval("Title") %>" alt='<%#Eval("Title") %>' src="/Media/<%#Eval("TourImage") %>"
                                    width="180px" height="103px"></a></p>
                        <p>
                            <%#WordCut(Eval("MetaDes").ToString())%><a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"></p>
                        <p>
                            from <span style="color: #dc0196; font-size: 18px; font-weight: bold;">Sale Off</span>
                        </p>
                        <p>
                            <a class="blueBtn" href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'>
                                Find out more</a></p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="bgB">
        </div>
    </div>
