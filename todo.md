# TODO
## Currently working on
### Player
* compare Player animation states (DoomInfo.States) with Heretic source
### Enemy
#### Imp
* check impchunk velocity 
* Ranged attack = check fireball speed (mobj2flags)
### Weapon
#### Goldenwand
* change AmmoType from clip
* replace Pistol reference with Goldenwand
### Pickups
* Yellow Key -> check if everthing is there 
### GameLogic
#### Mobj2Flags
* added class Mobj2Flags and started implementing the ones already referenced by mobjinfos
    * FootClip & FeetAreClipped started
        * added in trymove and project vissprite
        * check other usages to continue
### UI
#### Menu
#### StatusBar
#### Automap


## To Be Done
* Almost everthing:)
### Enemy
* All enemies except for imp
### Weapon
* All Weapons except for Goldenwand (default weapon)
### GameLogic
* HitScan.SpawnPuff needs to support different puff types (currently hardcode to GoldenwandPuff)
* HitScan.ShootTraverse: Special Handling for MT_BLASTERPUFF1 and P_BloodSplatter
### UI
#### Menu
#### StatusBar
#### Automap
