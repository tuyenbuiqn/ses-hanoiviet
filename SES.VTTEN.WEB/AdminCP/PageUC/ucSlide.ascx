﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSlide.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucSlide" %>
<h2>
    Cập nhật Slide</h2>
<table width="100%" border="1">
    <tr>
        <td class="style8">
            Tiêu đề:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtTitle" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTitle" ErrorMessage="*** Cần nhập tiêu đề" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;
            &nbsp; Số thứ tự: <asp:TextBox ID="txtOrder" runat="server" Width="50px" 
                ValidationGroup="submitGrp"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtOrder" ErrorMessage="*** Cần nhập số thứ tự" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator></td>
    </tr>    
    <tr>
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" Visible="False">[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    
     <tr>
        <td class="style8">
            Thuộc module:</td>
        <td>
            <asp:DropDownList runat="server" ID="ddlSlideCate" AppendDataBoundItems="true">
                <asp:ListItem Text="Slide trang chủ" Value="0"></asp:ListItem>
                <asp:ListItem Text="Slide trang tour" Value="1"></asp:ListItem>
                <asp:ListItem Text="Slide trang hotel" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <span style="color: Red;">Kích thước của Slide trang tour: 948 x 300px, trang chủ: 948 x 400px</span>
        </td>
    </tr>
   <tr>
        <td class="style8">
            Đường dẫn:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtSlideURL" runat="server" Width="179px" 
                ValidationGroup="submitGrp"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtSlideURL" ErrorMessage="*** Cần nhập đường dẫn" 
                ValidationGroup="submitGrp"></asp:RequiredFieldValidator>
        &nbsp;
            &nbsp;</td>
    </tr>
    
    <tr>
        <td class="style8">
            Chi tiết:</td>
        <td>
            <asp:TextBox ID="txtDescription" TextMode="MultiLine" runat="server" Width="90%">
           </asp:TextBox>
        </td>
    </tr>
    
   
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" />
        </td>
    </tr>
    
    
</table>
