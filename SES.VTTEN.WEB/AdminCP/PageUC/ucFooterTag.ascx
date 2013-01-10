<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFooterTag.ascx.cs"
    Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucFooterTag" %>
    <h2>Footer tag</h2>
<div style="float: left; width: 100px">
    Tag:</div>
<div style="float: left; width: 850px ">
    <asp:TextBox ID="txtTag" runat="server" Width="700px" Height="200px" TextMode="MultiLine"></asp:TextBox>
</div>
<br />
<div style="float: left; width: 100px; height:10px">
</div>
<div>
    <asp:Button ID="Save" runat="server" Text="Lưu" onclick="Save_Click" />
</div>
