<?php
namespace app;

use \PDO;
class PouleCollection
{

    private $db;
    private $poules;

    public function __construct($db)
    {
        $this->db = $db;
        $sql = "SELECT * FROM `tbl_poules`";
        $this->poules = $this->db->query($sql)->fetchAll(PDO::FETCH_ASSOC);
    }

    public function NumberOfTeamInPoul($poule_id)
    {
        $teamCollection = new TeamCollection($this->db);
        return count($teamCollection->GetTeamByPouleId($poule_id));
    }

    public function GetPoules()
    {
        return $this->poules;
    }
}