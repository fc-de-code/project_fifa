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

    public function TeamValidator($teamName, $playerAmount)
    {
        if(empty($teamName) == true || ($playerAmount ==0 || $playerAmount >5) )
        {
            $msg = "teamName and playerAmount is required";
            return false;
        }
        elseif (empty($teamName) == false && ($playerAmount =1 || $playerAmount <=5))
        {
            return true;
        }
    }

    public function PlayerValidator($student_id, $firstName, $LastName, $TeamId)
    {
        if (empty($student_id ) || empty($firstName) || empty($LastName))
        {
            $msg = "please fill in the field in order to continue";
            return false;
        }
        if (isset($TeamId)== null)
        {
            $msg = "please fill in the field in order to continue";
            return false;
        }
        else
        {
            return true;
        }
    }


}

