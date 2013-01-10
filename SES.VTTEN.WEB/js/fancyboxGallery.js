// $Id: fancyboxGallery.js,v 1.3 2011/02/17 08:42:19 andy.f Exp $ 
Gallery = {
		
		init: function() {
			if($(".gallery .thumbs img").length > 0){
				$('.gallery .thumbs img').css("cursor","pointer");
				$('.gallery .thumbs img').click(
						function(e){	
							e.preventDefault();
							Gallery.updateMainPic($(this));
						}
				);
				$('.gallery .thumbs img').hover(function(){
					$(this).fadeTo("fast", 0.4); // This should set the opacity to 100% on hover
					Gallery.updateMainPic($(this));
				},function(){
					$(this).fadeTo("fast", 1.0); // This should set the opacity back to 60% on mouseout
				});
				
				$('.main_image_fb').click(function(e){
					e.preventDefault();
					indexValue = $(this).parent().attr('class').replace("galRef-","")-1;
					$(".galleryFB a").attr('rel','group1').eq(indexValue).trigger('click');
				});
				Gallery.fancybox_init();
				
				
			}
			$('.fbGallery').click(function(e){
				// Listener for search results and browse hotels and destinations
				e.preventDefault();
				clckHref = eval($(this).attr('href').replace("#",""));				
				Gallery.searchResultsTrigger(clckHref);
				
			});
		},

		updateMainPic: function(element) {
			imgRef = element;
			tmpThubSrc = imgRef.attr('src').replace("thumbnail","gallery");
			$('#hotel_main_image').attr('src', function(){
				return tmpThubSrc;
			});
			$('.mainPic a').attr('href', function(){
				return tmpThubSrc.replace("gallery","600x450");
			});
			$('.mainPic a').attr('class', function(){
				return imgRef.parent().attr('class');
			});
			
		},
		fancybox_init: function() {
			
				$(".galleryFB a").attr('rel','group1').fancybox({
					'transitionIn'		: 'none',
					'transitionOut'		: 'none',
					'centerOnScroll'	: 'true',
					'titlePosition' 	: 'over',
					'cyclic'			: 'true',
					'overlayOpacity'	: '0.8',
					'overlayColor'		: '#737373',
					
					'titleFormat'		: function(title, currentArray, currentIndex, currentOpts) {
							return '<span id="fancybox-title-over">Image ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';				
							}
				});
			
		},
		
		searchResultsTrigger: function(clckHref){
			
			$.fancybox(
					clckHref,
					{
						'transitionIn'		: 'none',
						'transitionOut'		: 'none',
						'titlePosition' 	: 'over',
						'cyclic'			: 'true',
						'overlayOpacity'	: '0.8',
						'overlayColor'		: '#737373',
						'titleFormat'		: function(title, currentArray, currentIndex, currentOpts) {
							return '<span id="fancybox-title-over">Image ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';				
							}
					});

		}
};