<?php
namespace app;

use \PDO;
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

    public function SetPoule($teamId)
    {
        $arr_poules = array();
        $poule = new PouleCollection($this->db);
        foreach ($poule->GetPoules() as $poulee)
        {
            $arr_poule = array('id' => $poulee['id'], 'teamscount' => $poule->NumberOfTeamInPoul($poulee['id']));
            array_push($arr_poules , $arr_poule);

        }
        $min = array_reduce($arr_poules , function ($result , $item)
        {
            if (!isset($result))
            {
                $result = $item;
            }
            if ($result['teamscount'] > $item['teamscount'])
            {
                $result = $item;
            }

            return $result;
        });
        return $min['id'];
    }
    public function GetTeamByPouleId($poule_id)
    {
        $arr_teams = array();
        foreach ($this->GetTeams() as $team)
        {
            if ($team['poule_id'] == $poule_id)
            {
                array_push($arr_teams, $team);
            }
        }
        return $arr_teams;
    }
    public  function GetTeamById($Team_id)
    {
        foreach ($this->GetTeams() as $team)
        {
            if($team['id'] == $Team_id)
            {
                return $team;
            }
        }
        return null;
    }

}


