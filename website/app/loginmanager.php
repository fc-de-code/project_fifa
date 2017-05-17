<?php
session_start();
require 'init.php';

if ($_SERVER['REQUEST_METHOD'] == 'GET')
{
    session_destroy();
    header("location: ../public/index.php");
}

$username = $_POST['username'];
$password = $_POST['password'];
$DataValidator = new DataValidator($db);

$user = $DataValidator->LoginValidator($username, $password);

if ($user)
{
    if ($DataValidator->IsAdmin($user))
    {
        $_SESSION['admin'] = true;
    }
    else
    {
        $_SESSION['admin'] = false;
    }

    $_SESSION['user'] = $user['user'];
}
else
{
    $msg = 'JOUW MOEDER HEEFT KK EN JOUW PASSWORD IS SLECHT EN JOUW NAAM IS NOCH SLECHTER';
}


header("location: ../public/index.php?msg=$msg");
