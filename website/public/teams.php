<?php require(realpath(__DIR__) . '/templates/header.php'); ?>

    <div class="main_content">
      <div class="hero">
        <div class="wrapper">
          <h2>Teams</h2>
        </div>
      </div>
    <?php require(realpath(__DIR__) . '/templates/navigatie.php'); ?>
    <div class="wrapper">
      <div class="teams">
        <div id="open-team-modal" class="teamadd-button">
          <h3>Add-Team</h3>
          <span>+</span>
        </div>
        <div id="open-player-modal" class="playeradd-button">
          <h3>Add-Player</h3>
          <span>+</span>
        </div>
      </div>


    </div>
    <?php require(realpath(__DIR__) . '/templates/team-add.php'); ?>
    <?php require(realpath(__DIR__) . '/templates/player-add.php'); ?>
    <?php require(realpath(__DIR__) . '/templates/footer-content.php'); ?>
    </div>

<?php require(realpath(__DIR__) . '/templates/footer.php');
//bycrypt
