<?php require(realpath(__DIR__) . '/templates/header.php'); ?>


    <div class="main-content">
      <div class="hero">
        <div class="wrapper">
          <h1 class="text-align">RADIUS</h1>
          <img src="img/LogoTest.png" alt="logo-test">
          <h1>FIFA</h1>
        </div>
      </div>
      <?php require(realpath(__DIR__) . '/templates/navigatie.php'); ?>
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
                <?php
                  require_once (realpath(__DIR__) . '/../app/init.php');
                  $team = new \App\TeamCollection($db);
                  foreach ($team->GetTeams()as $team)
                  {
                      echo "<li>".$team['id'].".".$team['name']."</li>";
                  }
                  ?>
              </ul>
            </div>
          </div>
        </div>
      </div>
      <?php require(realpath(__DIR__) . '/templates/footer-content.php'); ?>
    </div>
    
<?php require(realpath(__DIR__) . '/templates/footer.php');
