
    //below is from https://codepen.io/diegoleme/pen/surIK



function validatePassword() { //used to validate passwords

    var password = document.getElementById("password1");
    var confirm_password = document.getElementById("password2"); 

        if (password.value != confirm_password.value) {
            confirm_password.setCustomValidity("Passwords Don't Match");
        } else {
            confirm_password.setCustomValidity('');
        }
    }

