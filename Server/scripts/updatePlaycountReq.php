<?php
/*==============================================================================
  Troposphir - Part of the Troposphir Project
  Copyright (C) 2013  Kevin Sonoda, Leonardo Giovanni Scur

  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU Affero General Public License as
  published by the Free Software Foundation, either version 3 of the
  License, or (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU Affero General Public License for more details.

  You should have received a copy of the GNU Affero General Public License 
  along with this program.  If not, see <http://www.gnu.org/licenses/>.    
==============================================================================*/
if (!defined("INCLUDE_SCRIPT")) return;
class updatePlaycountReq extends RequestResponse {
	public function work($json) {
		if (!isset($json['body']['levelId'])) return;

		$db = $this->getConnection();
	
		//Update level data id
		// $stmt = $db->prepare("UPDATE `" . $this->config['table_map'] . "` 
		// 	SET `dc`=`dc`+1 
		// 	WHERE `id`=:levelId");		
		// $stmt->bindValue(':levelId', $json['body']['levelId'], PDO::PARAM_INT);
		// $stmt->execute();            
	}
}
?>