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
      <input type="number" placeholder="Enter Team Size" name="players" id="players" required>
      <label for="description">Description:</label>
      <input type="text" size="255" placeholder="enter Description">
      <button type="submit" value="Submit">Add-Team</button>
    </form>
  </div>
</div>
