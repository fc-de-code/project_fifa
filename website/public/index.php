<?php require(realpath(__DIR__) . '/templates/header.php'); ?>


    <div class="main-content">
      <div class="hero">
        <div class="wrapper">
          <h1 class="text-align">RADIUS</h1>
          <img src="img/LogoTest.png" alt="logo-test">
          <h1>FIFA</h1>
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
          <h2>Introductie</h2>
          <div class="content">
            <p>
              hallo en welkom op de radius fifa site.
              deze site is gemaakt voor het berekenen en bijhouden van wedstrijden voor het voetballen, hierbij is ook een applicatie te downloaden om te gokken op de teams die spelen. op de site wordend de wedstrijden gemaakt en de scores bij gehouden, en in de applicatie kan je gokken op welk team er volgens jou gaat winnen.
            </p>
            <p>
              Op deze website kan je via het navigatie menu naar verschillen web pagina's gaan.
              Op dit moment zijn wij op de home pagina, hier vindt je de introductie die u nu aan het lezen ben maar ook de totaal score van alle team die zich geregistreert hebben.
              Op de finale pagina vind u de wedstrijden die gespeelt gaan worden.
              Op de resultaaten pagina vind u de uitslagen per wedstrijden die er gespeeld zijn.
              Op de teams pagin vind u alle teams die op deze site geregistreert zijn.
            </p>
          </div>
        </div>
      </div>
      <div class="team-score">
        <div class="wrapper">
          <h2>Teams Score</h2>
          <div class="content">
            <div class="team-list">
              <ul>
                <li>team1</li>
                <li>team2</li>
                <li>team3</li>
                <li>team4</li>
                <li>team5</li>
                <li>team6</li>
                <li>team7</li>
                <li>team8</li>
                <li>team9</li>
                <li>team10</li>
                <li>team11</li>
                <li>team12</li>
                <li>team13</li>
                <li>team14</li>
                <li>team15</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
      <footer>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
      </footer>
    </div>

    <script src="js/loginpopup.js"></script>

<?php require(realpath(__DIR__) . '/templates/footer.php');
