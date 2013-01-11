<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="AlbumDetail.aspx.cs" Inherits="SES.VTTEN.WEB.AlbumDetail" Title="" %>
    <%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <h1 class="travel-h1">
        <asp:Label runat="server" ID="lblAlbum"></asp:Label></h1>
    <div class="thinline7">
    </div>
    <asp:Repeater ID="rptImages" runat="server">
        <ItemTemplate>
            <div class="Album">
                <div class="Album-Cover">
                    <a class="fancybox-tourimg" rel="tourimg" title='<%#Eval("Title") %>' href='/Media/<%#Eval("Url") %>'>
                        <img src='/Media/<%#Eval("Url") %>' height="120px" width="180px" title='<%#Eval("Title") %>'
                            alt='<%#Eval("Title")%>' />
                    </a>
                </div>
                <div class="Album-Title" style="text-align: center;">
                    <a href='/AlbumDetail/<%#Eval("Url") %>/<%#Change_AV(Eval("Title").ToString()) %>'
                        title='<%#Eval("Title") %>'>
                        <%#Eval("Title")%>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
