<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTestimonial.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTestimonial" %>
 <div id="RightBox1">
                <div class="Captionbox">
                    <p>
                        TESTIMONIAL</p>
                </div>
                <div id="boximg">
                <img src="/images/tripadvisor.png" />
                Recommended on Tripadvisor.
                </div>
                <div class="viewTripAd">
                    <asp:HyperLink ID="hplTripAd" Target="_blank" runat="server">Read more.</asp:HyperLink></div>
                <div class="Boxdetail">
                    <p id="DearHa">
                        <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                        </p>
                    <p style="text-align: justify;">
                       <asp:Label ID="lblDes" runat="server" Text="Label"></asp:Label>
                       </p>
                    <asp:HyperLink ID="hplRv" runat="server">View more...</asp:HyperLink>
                </div>
            </div>