<?php require(realpath(__DIR__) . '/templates/header.php');
    $Match = new \app\MatchCollection($db);
    $team = new \app\TeamCollection($db);
    ?>

<?php require_once '../app/init.php' ?>
    <div class="main_content">
      <div class="hero">
        <div class="wrapper">
          <h2>Finales</h2>
        </div>
      </div>

    <?php require(realpath(__DIR__) . '/templates/navigatie.php'); ?>
    <div class="wrapper">
        <?php
          $match = new \app\MatchCollection($db);

        echo '<table class="table">
                    <thead>
                    <tr>
                        <th>Team A</th>
                        <th>Team B</th>
                    </tr>
                    </thead>
                    <tbody>
                    ';

          foreach ($match->GetMatch() as $matches)
          {

              echo "<tr>";
              echo "<th>".$team->GetTeamById($matches ['team_id_a'])['name'] ."</th>";
              echo "<th> VS</th>";
              echo "<th>".$team->GetTeamById($matches ['team_id_b'])['name'] ."</th>";
              echo "</tr>";
          }

          echo '</tbody>
                </table>'
        ?>
        </div>
    <?php require(realpath(__DIR__) . '/templates/footer-content.php'); ?>

    </div>
<?php require(realpath(__DIR__) . '/templates/footer.php');
