<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Travel-Review.aspx.cs" Inherits="SES.VTTEN.WEB.Travel_Review" Title="Untitled Page" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="DanhSachTour-title">
        <div>
            <p>
                Thông tin du lịch
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
     <div class="content">
        <h1 style="color: #BE2020">
            <asp:Label runat="server" ID="lblReviewTitle" Text=""></asp:Label>
        </h1>
        <div class="thinline7">
        </div>
        <div class="contentourdt1">
            <div class="imgtourcatx" style="margin-right:10px;">
                <asp:HyperLink ID="hplIMG" CssClass="fancybox-tourimg" runat="server">
                    <asp:Image width="180px" ID="imgRV" runat="server" height="103px"/>
                </asp:HyperLink>
            </div>
            <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
        </div>
        <div class="toursub2">
            <h4 style="color: #2772BC; width: 100%; float: left; border-bottom: 1px solid #CCCCCC; padding-bottom: 10px;">CÁC TIN LIÊN QUAN</h4>
        </div>
        <div class="toursub2">
            <asp:Repeater runat="server" ID="rptRelatedReview">
                <ItemTemplate>
                    <div class="toursub12">
                        <div class="in1toursub10">
                            <a href='/Travel-Review/<%#Eval("CustomerReviewID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                title='<%#Eval("Title")%>'>
                                » <%#Eval("Title")%>
                            </a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
