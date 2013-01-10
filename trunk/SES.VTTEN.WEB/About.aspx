<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SES.VTTEN.WEB.About" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="Module/ucLeftBanner.ascx" TagName="ucLeftBanner" TagPrefix="uc7" %>
<%@ Register src="Module/ucAboutMenu.ascx" tagname="ucAboutMenu" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/tourstyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div id="Panel">
        <div class="menuleftmain1">
          <uc1:ucAboutMenu ID="ucAboutMenu1" runat="server" />
            <uc7:ucLeftBanner ID="ucLeftBanner1" runat="server" />
            
        </div>
        <div class="left-content" style="width:775px;">
            <div class="content" style="width:775px;">
                <h1>
                    <asp:Label runat="server" ID="lblContentName" Text=""></asp:Label>
                </h1>
                <div class="thinline7" style="width:775px;">
                </div>
                <div class="contentourdt1" style="width:775px;">
                    <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
                </div>
                <div class="toursub2" style="width:775px;">
                    <h3>
                        MORE INFORMATIONS</h3>
                </div>
                <div class="toursub2">
                    <asp:Repeater runat="server" ID="rptRelatedContent">
                        <ItemTemplate>
                            <div class="toursub12">
                                <div class="in1toursub10">
                                    <a href='/Travel-Guide/<%#Eval("ContentID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>'
                                        title='<%#Eval("Title")%>'>
                                        <%#Eval("Title")%>
                                    </a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>

