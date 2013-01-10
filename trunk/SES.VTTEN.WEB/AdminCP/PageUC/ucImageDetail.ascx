<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucImageDetail.ascx.cs" Inherits="SES.VTTEN.WEB.AdminCP.PageUC.ucImageDetail" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<h2>
    Cập nhật hình ảnh</h2>
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr> 
    
    <tr id="trDes" runat="server" visible="true">
        <td class="style8">
            Mô tả:</td>
        <td>
            <CKEditor:CKEditorControl FilebrowserImageBrowseUrl="/ckfinder/ckfinder.html?type=Images" FilebrowserImageUploadUrl="/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images" BasePath="/ckeditor/" ID="txtDescription" TextMode="MultiLine" runat="server" Width="90%">
           </CKEditor:CKEditorControl>
        </td>
    </tr>
    <tr>
        <td>Thuộc album</td>
        <td><asp:DropDownList runat="server" ID="ddlAlbum" AppendDataBoundItems="true">
            <asp:ListItem Value="0" Text=".: Không chọn :."></asp:ListItem>
        </asp:DropDownList></td>
    </tr>
     <tr>
        <td>OrderID</td>
        <td> <asp:TextBox ID="txtOrder" runat="server" Width="50px"></asp:TextBox></td>
    </tr>
    <tr runat="server" id="trVideo">
        <td class="style8">
            Video:
        </td>
        <td class="style9">
            <asp:TextBox ID="txtVideo" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
   <tr runat="server" id="trPopup">
        <td class="style8">
            Hình ảnh
        </td>
        <td class="style9">
            <asp:FileUpload ID="fuImage" runat="server" />
            &nbsp;
            <asp:HyperLink ID="hplImage" runat="server" Target="_blank" >[Xem 
            ảnh]</asp:HyperLink>
        </td>
    </tr>
    
    
    <tr>
        <td class="style8">
            &nbsp;
        </td>
        <td class="style4">
            <asp:Button ID="btnSave" runat="server" Text="Lưu" OnClick="btnSave_Click" 
                ValidationGroup="submitGrp" />
            <asp:Button ID="btnReset" runat="server" Text="Hủy" onclick="btnReset_Click" />
        </td>
    </tr>
    
    
</table>
