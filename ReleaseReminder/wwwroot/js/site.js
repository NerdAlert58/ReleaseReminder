// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function mediaSelect(selectObject) {
    var value = selectObject.value;

    if (value == "Movies") {

        document.getElementById('checkbox1ID').textContent = 'Horror';
        document.getElementById('checkbox2ID').textContent = 'Action';
        document.getElementById('checkbox3ID').textContent = 'Comedy';

        document.getElementById('creatorLabel').textContent = 'Director';
    }
    else if (value == "Video Games") {

        document.getElementById('checkbox1ID').textContent = 'Horror';
        document.getElementById('checkbox2ID').textContent = 'FPS';
        document.getElementById('checkbox3ID').textContent = 'Adventure';

        document.getElementById('creatorLabel').textContent = 'Producer';
    }
    else if (value == "Music") {

        document.getElementById('checkbox1ID').textContent = 'Rock';
        document.getElementById('checkbox2ID').textContent = 'Pop';
        document.getElementById('checkbox3ID').textContent = 'Rap';

        document.getElementById('creatorLabel').textContent = 'Artist';
    }
    else {
        console.log("The other one.")
    }
}