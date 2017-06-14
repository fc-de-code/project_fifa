<?php
require 'init.php';


if ($_SERVER['REQUEST_METHOD'] == 'GET')
{
    session_destroy();
    header("location: ../public/teams.php");
}

$teamName = $_POST['teamName'];
$playerAmount = $_POST['playerAmount'];
$teamDescription = $_POST['teamDescription'];

$dataValidate = new DataValidator($db);
$user = $dataValidate->TeamValidator($teamName , $playerAmount);

if ($dataValidate->TeamValidator($teamName , $playerAmount) == true)
{
    $sql= "INSERT INTO `tbl_teams` (`name` ,`player_amount`) VALUES ('$teamName','$playerAmount')";
    $db->query($sql);
}

header("location: ../public/teams.php");
