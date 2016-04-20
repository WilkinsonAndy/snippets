/* ----------------- *\
 * Equal Height Divs *
\* ----------------- */

//For each element with a class of "row".
$('.row').each(function (i, obj) {
	//Find all child elements with a class of "equal-height".
	var equalHeightsDivs = $(this).find('.equal-height');

	//If elements were found.
	if (equalHeightsDivs.length > 0) {
		//Declare the max height.
		var maxHeight = 0;
		
		//For each child element.
		equalHeightsDivs.each(function () {
			//If the element height is greater than the max height, use that value as the new max height.
			maxHeight = Math.max(maxHeight, $(this).outerHeight());
		});
		
		//Set the height of the child elements.
		equalHeightsDivs.css('height', maxHeight + 'px');
	}
}); 


// -------------------------------- 
// -------------------------------- 


$('.row').each(function (i, obj) {
	var equalHeightsDivs = $(this).find('.equal-height');

	if (equalHeightsDivs.length > 0) {
		var maxHeight = 0;
		
		equalHeightsDivs.each(function () {
			maxHeight = Math.max(maxHeight, $(this).outerHeight());
		});
		
		equalHeightsDivs.css('height', maxHeight + 'px');
	}
});   