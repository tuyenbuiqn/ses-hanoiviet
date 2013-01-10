// jDiv - a jQuery plugin
// (c) Skyrocket Labs
// http://www.skyrocketlabs.com
// fred@skyrocketlabs.com
// Created: 10.24.2009
// Last updated: 02.06.2010

// DISPLAYS HIDDEN DIVS AS SUBMENUS ON HOVER

jQuery(document).ready(function(_q) {

	// addd by Profero (Scott) : 16th Nov 2010
	var isiPad = navigator.userAgent.match(/iPad/i) != null;
	if(isiPad) {
		$('.subMenuCon').each(function(){
			$(this).find('.bgM').prepend('<a href="javascript:;" style="position:relative;z-index:99999999;float:right;margin:0;padding:0;top:-1px;right:0px;" class="overlayClose"><img src="/images/overlayClose.png" border="0" alt=""></a><div class="clear"></div>');
			$(this).find('.bgM').css('padding','0px');
			$(this).find('.bgM').css('margin','0px');
		});
		$('ul#topnav li a,ul#topnavone li a').click(function(){
			if($(this).parent().find('.subMenuCon').length>0) {	
				if($(this).parent().find('.subMenuCon').is(':visible')) {
				return true;
				}
				else {
				$('ul#topnav li .subMenuCon,ul#topnavone li .subMenuCon').fadeOut('fast');
				$(this).parent().find('.subMenuCon').fadeIn('fast');
					$(this).parent().find('.overlayClose').click(function(){
					$('ul#topnav li .subMenuCon,ul#topnavone li .subMenuCon').fadeOut('fast');
					return false;
					});
				return false;
				}
			}
		});
	}
	
	//slideDown slideUp
	_q('.showhide,.all').click(function () {
			var classID = _q(this).attr("class");
			switch (classID)
			{
			case "showhide":
				slideDownUp(_q(this));
				break;
			case "all":
				slideDownUp(_q(this).parent().prev());
				break;
			}
	});
	//For the overlay of navigation 

	function megaHoverOver(){

		switch (jQuery('.select' ,this).attr('class'))
		{
		/*case 'link select':
			return ;
			break;*/
		case 'last link select':
			return ;
			break;
		
		}

		jQuery(this).find(".link").addClass('active');
		jQuery(this).find(".subMenuCon").stop().fadeTo('fast', 1).fadeIn();
			
		//Calculate width of all ul's
		(function(jQuery) { 
			jQuery.fn.calcSubWidth = function() {
				rowWidth = 0;

				//Calculate row
				jQuery(this).find("ul").each(function() {					
					rowWidth += jQuery(this).width(); 
				});	

			};
		})(jQuery); 

		jQuery(this).find(".subMenuCon").css({'width' : '984px'});//rowWidth

	}
	
	function megaHoverOut(){ 
	  jQuery(this).find(".link").removeClass('active');
	  jQuery(this).find(".subMenuCon").stop().fadeTo('fast', 0, function() {
		  jQuery(this).fadeOut(); 
	  });
	}


	var config = {    
		 sensitivity: 5, // number = sensitivity threshold (must be 1 or higher)    
		 interval: 100, // number = milliseconds for onMouseOver polling interval    
		 over: megaHoverOver, // function = onMouseOver callback (REQUIRED)    
		 timeout: 300, // number = milliseconds delay before onMouseOut    
		 out: megaHoverOut // function = onMouseOut callback (REQUIRED)    
	};
	
	// addd by Profero (Scott) : 16th Nov 2010
	if(!isiPad) {
	jQuery("ul#topnav li .subMenuCon, ul#topnavone li .subMenuCon").css({'opacity':'1'});
	jQuery("ul#topnav li,ul#topnavone li").hoverIntent(config);
	}
	
	//For the search of navigation
	 _q("#inputsearch").keypress(function () {
		 if(_q(this).val() == 'Search mynrma')
		 {
			 _q(this).val('');
		 }
		_q("#search_result_div").show();
	 
	 });
	 _q("#inputsearch").blur(function () {
		_q("#search_result_div").hide();
	 
	 });
});

function slideDownUp (_this)
{
		var _thisname = _this.children("a");
		if (_thisname.attr('class') == 'fold')
	{
		_this.next("ul").children("li").slideDown();
		_thisname.removeClass('fold').addClass("expand");
		_this.next("ul").children('.all').slideUp();
	} else if (_thisname.attr('class') == 'expand')
	{
		_this.next("ul").children("li:gt(0):not('.all')").slideUp();
		_this.next("ul").children('.all').slideDown();
		_thisname.removeClass('expand').addClass("fold");
	}
}