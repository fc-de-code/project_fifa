// Get the modal
var login_modal = document.getElementById('popup');
// Get the button that opens the modal
var btn = document.getElementById("open");
// Get the <span> element that closes the modal
var span = document.getElementsByClassName("login-close")[0];
// When the user clicks on the button, open the modal
btn.onclick = function() {
    login_modal.style.display = "block";
}
// When the user clicks on <span> (x), close the modal
span.onclick = function() {
    login_modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close it
login_modal.onclick = function(event) {
  if (login_modal.style.display == "block")
  {
    if (event.target == login_modal) {
        login_modal.style.display = "none";
    }
  }
}
