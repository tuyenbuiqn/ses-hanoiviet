<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomepageAlbums.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomepageAlbums" %>
<%-- <div class="box divAlbum">
            <div class="box-title">
                <p>
                    ALBUM ẢNH</p>
            </div>
            <div class="detail-box">
                <img alt="AlBum" class="albumImgBig" src="/image/Allbum1.png" width="190" height="125" />
                <p>
                    <img alt="AlBum" class="albumImgSmall" src="/image/Allbum2.png" width="60" height="57" />
                    <img alt="AlBum" class="albumImgSmall" src="/image/Allbum3.png" width="60" height="57" />
                    <img alt="AlBum" class="albumImgSmall" src="/image/Allbum4.png" width="60" height="57" />
                </p>
                
            </div>
        </div>--%>
<div class="box divAlbum">
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
