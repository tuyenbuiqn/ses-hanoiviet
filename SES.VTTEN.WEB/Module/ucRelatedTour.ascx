<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRelatedTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucRelatedTour" %>
<div class="sliderkit carousel-demo2" style="width: 700px !important;">
	<div class="sliderkit-nav">
		<div class="sliderkit-nav-clip">
			<ul>
                <asp:Repeater runat="server" ID="rptRelatedTours">
                    <ItemTemplate>
                    <li>
                        <div class="ListTourBox">
                            <div class="ImagesTour">
                                <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'>
                                    <img alt="<%#Eval("Title") %>" title="<%#Eval("Title") %>" src="/Media/<%#Eval("TourImage") %>" />
                                </a>
                            </div>
                            <div class="Time-Price-ListTourBox">
                                <p class="Time-ListTourBox">
                                    <%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%>
                                </p>
                                <p class="Price-ListTourBox">
                                    Giá Tour: <%#Eval("TourPrice", "{0:0,000}")%>đ
                                </p>
                            </div>
                            <p class="ListTourBox-title">
                                <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'><%#Eval("Title")%></a>
                            </p>
                            <%--<div class="MoTa-ListTourBox">
                                <p>
                                    <%#WordCut(Eval("MetaDes").ToString())%>
                                </p>
                            </div>--%>
                        </div>
                    </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
		</div>
		<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-prev"><a href="#" title="Scroll to the left"><span>Previous</span></a></div>
		<div class="sliderkit-btn sliderkit-nav-btn sliderkit-nav-next"><a href="#" title="Scroll to the right"><span>Next</span></a></div>
	</div>
</div>			