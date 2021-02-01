
$(window).ready(function ()
{
	
	$(" .loading-overlay .spinner ,.loading-overlay h1").fadeOut(2000,
	function ()
	{
		 $("body").css("overflow","auto");
		$(this).parent().fadeOut(1000,
		function ()
		{
			
			$(this).remove();
		});
		
		
	});
	
});