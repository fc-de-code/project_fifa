<?php


namespace app;

use \PDO;
class PlayerCollection
{
    private $db;
    private $players;

    public function __construct($db)
    {
        $this->db = $db;
        $sql = "SELECT * FROM `tbl_players`";
        $this->players = $this->db->query($sql)->fetchAll(PDO::FETCH_ASSOC);
    }

    public function GetPlayerCollectionByTeamId($teamId)
    {
        $arr_players = array();
        foreach($this->GetPlayers() as $player)
        {
            if ($player ['team_id'] == $teamId)
            {
                array_push($arr_players, $player);
            }
        }
        return $arr_players;
    }

    public function GetPlayers()
    {
        return $this->players;
    }
}