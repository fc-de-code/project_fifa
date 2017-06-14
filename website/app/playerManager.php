<?php
session_start();
require 'init.php';

if ($_SERVER['REQUEST_METHOD'] == 'GET')
{
    session_destroy();
    header("location:" . $_SERVER['HTTP_REFERER']);
}

$studentID = $_POST['studentID'];
$firstName = $_POST['firstName'];
$lastName = $_POST['lastName'];
$teamSelect = $_POST['teamSelect'];

$dataValidate = new DataValidator($db);

$user = $dataValidate->PlayerValidator($studentID, $firstName, $lastName , $teamSelect);

if ($dataValidate->PlayerValidator($studentID, $firstName, $lastName , $teamSelect) == true)
{
    $sql= "INSERT INTO `tbl_players` (`student_id` ,`team_id` ,`first_name`, `last_name`) VALUES ('$studentID' ,'$teamSelect' ,'$firstName' ,'$lastName')";
    $db->query($sql);
}
header("location:" . $_SERVER['HTTP_REFERER']);

