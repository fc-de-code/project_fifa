<?php
require 'init.php';

$derp = new \app\MatchCollection($db);

$derp->MakePoulMatchesByPoulId(1,'12:00','00:15');