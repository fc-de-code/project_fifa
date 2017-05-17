<?php
namespace App;

class TeamCollection
{
    private $db;
    private $teams;

    public function __construct($db)
    {
        $this->db = $db;
        $sql = "SELECT * FROM `tbl_teams`";
        $this->teams = $this->db->query($sql)->fetchAll(PDO::FETCH_ASSOC);
    }

    public function GetTeams()
    {
        return $this->teams;
    }

}