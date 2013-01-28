<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRelatedTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucRelatedTour" %>
<asp:Repeater runat="server" ID="rptRelatedTours">
        <ItemTemplate>
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
        </ItemTemplate>
    </asp:Repeater>
