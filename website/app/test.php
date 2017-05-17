<?php
require 'init.php';


$team = new TeamCollection($db);

$arr_teams = $team->GetTeams();
echo "<pre>";
var_dump($arr_teams);
echo "</pre>";