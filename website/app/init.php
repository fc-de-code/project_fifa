<?php
require_once __DIR__ . '/db-connection.php';
require_once __DIR__ . '/TeamCollection.php';
require_once  __DIR__ . '/data-validator.php';
require_once __DIR__ . '/PlayerCollection.php';
require_once __DIR__ . '/PouleCollection.php';
require_once __DIR__ . '/MatchCollection.php';

$PDO = new database('localhost', 'project_fifa', 'root','');
$db = $PDO->connect();
