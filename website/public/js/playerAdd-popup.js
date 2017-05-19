// gets the modal that you wanna open
var player_modal = document.getElementById('player-add');
// Get the button that opens the modal
var player_btn = document.getElementById("open-player-modal");
// Get the <span> element that closes the modal
var player_span = document.getElementsByClassName("playeradd-close")[0];
// When the user clicks on the button, open the modal
player_btn.onclick = function() {
    player_modal.style.display = "block";
}
// When the user clicks on <span> (x), close the modal
player_span.onclick = function() {
    player_modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close it
player_modal.onclick = function(event) {
      if (player_modal.style.display == "block")
      {
        if (event.target == player_modal) {
            player_modal.style.display = "none";
        }
      }
}
