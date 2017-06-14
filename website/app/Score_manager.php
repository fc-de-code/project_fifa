<?php
require_once 'init.php';



$match_id = $_POST['match_id'];
$score_a = $_POST['score_a'];
$score_b =$_POST['score_b'];

var_dump($_POST);

$dataValidate = new DataValidator($db);
$matchCollection = new \app\MatchCollection($db);

    if (!empty($match_id) || !empty($score_a) || !empty($score_b))
    {
        $matchCollection->ScoreUpdate($match_id , $score_a, $score_b);
    }
header("location:" . $_SERVER['HTTP_REFERER']);


