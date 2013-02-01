<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSlideHome.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucSlideHome" %>
<div class="sliderkit photosgallery-captions">
    <div class="sliderkit-nav">
        <div class="sliderkit-nav-clip">
            <ul>
            <asp:Repeater runat="server" ID="rptMainSlide">
                <ItemTemplate>
                <li><a href='<%#Eval("SlideUrl") %>' rel="nofollow" title='<%#Eval("Title") %>'>
                    <img src='/Media/<%#Eval("SlideImg") %>' alt='<%#Eval("Title") %>' /></a></li>
                </ItemTemplate>
            </asp:Repeater>
                
            </ul>
        </div>
        <%--<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-prev"><a rel="nofollow" href="#" title="Previous line"><span>Previous line</span></a></div>--%>
        <%--<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-next"><a rel="nofollow" href="#" title="Next line"><span>Next line</span></a></div>--%>
        <div class="sliderkit-btn sliderkit-go-btn sliderkit-go-prev"><a rel="nofollow" href="#" title="Previous photo"><span>Previous photo</span></a></div>
        <div class="sliderkit-btn sliderkit-go-btn sliderkit-go-next"><a rel="nofollow" href="#" title="Next photo"><span>Next photo</span></a></div>
    </div>
    <div class="sliderkit-panels">
    <asp:Repeater runat="server" ID="rptThumbSlide">
        <ItemTemplate>
        <div class="sliderkit-panel">
            <img src='/Media/<%#Eval("SlideImg") %>' alt='<%#Eval("Title") %>' />
            <div class="sliderkit-panel-textbox">
                <div class="sliderkit-panel-text">
                    <h4>
                        <%#Eval("Title") %></h4>
                    <p>
                        <%#Eval("Description") %></p>
                </div>
                <div class="sliderkit-panel-overlay">
                </div>
            </div>
        </div>
        </ItemTemplate>
    </asp:Repeater>
        
    </div>
</div>
<img style="top: 400px; z-index: 99; left: 0; position: absolute;" src="/images/imgontop-l.png" />
<img style="top: 400px; right: 0; z-index: 99; position: absolute;" src="/images/imgontop-r.png" />
