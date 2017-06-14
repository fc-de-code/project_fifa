<?php

namespace app;

use \PDO;

class MatchCollection
{
    private $db;
    private $Matches;

    public function __construct($db)
    {
        $this->db = $db;
        $sql = "SELECT * FROM `tbl_matches`";
        $this->Matches = $this->db->query($sql)->fetchAll(PDO::FETCH_ASSOC);
    }

    public function GetMatch()
    {
        return $this->Matches;
    }

    public function GetMatchById($match_id)
    {
        foreach ($this->GetMatch() as $match)
        {
            if($match['id'] == $match_id)
            {
                return $match;
            }
        }
        return null;
    }

    public function ScoreUpdate($match_id, $Score_a, $Score_b)
    {
        $sql = "UPDATE `tbl_matches` SET `score_team_a` = '$Score_a', `score_team_b`= '$Score_b' WHERE `id` = '$match_id';";
        $this->Matches = $this->db->query($sql);
    }

    public function MakePoulMatchesByPoulId($poule_id, $start_time, $duration_time)
    {
        $time_start = strtotime($start_time);
        $count = 0;

        $teams = new TeamCollection($this->db);
        $arr_teams = $teams->GetTeamByPouleId($poule_id);
        $arr_teams_id = array();



        foreach ($arr_teams as $team)
        {

            array_push($arr_teams_id, $team['id']);
        }

        $arr_size = sizeof($arr_teams_id) ;

        for ($i = 0; $i <= $arr_size - 1; $i++)
        {
            for ($c = $i+1; $c <= $arr_size - 1; $c++)
            {
                if ($i != $c)
                {
                    if ($count == 0)
                    {
                        $time = $time_start;
                    }
                    else{
                        $time_start = strtotime("+".substr($duration_time, 0, 2)." hour".substr($duration_time,-2)." minutes", $time_start);
                        $time = $time_start;
                    }

                    $time = date('G:i', $time);

                    $sql = "INSERT INTO `project_fifa`.`tbl_matches` (`id`, `team_id_a`, `team_id_b`, `score_team_a`, `score_team_b`, `start_time`) VALUES (NULL, '$arr_teams_id[$i]', '$arr_teams_id[$c]', NULL, NULL, '$time');";
                    $this->db->query($sql);
                    $count++;
                }

            }
        }
    }
}