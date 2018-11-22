// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

tableColoring();

function tableColoring(){
    var table = document.getElementById("formTable");


    for (var i = 1, row; row = table.rows[i]; i++) { //avoiding first row because it's just the headers
        if (row.cells[4].innerHTML == "Movies") {
            row.style.backgroundColor = "#067BC2";    
        }
        else if (row.cells[4].innerHTML == "VideoGames") {
            row.style.backgroundColor = "#2ECC71";
        }
        else if (row.cells[4].innerHTML == "Music") {
            row.style.backgroundColor = "#76D7C4";
        }
        else if (row.cells[4].innerHTML == "Books") {
            row.style.backgroundColor = "#2E86C1";
        }
        else if (row.cells[4].innerHTML == "Television") {
            row.style.backgroundColor = "#5DADE2";
        }
    }
}

function mediaSelect(selectObject) {
    var value = selectObject.value;

	if (value == "Movies") {

		tableFilter("Movies");
	}
	else if (value == "VideoGames") {
		tableFilter("VideoGames");
	}
	else if (value == "Music") {
		tableFilter("music");
	}
	else if (value == "Books") {
		tableFilter("books");
	}
	else if (value == "Television") {
		tableFilter("television");
	}
	else {
		tableFilter("");
	}
}

function tableFilter(filterVar) {
	var filter, table, tr, td, i;
	filter = filterVar.toUpperCase();
	table = document.getElementById("formTable");
	tr = table.getElementsByTagName("tr");

	// Loop through all table rows, and hide those who don't match the search query
	for (i = 1; i < tr.length; i++) { //i = 1 to avoid headers
		td = tr[i].getElementsByTagName("td")[4]; //at[1] because filtering categories
		if (td) {
			if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
				tr[i].style.display = "";
			} else {
				tr[i].style.display = "none";
			}
		}
	}
}

//below is from https://codepen.io/diegoleme/pen/surIK
var password = document.getElementById("password")
	, confirm_password = document.getElementById("password2");

function validatePassword() {
	if (password.value != confirm_password.value) {
		confirm_password.setCustomValidity("Passwords Don't Match");
	} else {
		confirm_password.setCustomValidity('');
	}
}

password.onchange = validatePassword();
confirm_password.onkeyup = validatePassword();



function selectedData() {
    var table = document.getElementById("formTable");

    var count = 0;
    var stringArray = new Array();

    for (var i = 1, row; row = table.rows[i]; i++) { //avoiding first row because it's just the headers
        if (row.cells[0].children[0].checked) { //checking the first rows textbox
            stringArray[count] = row.cells[1].innerHTML;
            count++;
        }
    }
    var postData = { values: stringArray };
    $.ajax({
        type: "POST",
        url: "/Home/Forms",
        data: postData,
        success: function () {
            alert("Successfully Submitted your Reminders.");
        },
        dataType: "json",
        traditional: true
    });
}