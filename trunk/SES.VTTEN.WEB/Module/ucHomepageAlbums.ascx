<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomepageAlbums.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomepageAlbums" %>

<%--<div class="box divAlbum">
    <div class="box-title">
        <p>
            ALBUM ẢNH</p>
    </div>
    <div class="detail-box">
        <div class="flexslider" style="float: left;">
            <div class="desc">
            </div>
            <ul class="slides">
                <asp:Repeater runat="server" ID="rptBigAlbum">
                    <ItemTemplate>
                        <li><a href='/AlbumDetail/<%#Eval("AlbumID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>'>
                            <div class="bimage">
                                <img id="bigimage" class="big-album-img" src='/Media/<%#Eval("AlbumImg")%>' />
                            </div>
                        </a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <asp:Repeater runat="server" ID="rptSmallAlbums">
            <ItemTemplate>
                <div class="Simage">
                    <a href='/AlbumDetail/<%#Eval("AlbumID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>'
                        tooltip='<%#Eval("Title")%>' id="idimg">
                        <img class="SmallImage" class="small-album-img" src='/Media/<%#Eval("AlbumImg")%>'
                            alt='<%#Eval("Title")%>' title='<%#Eval("Title") %>' />
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
--%>
<div class="box divAlbum">
    <div class="box-title">
        <p>
            ALBUM ẢNH</p>
    </div>
    <div class="detail-box">
        <div class="sliderkit photosgallery-captions">
            <div class="sliderkit-nav">
                <%--<img style="top: 40px; z-index: 99; left: 0; position: absolute;" src="/Images/ButtomNext.png" />
                <img style="top: 40px; right: 0; z-index: 99; position: absolute;" src="/Images/ButtomPr.png" />--%>
                <div class="sliderkit-nav-clip">
                    <ul>
                    <asp:Repeater runat="server" ID="rptMainSlide">
                        <ItemTemplate>
                        <li><a href='/AlbumDetail/<%#Eval("AlbumID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' rel="nofollow" title=''>
                            <img src='/Media/<%#Eval("AlbumImg") %>' alt='' /></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                
                    </ul>
                </div>
                <%--<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-prev"><a rel="nofollow" href="#" title="Previous line"><span>Previous line</span></a></div>--%>
                <%--<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-next"><a rel="nofollow" href="#" title="Next line"><span>Next line</span></a></div>--%>
                <%--<div class="sliderkit-btn sliderkit-go-btn sliderkit-go-prev"><a rel="nofollow" href="#" title="Previous photo"><span>Previous photo</span></a></div>
                <div class="sliderkit-btn sliderkit-go-btn sliderkit-go-next"><a rel="nofollow" href="#" title="Next photo"><span>Next photo</span></a></div>--%>
            </div>
            <div class="sliderkit-panels">
                <asp:Repeater runat="server" ID="rptThumbSlide">
                    <ItemTemplate>
                    <div class="sliderkit-panel">
                        <a href='/AlbumDetail/<%#Eval("AlbumID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' rel="nofollow" title=''><img src='/Media/<%#Eval("AlbumImg") %>' alt='' /></a>
                        <%--<div class="sliderkit-panel-textbox">
                            <div class="sliderkit-panel-text">
                                    <%#Eval("Description")%>
                            </div>
                            <div class="sliderkit-panel-overlay">
                            </div>
                        </div>--%>
                    </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>