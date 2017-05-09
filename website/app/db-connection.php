<?php
class connection
{
  protected $connection_db_link;
  public $db_user = 'root';
  public $db_host = 'localhost';
  public $db_name = 'project_fifa';
  public $db_pass = '';

  function db_connect()
  {
    try {
      $this->connection_db_link = new PDO("mysql:host=$this->db_host;$this->db_name",$this->db_user,$this->db_pass);
      $this->connection_db_link->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
      return $this->connection_db_link;
    } catch (Exception $e) {
      echo $e->getMessage();
    }

  }
  function display_connection()
  {
    if ($this->connection_db_link == true)
    {
      echo 'connection succes';
    }
  }
}
$users = new connection;
$users->db_connect();
$users->display_connection();
 ?>
