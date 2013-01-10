<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMnuTravel.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucMnuTravel" %>
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
            <div class="boxL">
                <div class="heading2">
                    <h3>
                        <a href="/Tour-Category/1/Vietnam-Day-Trip-Excursions.aspx">Vietnam Day Trip & Excursions</a></h3>
                </div>
                <p>
                    <a href="#">
                        <img src="/images/vntrip-exclusion.jpg" border="0" height="115px" width="198px"></a></p>
                <p>
                </p>
                <p>
                    <asp:Repeater runat="server" ID="rptTripEx">
                        <ItemTemplate>
                            <a href="/Tour-Category/<%#Eval("TourTypeID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title")%></a><span class="divide" style="margin: 0 0.0em;"> | </span>
                        </ItemTemplate>
                    </asp:Repeater>
                </p>
                <p>
                </p>
            </div>
            <div class="boxL">
                <div class="heading2">
                    <h3>
                        <a href="/Tour-Category/5/Vietnam-Package-Tours.aspx">Vietnam Package Tours</a></h3>
                </div>
                <p>
                    <a href="#">
                        <img src="/images/travel-package.jpg" border="0" height="115px" width="198px"></a></p>
                <p>
                </p>
                <p>
                    <asp:Repeater runat="server" ID="rptPack">
                        <ItemTemplate>
                            <a href="/Tour-Category/<%#Eval("TourTypeID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                <%#Eval("Title")%></a><span class="divide" style="margin: 0 0.0em;"> | </span>
                        </ItemTemplate>
                    </asp:Repeater>
                </p>
                <p>
                </p>
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
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
    <div class="bgB">
    </div>
</div>
