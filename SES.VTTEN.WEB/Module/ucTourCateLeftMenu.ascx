<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTourCateLeftMenu.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucTourCateLeftMenu" %>
<ul id="menuxo">
    <li><a href="/Travel-Guides/1/Default.aspx">Travel Guide</a>
        <asp:Repeater Visible="false" runat="server" ID="rptChildGuide">
            <HeaderTemplate>
                <ul id="bibo">
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href='/Travel-Guide/<%#Eval("ContentID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                    title='<%#Eval("Title")%>'>+
                    <%#Eval("Title")%>
                </a></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </li>
    <li><a href="/Travel-News/1/Default.aspx">Travel News</a> </li>
    <asp:Repeater runat="server" ID="rptParentTourType" OnItemDataBound="rptParentTourType_ItemDataBound">
        <ItemTemplate>
            <li><a href='/Tour-Category/<%#Eval("TourTypeID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                title='<%#Eval("Title")%>'>
                <%#Eval("Title")%>
            </a>
                <ul id="bibo">
                    <asp:Repeater Visible="True" runat="server" ID="rptChildTourType">
                        <ItemTemplate>
                            <li><a href='/Tour-Category/<%#Eval("TourTypeID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                title='<%#Eval("Title")%>'>+
                                <%#Eval("Title")%>
                            </a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </li>
        </ItemTemplate>
    </asp:Repeater>
    <li><a href="/Vietnam-Destination/1/Default.aspx">Vietnam Destination</a>
        <asp:Repeater Visible="false" runat="server" ID="rptChildDestination">
            <HeaderTemplate>
                <ul id="Ul1">
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href='/Destination/<%#Eval("DestinationID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>'
                    title='<%#Eval("Title")%>'>+
                    <%#Eval("Title")%>
                </a></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </li>
    <li><a href="/Hotel-Category/0/Default.aspx">Viet Nam Hotels</a>
        <asp:Repeater Visible="false" runat="server" ID="rptHotel">
            <HeaderTemplate>
                <ul id="Ul1">
            </HeaderTemplate>
            <ItemTemplate>
                <li><a href='/Hotel-Category/<%#Eval("DestinationID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                    title='<%#Eval("Title")%>'>+ Hotels in
                    <%#Eval("Title")%>
                </a></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </li>
    <li><a href="/Customer-Reviews/0/Default.aspx">Customer Reviews</a></li>
    <li><a href="/Albums/0/Vietnam-Photos.aspx">Vietnam Photos</a></li>
    <li><a href="/Videos/0/Travel-Videos.aspx">Travel Videos</a></li>
</ul>
