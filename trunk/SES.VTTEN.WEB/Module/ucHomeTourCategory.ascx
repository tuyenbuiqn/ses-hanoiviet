<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomeTourCategory.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomeTourCategory" %>
<asp:Repeater runat="server" ID="rptParentCate" OnItemDataBound="rptParentCate_ItemDataBound">
    <ItemTemplate>
        <div class="Khung2">
            <div class="VDTE-Caption">
                <a href='/Tour-Category/<%#Eval("TourTypeID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                    title='<%#Eval("Title") %>'>
                    <%#Eval("Title") %>
                </a>
            </div>
            <div class="menu2">
                <ul class="toplink">
                    <asp:Repeater runat="server" ID="rptMenuChild">
                        <ItemTemplate>
                            <li><a href='/Tour-Category/<%#Eval("TourTypeID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                title='<%#Eval("Title") %>'>
                                <%#Eval("Title") %>
                            </a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <asp:Repeater runat="server" ID="rptCategoryChildHomepage" OnItemDataBound="rptCategoryChildHomepage_ItemDataBound">
                <ItemTemplate>
                    <div class="NoiDung">
                        <div class="TopNews">
                            <asp:Repeater runat="server" ID="rptTopNews">
                                <ItemTemplate>
                                    <div class="TopNews-Image">
                                        <a href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                            title='<%#Eval("Title") %>' >
                                            <img src='/Media/<%#Eval("TourImage")%>' alt='<%#Eval("Title")%>' title='<%#Eval("Title")%>'
                                                class="UP-Image" />
                                        </a>
                                    </div>
                                    <div class="TopNews-Content-Box">
                                        <a class="TopNews-Title" href='/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                            title='<%#Eval("Title") %>'>
                                            <%#Eval("Title") %>
                                        </a>
                                        <div class="TopNews-Content">
                                            <%#WordCut(Eval("MetaDes").ToString())%>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="TopTours">
                            <ul class="TopTours-List">
                                <asp:Repeater runat="server" ID="rptTopToursList">
                                    <ItemTemplate>
                                        <li><a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Alias").ToString()) %>'
                                            title='<%#Eval("Title") %>'>»
                                            <%#Eval("Title")%>
                                        </a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </ItemTemplate>
</asp:Repeater>
