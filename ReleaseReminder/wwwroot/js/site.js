// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function mediaSelect(selectObject) {
    var value = selectObject.value;

    if (value == "Movies") {

		tableFilter("Movies");
    }
    else if (value == "Video Games") {
		tableFilter("VideoGames");
    }
    else if (value == "Music") {
		tableFilter("music");
    }
    else {
        console.log("The other one.")
    }
}

function tableFilter(filterVar) {
	var input, filter, table, tr, td, i;
	filter = filterVar.toUpperCase();
	table = document.getElementById("formTable");
	tr = table.getElementsByTagName("tr");

	// Loop through all table rows, and hide those who don't match the search query
	for (i = 1; i < tr.length; i++) { //i = 1 to avoid headers
		td = tr[i].getElementsByTagName("td")[1]; //at[1] because filtering categories
		if (td) {
			if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			} else {
				tr[i].style.display = "none";
			}
		}
	}
}