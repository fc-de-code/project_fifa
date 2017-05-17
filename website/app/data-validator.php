<?php

require 'init.php';

class DataValidator
{
    private $db;

    public function __Construct($db)
    {
        $this->db = $db;
    }

    public function LoginValidator($username, $password)
    {
        $sql = "SELECT * FROM `tbl_users` WHERE `user` = '$username' AND `password` = '$password'";
        $user = $this->db->query($sql)->fetch(PDO::FETCH_ASSOC);
        if($user)
        {
            return $user;
        }

        return false;
    }

    public function IsAdmin($user)
    {
        if ($user == false)
        {
            return false;
        }
        if ($user['admin'] == 1)
        {
            return true;
        }
    }



}

