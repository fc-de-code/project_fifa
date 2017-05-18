<div id="team-add" class="team-add">
  <div class="teamAddWindow">
    <div class="teamAddHeader">
      <h3>Add Team</h3>
      <span class="teamadd-close">&times;</span>
    </div>
    <form action="../app/addTeam.php" method="post">
      <label for="team">Team Name:</label>
      <input type="text" placeholder="Enter Team Name" name="team" id="team" required>
      <label for="players">PlayerAmount</label>
      <input type="number" value="1" min="1" max="5" name="players" id="players" required>
      <label for="description">Description:</label>
      <textarea type="text" maxlength="255" placeholder="enter Description" name="desciption" rows="8" cols="80"></textarea>
      <button type="submit" value="Submit">Add-Team</button>
    </form>
  </div>
</div>
//
