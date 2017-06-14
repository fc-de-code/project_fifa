<div id="team-add" class="team-add">
  <div class="teamAddWindow">
    <div class="teamAddHeader">
      <h3>Add Team</h3>
      <span class="teamadd-close">&times;</span>
    </div>
    <form action="../app/teamManager.php" method="post">
      <label for="teamName">Team Name:</label>
      <input type="text" placeholder="Enter Team Name" name="teamName" id="teamName" required>
      <label for="playerAmount">PlayerAmount</label>
      <input type="number" value="1" min="1" max="5" name="playerAmount" id="playerAmount" required>
      <label for="teamDescription">Description:</label>
      <textarea type="text" maxlength="255" placeholder="enter Description" name="teamDescription" id="teamDescription"  rows="8" cols="80"></textarea>
      <button type="submit" value="Submit">Add-Team</button>
    </form>
  </div>
</div>

