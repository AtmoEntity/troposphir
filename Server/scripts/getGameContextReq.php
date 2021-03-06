
<?php
/*==============================================================================
  Troposphir - Part of the Troposphir Project
  Copyright (C) 2013  Troposphir Development Team
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
class getGameContextReq extends RequestResponse {
	public function work($json) {
        $cust_levels = array(
            928, // Untitled by freekboy31
            931, // Dreamland by Baufritz
            975  // Cirrus by zardini123
        );
        
        $cust_level = $cust_levels[rand(0, count($cust_levels)-1)];
        
		$this->addBody('assetEndpoint', $this->config['site'] . $this->config['dir_assets']);
		$this->addBody('mailboxEndpoint', "");
		$this->addBody('friendsUrl', "");
		$this->addBody('masterServerHost', $this->config['site']);
		$this->addBody('masterServerPort', 80);
		$this->addBody('natFacilitatorPort', 0);
		$this->addBody('redCarpetTutorialLevelId', $cust_level);
		$this->addBody('charCustLevelId', $cust_level);
		$this->addBody('levelBrowserLevelId', $cust_level);
		$this->addBody('tutorialUserId', 0);
		$this->addBody('unityBundleUrl', "");
		$this->addBody('staticImagesUrl', $this->config['site'] . $this->config['dir_imgs']);
		$this->addBody('staticMapUrl', $this->config['site'] . $this->config['dir_maps']);
		$this->addBody('staticAvatarUrl', $this->config['site'] . $this->config['dir_avatars']);
	}
}
?>
