<?php require(realpath(__DIR__) . '/templates/header.php'); ?>


    <div class="main-content">
      <div class="hero">
        <div class="wrapper">
          <h1>fifa dev edition</h1>
        </div>
      </div>
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
      </nav>

      <div id="popup" class="login">
        <div class="loginwindow">
          <div class="loginheader">
            <h3>login</h3>
            <span class="close">&times;</span>
          </div>
          <form action="../loginmanager.php" method="post">
            <label for="Username">Username</label>
            <input type="text" placeholder="Enter Username" name="Username" id="username" required>
            <label for="password">Password</label>
            <input type="password" placeholder="Enter Password" name="password" id="password" required>
            <button type="submit" value="Submit">Login</button>
          </form>
        </div>
      </div>
      <div class="introwebsite">
        <div class="wrapper">

        </div>
      </div>
      <div class="updates">
        <div class="wrapper">

        </div>
      </div>
    </div>

    <script src="js/loginpopup.js"></script>

<?php require(realpath(__DIR__) . '/templates/footer.php');
