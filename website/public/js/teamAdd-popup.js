// Get the modal
var team_modal = document.getElementById('team-add');
// Get the button that opens the modal
var team_btn = document.getElementById("open-team-modal");
// Get the <span> element that closes the modal
var team_span = document.getElementsByClassName("teamadd-close")[0];
// When the user clicks on the button, open the modal
team_btn.onclick = function() {
    team_modal.style.display = "block";
}
// When the user clicks on <span> (x), close the modal
team_span.onclick = function() {
    team_modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close it
team_modal.onclick = function(event) {
      if (team_modal.style.display == "block")
      {
        if (event.target == team_modal) {
            team_modal.style.display = "none";
        }
      }
}
