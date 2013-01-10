<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPopupLang.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucPopupLang" %>


<script type='text/javascript'>
  $(window).load(function(){
      $('#basic-modal-content').modal();
    });
</script>

<style>
.simplemodal-close {display:none;}
</style>
<div id="basic-modal-content">
<div style="width:404px;height:346px; background-color:#1D87D6;">
<div style="width:404px;height:220px; background-color:#1D87D6;">
<img style="margin-left:70px;" src="/images/logo1.jpg" alt="Hanoi Viet Travel" />
</div>
<div style="width:404px;height:126px; background-color:#1D87D6;">
<a href="#">
<img src="/images/outbound.jpg" alt="Outbound Travel" /></a>
<a href="/Default.aspx?popup=0">
<img src="/images/inbound.jpg" alt="Inbound Travel" />
</a>
</div>
</div>
</div>