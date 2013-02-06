<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="VideoDetail.aspx.cs" Inherits="SES.VTTEN.WEB.VideoDetail" Title="Untitled Page" %>
    <%@ Register Src="Module/ucBreadcrumb.ascx" TagName="ucBreadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucBreadcrumb ID="ucBreadcrumb1" runat="server" />
    <p style="float: left; width: 100%; font-size: 14px; font-weight: bold; margin: 10px 0px 10px 0px; color: #BE2020;">
        <asp:Label runat="server" ID="lblAlbum"></asp:Label></p>
    
    <asp:Repeater ID="rptImages" runat="server">
        <ItemTemplate>
            <div class="Album-video">
                <div class="Album-Cover-video">
                    <a id="various3" title='<%#Eval("Title") %>' href='http://www.youtube.com/embed/<%#Eval("Url") %>'>
                        <img src='http://i4.ytimg.com/vi/<%#Eval("Url") %>/default.jpg' height="120px" width="180px"
                            title='<%#Eval("Title") %>' alt='<%#Eval("Title")%>' />
                    </a>
                </div>
                <div class="Album-Title-video" style="text-align: center;">
                    <%#Eval("Title")%>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
