
<nav>
  <div class="navigation">
    <ul>
      <li><a href="index.php">HOME</a></li>
      <li><a href="finales.php">FINALES</a></li>
      <li><a href="resultaat.php">RESULTAAT</a></li>
      <li><a href="teams.php">TEAMS</a></li>
      <?php
      if (isset($_SESSION['admin']))
      {
        echo '<li><a href="scoreAdd.php">UITSLAGEN INVOEREN</li>';
      }
       ?>
    </ul>
    <a <?php

    if (isset($_SESSION['admin']))
    {
        echo 'href="../app/loginManager.php"';
    }
    else
    {
        echo 'id="open"';
    }
        ?>>
        <?php
        if (isset($_SESSION['admin']))
        {
            echo "LOGOUT";
        }
        else
            echo "LOGIN";
        ?></a>
  </div>
  <div id="popup" class="login">
    <div class="loginwindow">
      <div class="loginheader">
        <h3>login</h3>
        <span class="login-close">&times;</span>
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

</nav>
