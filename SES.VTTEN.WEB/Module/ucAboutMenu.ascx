<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAboutMenu.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucAboutMenu" %>
<ul id="menuxo">
<asp:Repeater ID="rptAbout" runat="server">
<ItemTemplate>
    <li><a href="/About/<%#Eval("ContentID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"><%#Eval("Title") %></a></li>
    </ItemTemplate>
    </asp:Repeater>
    
</ul>