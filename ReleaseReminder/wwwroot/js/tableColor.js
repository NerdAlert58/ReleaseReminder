
    var table = document.getElementById("formTable"); //getting the form table by id for editing
    //goes through every row, and colors based on specific text in the media type
for (var i = 1, row; row = table.rows[i]; i++) { //avoiding first row because it's just the headers
    if (row.cells.length == 5) {
        if (row.cells[4].innerHTML == "Movies") {
            row.style.backgroundColor = "#5DADE2";
        } else if (row.cells[4].innerHTML == "VideoGames") {
            row.style.backgroundColor = "#5D6BE2";
        } else if (row.cells[4].innerHTML == "Music") {
            row.style.backgroundColor = "#925DE2";
        } else if (row.cells[4].innerHTML == "Books") {
            row.style.backgroundColor = "#D55DE2";
        } else if (row.cells[4].innerHTML == "Television") {
            row.style.backgroundColor = "#E25D6B";
        }
    }
    else {
        if (row.cells[3].innerHTML == "Movies") {
            row.style.backgroundColor = "#5DADE2";
        } else if (row.cells[3].innerHTML == "VideoGames") {
            row.style.backgroundColor = "#5D6BE2";
        } else if (row.cells[3].innerHTML == "Music") {
            row.style.backgroundColor = "#925DE2";
        } else if (row.cells[3].innerHTML == "Books") {
            row.style.backgroundColor = "#D55DE2";
        } else if (row.cells[3].innerHTML == "Television") {
            row.style.backgroundColor = "#E25D6B";

        }
    }
}