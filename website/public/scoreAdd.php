<?php require(realpath(__DIR__) . '/templates/header.php');?>
<div class="hero">
  <div class="wrapper">
    <h2>Score toevoegen</h2>
</div>
<?php require(realpath(__DIR__) . '/templates/navigatie.php'); ?>
<div class="wrapper">
  <div class="content">
    <div class="add-score">
      <form class="MatchSelection" action="" method="Post">
        <label for="matchSelect">Selecteer wedstrijd</label>
        <select name="matchSelect" id="matchSelect" class="se" placeholder="select match please">
        <?php
        $Match = new \app\MatchCollection($db);
        $team = new \app\TeamCollection($db);
        foreach ($Match->GetMatch() as $match)
        {
            echo '<option value="'.$match['id'].'">'.$team->GetTeamById($match ['team_id_a'])['name'] .' vs '.$team->GetTeamById($match ['team_id_b'])['name'].'</option>';
        }

         ?>
        </select>
          <button type="submit">Selecteer</button>
      </form>
        <form class="scoreInput" action="../app/Score_manager.php" method="post">
        <?php
        if(isset($_POST['matchSelect']))
        {
            $arr_match = $Match->GetMatchById($_POST['matchSelect']);
            echo '<label  for="score_a">'.$team->GetTeamById($arr_match ['team_id_a'])['name'] .'</label>';
            echo '<input type="hidden" id="">';
            echo'<input type="number" name="score_a" required="">';
            echo'<input type="number" name="score_b" required="">';           
            echo '<label  for="Score_b">'.$team->GetTeamById($arr_match ['team_id_b'])['name'] .'</label>
            <input type="text" name="match_id" value="'.$_POST['matchSelect'].'" hidden>
            <button type="submit" name="submit">Verzend uitslag</button>
            ';
        }
        ?>

        </form>
    </div>
  </div>
</div>


<?php require(realpath(__DIR__) . '/templates/footer-content.php');
require(realpath(__DIR__) . '/templates/footer.php');?>
