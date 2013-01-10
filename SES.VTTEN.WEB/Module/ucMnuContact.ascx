<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMnuContact.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucMnuContact" %>
<div class="subMenuCon" id="meganavMotoring" style="opacity: 0; width: 984px; display: none;">
    <div class="con">
        <div class="bgM">
            <div class="boxL">
                <div class="abo1">
                    Head Office:</div>
                <div class="abo2">
                    <img src="/images/logo.png" alt="Hanoi Viet Travel"></div>
                <div class="abo3">
                    <asp:Label runat="server" ID="lblHeadOffice" Text=""></asp:Label>
                </div>
            </div>
            <div class="boxM" style="padding-left:5px;">
                <div class="cont1">
                    <img src="/Media/contact-us.jpg" width="451" height="257"></div>
            </div>
            <div class="boxR" style="float:left;">
                <div class="abo1" style="color: #14529B;">
                    Contact us</div>
                <br>
                <div class="cont5">
                    <%-- <a href="#">
                        FAQs: Frequently Asked Questions</a><br>
                    Direct mail: <a href="#">info@southpacifictravel.com.vn</a><br>
                    <a href="#">General request form</a><br>
                    <a href="#">Plan your tailor-made trip</a><br>
                    <a href="#">Feedback / Complaints</a><br>--%>
                </div>
                <div class="thinline1111">
                </div>
                <div class="cont6"  style="text-align:justify;">
                    <asp:Label runat="server" ID="lblContactInfo" Text="" CssClass="conts7"></asp:Label>
                </div>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="bgB">
        </div>
    </div>
