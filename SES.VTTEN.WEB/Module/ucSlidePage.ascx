<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSlidePage.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucSlidePage" %>
<div id="banner">
    <div class="bannerslide">
        <div class="wt-rotator" style="width: 948px; height: 300px;">
            <a href="#"></a>
            <div class="desc" style="top: 20px !important;">
            </div>
            <div class="preloader">
            </div>
            <div class="c-panel">
                <div class="buttons">
                    <div class="prev-btn">
                    </div>
                    <div class="play-btn">
                    </div>
                    <div class="next-btn">
                    </div>
                </div>
                <!--End #buttons-->
                <div class="thumbnails">
                    <ul>
                        <asp:Repeater runat="server" ID="rptSlide">
                            <ItemTemplate>
                                <li><a href='/Media/<%#Eval("SlideImg")%>' title='<%#Eval("Title") %>'></a><a href='<%#Eval("SlideUrl")%>'>
                                </a>
                                    <div style="left: 0px; background-color: #4EA77E; opacity: 0.4; filter: alpha(opacity=40);
                                        top: 236px; height: 40px; width: 450px;">
                                        <span class="cap-title" style="text-transform: uppercase;"><a href='<%#Eval("SlideUrl")%>'>
                                            <%#Eval("Title") %></a> </span>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <!--End #thumbnails-->
            </div>
            <!--End #c-panel-->
        </div>
    </div>
</div>
