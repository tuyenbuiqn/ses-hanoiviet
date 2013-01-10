<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSearchTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucSearchTour" %>
<div class="modul1" style="margin-bottom:10px;">
    <div class="modul1in">
        <div class="titmodul1">
            QUICK TOUR SEARCH</div>
    </div>
    <div class="modul1list">
        <asp:DropDownList ID="ddlDestination" class="DropDownListx" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTourType" class="DropDownListx" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTourCat" class="DropDownListx" runat="server">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem Value="1">Superior</asp:ListItem>
                        <asp:ListItem Value="2">Deluxe</asp:ListItem>
                        <asp:ListItem Value="3">Luxury</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlDuration" class="DropDownListx" runat="server">
                        <asp:ListItem Selected="True">Tour Duration</asp:ListItem>
                        <asp:ListItem Value="1">Less than 3 days</asp:ListItem>
                        <asp:ListItem Value="2">From 3 days to 8 days</asp:ListItem>
                        <asp:ListItem Value="3">From 8 days to 12 days</asp:ListItem>
                        <asp:ListItem Value="4">From 12 days to 16 days</asp:ListItem>
                        <asp:ListItem Value="5">More than 16 days</asp:ListItem>
                    </asp:DropDownList>
                    <div class="SearchButton">
                        <asp:Button ID="btnSearch" CssClass="search-tourx" runat="server" Text="SEARCH" 
                            onclick="btnSearch_Click" />
                            
                            </div>
    </div>
</div>
