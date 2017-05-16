
<nav>
  <div class="navigation">
    <ul>
      <li><a href="index.php">HOME</a></li>
      <li><a href="finales.php">FINALES</a></li>
      <li><a href="resultaat.php">RESULTAAT</a></li>
      <li><a href="teams.php">TEAMS</a></li>
    </ul>
    <a id="open">LOGIN</a>
  </div>
  <div id="popup" class="login">
    <div class="loginwindow">
      <div class="loginheader">
        <h3>login</h3>
        <span class="close">&times;</span>
      </div>
      <form action="../app/loginmanager.php" method="post">
        <label for="username">Username</label>
        <input type="text" placeholder="Enter Username" name="username" id="username" required>
        <label for="password">Password</label>
        <input type="password" placeholder="Enter Password" name="password" id="password" required>
        <button type="submit" value="Submit">Login</button>
      </form>
    </div>
  </div>
  <script src="js/loginpopup.js"></script>
</nav>
