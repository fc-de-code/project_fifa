<div id="player-add" class="player-add">
  <div class="playerAddWindow">
    <div class="playerAddHeader">
      <h3>Add Player</h3>
      <span class="playeradd-close">&times;</span>
    </div>
    <form action="../app/playermanager.php" method="post">
      <label for="studentID">student ID:</label>
      <input type="text" placeholder="Enter student ID" name="studentID" id="studentID" required>
      <label for="firstName">First Name:</label>
      <input type="text" name="firstName" placeholder="enter your first name:" id="firstName" required>
      <label for="lastName:">last Name:</label>
      <input type="text" name="lastName" id="lastname" placeholder="enter your lastname" required="">
      <label for="teamSelect">select your team:</label>

      <!-- <input type="o" name="teamSelect" required> -->
      <select name="teamSelect" id="teamSelect" class="se"  placeholder="Select your team">
          <?php
          require_once (realpath(__DIR__) . '/../../app/init.php');
          $team = new \App\TeamCollection($db);
          foreach ($team->GetTeams()as $team)
          {
              echo "<option value='".$team['id']."'>".$team['id'].".".$team['name']."</option>";
          }
          ?>
      </select>
      <button type="submit" value="Submit">Add-Player</button>
    </form>
  </div>
</div>
