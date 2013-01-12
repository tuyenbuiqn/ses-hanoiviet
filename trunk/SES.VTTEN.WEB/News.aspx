<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="SES.VTTEN.WEB.News" Title="Untitled Page" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="DanhSachTour-title">
        <div>
            <p>
                <a href="/Default.aspx" title="Trang chủ">Trang chủ</a>&nbsp;» &nbsp;
                <a href="/Travel-News/1/Default.aspx" title="Tin tức du lịch">Tin tức du lịch</a>&nbsp;» &nbsp;
                <asp:Label runat="server" ID="lblNewsTitle" Text=""></asp:Label>
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
     <div class="content">
        <div class="thinline7">
        </div>
        <div class="contentourdt1">
            <div class="imgtourcatx" style="margin-right:10px;">
                <asp:HyperLink ID="hplIMG" CssClass="fancybox-tourimg" runat="server"><asp:Image width="180px" ID="imgRV" runat="server"
                                    height="103px"/></asp:HyperLink>
            </div>
            <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
        </div>
        <div class="toursub2">
            <h3>
                Các bài liên quan
            </h3>
        </div>
            <div class="thinline7">
        </div>
        <div class="toursub2" style="margin-top:5px;">
            <asp:Repeater runat="server" ID="rptRelatedReview">
                <ItemTemplate>
                    <div class="toursub12">
                        <div class="in1toursub10" style="width:100%;">
                            <a href='/News/<%#Eval("NewsID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                title='<%#Eval("Title")%>'>
                                <%#Eval("Title")%>
                            </a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
