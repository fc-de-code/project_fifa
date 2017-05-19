
<div id="player-add" class="player-add">
  <div class="playerAddWindow">
    <div class="playerAddHeader">
      <h3>Add Player</h3>
      <span class="playeradd-close">&times;</span>
    </div>
    <form action="../app/playerCollection.php" method="post">
      <label for="studentID">student ID:</label>
      <input type="text" placeholder="Enter student ID" name="studentID" id="studentID" required>
      <label for="firstName">First Name:</label>
      <input type="text"name="playeramount" id="firstName" required>
      <label for="lastName:">last Name:</label>
      <input type="text"name="lastName" id="lastname" placeholder="enter your lastname">
      <label for="teamSelect">select your team:</label>
      <!-- <input type="o" name="teamSelect" required> -->
      <select class="se" name="">
        <option value="">jhyggyu </option>
        <option value="">jhyggyu </option>
      </select>
      <button type="submit" value="Submit">Add-Team</button>
    </form>
  </div>
</div>
