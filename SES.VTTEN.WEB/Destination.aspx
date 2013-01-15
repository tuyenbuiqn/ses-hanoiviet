<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Destination.aspx.cs" Inherits="SES.VTTEN.WEB.Destination" Title="Untitled Page" %>
    <%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucbreadcrumb id="ucBreadcrumb1" runat="server" />
    <p style="float: left; width: 100%; font-size: 14px; font-weight: bold; margin: 10px 0px 10px 0px; color: #BE2020;">
        <asp:Label runat="server" ID="lblDestinationName" Text=""></asp:Label>
    </p>
    <div class="img_hotel1">
        <div class="gallery galNoMargin gallhotelDetails">
            <div class="thumbs galleryFB">
                <asp:Repeater ID="rpImage" runat="server">
                    <ItemTemplate>
                        <a class="fancybox-tourimg" rel="tourimg" title="<%#Eval("Title") %>" href="/Media/<%#Eval("MediaFile") %>">
                            <img src="/Media/<%#Eval("MediaFile") %>" alt="<%#Eval("Title") %>">
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="mainPic">
                <a class="fancybox-tourimg" id="hplMainIMG" rel="tourimg" title="" href="" runat="server">
                    <asp:Image ID="ImgTour" Width="510px" Height="320px" runat="server" />
                </a>
            </div>
        </div>
    </div>
    <div class="contentourdt1">
        <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
    </div>
    <div class="toursub2">
        <h3>
            Các tour liên quan</h3>
        <div class="thinline7">
        </div>
    </div>
    <div class="toursub2">
        <asp:Repeater runat="server" ID="rptRelatedTour">
            <ItemTemplate>
                <div class="toursub12">
                    <div class="in1toursub10">
                        <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'>
                            <%#Eval("Title")%>
                        </a>
                    </div>
                    <div class="in2toursub10">
                        <%#Eval("TourCode") %></div>
                    <div class="in3toursub10">
                        Giá: </div>
                    <div class="in4toursub10">
                        <%#Eval("TourPrice", "{0:0,000}")%>đ</div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
