const text = document.querySelector

// Write your JavaScript code.
 /*Get the modal*/
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("btn");

//Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function () {
    modal.style.display = "block";
}


// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}


//iot javascript

// Get the modal
var modal1 = document.getElementById("myModal1");

// Get the button that opens the modal
var btn1 = document.getElementById("myBtn1");

// Get the <span> element that closes the modal
var span1 = document.getElementsByClassName("close1")[0];

// When the user clicks on the button, open the modal
btn1.onclick = function () {
    modal1.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span1.onclick = function () {
    modal1.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal1) {
        modal1.style.display = "none";
    }
} 
///
//SQL
///



// Get the modal
var myModal2 = document.getElementById("myModal2");

// Get the button that opens the modal
var myBtn2 = document.getElementById("myBtn2");

// Get the <span> element that closes the modal
var span2 = document1.getElementsByClassName("close1")[0];

// When the user clicks on the button, open the modal
myBtn2.onclick = function () {
    myModal2.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span2.onclick = function () {
    myModal2.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function () {
    if (event.target == myModal2) {
        myModal2.style.display = "none";
    }
} 