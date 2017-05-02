<?php
$server = 'localhost';
$username = 'root';
$password = 'welkom1';
$database = 'todo';

try{
  $conn = new PDO("mysql:host=$server;dbname=$database", $username, $password);
}catch(PDOException $e){
  die("connection failed:" . $e->getMessage());
}
?>
