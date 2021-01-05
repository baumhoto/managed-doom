﻿//
// Copyright (C) 1993-1996 Id Software, Inc.
// Copyright (C) 2019-2020 Nobuaki Tanaka
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//



using System;

namespace ManagedDoom
{
    public static partial class DoomInfo
    {
        private static PlayerActions pa = new PlayerActions();
        private static MobjActions ma = new MobjActions();

        public static readonly MobjStateDef[] States = new MobjStateDef[]
        {
            new MobjStateDef(0, Sprite.PUF3, 0, -1, null, null, MobjState.Null, 0, 0), // State.Null
            new MobjStateDef(1, Sprite.PLAY, 0, -1, null, null, MobjState.Null, 0, 0), // State.Play
            new MobjStateDef(2, Sprite.PLAY, 0, 4, null, null, MobjState.PlayRun2, 0, 0), // State.PlayRun1
            new MobjStateDef(3, Sprite.PLAY, 1, 4, null, null, MobjState.PlayRun3, 0, 0), // State.PlayRun2
            new MobjStateDef(4, Sprite.PLAY, 2, 4, null, null, MobjState.PlayRun4, 0, 0), // State.PlayRun3
            new MobjStateDef(5, Sprite.PLAY, 3, 4, null, null, MobjState.PlayRun1, 0, 0), // State.PlayRun4
            new MobjStateDef(6, Sprite.PLAY, 4, 12, null, null, MobjState.Play, 0, 0), // State.PlayAtk1
            new MobjStateDef(7, Sprite.PLAY, 32773, 6, null, null, MobjState.PlayAtk1, 0, 0), // State.PlayAtk2
            new MobjStateDef(8, Sprite.PLAY, 6, 4, null, null, MobjState.PlayPain2, 0, 0), // State.PlayPain
            new MobjStateDef(9, Sprite.PLAY, 6, 4, null, ma.Pain, MobjState.Play, 0, 0), // State.PlayPain2
            new MobjStateDef(10, Sprite.PLAY, 7, 10, null, null, MobjState.PlayDie2, 0, 0), // State.PlayDie1
            new MobjStateDef(11, Sprite.PLAY, 8, 10, null, ma.PlayerScream, MobjState.PlayDie3, 0, 0), // State.PlayDie2
            new MobjStateDef(12, Sprite.PLAY, 9, 10, null, ma.Fall, MobjState.PlayDie4, 0, 0), // State.PlayDie3
            new MobjStateDef(13, Sprite.PLAY, 10, 10, null, null, MobjState.PlayDie5, 0, 0), // State.PlayDie4
            new MobjStateDef(14, Sprite.PLAY, 11, 10, null, null, MobjState.PlayDie6, 0, 0), // State.PlayDie5
            new MobjStateDef(15, Sprite.PLAY, 12, 10, null, null, MobjState.PlayDie7, 0, 0), // State.PlayDie6
            new MobjStateDef(16, Sprite.PLAY, 13, -1, null, null, MobjState.Null, 0, 0), // State.PlayDie7
            new MobjStateDef(17, Sprite.PLAY, 14, 5, null, null, MobjState.PlayXdie2, 0, 0), // State.PlayXdie1
            new MobjStateDef(18, Sprite.PLAY, 15, 5, null, ma.XScream, MobjState.PlayXdie3, 0, 0), // State.PlayXdie2
            new MobjStateDef(19, Sprite.PLAY, 16, 5, null, ma.Fall, MobjState.PlayXdie4, 0, 0), // State.PlayXdie3
            new MobjStateDef(20, Sprite.PLAY, 17, 5, null, null, MobjState.PlayXdie5, 0, 0), // State.PlayXdie4
            new MobjStateDef(21, Sprite.PLAY, 18, 5, null, null, MobjState.PlayXdie6, 0, 0), // State.PlayXdie5
            new MobjStateDef(22, Sprite.PLAY, 19, 5, null, null, MobjState.PlayXdie7, 0, 0), // State.PlayXdie6
            new MobjStateDef(23, Sprite.PLAY, 20, 5, null, null, MobjState.PlayXdie8, 0, 0), // State.PlayXdie7
            new MobjStateDef(24, Sprite.PLAY, 21, 5, null, null, MobjState.PlayXdie9, 0, 0), // State.PlayXdie8
            new MobjStateDef(25, Sprite.PLAY, 22, -1, null, null, MobjState.Null, 0, 0), // State.PlayXdie9
            new MobjStateDef(26, Sprite.CKYY, 32768, 3, null, null, MobjState.Ykyy2, 0, 0), // State.Ykey
            new MobjStateDef(27, Sprite.CKYY, 32769, 3, null, null, MobjState.Ykyy3, 0, 0), // State.Ykey2
            new MobjStateDef(28, Sprite.CKYY, 32770, 3, null, null, MobjState.Ykyy4, 0, 0), // State.Ykey3
            new MobjStateDef(29, Sprite.CKYY, 32771, 3, null, null, MobjState.Ykyy5, 0, 0), // State.Ykey4
            new MobjStateDef(30, Sprite.CKYY, 32772, 3, null, null, MobjState.Ykyy6, 0, 0), // State.Ykey5
            new MobjStateDef(31, Sprite.CKYY, 32773, 3, null, null, MobjState.Ykyy7, 0, 0), // State.Ykey6
            new MobjStateDef(32, Sprite.CKYY, 32774, 3, null, null, MobjState.Ykyy8, 0, 0), // State.Ykey7
            new MobjStateDef(33, Sprite.CKYY, 32775, 3, null, null, MobjState.Ykyy9, 0, 0), // State.Ykey8
            new MobjStateDef(34, Sprite.CKYY, 32776, 3, null, null, MobjState.Ykyy, 0, 0), // State.Ykey9
            new MobjStateDef(35, Sprite.GWND, 0, 1, pa.WeaponReady, null, MobjState.GoldwandReady, 0, 0), // State.GoldwandReady
            new MobjStateDef(36, Sprite.GWND, 0, 1, pa.Lower, null, MobjState.GoldwandDown, 0, 0), // State.GoldwandDown
            new MobjStateDef(37, Sprite.GWND, 0, 1, pa.Raise, null, MobjState.GoldwandUp, 0, 0), // State.GoldwandUp
            new MobjStateDef(38, Sprite.GWND, 1, 3, null, null, MobjState.GoldwandAtk1_2, 0, 0), // State.Pistol1
            new MobjStateDef(39, Sprite.GWND, 2, 5, pa.FireGoldwand, null, MobjState.GoldwandAtk1_3, 0, 0), // State.Pistol1
            new MobjStateDef(40, Sprite.GWND, 3, 3, null, null, MobjState.GoldwandAtk1_4, 0, 0), // State.Pistol1
            new MobjStateDef(41, Sprite.GWND, 3, 0, pa.ReFire, null, MobjState.GoldwandReady, 0, 0), // State.Pistol1
            new MobjStateDef(42, Sprite.GWND, 1, 3, null, null, MobjState.GoldwandAtk2_2, 0, 0), // State.Pistol1
            new MobjStateDef(43, Sprite.GWND, 2, 4, pa.FireGoldwand, null, MobjState.GoldwandAtk2_3, 0, 0), //* FireGoldwandPL2 needs to be added (multiplayer only?)
            new MobjStateDef(44, Sprite.GWND, 3, 3, null, null, MobjState.GoldwandAtk2_4, 0, 0), // State.Pistol1
            new MobjStateDef(45, Sprite.GWND, 3, 0, pa.ReFire, null, MobjState.GoldwandReady, 0, 0), // State.Pistol1
            new MobjStateDef(46, Sprite.PUF2, 32768, 3, null, null, MobjState.GwandPuff1_2, 0, 0), // State.Puf21
            new MobjStateDef(47, Sprite.PUF2, 32769, 3, null, null, MobjState.GwandPuff1_3, 0, 0), // State.Puf22
            new MobjStateDef(48, Sprite.PUF2, 32770, 3, null, null, MobjState.GwandPuff1_4, 0, 0), // State.Puf23
            new MobjStateDef(49, Sprite.PUF2, 32771, 3, null, null, MobjState.GwandPuff1_5, 0, 0), // State.Puf24
            new MobjStateDef(50, Sprite.PUF2, 32772, 3, null, null, MobjState.Null, 0, 0), // State.Puf24
            new MobjStateDef(51, Sprite.IMPX, 0, 10, null, ma.Look, MobjState.ImpLook2, 0, 0), // State.ImpLook1
            new MobjStateDef(52, Sprite.IMPX, 1, 10, null, ma.Look, MobjState.ImpLook3, 0, 0), // State.ImpLook2
            new MobjStateDef(53, Sprite.IMPX, 2, 10, null, ma.Look, MobjState.ImpLook4, 0, 0), // State.ImpLook3
            new MobjStateDef(54, Sprite.IMPX, 1, 10, null, ma.Look, MobjState.ImpLook1, 0, 0), // State.ImpLook3
            new MobjStateDef(55, Sprite.IMPX, 0, 3, null, ma.Chase, MobjState.ImpFly2, 0, 0), // State.ImpFly1
            new MobjStateDef(56, Sprite.IMPX, 0, 3, null, ma.Chase, MobjState.ImpFly3, 0, 0), // State.ImpFly2
            new MobjStateDef(57, Sprite.IMPX, 1, 3, null, ma.Chase, MobjState.ImpFly4, 0, 0), // State.ImpFly3
            new MobjStateDef(58, Sprite.IMPX, 1, 3, null, ma.Chase, MobjState.ImpFly5, 0, 0), // State.ImpFly4
            new MobjStateDef(59, Sprite.IMPX, 2, 3, null, ma.Chase, MobjState.ImpFly6, 0, 0), // State.ImpFly5
            new MobjStateDef(60, Sprite.IMPX, 2, 3, null, ma.Chase, MobjState.ImpFly7, 0, 0), // State.ImpFly6
            new MobjStateDef(61, Sprite.IMPX, 1, 3, null, ma.Chase, MobjState.ImpFly8, 0, 0), // State.ImpFly7
            new MobjStateDef(62, Sprite.IMPX, 1, 3, null, ma.Chase, MobjState.ImpFly1, 0, 0), // State.ImpFly8
            new MobjStateDef(63, Sprite.IMPX, 3, 6, null, ma.FaceTarget, MobjState.ImpMeatK2, 0, 0), // State.ImpMeatK1
            new MobjStateDef(64, Sprite.IMPX, 4, 6, null, ma.FaceTarget, MobjState.ImpMeatK3, 0, 0), // State.ImpMeatK2
            new MobjStateDef(65, Sprite.IMPX, 5, 6, null, ma.ImpMeAttack, MobjState.ImpFly1, 0, 0), // State.ImpMeatK3 
            new MobjStateDef(66, Sprite.IMPX, 0, 10, null, ma.FaceTarget, MobjState.ImpMsAtk1_2, 0, 0), // State.ImpMsAtk1_1
            new MobjStateDef(67, Sprite.IMPX, 1, 6, null, ma.ImpMsAttack, MobjState.ImpMsAtk1_3, 0, 0), // State.ImpMsAtk1_2
            new MobjStateDef(68, Sprite.IMPX, 2, 6, null, null, MobjState.ImpMsAtk1_4, 0, 0), // State.ImpMsAtk1_3
            new MobjStateDef(69, Sprite.IMPX, 1, 6, null, null, MobjState.ImpMsAtk1_5, 0, 0), // State.ImpMsAtk1_4
            new MobjStateDef(70, Sprite.IMPX, 0, 6, null, null, MobjState.ImpMsAtk1_6, 0, 0), // State.ImpMsAtk1_5
            new MobjStateDef(71, Sprite.IMPX, 1, 6, null, null, MobjState.ImpMsAtk1_3, 0, 0), // State.ImpMsAtk1_6
            new MobjStateDef(72, Sprite.IMPX, 3, 6, null, ma.FaceTarget, MobjState.ImpMsAtk2_2, 0, 0), // State.ImpMsAtk2_1
            new MobjStateDef(73, Sprite.IMPX, 4, 6, null, ma.FaceTarget, MobjState.ImpMsAtk2_3, 0, 0), // State.ImpMsAtk2_2
            new MobjStateDef(74, Sprite.IMPX, 5, 6, null, ma.ImpMsAttack2, MobjState.ImpFly1, 0, 0), // State.ImpMsAtk2_2
            new MobjStateDef(75, Sprite.IMPX, 6, 3, null, null, MobjState.ImpPain2, 0, 0), // State.ImpPain1
            new MobjStateDef(76, Sprite.IMPX, 6, 3, null, ma.Pain, MobjState.ImpFly1, 0, 0), // State.ImpPain2
            new MobjStateDef(77, Sprite.IMPX, 6, 4, null, ma.ImpDeath, MobjState.ImpDie2, 0, 0), // State.ImpDie1
            new MobjStateDef(78, Sprite.IMPX, 7, 5, null, null, MobjState.ImpDie2, 0, 0), // State.ImpDie2
            new MobjStateDef(79, Sprite.IMPX, 18, 5, null, ma.ImpXDeath1, MobjState.ImpXDie2, 0, 0), // State.ImpXDie1
            new MobjStateDef(80, Sprite.IMPX, 19, 5, null, null, MobjState.ImpXDie3, 0, 0), // State.ImpXDie2
            new MobjStateDef(81, Sprite.IMPX, 20, 5, null, null, MobjState.ImpXDie4, 0, 0), // State.ImpXDie3
            new MobjStateDef(82, Sprite.IMPX, 21, 5, null, ma.ImpXDeath2, MobjState.ImpXDie5, 0, 0), // State.ImpXDie4
            new MobjStateDef(83, Sprite.IMPX, 22, 5, null, null, MobjState.ImpXDie5, 0, 0), // State.ImpXDie5
            new MobjStateDef(84, Sprite.IMPX, 8, 7, null, ma.ImpExplode, MobjState.ImpCrash2, 0, 0), // State.ImpCrash1
            new MobjStateDef(85, Sprite.IMPX, 9, 7, null, ma.Scream, MobjState.ImpCrash3, 0, 0), // State.ImpCrash2
            new MobjStateDef(86, Sprite.IMPX, 10, 7, null, null, MobjState.ImpCrash4, 0, 0), // State.ImpCrash3
            new MobjStateDef(87, Sprite.IMPX, 11, -1, null, null, MobjState.Null, 0, 0), // State.ImpCrash4
            new MobjStateDef(88, Sprite.IMPX, 23, 7, null, null, MobjState.ImpXCrash2, 0, 0), // State.ImpXCrash1
            new MobjStateDef(89, Sprite.IMPX, 24, 7, null, null, MobjState.ImpXCrash3, 0, 0), // State.ImpXCrash2
            new MobjStateDef(90, Sprite.IMPX, 25, -1, null, null, MobjState.Null, 0, 0), // State.ImpXCrash3
            new MobjStateDef(91, Sprite.IMPX, 12, 5, null, null, MobjState.ImpChunkA2, 0, 0), // State.ImpChunkA1
            new MobjStateDef(92, Sprite.IMPX, 13, 700, null, null, MobjState.ImpChunkA3, 0, 0), // State.ImpChunkA2
            new MobjStateDef(93, Sprite.IMPX, 14, 700, null, null, MobjState.Null, 0, 0), // State.ImpChunkA3
            new MobjStateDef(94, Sprite.IMPX, 15, 5, null, null, MobjState.ImpChunkB2, 0, 0), // State.ImpChunkB1
            new MobjStateDef(95, Sprite.IMPX, 16, 700, null, null, MobjState.ImpChunkB3, 0, 0), // State.ImpChunkB2
            new MobjStateDef(96, Sprite.IMPX, 17, 700, null, null, MobjState.Null, 0, 0), // State.ImpChunkB3
            new MobjStateDef(97, Sprite.FX10, 32768, 6, null, null, MobjState.ImpFx2, 0, 0), // State.ImpFx1
            new MobjStateDef(98, Sprite.FX10, 32769, 6, null, null, MobjState.ImpFx3, 0, 0), // State.ImpFx2
            new MobjStateDef(99, Sprite.FX10, 32770, 6, null, null, MobjState.ImpFx1, 0, 0), // State.ImpFx3
            new MobjStateDef(100, Sprite.FX10, 32771, 5, null, null, MobjState.ImpFxI2, 0, 0), // State.ImpFxI1
            new MobjStateDef(101, Sprite.FX10, 32772, 5, null, null, MobjState.ImpFxI3, 0, 0), // State.ImpFxI2
            new MobjStateDef(102, Sprite.FX10, 32773, 5, null, null, MobjState.ImpFxI4, 0, 0), // State.ImpFxI3
            new MobjStateDef(103, Sprite.FX10, 32774, 5, null, null, MobjState.Null, 0, 0), // State.ImpFxI4
            new MobjStateDef(104, Sprite.SPSH, 0, 8, null, null, MobjState.Splash2, 0, 0), // State.Splash1
            new MobjStateDef(105, Sprite.SPSH, 1, 8, null, null, MobjState.Splash3, 0, 0), // State.Splash2
            new MobjStateDef(106, Sprite.SPSH, 2, 8, null, null, MobjState.Splash4, 0, 0), // State.Splash3
            new MobjStateDef(107, Sprite.SPSH, 3, 16, null, null, MobjState.Null, 0, 0), // State.Splash4
            new MobjStateDef(108, Sprite.SPSH, 3, 10, null, null, MobjState.Null, 0, 0), // State.SplashX 
            new MobjStateDef(109, Sprite.SPSH, 4, 5, null, null, MobjState.SplashBase2, 0, 0), // State.SplashBase1
            new MobjStateDef(110, Sprite.SPSH, 5, 5, null, null, MobjState.SplashBase3, 0, 0), // State.SplashBase2
            new MobjStateDef(111, Sprite.SPSH, 6, 5, null, null, MobjState.SplashBase4, 0, 0), // State.SplashBase3
            new MobjStateDef(112, Sprite.SPSH, 7, 5, null, null, MobjState.SplashBase5, 0, 0), // State.SplashBase4
            new MobjStateDef(113, Sprite.SPSH, 8, 5, null, null, MobjState.SplashBase6, 0, 0), // State.SplashBase5
            new MobjStateDef(114, Sprite.SPSH, 9, 5, null, null, MobjState.SplashBase7, 0, 0), // State.SplashBase6
            new MobjStateDef(115, Sprite.SPSH, 10, 5, null, null, MobjState.Null, 0, 0), // State.SplashBase7

          

            // new MobjStateDef(14, Sprite.PISG, 1, 6, pa.FirePistol, null, MobjState.Pistol3, 0, 0), // State.Pistol2
            // new MobjStateDef(15, Sprite.PISG, 2, 4, null, null, MobjState.Pistol4, 0, 0), // State.Pistol3
            // new MobjStateDef(16, Sprite.PISG, 1, 5, pa.ReFire, null, MobjState.Pistol, 0, 0), // State.Pistol4
            // new MobjStateDef(17, Sprite.PISF, 32768, 7, pa.Light1, null, MobjState.Lightdone, 0, 0), // State.Pistolflash
 
            //* new MobjStateDef(1, Sprite.SHTG, 4, 0, pa.Light0, null, MobjState.Null, 0, 0), // State.Lightdone
            // new MobjStateDef(2, Sprite.PUNG, 0, 1, pa.WeaponReady, null, MobjState.Punch, 0, 0), // State.Punch
            // new MobjStateDef(3, Sprite.PUNG, 0, 1, pa.Lower, null, MobjState.Punchdown, 0, 0), // State.Punchdown
            // new MobjStateDef(4, Sprite.PUNG, 0, 1, pa.Raise, null, MobjState.Punchup, 0, 0), // State.Punchup
            // new MobjStateDef(5, Sprite.PUNG, 1, 4, null, null, MobjState.Punch2, 0, 0), // State.Punch1
            // new MobjStateDef(6, Sprite.PUNG, 2, 4, pa.Punch, null, MobjState.Punch3, 0, 0), // State.Punch2
            // new MobjStateDef(7, Sprite.PUNG, 3, 5, null, null, MobjState.Punch4, 0, 0), // State.Punch3
            // new MobjStateDef(8, Sprite.PUNG, 2, 4, null, null, MobjState.Punch5, 0, 0), // State.Punch4
            // new MobjStateDef(9, Sprite.PUNG, 1, 5, pa.ReFire, null, MobjState.Punch, 0, 0), // State.Punch5
                       // new MobjStateDef(18, Sprite.SHTG, 0, 1, pa.WeaponReady, null, MobjState.Sgun, 0, 0), // State.Sgun
            // new MobjStateDef(19, Sprite.SHTG, 0, 1, pa.Lower, null, MobjState.Sgundown, 0, 0), // State.Sgundown
            // new MobjStateDef(20, Sprite.SHTG, 0, 1, pa.Raise, null, MobjState.Sgunup, 0, 0), // State.Sgunup
            // new MobjStateDef(21, Sprite.SHTG, 0, 3, null, null, MobjState.Sgun2, 0, 0), // State.Sgun1
            // new MobjStateDef(22, Sprite.SHTG, 0, 7, pa.FireShotgun, null, MobjState.Sgun3, 0, 0), // State.Sgun2
            // new MobjStateDef(23, Sprite.SHTG, 1, 5, null, null, MobjState.Sgun4, 0, 0), // State.Sgun3
            // new MobjStateDef(24, Sprite.SHTG, 2, 5, null, null, MobjState.Sgun5, 0, 0), // State.Sgun4
            // new MobjStateDef(25, Sprite.SHTG, 3, 4, null, null, MobjState.Sgun6, 0, 0), // State.Sgun5
            // new MobjStateDef(26, Sprite.SHTG, 2, 5, null, null, MobjState.Sgun7, 0, 0), // State.Sgun6
            // new MobjStateDef(27, Sprite.SHTG, 1, 5, null, null, MobjState.Sgun8, 0, 0), // State.Sgun7
            // new MobjStateDef(28, Sprite.SHTG, 0, 3, null, null, MobjState.Sgun9, 0, 0), // State.Sgun8
            // new MobjStateDef(29, Sprite.SHTG, 0, 7, pa.ReFire, null, MobjState.Sgun, 0, 0), // State.Sgun9
            // new MobjStateDef(30, Sprite.SHTF, 32768, 4, pa.Light1, null, MobjState.Sgunflash2, 0, 0), // State.Sgunflash1
            // new MobjStateDef(31, Sprite.SHTF, 32769, 3, pa.Light2, null, MobjState.Lightdone, 0, 0), // State.Sgunflash2
            // new MobjStateDef(32, Sprite.SHT2, 0, 1, pa.WeaponReady, null, MobjState.Dsgun, 0, 0), // State.Dsgun
            // new MobjStateDef(33, Sprite.SHT2, 0, 1, pa.Lower, null, MobjState.Dsgundown, 0, 0), // State.Dsgundown
            // new MobjStateDef(34, Sprite.SHT2, 0, 1, pa.Raise, null, MobjState.Dsgunup, 0, 0), // State.Dsgunup
            // new MobjStateDef(35, Sprite.SHT2, 0, 3, null, null, MobjState.Dsgun2, 0, 0), // State.Dsgun1
            // new MobjStateDef(36, Sprite.SHT2, 0, 7, pa.FireShotgun2, null, MobjState.Dsgun3, 0, 0), // State.Dsgun2
            // new MobjStateDef(37, Sprite.SHT2, 1, 7, null, null, MobjState.Dsgun4, 0, 0), // State.Dsgun3
            // new MobjStateDef(38, Sprite.SHT2, 2, 7, pa.CheckReload, null, MobjState.Dsgun5, 0, 0), // State.Dsgun4
            // new MobjStateDef(39, Sprite.SHT2, 3, 7, pa.OpenShotgun2, null, MobjState.Dsgun6, 0, 0), // State.Dsgun5
            // new MobjStateDef(40, Sprite.SHT2, 4, 7, null, null, MobjState.Dsgun7, 0, 0), // State.Dsgun6
            // new MobjStateDef(41, Sprite.SHT2, 5, 7, pa.LoadShotgun2, null, MobjState.Dsgun8, 0, 0), // State.Dsgun7
            // new MobjStateDef(42, Sprite.SHT2, 6, 6, null, null, MobjState.Dsgun9, 0, 0), // State.Dsgun8
            // new MobjStateDef(43, Sprite.SHT2, 7, 6, pa.CloseShotgun2, null, MobjState.Dsgun10, 0, 0), // State.Dsgun9
            // new MobjStateDef(44, Sprite.SHT2, 0, 5, pa.ReFire, null, MobjState.Dsgun, 0, 0), // State.Dsgun10
            // new MobjStateDef(45, Sprite.SHT2, 1, 7, null, null, MobjState.Dsnr2, 0, 0), // State.Dsnr1
            // new MobjStateDef(46, Sprite.SHT2, 0, 3, null, null, MobjState.Dsgundown, 0, 0), // State.Dsnr2
            // new MobjStateDef(47, Sprite.SHT2, 32776, 5, pa.Light1, null, MobjState.Dsgunflash2, 0, 0), // State.Dsgunflash1
            // new MobjStateDef(48, Sprite.SHT2, 32777, 4, pa.Light2, null, MobjState.Lightdone, 0, 0), // State.Dsgunflash2
            // new MobjStateDef(49, Sprite.CHGG, 0, 1, pa.WeaponReady, null, MobjState.Chain, 0, 0), // State.Chain
            // new MobjStateDef(50, Sprite.CHGG, 0, 1, pa.Lower, null, MobjState.Chaindown, 0, 0), // State.Chaindown
            // new MobjStateDef(51, Sprite.CHGG, 0, 1, pa.Raise, null, MobjState.Chainup, 0, 0), // State.Chainup
            // new MobjStateDef(52, Sprite.CHGG, 0, 4, pa.FireCGun, null, MobjState.Chain2, 0, 0), // State.Chain1
            // new MobjStateDef(53, Sprite.CHGG, 1, 4, pa.FireCGun, null, MobjState.Chain3, 0, 0), // State.Chain2
            // new MobjStateDef(54, Sprite.CHGG, 1, 0, pa.ReFire, null, MobjState.Chain, 0, 0), // State.Chain3
            // new MobjStateDef(55, Sprite.CHGF, 32768, 5, pa.Light1, null, MobjState.Lightdone, 0, 0), // State.Chainflash1
            // new MobjStateDef(56, Sprite.CHGF, 32769, 5, pa.Light2, null, MobjState.Lightdone, 0, 0), // State.Chainflash2
            // new MobjStateDef(57, Sprite.MISG, 0, 1, pa.WeaponReady, null, MobjState.Missile, 0, 0), // State.Missile
            // new MobjStateDef(58, Sprite.MISG, 0, 1, pa.Lower, null, MobjState.Missiledown, 0, 0), // State.Missiledown
            // new MobjStateDef(59, Sprite.MISG, 0, 1, pa.Raise, null, MobjState.Missileup, 0, 0), // State.Missileup
            // new MobjStateDef(60, Sprite.MISG, 1, 8, pa.GunFlash, null, MobjState.Missile2, 0, 0), // State.Missile1
            // new MobjStateDef(61, Sprite.MISG, 1, 12, pa.FireMissile, null, MobjState.Missile3, 0, 0), // State.Missile2
            // new MobjStateDef(62, Sprite.MISG, 1, 0, pa.ReFire, null, MobjState.Missile, 0, 0), // State.Missile3
            // new MobjStateDef(63, Sprite.MISF, 32768, 3, pa.Light1, null, MobjState.Missileflash2, 0, 0), // State.Missileflash1
            // new MobjStateDef(64, Sprite.MISF, 32769, 4, null, null, MobjState.Missileflash3, 0, 0), // State.Missileflash2
            // new MobjStateDef(65, Sprite.MISF, 32770, 4, pa.Light2, null, MobjState.Missileflash4, 0, 0), // State.Missileflash3
            // new MobjStateDef(66, Sprite.MISF, 32771, 4, pa.Light2, null, MobjState.Lightdone, 0, 0), // State.Missileflash4
            // new MobjStateDef(67, Sprite.SAWG, 2, 4, pa.WeaponReady, null, MobjState.Sawb, 0, 0), // State.Saw
            // new MobjStateDef(68, Sprite.SAWG, 3, 4, pa.WeaponReady, null, MobjState.Saw, 0, 0), // State.Sawb
            // new MobjStateDef(69, Sprite.SAWG, 2, 1, pa.Lower, null, MobjState.Sawdown, 0, 0), // State.Sawdown
            // new MobjStateDef(70, Sprite.SAWG, 2, 1, pa.Raise, null, MobjState.Sawup, 0, 0), // State.Sawup
            // new MobjStateDef(71, Sprite.SAWG, 0, 4, pa.Saw, null, MobjState.Saw2, 0, 0), // State.Saw1
            // new MobjStateDef(72, Sprite.SAWG, 1, 4, pa.Saw, null, MobjState.Saw3, 0, 0), // State.Saw2
            // new MobjStateDef(73, Sprite.SAWG, 1, 0, pa.ReFire, null, MobjState.Saw, 0, 0), // State.Saw3
            // new MobjStateDef(74, Sprite.PLSG, 0, 1, pa.WeaponReady, null, MobjState.Plasma, 0, 0), // State.Plasma
            // new MobjStateDef(75, Sprite.PLSG, 0, 1, pa.Lower, null, MobjState.Plasmadown, 0, 0), // State.Plasmadown
            // new MobjStateDef(76, Sprite.PLSG, 0, 1, pa.Raise, null, MobjState.Plasmaup, 0, 0), // State.Plasmaup
            // new MobjStateDef(77, Sprite.PLSG, 0, 3, pa.FirePlasma, null, MobjState.Plasma2, 0, 0), // State.Plasma1
            // new MobjStateDef(78, Sprite.PLSG, 1, 20, pa.ReFire, null, MobjState.Plasma, 0, 0), // State.Plasma2
            // new MobjStateDef(79, Sprite.PLSF, 32768, 4, pa.Light1, null, MobjState.Lightdone, 0, 0), // State.Plasmaflash1
            // new MobjStateDef(80, Sprite.PLSF, 32769, 4, pa.Light1, null, MobjState.Lightdone, 0, 0), // State.Plasmaflash2
            // new MobjStateDef(81, Sprite.BFGG, 0, 1, pa.WeaponReady, null, MobjState.Bfg, 0, 0), // State.Bfg
            // new MobjStateDef(82, Sprite.BFGG, 0, 1, pa.Lower, null, MobjState.Bfgdown, 0, 0), // State.Bfgdown
            // new MobjStateDef(83, Sprite.BFGG, 0, 1, pa.Raise, null, MobjState.Bfgup, 0, 0), // State.Bfgup
            // new MobjStateDef(84, Sprite.BFGG, 0, 20, pa.BFGsound, null, MobjState.Bfg2, 0, 0), // State.Bfg1
            // new MobjStateDef(85, Sprite.BFGG, 1, 10, pa.GunFlash, null, MobjState.Bfg3, 0, 0), // State.Bfg2
            // new MobjStateDef(86, Sprite.BFGG, 1, 10, pa.FireBFG, null, MobjState.Bfg4, 0, 0), // State.Bfg3
            // new MobjStateDef(87, Sprite.BFGG, 1, 20, pa.ReFire, null, MobjState.Bfg, 0, 0), // State.Bfg4
            // new MobjStateDef(88, Sprite.BFGF, 32768, 11, pa.Light1, null, MobjState.Bfgflash2, 0, 0), // State.Bfgflash1
            // new MobjStateDef(89, Sprite.BFGF, 32769, 6, pa.Light2, null, MobjState.Lightdone, 0, 0), // State.Bfgflash2
            // new MobjStateDef(90, Sprite.BLUD, 2, 8, null, null, MobjState.Blood2, 0, 0), // State.Blood1
            // new MobjStateDef(91, Sprite.BLUD, 1, 8, null, null, MobjState.Blood3, 0, 0), // State.Blood2
            // new MobjStateDef(92, Sprite.BLUD, 0, 8, null, null, MobjState.Null, 0, 0), // State.Blood3
            // new MobjStateDef(93, Sprite.PUFF, 32768, 4, null, null, MobjState.Puff2, 0, 0), // State.Puff1
            // new MobjStateDef(94, Sprite.PUFF, 1, 4, null, null, MobjState.Puff3, 0, 0), // State.Puff2
            // new MobjStateDef(95, Sprite.PUFF, 2, 4, null, null, MobjState.Puff4, 0, 0), // State.Puff3
            // new MobjStateDef(96, Sprite.PUFF, 3, 4, null, null, MobjState.Null, 0, 0), // State.Puff4
            // new MobjStateDef(97, Sprite.BAL1, 32768, 4, null, null, MobjState.Tball2, 0, 0), // State.Tball1
            // new MobjStateDef(98, Sprite.BAL1, 32769, 4, null, null, MobjState.Tball1, 0, 0), // State.Tball2
            // new MobjStateDef(99, Sprite.BAL1, 32770, 6, null, null, MobjState.Tballx2, 0, 0), // State.Tballx1
            // new MobjStateDef(100, Sprite.BAL1, 32771, 6, null, null, MobjState.Tballx3, 0, 0), // State.Tballx2
            // new MobjStateDef(101, Sprite.BAL1, 32772, 6, null, null, MobjState.Null, 0, 0), // State.Tballx3
            // new MobjStateDef(102, Sprite.BAL2, 32768, 4, null, null, MobjState.Rball2, 0, 0), // State.Rball1
            // new MobjStateDef(103, Sprite.BAL2, 32769, 4, null, null, MobjState.Rball1, 0, 0), // State.Rball2
            // new MobjStateDef(104, Sprite.BAL2, 32770, 6, null, null, MobjState.Rballx2, 0, 0), // State.Rballx1
            // new MobjStateDef(105, Sprite.BAL2, 32771, 6, null, null, MobjState.Rballx3, 0, 0), // State.Rballx2
            // new MobjStateDef(106, Sprite.BAL2, 32772, 6, null, null, MobjState.Null, 0, 0), // State.Rballx3
            // new MobjStateDef(107, Sprite.PLSS, 32768, 6, null, null, MobjState.Plasball2, 0, 0), // State.Plasball
            // new MobjStateDef(108, Sprite.PLSS, 32769, 6, null, null, MobjState.Plasball, 0, 0), // State.Plasball2
            // new MobjStateDef(109, Sprite.PLSE, 32768, 4, null, null, MobjState.Plasexp2, 0, 0), // State.Plasexp
            // new MobjStateDef(110, Sprite.PLSE, 32769, 4, null, null, MobjState.Plasexp3, 0, 0), // State.Plasexp2
            // new MobjStateDef(111, Sprite.PLSE, 32770, 4, null, null, MobjState.Plasexp4, 0, 0), // State.Plasexp3
            // new MobjStateDef(112, Sprite.PLSE, 32771, 4, null, null, MobjState.Plasexp5, 0, 0), // State.Plasexp4
            // new MobjStateDef(113, Sprite.PLSE, 32772, 4, null, null, MobjState.Null, 0, 0), // State.Plasexp5
            // new MobjStateDef(114, Sprite.MISL, 32768, 1, null, null, MobjState.Rocket, 0, 0), // State.Rocket
            // new MobjStateDef(115, Sprite.BFS1, 32768, 4, null, null, MobjState.Bfgshot2, 0, 0), // State.Bfgshot
            // new MobjStateDef(116, Sprite.BFS1, 32769, 4, null, null, MobjState.Bfgshot, 0, 0), // State.Bfgshot2
            // new MobjStateDef(117, Sprite.BFE1, 32768, 8, null, null, MobjState.Bfgland2, 0, 0), // State.Bfgland
            // new MobjStateDef(118, Sprite.BFE1, 32769, 8, null, null, MobjState.Bfgland3, 0, 0), // State.Bfgland2
            // new MobjStateDef(119, Sprite.BFE1, 32770, 8, null, ma.BFGSpray, MobjState.Bfgland4, 0, 0), // State.Bfgland3
            // new MobjStateDef(120, Sprite.BFE1, 32771, 8, null, null, MobjState.Bfgland5, 0, 0), // State.Bfgland4
            // new MobjStateDef(121, Sprite.BFE1, 32772, 8, null, null, MobjState.Bfgland6, 0, 0), // State.Bfgland5
            // new MobjStateDef(122, Sprite.BFE1, 32773, 8, null, null, MobjState.Null, 0, 0), // State.Bfgland6
            // new MobjStateDef(123, Sprite.BFE2, 32768, 8, null, null, MobjState.Bfgexp2, 0, 0), // State.Bfgexp
            // new MobjStateDef(124, Sprite.BFE2, 32769, 8, null, null, MobjState.Bfgexp3, 0, 0), // State.Bfgexp2
            // new MobjStateDef(125, Sprite.BFE2, 32770, 8, null, null, MobjState.Bfgexp4, 0, 0), // State.Bfgexp3
            // new MobjStateDef(126, Sprite.BFE2, 32771, 8, null, null, MobjState.Null, 0, 0), // State.Bfgexp4
            // new MobjStateDef(127, Sprite.MISL, 32769, 8, null, ma.Explode, MobjState.Explode2, 0, 0), // State.Explode1
            // new MobjStateDef(128, Sprite.MISL, 32770, 6, null, null, MobjState.Explode3, 0, 0), // State.Explode2
            // new MobjStateDef(129, Sprite.MISL, 32771, 4, null, null, MobjState.Null, 0, 0), // State.Explode3
            // new MobjStateDef(130, Sprite.TFOG, 32768, 6, null, null, MobjState.Tfog01, 0, 0), // State.Tfog
            // new MobjStateDef(131, Sprite.TFOG, 32769, 6, null, null, MobjState.Tfog02, 0, 0), // State.Tfog01
            // new MobjStateDef(132, Sprite.TFOG, 32768, 6, null, null, MobjState.Tfog2, 0, 0), // State.Tfog02
            // new MobjStateDef(133, Sprite.TFOG, 32769, 6, null, null, MobjState.Tfog3, 0, 0), // State.Tfog2
            // new MobjStateDef(134, Sprite.TFOG, 32770, 6, null, null, MobjState.Tfog4, 0, 0), // State.Tfog3
            // new MobjStateDef(135, Sprite.TFOG, 32771, 6, null, null, MobjState.Tfog5, 0, 0), // State.Tfog4
            // new MobjStateDef(136, Sprite.TFOG, 32772, 6, null, null, MobjState.Tfog6, 0, 0), // State.Tfog5
            // new MobjStateDef(137, Sprite.TFOG, 32773, 6, null, null, MobjState.Tfog7, 0, 0), // State.Tfog6
            // new MobjStateDef(138, Sprite.TFOG, 32774, 6, null, null, MobjState.Tfog8, 0, 0), // State.Tfog7
            // new MobjStateDef(139, Sprite.TFOG, 32775, 6, null, null, MobjState.Tfog9, 0, 0), // State.Tfog8
            // new MobjStateDef(140, Sprite.TFOG, 32776, 6, null, null, MobjState.Tfog10, 0, 0), // State.Tfog9
            // new MobjStateDef(141, Sprite.TFOG, 32777, 6, null, null, MobjState.Null, 0, 0), // State.Tfog10
            // new MobjStateDef(142, Sprite.IFOG, 32768, 6, null, null, MobjState.Ifog01, 0, 0), // State.Ifog
            // new MobjStateDef(143, Sprite.IFOG, 32769, 6, null, null, MobjState.Ifog02, 0, 0), // State.Ifog01
            // new MobjStateDef(144, Sprite.IFOG, 32768, 6, null, null, MobjState.Ifog2, 0, 0), // State.Ifog02
            // new MobjStateDef(145, Sprite.IFOG, 32769, 6, null, null, MobjState.Ifog3, 0, 0), // State.Ifog2
            // new MobjStateDef(146, Sprite.IFOG, 32770, 6, null, null, MobjState.Ifog4, 0, 0), // State.Ifog3
            // new MobjStateDef(147, Sprite.IFOG, 32771, 6, null, null, MobjState.Ifog5, 0, 0), // State.Ifog4
            // new MobjStateDef(148, Sprite.IFOG, 32772, 6, null, null, MobjState.Null, 0, 0), // State.Ifog5
                     // new MobjStateDef(174, Sprite.POSS, 0, 10, null, ma.Look, MobjState.PossStnd2, 0, 0), // State.PossStnd
            // new MobjStateDef(175, Sprite.POSS, 1, 10, null, ma.Look, MobjState.PossStnd, 0, 0), // State.PossStnd2
            // new MobjStateDef(176, Sprite.POSS, 0, 4, null, ma.Chase, MobjState.PossRun2, 0, 0), // State.PossRun1
            // new MobjStateDef(177, Sprite.POSS, 0, 4, null, ma.Chase, MobjState.PossRun3, 0, 0), // State.PossRun2
            // new MobjStateDef(178, Sprite.POSS, 1, 4, null, ma.Chase, MobjState.PossRun4, 0, 0), // State.PossRun3
            // new MobjStateDef(179, Sprite.POSS, 1, 4, null, ma.Chase, MobjState.PossRun5, 0, 0), // State.PossRun4
            // new MobjStateDef(180, Sprite.POSS, 2, 4, null, ma.Chase, MobjState.PossRun6, 0, 0), // State.PossRun5
            // new MobjStateDef(181, Sprite.POSS, 2, 4, null, ma.Chase, MobjState.PossRun7, 0, 0), // State.PossRun6
            // new MobjStateDef(182, Sprite.POSS, 3, 4, null, ma.Chase, MobjState.PossRun8, 0, 0), // State.PossRun7
            // new MobjStateDef(183, Sprite.POSS, 3, 4, null, ma.Chase, MobjState.PossRun1, 0, 0), // State.PossRun8
            // new MobjStateDef(184, Sprite.POSS, 4, 10, null, ma.FaceTarget, MobjState.PossAtk2, 0, 0), // State.PossAtk1
            // new MobjStateDef(185, Sprite.POSS, 5, 8, null, ma.PosAttack, MobjState.PossAtk3, 0, 0), // State.PossAtk2
            // new MobjStateDef(186, Sprite.POSS, 4, 8, null, null, MobjState.PossRun1, 0, 0), // State.PossAtk3
            // new MobjStateDef(187, Sprite.POSS, 6, 3, null, null, MobjState.PossPain2, 0, 0), // State.PossPain
            // new MobjStateDef(188, Sprite.POSS, 6, 3, null, ma.Pain, MobjState.PossRun1, 0, 0), // State.PossPain2
            // new MobjStateDef(189, Sprite.POSS, 7, 5, null, null, MobjState.PossDie2, 0, 0), // State.PossDie1
            // new MobjStateDef(190, Sprite.POSS, 8, 5, null, ma.Scream, MobjState.PossDie3, 0, 0), // State.PossDie2
            // new MobjStateDef(191, Sprite.POSS, 9, 5, null, ma.Fall, MobjState.PossDie4, 0, 0), // State.PossDie3
            // new MobjStateDef(192, Sprite.POSS, 10, 5, null, null, MobjState.PossDie5, 0, 0), // State.PossDie4
            // new MobjStateDef(193, Sprite.POSS, 11, -1, null, null, MobjState.Null, 0, 0), // State.PossDie5
            // new MobjStateDef(194, Sprite.POSS, 12, 5, null, null, MobjState.PossXdie2, 0, 0), // State.PossXdie1
            // new MobjStateDef(195, Sprite.POSS, 13, 5, null, ma.XScream, MobjState.PossXdie3, 0, 0), // State.PossXdie2
            // new MobjStateDef(196, Sprite.POSS, 14, 5, null, ma.Fall, MobjState.PossXdie4, 0, 0), // State.PossXdie3
            // new MobjStateDef(197, Sprite.POSS, 15, 5, null, null, MobjState.PossXdie5, 0, 0), // State.PossXdie4
            // new MobjStateDef(198, Sprite.POSS, 16, 5, null, null, MobjState.PossXdie6, 0, 0), // State.PossXdie5
            // new MobjStateDef(199, Sprite.POSS, 17, 5, null, null, MobjState.PossXdie7, 0, 0), // State.PossXdie6
            // new MobjStateDef(200, Sprite.POSS, 18, 5, null, null, MobjState.PossXdie8, 0, 0), // State.PossXdie7
            // new MobjStateDef(201, Sprite.POSS, 19, 5, null, null, MobjState.PossXdie9, 0, 0), // State.PossXdie8
            // new MobjStateDef(202, Sprite.POSS, 20, -1, null, null, MobjState.Null, 0, 0), // State.PossXdie9
            // new MobjStateDef(203, Sprite.POSS, 10, 5, null, null, MobjState.PossRaise2, 0, 0), // State.PossRaise1
            // new MobjStateDef(204, Sprite.POSS, 9, 5, null, null, MobjState.PossRaise3, 0, 0), // State.PossRaise2
            // new MobjStateDef(205, Sprite.POSS, 8, 5, null, null, MobjState.PossRaise4, 0, 0), // State.PossRaise3
            // new MobjStateDef(206, Sprite.POSS, 7, 5, null, null, MobjState.PossRun1, 0, 0), // State.PossRaise4
            // new MobjStateDef(207, Sprite.SPOS, 0, 10, null, ma.Look, MobjState.SposStnd2, 0, 0), // State.SposStnd
            // new MobjStateDef(208, Sprite.SPOS, 1, 10, null, ma.Look, MobjState.SposStnd, 0, 0), // State.SposStnd2
            // new MobjStateDef(209, Sprite.SPOS, 0, 3, null, ma.Chase, MobjState.SposRun2, 0, 0), // State.SposRun1
            // new MobjStateDef(210, Sprite.SPOS, 0, 3, null, ma.Chase, MobjState.SposRun3, 0, 0), // State.SposRun2
            // new MobjStateDef(211, Sprite.SPOS, 1, 3, null, ma.Chase, MobjState.SposRun4, 0, 0), // State.SposRun3
            // new MobjStateDef(212, Sprite.SPOS, 1, 3, null, ma.Chase, MobjState.SposRun5, 0, 0), // State.SposRun4
            // new MobjStateDef(213, Sprite.SPOS, 2, 3, null, ma.Chase, MobjState.SposRun6, 0, 0), // State.SposRun5
            // new MobjStateDef(214, Sprite.SPOS, 2, 3, null, ma.Chase, MobjState.SposRun7, 0, 0), // State.SposRun6
            // new MobjStateDef(215, Sprite.SPOS, 3, 3, null, ma.Chase, MobjState.SposRun8, 0, 0), // State.SposRun7
            // new MobjStateDef(216, Sprite.SPOS, 3, 3, null, ma.Chase, MobjState.SposRun1, 0, 0), // State.SposRun8
            // new MobjStateDef(217, Sprite.SPOS, 4, 10, null, ma.FaceTarget, MobjState.SposAtk2, 0, 0), // State.SposAtk1
            // new MobjStateDef(218, Sprite.SPOS, 32773, 10, null, ma.SPosAttack, MobjState.SposAtk3, 0, 0), // State.SposAtk2
            // new MobjStateDef(219, Sprite.SPOS, 4, 10, null, null, MobjState.SposRun1, 0, 0), // State.SposAtk3
            // new MobjStateDef(220, Sprite.SPOS, 6, 3, null, null, MobjState.SposPain2, 0, 0), // State.SposPain
            // new MobjStateDef(221, Sprite.SPOS, 6, 3, null, ma.Pain, MobjState.SposRun1, 0, 0), // State.SposPain2
            // new MobjStateDef(222, Sprite.SPOS, 7, 5, null, null, MobjState.SposDie2, 0, 0), // State.SposDie1
            // new MobjStateDef(223, Sprite.SPOS, 8, 5, null, ma.Scream, MobjState.SposDie3, 0, 0), // State.SposDie2
            // new MobjStateDef(224, Sprite.SPOS, 9, 5, null, ma.Fall, MobjState.SposDie4, 0, 0), // State.SposDie3
            // new MobjStateDef(225, Sprite.SPOS, 10, 5, null, null, MobjState.SposDie5, 0, 0), // State.SposDie4
            // new MobjStateDef(226, Sprite.SPOS, 11, -1, null, null, MobjState.Null, 0, 0), // State.SposDie5
            // new MobjStateDef(227, Sprite.SPOS, 12, 5, null, null, MobjState.SposXdie2, 0, 0), // State.SposXdie1
            // new MobjStateDef(228, Sprite.SPOS, 13, 5, null, ma.XScream, MobjState.SposXdie3, 0, 0), // State.SposXdie2
            // new MobjStateDef(229, Sprite.SPOS, 14, 5, null, ma.Fall, MobjState.SposXdie4, 0, 0), // State.SposXdie3
            // new MobjStateDef(230, Sprite.SPOS, 15, 5, null, null, MobjState.SposXdie5, 0, 0), // State.SposXdie4
            // new MobjStateDef(231, Sprite.SPOS, 16, 5, null, null, MobjState.SposXdie6, 0, 0), // State.SposXdie5
            // new MobjStateDef(232, Sprite.SPOS, 17, 5, null, null, MobjState.SposXdie7, 0, 0), // State.SposXdie6
            // new MobjStateDef(233, Sprite.SPOS, 18, 5, null, null, MobjState.SposXdie8, 0, 0), // State.SposXdie7
            // new MobjStateDef(234, Sprite.SPOS, 19, 5, null, null, MobjState.SposXdie9, 0, 0), // State.SposXdie8
            // new MobjStateDef(235, Sprite.SPOS, 20, -1, null, null, MobjState.Null, 0, 0), // State.SposXdie9
            // new MobjStateDef(236, Sprite.SPOS, 11, 5, null, null, MobjState.SposRaise2, 0, 0), // State.SposRaise1
            // new MobjStateDef(237, Sprite.SPOS, 10, 5, null, null, MobjState.SposRaise3, 0, 0), // State.SposRaise2
            // new MobjStateDef(238, Sprite.SPOS, 9, 5, null, null, MobjState.SposRaise4, 0, 0), // State.SposRaise3
            // new MobjStateDef(239, Sprite.SPOS, 8, 5, null, null, MobjState.SposRaise5, 0, 0), // State.SposRaise4
            // new MobjStateDef(240, Sprite.SPOS, 7, 5, null, null, MobjState.SposRun1, 0, 0), // State.SposRaise5
            // new MobjStateDef(241, Sprite.VILE, 0, 10, null, ma.Look, MobjState.VileStnd2, 0, 0), // State.VileStnd
            // new MobjStateDef(242, Sprite.VILE, 1, 10, null, ma.Look, MobjState.VileStnd, 0, 0), // State.VileStnd2
            // new MobjStateDef(243, Sprite.VILE, 0, 2, null, ma.VileChase, MobjState.VileRun2, 0, 0), // State.VileRun1
            // new MobjStateDef(244, Sprite.VILE, 0, 2, null, ma.VileChase, MobjState.VileRun3, 0, 0), // State.VileRun2
            // new MobjStateDef(245, Sprite.VILE, 1, 2, null, ma.VileChase, MobjState.VileRun4, 0, 0), // State.VileRun3
            // new MobjStateDef(246, Sprite.VILE, 1, 2, null, ma.VileChase, MobjState.VileRun5, 0, 0), // State.VileRun4
            // new MobjStateDef(247, Sprite.VILE, 2, 2, null, ma.VileChase, MobjState.VileRun6, 0, 0), // State.VileRun5
            // new MobjStateDef(248, Sprite.VILE, 2, 2, null, ma.VileChase, MobjState.VileRun7, 0, 0), // State.VileRun6
            // new MobjStateDef(249, Sprite.VILE, 3, 2, null, ma.VileChase, MobjState.VileRun8, 0, 0), // State.VileRun7
            // new MobjStateDef(250, Sprite.VILE, 3, 2, null, ma.VileChase, MobjState.VileRun9, 0, 0), // State.VileRun8
            // new MobjStateDef(251, Sprite.VILE, 4, 2, null, ma.VileChase, MobjState.VileRun10, 0, 0), // State.VileRun9
            // new MobjStateDef(252, Sprite.VILE, 4, 2, null, ma.VileChase, MobjState.VileRun11, 0, 0), // State.VileRun10
            // new MobjStateDef(253, Sprite.VILE, 5, 2, null, ma.VileChase, MobjState.VileRun12, 0, 0), // State.VileRun11
            // new MobjStateDef(254, Sprite.VILE, 5, 2, null, ma.VileChase, MobjState.VileRun1, 0, 0), // State.VileRun12
            // new MobjStateDef(255, Sprite.VILE, 32774, 0, null, ma.VileStart, MobjState.VileAtk2, 0, 0), // State.VileAtk1
            // new MobjStateDef(256, Sprite.VILE, 32774, 10, null, ma.FaceTarget, MobjState.VileAtk3, 0, 0), // State.VileAtk2
            // new MobjStateDef(257, Sprite.VILE, 32775, 8, null, ma.VileTarget, MobjState.VileAtk4, 0, 0), // State.VileAtk3
            // new MobjStateDef(258, Sprite.VILE, 32776, 8, null, ma.FaceTarget, MobjState.VileAtk5, 0, 0), // State.VileAtk4
            // new MobjStateDef(259, Sprite.VILE, 32777, 8, null, ma.FaceTarget, MobjState.VileAtk6, 0, 0), // State.VileAtk5
            // new MobjStateDef(260, Sprite.VILE, 32778, 8, null, ma.FaceTarget, MobjState.VileAtk7, 0, 0), // State.VileAtk6
            // new MobjStateDef(261, Sprite.VILE, 32779, 8, null, ma.FaceTarget, MobjState.VileAtk8, 0, 0), // State.VileAtk7
            // new MobjStateDef(262, Sprite.VILE, 32780, 8, null, ma.FaceTarget, MobjState.VileAtk9, 0, 0), // State.VileAtk8
            // new MobjStateDef(263, Sprite.VILE, 32781, 8, null, ma.FaceTarget, MobjState.VileAtk10, 0, 0), // State.VileAtk9
            // new MobjStateDef(264, Sprite.VILE, 32782, 8, null, ma.VileAttack, MobjState.VileAtk11, 0, 0), // State.VileAtk10
            // new MobjStateDef(265, Sprite.VILE, 32783, 20, null, null, MobjState.VileRun1, 0, 0), // State.VileAtk11
            // new MobjStateDef(266, Sprite.VILE, 32794, 10, null, null, MobjState.VileHeal2, 0, 0), // State.VileHeal1
            // new MobjStateDef(267, Sprite.VILE, 32795, 10, null, null, MobjState.VileHeal3, 0, 0), // State.VileHeal2
            // new MobjStateDef(268, Sprite.VILE, 32796, 10, null, null, MobjState.VileRun1, 0, 0), // State.VileHeal3
            // new MobjStateDef(269, Sprite.VILE, 16, 5, null, null, MobjState.VilePain2, 0, 0), // State.VilePain
            // new MobjStateDef(270, Sprite.VILE, 16, 5, null, ma.Pain, MobjState.VileRun1, 0, 0), // State.VilePain2
            // new MobjStateDef(271, Sprite.VILE, 16, 7, null, null, MobjState.VileDie2, 0, 0), // State.VileDie1
            // new MobjStateDef(272, Sprite.VILE, 17, 7, null, ma.Scream, MobjState.VileDie3, 0, 0), // State.VileDie2
            // new MobjStateDef(273, Sprite.VILE, 18, 7, null, ma.Fall, MobjState.VileDie4, 0, 0), // State.VileDie3
            // new MobjStateDef(274, Sprite.VILE, 19, 7, null, null, MobjState.VileDie5, 0, 0), // State.VileDie4
            // new MobjStateDef(275, Sprite.VILE, 20, 7, null, null, MobjState.VileDie6, 0, 0), // State.VileDie5
            // new MobjStateDef(276, Sprite.VILE, 21, 7, null, null, MobjState.VileDie7, 0, 0), // State.VileDie6
            // new MobjStateDef(277, Sprite.VILE, 22, 7, null, null, MobjState.VileDie8, 0, 0), // State.VileDie7
            // new MobjStateDef(278, Sprite.VILE, 23, 5, null, null, MobjState.VileDie9, 0, 0), // State.VileDie8
            // new MobjStateDef(279, Sprite.VILE, 24, 5, null, null, MobjState.VileDie10, 0, 0), // State.VileDie9
            // new MobjStateDef(280, Sprite.VILE, 25, -1, null, null, MobjState.Null, 0, 0), // State.VileDie10
            // new MobjStateDef(281, Sprite.FIRE, 32768, 2, null, ma.StartFire, MobjState.Fire2, 0, 0), // State.Fire1
            // new MobjStateDef(282, Sprite.FIRE, 32769, 2, null, ma.Fire, MobjState.Fire3, 0, 0), // State.Fire2
            // new MobjStateDef(283, Sprite.FIRE, 32768, 2, null, ma.Fire, MobjState.Fire4, 0, 0), // State.Fire3
            // new MobjStateDef(284, Sprite.FIRE, 32769, 2, null, ma.Fire, MobjState.Fire5, 0, 0), // State.Fire4
            // new MobjStateDef(285, Sprite.FIRE, 32770, 2, null, ma.FireCrackle, MobjState.Fire6, 0, 0), // State.Fire5
            // new MobjStateDef(286, Sprite.FIRE, 32769, 2, null, ma.Fire, MobjState.Fire7, 0, 0), // State.Fire6
            // new MobjStateDef(287, Sprite.FIRE, 32770, 2, null, ma.Fire, MobjState.Fire8, 0, 0), // State.Fire7
            // new MobjStateDef(288, Sprite.FIRE, 32769, 2, null, ma.Fire, MobjState.Fire9, 0, 0), // State.Fire8
            // new MobjStateDef(289, Sprite.FIRE, 32770, 2, null, ma.Fire, MobjState.Fire10, 0, 0), // State.Fire9
            // new MobjStateDef(290, Sprite.FIRE, 32771, 2, null, ma.Fire, MobjState.Fire11, 0, 0), // State.Fire10
            // new MobjStateDef(291, Sprite.FIRE, 32770, 2, null, ma.Fire, MobjState.Fire12, 0, 0), // State.Fire11
            // new MobjStateDef(292, Sprite.FIRE, 32771, 2, null, ma.Fire, MobjState.Fire13, 0, 0), // State.Fire12
            // new MobjStateDef(293, Sprite.FIRE, 32770, 2, null, ma.Fire, MobjState.Fire14, 0, 0), // State.Fire13
            // new MobjStateDef(294, Sprite.FIRE, 32771, 2, null, ma.Fire, MobjState.Fire15, 0, 0), // State.Fire14
            // new MobjStateDef(295, Sprite.FIRE, 32772, 2, null, ma.Fire, MobjState.Fire16, 0, 0), // State.Fire15
            // new MobjStateDef(296, Sprite.FIRE, 32771, 2, null, ma.Fire, MobjState.Fire17, 0, 0), // State.Fire16
            // new MobjStateDef(297, Sprite.FIRE, 32772, 2, null, ma.Fire, MobjState.Fire18, 0, 0), // State.Fire17
            // new MobjStateDef(298, Sprite.FIRE, 32771, 2, null, ma.Fire, MobjState.Fire19, 0, 0), // State.Fire18
            // new MobjStateDef(299, Sprite.FIRE, 32772, 2, null, ma.FireCrackle, MobjState.Fire20, 0, 0), // State.Fire19
            // new MobjStateDef(300, Sprite.FIRE, 32773, 2, null, ma.Fire, MobjState.Fire21, 0, 0), // State.Fire20
            // new MobjStateDef(301, Sprite.FIRE, 32772, 2, null, ma.Fire, MobjState.Fire22, 0, 0), // State.Fire21
            // new MobjStateDef(302, Sprite.FIRE, 32773, 2, null, ma.Fire, MobjState.Fire23, 0, 0), // State.Fire22
            // new MobjStateDef(303, Sprite.FIRE, 32772, 2, null, ma.Fire, MobjState.Fire24, 0, 0), // State.Fire23
            // new MobjStateDef(304, Sprite.FIRE, 32773, 2, null, ma.Fire, MobjState.Fire25, 0, 0), // State.Fire24
            // new MobjStateDef(305, Sprite.FIRE, 32774, 2, null, ma.Fire, MobjState.Fire26, 0, 0), // State.Fire25
            // new MobjStateDef(306, Sprite.FIRE, 32775, 2, null, ma.Fire, MobjState.Fire27, 0, 0), // State.Fire26
            // new MobjStateDef(307, Sprite.FIRE, 32774, 2, null, ma.Fire, MobjState.Fire28, 0, 0), // State.Fire27
            // new MobjStateDef(308, Sprite.FIRE, 32775, 2, null, ma.Fire, MobjState.Fire29, 0, 0), // State.Fire28
            // new MobjStateDef(309, Sprite.FIRE, 32774, 2, null, ma.Fire, MobjState.Fire30, 0, 0), // State.Fire29
            // new MobjStateDef(310, Sprite.FIRE, 32775, 2, null, ma.Fire, MobjState.Null, 0, 0), // State.Fire30
            // new MobjStateDef(311, Sprite.PUFF, 1, 4, null, null, MobjState.Smoke2, 0, 0), // State.Smoke1
            // new MobjStateDef(312, Sprite.PUFF, 2, 4, null, null, MobjState.Smoke3, 0, 0), // State.Smoke2
            // new MobjStateDef(313, Sprite.PUFF, 1, 4, null, null, MobjState.Smoke4, 0, 0), // State.Smoke3
            // new MobjStateDef(314, Sprite.PUFF, 2, 4, null, null, MobjState.Smoke5, 0, 0), // State.Smoke4
            // new MobjStateDef(315, Sprite.PUFF, 3, 4, null, null, MobjState.Null, 0, 0), // State.Smoke5
            // new MobjStateDef(316, Sprite.FATB, 32768, 2, null, ma.Tracer, MobjState.Tracer2, 0, 0), // State.Tracer
            // new MobjStateDef(317, Sprite.FATB, 32769, 2, null, ma.Tracer, MobjState.Tracer, 0, 0), // State.Tracer2
            // new MobjStateDef(318, Sprite.FBXP, 32768, 8, null, null, MobjState.Traceexp2, 0, 0), // State.Traceexp1
            // new MobjStateDef(319, Sprite.FBXP, 32769, 6, null, null, MobjState.Traceexp3, 0, 0), // State.Traceexp2
            // new MobjStateDef(320, Sprite.FBXP, 32770, 4, null, null, MobjState.Null, 0, 0), // State.Traceexp3
            // new MobjStateDef(321, Sprite.SKEL, 0, 10, null, ma.Look, MobjState.SkelStnd2, 0, 0), // State.SkelStnd
            // new MobjStateDef(322, Sprite.SKEL, 1, 10, null, ma.Look, MobjState.SkelStnd, 0, 0), // State.SkelStnd2
            // new MobjStateDef(323, Sprite.SKEL, 0, 2, null, ma.Chase, MobjState.SkelRun2, 0, 0), // State.SkelRun1
            // new MobjStateDef(324, Sprite.SKEL, 0, 2, null, ma.Chase, MobjState.SkelRun3, 0, 0), // State.SkelRun2
            // new MobjStateDef(325, Sprite.SKEL, 1, 2, null, ma.Chase, MobjState.SkelRun4, 0, 0), // State.SkelRun3
            // new MobjStateDef(326, Sprite.SKEL, 1, 2, null, ma.Chase, MobjState.SkelRun5, 0, 0), // State.SkelRun4
            // new MobjStateDef(327, Sprite.SKEL, 2, 2, null, ma.Chase, MobjState.SkelRun6, 0, 0), // State.SkelRun5
            // new MobjStateDef(328, Sprite.SKEL, 2, 2, null, ma.Chase, MobjState.SkelRun7, 0, 0), // State.SkelRun6
            // new MobjStateDef(329, Sprite.SKEL, 3, 2, null, ma.Chase, MobjState.SkelRun8, 0, 0), // State.SkelRun7
            // new MobjStateDef(330, Sprite.SKEL, 3, 2, null, ma.Chase, MobjState.SkelRun9, 0, 0), // State.SkelRun8
            // new MobjStateDef(331, Sprite.SKEL, 4, 2, null, ma.Chase, MobjState.SkelRun10, 0, 0), // State.SkelRun9
            // new MobjStateDef(332, Sprite.SKEL, 4, 2, null, ma.Chase, MobjState.SkelRun11, 0, 0), // State.SkelRun10
            // new MobjStateDef(333, Sprite.SKEL, 5, 2, null, ma.Chase, MobjState.SkelRun12, 0, 0), // State.SkelRun11
            // new MobjStateDef(334, Sprite.SKEL, 5, 2, null, ma.Chase, MobjState.SkelRun1, 0, 0), // State.SkelRun12
            // new MobjStateDef(335, Sprite.SKEL, 6, 0, null, ma.FaceTarget, MobjState.SkelFist2, 0, 0), // State.SkelFist1
            // new MobjStateDef(336, Sprite.SKEL, 6, 6, null, ma.SkelWhoosh, MobjState.SkelFist3, 0, 0), // State.SkelFist2
            // new MobjStateDef(337, Sprite.SKEL, 7, 6, null, ma.FaceTarget, MobjState.SkelFist4, 0, 0), // State.SkelFist3
            // new MobjStateDef(338, Sprite.SKEL, 8, 6, null, ma.SkelFist, MobjState.SkelRun1, 0, 0), // State.SkelFist4
            // new MobjStateDef(339, Sprite.SKEL, 32777, 0, null, ma.FaceTarget, MobjState.SkelMiss2, 0, 0), // State.SkelMiss1
            // new MobjStateDef(340, Sprite.SKEL, 32777, 10, null, ma.FaceTarget, MobjState.SkelMiss3, 0, 0), // State.SkelMiss2
            // new MobjStateDef(341, Sprite.SKEL, 10, 10, null, ma.SkelMissile, MobjState.SkelMiss4, 0, 0), // State.SkelMiss3
            // new MobjStateDef(342, Sprite.SKEL, 10, 10, null, ma.FaceTarget, MobjState.SkelRun1, 0, 0), // State.SkelMiss4
            // new MobjStateDef(343, Sprite.SKEL, 11, 5, null, null, MobjState.SkelPain2, 0, 0), // State.SkelPain
            // new MobjStateDef(344, Sprite.SKEL, 11, 5, null, ma.Pain, MobjState.SkelRun1, 0, 0), // State.SkelPain2
            // new MobjStateDef(345, Sprite.SKEL, 11, 7, null, null, MobjState.SkelDie2, 0, 0), // State.SkelDie1
            // new MobjStateDef(346, Sprite.SKEL, 12, 7, null, null, MobjState.SkelDie3, 0, 0), // State.SkelDie2
            // new MobjStateDef(347, Sprite.SKEL, 13, 7, null, ma.Scream, MobjState.SkelDie4, 0, 0), // State.SkelDie3
            // new MobjStateDef(348, Sprite.SKEL, 14, 7, null, ma.Fall, MobjState.SkelDie5, 0, 0), // State.SkelDie4
            // new MobjStateDef(349, Sprite.SKEL, 15, 7, null, null, MobjState.SkelDie6, 0, 0), // State.SkelDie5
            // new MobjStateDef(350, Sprite.SKEL, 16, -1, null, null, MobjState.Null, 0, 0), // State.SkelDie6
            // new MobjStateDef(351, Sprite.SKEL, 16, 5, null, null, MobjState.SkelRaise2, 0, 0), // State.SkelRaise1
            // new MobjStateDef(352, Sprite.SKEL, 15, 5, null, null, MobjState.SkelRaise3, 0, 0), // State.SkelRaise2
            // new MobjStateDef(353, Sprite.SKEL, 14, 5, null, null, MobjState.SkelRaise4, 0, 0), // State.SkelRaise3
            // new MobjStateDef(354, Sprite.SKEL, 13, 5, null, null, MobjState.SkelRaise5, 0, 0), // State.SkelRaise4
            // new MobjStateDef(355, Sprite.SKEL, 12, 5, null, null, MobjState.SkelRaise6, 0, 0), // State.SkelRaise5
            // new MobjStateDef(356, Sprite.SKEL, 11, 5, null, null, MobjState.SkelRun1, 0, 0), // State.SkelRaise6
            // new MobjStateDef(357, Sprite.MANF, 32768, 4, null, null, MobjState.Fatshot2, 0, 0), // State.Fatshot1
            // new MobjStateDef(358, Sprite.MANF, 32769, 4, null, null, MobjState.Fatshot1, 0, 0), // State.Fatshot2
            // new MobjStateDef(359, Sprite.MISL, 32769, 8, null, null, MobjState.Fatshotx2, 0, 0), // State.Fatshotx1
            // new MobjStateDef(360, Sprite.MISL, 32770, 6, null, null, MobjState.Fatshotx3, 0, 0), // State.Fatshotx2
            // new MobjStateDef(361, Sprite.MISL, 32771, 4, null, null, MobjState.Null, 0, 0), // State.Fatshotx3
            // new MobjStateDef(362, Sprite.FATT, 0, 15, null, ma.Look, MobjState.FattStnd2, 0, 0), // State.FattStnd
            // new MobjStateDef(363, Sprite.FATT, 1, 15, null, ma.Look, MobjState.FattStnd, 0, 0), // State.FattStnd2
            // new MobjStateDef(364, Sprite.FATT, 0, 4, null, ma.Chase, MobjState.FattRun2, 0, 0), // State.FattRun1
            // new MobjStateDef(365, Sprite.FATT, 0, 4, null, ma.Chase, MobjState.FattRun3, 0, 0), // State.FattRun2
            // new MobjStateDef(366, Sprite.FATT, 1, 4, null, ma.Chase, MobjState.FattRun4, 0, 0), // State.FattRun3
            // new MobjStateDef(367, Sprite.FATT, 1, 4, null, ma.Chase, MobjState.FattRun5, 0, 0), // State.FattRun4
            // new MobjStateDef(368, Sprite.FATT, 2, 4, null, ma.Chase, MobjState.FattRun6, 0, 0), // State.FattRun5
            // new MobjStateDef(369, Sprite.FATT, 2, 4, null, ma.Chase, MobjState.FattRun7, 0, 0), // State.FattRun6
            // new MobjStateDef(370, Sprite.FATT, 3, 4, null, ma.Chase, MobjState.FattRun8, 0, 0), // State.FattRun7
            // new MobjStateDef(371, Sprite.FATT, 3, 4, null, ma.Chase, MobjState.FattRun9, 0, 0), // State.FattRun8
            // new MobjStateDef(372, Sprite.FATT, 4, 4, null, ma.Chase, MobjState.FattRun10, 0, 0), // State.FattRun9
            // new MobjStateDef(373, Sprite.FATT, 4, 4, null, ma.Chase, MobjState.FattRun11, 0, 0), // State.FattRun10
            // new MobjStateDef(374, Sprite.FATT, 5, 4, null, ma.Chase, MobjState.FattRun12, 0, 0), // State.FattRun11
            // new MobjStateDef(375, Sprite.FATT, 5, 4, null, ma.Chase, MobjState.FattRun1, 0, 0), // State.FattRun12
            // new MobjStateDef(376, Sprite.FATT, 6, 20, null, ma.FatRaise, MobjState.FattAtk2, 0, 0), // State.FattAtk1
            // new MobjStateDef(377, Sprite.FATT, 32775, 10, null, ma.FatAttack1, MobjState.FattAtk3, 0, 0), // State.FattAtk2
            // new MobjStateDef(378, Sprite.FATT, 8, 5, null, ma.FaceTarget, MobjState.FattAtk4, 0, 0), // State.FattAtk3
            // new MobjStateDef(379, Sprite.FATT, 6, 5, null, ma.FaceTarget, MobjState.FattAtk5, 0, 0), // State.FattAtk4
            // new MobjStateDef(380, Sprite.FATT, 32775, 10, null, ma.FatAttack2, MobjState.FattAtk6, 0, 0), // State.FattAtk5
            // new MobjStateDef(381, Sprite.FATT, 8, 5, null, ma.FaceTarget, MobjState.FattAtk7, 0, 0), // State.FattAtk6
            // new MobjStateDef(382, Sprite.FATT, 6, 5, null, ma.FaceTarget, MobjState.FattAtk8, 0, 0), // State.FattAtk7
            // new MobjStateDef(383, Sprite.FATT, 32775, 10, null, ma.FatAttack3, MobjState.FattAtk9, 0, 0), // State.FattAtk8
            // new MobjStateDef(384, Sprite.FATT, 8, 5, null, ma.FaceTarget, MobjState.FattAtk10, 0, 0), // State.FattAtk9
            // new MobjStateDef(385, Sprite.FATT, 6, 5, null, ma.FaceTarget, MobjState.FattRun1, 0, 0), // State.FattAtk10
            // new MobjStateDef(386, Sprite.FATT, 9, 3, null, null, MobjState.FattPain2, 0, 0), // State.FattPain
            // new MobjStateDef(387, Sprite.FATT, 9, 3, null, ma.Pain, MobjState.FattRun1, 0, 0), // State.FattPain2
            // new MobjStateDef(388, Sprite.FATT, 10, 6, null, null, MobjState.FattDie2, 0, 0), // State.FattDie1
            // new MobjStateDef(389, Sprite.FATT, 11, 6, null, ma.Scream, MobjState.FattDie3, 0, 0), // State.FattDie2
            // new MobjStateDef(390, Sprite.FATT, 12, 6, null, ma.Fall, MobjState.FattDie4, 0, 0), // State.FattDie3
            // new MobjStateDef(391, Sprite.FATT, 13, 6, null, null, MobjState.FattDie5, 0, 0), // State.FattDie4
            // new MobjStateDef(392, Sprite.FATT, 14, 6, null, null, MobjState.FattDie6, 0, 0), // State.FattDie5
            // new MobjStateDef(393, Sprite.FATT, 15, 6, null, null, MobjState.FattDie7, 0, 0), // State.FattDie6
            // new MobjStateDef(394, Sprite.FATT, 16, 6, null, null, MobjState.FattDie8, 0, 0), // State.FattDie7
            // new MobjStateDef(395, Sprite.FATT, 17, 6, null, null, MobjState.FattDie9, 0, 0), // State.FattDie8
            // new MobjStateDef(396, Sprite.FATT, 18, 6, null, null, MobjState.FattDie10, 0, 0), // State.FattDie9
            // new MobjStateDef(397, Sprite.FATT, 19, -1, null, ma.BossDeath, MobjState.Null, 0, 0), // State.FattDie10
            // new MobjStateDef(398, Sprite.FATT, 17, 5, null, null, MobjState.FattRaise2, 0, 0), // State.FattRaise1
            // new MobjStateDef(399, Sprite.FATT, 16, 5, null, null, MobjState.FattRaise3, 0, 0), // State.FattRaise2
            // new MobjStateDef(400, Sprite.FATT, 15, 5, null, null, MobjState.FattRaise4, 0, 0), // State.FattRaise3
            // new MobjStateDef(401, Sprite.FATT, 14, 5, null, null, MobjState.FattRaise5, 0, 0), // State.FattRaise4
            // new MobjStateDef(402, Sprite.FATT, 13, 5, null, null, MobjState.FattRaise6, 0, 0), // State.FattRaise5
            // new MobjStateDef(403, Sprite.FATT, 12, 5, null, null, MobjState.FattRaise7, 0, 0), // State.FattRaise6
            // new MobjStateDef(404, Sprite.FATT, 11, 5, null, null, MobjState.FattRaise8, 0, 0), // State.FattRaise7
            // new MobjStateDef(405, Sprite.FATT, 10, 5, null, null, MobjState.FattRun1, 0, 0), // State.FattRaise8
            // new MobjStateDef(406, Sprite.CPOS, 0, 10, null, ma.Look, MobjState.CposStnd2, 0, 0), // State.CposStnd
            // new MobjStateDef(407, Sprite.CPOS, 1, 10, null, ma.Look, MobjState.CposStnd, 0, 0), // State.CposStnd2
            // new MobjStateDef(408, Sprite.CPOS, 0, 3, null, ma.Chase, MobjState.CposRun2, 0, 0), // State.CposRun1
            // new MobjStateDef(409, Sprite.CPOS, 0, 3, null, ma.Chase, MobjState.CposRun3, 0, 0), // State.CposRun2
            // new MobjStateDef(410, Sprite.CPOS, 1, 3, null, ma.Chase, MobjState.CposRun4, 0, 0), // State.CposRun3
            // new MobjStateDef(411, Sprite.CPOS, 1, 3, null, ma.Chase, MobjState.CposRun5, 0, 0), // State.CposRun4
            // new MobjStateDef(412, Sprite.CPOS, 2, 3, null, ma.Chase, MobjState.CposRun6, 0, 0), // State.CposRun5
            // new MobjStateDef(413, Sprite.CPOS, 2, 3, null, ma.Chase, MobjState.CposRun7, 0, 0), // State.CposRun6
            // new MobjStateDef(414, Sprite.CPOS, 3, 3, null, ma.Chase, MobjState.CposRun8, 0, 0), // State.CposRun7
            // new MobjStateDef(415, Sprite.CPOS, 3, 3, null, ma.Chase, MobjState.CposRun1, 0, 0), // State.CposRun8
            // new MobjStateDef(416, Sprite.CPOS, 4, 10, null, ma.FaceTarget, MobjState.CposAtk2, 0, 0), // State.CposAtk1
            // new MobjStateDef(417, Sprite.CPOS, 32773, 4, null, ma.CPosAttack, MobjState.CposAtk3, 0, 0), // State.CposAtk2
            // new MobjStateDef(418, Sprite.CPOS, 32772, 4, null, ma.CPosAttack, MobjState.CposAtk4, 0, 0), // State.CposAtk3
            // new MobjStateDef(419, Sprite.CPOS, 5, 1, null, ma.CPosRefire, MobjState.CposAtk2, 0, 0), // State.CposAtk4
            // new MobjStateDef(420, Sprite.CPOS, 6, 3, null, null, MobjState.CposPain2, 0, 0), // State.CposPain
            // new MobjStateDef(421, Sprite.CPOS, 6, 3, null, ma.Pain, MobjState.CposRun1, 0, 0), // State.CposPain2
            // new MobjStateDef(422, Sprite.CPOS, 7, 5, null, null, MobjState.CposDie2, 0, 0), // State.CposDie1
            // new MobjStateDef(423, Sprite.CPOS, 8, 5, null, ma.Scream, MobjState.CposDie3, 0, 0), // State.CposDie2
            // new MobjStateDef(424, Sprite.CPOS, 9, 5, null, ma.Fall, MobjState.CposDie4, 0, 0), // State.CposDie3
            // new MobjStateDef(425, Sprite.CPOS, 10, 5, null, null, MobjState.CposDie5, 0, 0), // State.CposDie4
            // new MobjStateDef(426, Sprite.CPOS, 11, 5, null, null, MobjState.CposDie6, 0, 0), // State.CposDie5
            // new MobjStateDef(427, Sprite.CPOS, 12, 5, null, null, MobjState.CposDie7, 0, 0), // State.CposDie6
            // new MobjStateDef(428, Sprite.CPOS, 13, -1, null, null, MobjState.Null, 0, 0), // State.CposDie7
            // new MobjStateDef(429, Sprite.CPOS, 14, 5, null, null, MobjState.CposXdie2, 0, 0), // State.CposXdie1
            // new MobjStateDef(430, Sprite.CPOS, 15, 5, null, ma.XScream, MobjState.CposXdie3, 0, 0), // State.CposXdie2
            // new MobjStateDef(431, Sprite.CPOS, 16, 5, null, ma.Fall, MobjState.CposXdie4, 0, 0), // State.CposXdie3
            // new MobjStateDef(432, Sprite.CPOS, 17, 5, null, null, MobjState.CposXdie5, 0, 0), // State.CposXdie4
            // new MobjStateDef(433, Sprite.CPOS, 18, 5, null, null, MobjState.CposXdie6, 0, 0), // State.CposXdie5
            // new MobjStateDef(434, Sprite.CPOS, 19, -1, null, null, MobjState.Null, 0, 0), // State.CposXdie6
            // new MobjStateDef(435, Sprite.CPOS, 13, 5, null, null, MobjState.CposRaise2, 0, 0), // State.CposRaise1
            // new MobjStateDef(436, Sprite.CPOS, 12, 5, null, null, MobjState.CposRaise3, 0, 0), // State.CposRaise2
            // new MobjStateDef(437, Sprite.CPOS, 11, 5, null, null, MobjState.CposRaise4, 0, 0), // State.CposRaise3
            // new MobjStateDef(438, Sprite.CPOS, 10, 5, null, null, MobjState.CposRaise5, 0, 0), // State.CposRaise4
            // new MobjStateDef(439, Sprite.CPOS, 9, 5, null, null, MobjState.CposRaise6, 0, 0), // State.CposRaise5
            // new MobjStateDef(440, Sprite.CPOS, 8, 5, null, null, MobjState.CposRaise7, 0, 0), // State.CposRaise6
            // new MobjStateDef(441, Sprite.CPOS, 7, 5, null, null, MobjState.CposRun1, 0, 0), // State.CposRaise7
            // new MobjStateDef(442, Sprite.TROO, 0, 10, null, ma.Look, MobjState.TrooStnd2, 0, 0), // State.TrooStnd
            // new MobjStateDef(443, Sprite.TROO, 1, 10, null, ma.Look, MobjState.TrooStnd, 0, 0), // State.TrooStnd2
            // new MobjStateDef(444, Sprite.TROO, 0, 3, null, ma.Chase, MobjState.TrooRun2, 0, 0), // State.TrooRun1
            // new MobjStateDef(445, Sprite.TROO, 0, 3, null, ma.Chase, MobjState.TrooRun3, 0, 0), // State.TrooRun2
            // new MobjStateDef(446, Sprite.TROO, 1, 3, null, ma.Chase, MobjState.TrooRun4, 0, 0), // State.TrooRun3
            // new MobjStateDef(447, Sprite.TROO, 1, 3, null, ma.Chase, MobjState.TrooRun5, 0, 0), // State.TrooRun4
            // new MobjStateDef(448, Sprite.TROO, 2, 3, null, ma.Chase, MobjState.TrooRun6, 0, 0), // State.TrooRun5
            // new MobjStateDef(449, Sprite.TROO, 2, 3, null, ma.Chase, MobjState.TrooRun7, 0, 0), // State.TrooRun6
            // new MobjStateDef(450, Sprite.TROO, 3, 3, null, ma.Chase, MobjState.TrooRun8, 0, 0), // State.TrooRun7
            // new MobjStateDef(451, Sprite.TROO, 3, 3, null, ma.Chase, MobjState.TrooRun1, 0, 0), // State.TrooRun8
            // new MobjStateDef(452, Sprite.TROO, 4, 8, null, ma.FaceTarget, MobjState.TrooAtk2, 0, 0), // State.TrooAtk1
            // new MobjStateDef(453, Sprite.TROO, 5, 8, null, ma.FaceTarget, MobjState.TrooAtk3, 0, 0), // State.TrooAtk2
            // new MobjStateDef(454, Sprite.TROO, 6, 6, null, ma.TroopAttack, MobjState.TrooRun1, 0, 0), // State.TrooAtk3
            // new MobjStateDef(455, Sprite.TROO, 7, 2, null, null, MobjState.TrooPain2, 0, 0), // State.TrooPain
            // new MobjStateDef(456, Sprite.TROO, 7, 2, null, ma.Pain, MobjState.TrooRun1, 0, 0), // State.TrooPain2
            // new MobjStateDef(457, Sprite.TROO, 8, 8, null, null, MobjState.TrooDie2, 0, 0), // State.TrooDie1
            // new MobjStateDef(458, Sprite.TROO, 9, 8, null, ma.Scream, MobjState.TrooDie3, 0, 0), // State.TrooDie2
            // new MobjStateDef(459, Sprite.TROO, 10, 6, null, null, MobjState.TrooDie4, 0, 0), // State.TrooDie3
            // new MobjStateDef(460, Sprite.TROO, 11, 6, null, ma.Fall, MobjState.TrooDie5, 0, 0), // State.TrooDie4
            // new MobjStateDef(461, Sprite.TROO, 12, -1, null, null, MobjState.Null, 0, 0), // State.TrooDie5
            // new MobjStateDef(462, Sprite.TROO, 13, 5, null, null, MobjState.TrooXdie2, 0, 0), // State.TrooXdie1
            // new MobjStateDef(463, Sprite.TROO, 14, 5, null, ma.XScream, MobjState.TrooXdie3, 0, 0), // State.TrooXdie2
            // new MobjStateDef(464, Sprite.TROO, 15, 5, null, null, MobjState.TrooXdie4, 0, 0), // State.TrooXdie3
            // new MobjStateDef(465, Sprite.TROO, 16, 5, null, ma.Fall, MobjState.TrooXdie5, 0, 0), // State.TrooXdie4
            // new MobjStateDef(466, Sprite.TROO, 17, 5, null, null, MobjState.TrooXdie6, 0, 0), // State.TrooXdie5
            // new MobjStateDef(467, Sprite.TROO, 18, 5, null, null, MobjState.TrooXdie7, 0, 0), // State.TrooXdie6
            // new MobjStateDef(468, Sprite.TROO, 19, 5, null, null, MobjState.TrooXdie8, 0, 0), // State.TrooXdie7
            // new MobjStateDef(469, Sprite.TROO, 20, -1, null, null, MobjState.Null, 0, 0), // State.TrooXdie8
            // new MobjStateDef(470, Sprite.TROO, 12, 8, null, null, MobjState.TrooRaise2, 0, 0), // State.TrooRaise1
            // new MobjStateDef(471, Sprite.TROO, 11, 8, null, null, MobjState.TrooRaise3, 0, 0), // State.TrooRaise2
            // new MobjStateDef(472, Sprite.TROO, 10, 6, null, null, MobjState.TrooRaise4, 0, 0), // State.TrooRaise3
            // new MobjStateDef(473, Sprite.TROO, 9, 6, null, null, MobjState.TrooRaise5, 0, 0), // State.TrooRaise4
            // new MobjStateDef(474, Sprite.TROO, 8, 6, null, null, MobjState.TrooRun1, 0, 0), // State.TrooRaise5
            // new MobjStateDef(475, Sprite.SARG, 0, 10, null, ma.Look, MobjState.SargStnd2, 0, 0), // State.SargStnd
            // new MobjStateDef(476, Sprite.SARG, 1, 10, null, ma.Look, MobjState.SargStnd, 0, 0), // State.SargStnd2
            // new MobjStateDef(477, Sprite.SARG, 0, 2, null, ma.Chase, MobjState.SargRun2, 0, 0), // State.SargRun1
            // new MobjStateDef(478, Sprite.SARG, 0, 2, null, ma.Chase, MobjState.SargRun3, 0, 0), // State.SargRun2
            // new MobjStateDef(479, Sprite.SARG, 1, 2, null, ma.Chase, MobjState.SargRun4, 0, 0), // State.SargRun3
            // new MobjStateDef(480, Sprite.SARG, 1, 2, null, ma.Chase, MobjState.SargRun5, 0, 0), // State.SargRun4
            // new MobjStateDef(481, Sprite.SARG, 2, 2, null, ma.Chase, MobjState.SargRun6, 0, 0), // State.SargRun5
            // new MobjStateDef(482, Sprite.SARG, 2, 2, null, ma.Chase, MobjState.SargRun7, 0, 0), // State.SargRun6
            // new MobjStateDef(483, Sprite.SARG, 3, 2, null, ma.Chase, MobjState.SargRun8, 0, 0), // State.SargRun7
            // new MobjStateDef(484, Sprite.SARG, 3, 2, null, ma.Chase, MobjState.SargRun1, 0, 0), // State.SargRun8
            // new MobjStateDef(485, Sprite.SARG, 4, 8, null, ma.FaceTarget, MobjState.SargAtk2, 0, 0), // State.SargAtk1
            // new MobjStateDef(486, Sprite.SARG, 5, 8, null, ma.FaceTarget, MobjState.SargAtk3, 0, 0), // State.SargAtk2
            // new MobjStateDef(487, Sprite.SARG, 6, 8, null, ma.SargAttack, MobjState.SargRun1, 0, 0), // State.SargAtk3
            // new MobjStateDef(488, Sprite.SARG, 7, 2, null, null, MobjState.SargPain2, 0, 0), // State.SargPain
            // new MobjStateDef(489, Sprite.SARG, 7, 2, null, ma.Pain, MobjState.SargRun1, 0, 0), // State.SargPain2
            // new MobjStateDef(490, Sprite.SARG, 8, 8, null, null, MobjState.SargDie2, 0, 0), // State.SargDie1
            // new MobjStateDef(491, Sprite.SARG, 9, 8, null, ma.Scream, MobjState.SargDie3, 0, 0), // State.SargDie2
            // new MobjStateDef(492, Sprite.SARG, 10, 4, null, null, MobjState.SargDie4, 0, 0), // State.SargDie3
            // new MobjStateDef(493, Sprite.SARG, 11, 4, null, ma.Fall, MobjState.SargDie5, 0, 0), // State.SargDie4
            // new MobjStateDef(494, Sprite.SARG, 12, 4, null, null, MobjState.SargDie6, 0, 0), // State.SargDie5
            // new MobjStateDef(495, Sprite.SARG, 13, -1, null, null, MobjState.Null, 0, 0), // State.SargDie6
            // new MobjStateDef(496, Sprite.SARG, 13, 5, null, null, MobjState.SargRaise2, 0, 0), // State.SargRaise1
            // new MobjStateDef(497, Sprite.SARG, 12, 5, null, null, MobjState.SargRaise3, 0, 0), // State.SargRaise2
            // new MobjStateDef(498, Sprite.SARG, 11, 5, null, null, MobjState.SargRaise4, 0, 0), // State.SargRaise3
            // new MobjStateDef(499, Sprite.SARG, 10, 5, null, null, MobjState.SargRaise5, 0, 0), // State.SargRaise4
            // new MobjStateDef(500, Sprite.SARG, 9, 5, null, null, MobjState.SargRaise6, 0, 0), // State.SargRaise5
            // new MobjStateDef(501, Sprite.SARG, 8, 5, null, null, MobjState.SargRun1, 0, 0), // State.SargRaise6
            // new MobjStateDef(502, Sprite.HEAD, 0, 10, null, ma.Look, MobjState.HeadStnd, 0, 0), // State.HeadStnd
            // new MobjStateDef(503, Sprite.HEAD, 0, 3, null, ma.Chase, MobjState.HeadRun1, 0, 0), // State.HeadRun1
            // new MobjStateDef(504, Sprite.HEAD, 1, 5, null, ma.FaceTarget, MobjState.HeadAtk2, 0, 0), // State.HeadAtk1
            // new MobjStateDef(505, Sprite.HEAD, 2, 5, null, ma.FaceTarget, MobjState.HeadAtk3, 0, 0), // State.HeadAtk2
            // new MobjStateDef(506, Sprite.HEAD, 32771, 5, null, ma.HeadAttack, MobjState.HeadRun1, 0, 0), // State.HeadAtk3
            // new MobjStateDef(507, Sprite.HEAD, 4, 3, null, null, MobjState.HeadPain2, 0, 0), // State.HeadPain
            // new MobjStateDef(508, Sprite.HEAD, 4, 3, null, ma.Pain, MobjState.HeadPain3, 0, 0), // State.HeadPain2
            // new MobjStateDef(509, Sprite.HEAD, 5, 6, null, null, MobjState.HeadRun1, 0, 0), // State.HeadPain3
            // new MobjStateDef(510, Sprite.HEAD, 6, 8, null, null, MobjState.HeadDie2, 0, 0), // State.HeadDie1
            // new MobjStateDef(511, Sprite.HEAD, 7, 8, null, ma.Scream, MobjState.HeadDie3, 0, 0), // State.HeadDie2
            // new MobjStateDef(512, Sprite.HEAD, 8, 8, null, null, MobjState.HeadDie4, 0, 0), // State.HeadDie3
            // new MobjStateDef(513, Sprite.HEAD, 9, 8, null, null, MobjState.HeadDie5, 0, 0), // State.HeadDie4
            // new MobjStateDef(514, Sprite.HEAD, 10, 8, null, ma.Fall, MobjState.HeadDie6, 0, 0), // State.HeadDie5
            // new MobjStateDef(515, Sprite.HEAD, 11, -1, null, null, MobjState.Null, 0, 0), // State.HeadDie6
            // new MobjStateDef(516, Sprite.HEAD, 11, 8, null, null, MobjState.HeadRaise2, 0, 0), // State.HeadRaise1
            // new MobjStateDef(517, Sprite.HEAD, 10, 8, null, null, MobjState.HeadRaise3, 0, 0), // State.HeadRaise2
            // new MobjStateDef(518, Sprite.HEAD, 9, 8, null, null, MobjState.HeadRaise4, 0, 0), // State.HeadRaise3
            // new MobjStateDef(519, Sprite.HEAD, 8, 8, null, null, MobjState.HeadRaise5, 0, 0), // State.HeadRaise4
            // new MobjStateDef(520, Sprite.HEAD, 7, 8, null, null, MobjState.HeadRaise6, 0, 0), // State.HeadRaise5
            // new MobjStateDef(521, Sprite.HEAD, 6, 8, null, null, MobjState.HeadRun1, 0, 0), // State.HeadRaise6
            // new MobjStateDef(522, Sprite.BAL7, 32768, 4, null, null, MobjState.Brball2, 0, 0), // State.Brball1
            // new MobjStateDef(523, Sprite.BAL7, 32769, 4, null, null, MobjState.Brball1, 0, 0), // State.Brball2
            // new MobjStateDef(524, Sprite.BAL7, 32770, 6, null, null, MobjState.Brballx2, 0, 0), // State.Brballx1
            // new MobjStateDef(525, Sprite.BAL7, 32771, 6, null, null, MobjState.Brballx3, 0, 0), // State.Brballx2
            // new MobjStateDef(526, Sprite.BAL7, 32772, 6, null, null, MobjState.Null, 0, 0), // State.Brballx3
            // new MobjStateDef(527, Sprite.BOSS, 0, 10, null, ma.Look, MobjState.BossStnd2, 0, 0), // State.BossStnd
            // new MobjStateDef(528, Sprite.BOSS, 1, 10, null, ma.Look, MobjState.BossStnd, 0, 0), // State.BossStnd2
            // new MobjStateDef(529, Sprite.BOSS, 0, 3, null, ma.Chase, MobjState.BossRun2, 0, 0), // State.BossRun1
            // new MobjStateDef(530, Sprite.BOSS, 0, 3, null, ma.Chase, MobjState.BossRun3, 0, 0), // State.BossRun2
            // new MobjStateDef(531, Sprite.BOSS, 1, 3, null, ma.Chase, MobjState.BossRun4, 0, 0), // State.BossRun3
            // new MobjStateDef(532, Sprite.BOSS, 1, 3, null, ma.Chase, MobjState.BossRun5, 0, 0), // State.BossRun4
            // new MobjStateDef(533, Sprite.BOSS, 2, 3, null, ma.Chase, MobjState.BossRun6, 0, 0), // State.BossRun5
            // new MobjStateDef(534, Sprite.BOSS, 2, 3, null, ma.Chase, MobjState.BossRun7, 0, 0), // State.BossRun6
            // new MobjStateDef(535, Sprite.BOSS, 3, 3, null, ma.Chase, MobjState.BossRun8, 0, 0), // State.BossRun7
            // new MobjStateDef(536, Sprite.BOSS, 3, 3, null, ma.Chase, MobjState.BossRun1, 0, 0), // State.BossRun8
            // new MobjStateDef(537, Sprite.BOSS, 4, 8, null, ma.FaceTarget, MobjState.BossAtk2, 0, 0), // State.BossAtk1
            // new MobjStateDef(538, Sprite.BOSS, 5, 8, null, ma.FaceTarget, MobjState.BossAtk3, 0, 0), // State.BossAtk2
            // new MobjStateDef(539, Sprite.BOSS, 6, 8, null, ma.BruisAttack, MobjState.BossRun1, 0, 0), // State.BossAtk3
            // new MobjStateDef(540, Sprite.BOSS, 7, 2, null, null, MobjState.BossPain2, 0, 0), // State.BossPain
            // new MobjStateDef(541, Sprite.BOSS, 7, 2, null, ma.Pain, MobjState.BossRun1, 0, 0), // State.BossPain2
            // new MobjStateDef(542, Sprite.BOSS, 8, 8, null, null, MobjState.BossDie2, 0, 0), // State.BossDie1
            // new MobjStateDef(543, Sprite.BOSS, 9, 8, null, ma.Scream, MobjState.BossDie3, 0, 0), // State.BossDie2
            // new MobjStateDef(544, Sprite.BOSS, 10, 8, null, null, MobjState.BossDie4, 0, 0), // State.BossDie3
            // new MobjStateDef(545, Sprite.BOSS, 11, 8, null, ma.Fall, MobjState.BossDie5, 0, 0), // State.BossDie4
            // new MobjStateDef(546, Sprite.BOSS, 12, 8, null, null, MobjState.BossDie6, 0, 0), // State.BossDie5
            // new MobjStateDef(547, Sprite.BOSS, 13, 8, null, null, MobjState.BossDie7, 0, 0), // State.BossDie6
            // new MobjStateDef(548, Sprite.BOSS, 14, -1, null, ma.BossDeath, MobjState.Null, 0, 0), // State.BossDie7
            // new MobjStateDef(549, Sprite.BOSS, 14, 8, null, null, MobjState.BossRaise2, 0, 0), // State.BossRaise1
            // new MobjStateDef(550, Sprite.BOSS, 13, 8, null, null, MobjState.BossRaise3, 0, 0), // State.BossRaise2
            // new MobjStateDef(551, Sprite.BOSS, 12, 8, null, null, MobjState.BossRaise4, 0, 0), // State.BossRaise3
            // new MobjStateDef(552, Sprite.BOSS, 11, 8, null, null, MobjState.BossRaise5, 0, 0), // State.BossRaise4
            // new MobjStateDef(553, Sprite.BOSS, 10, 8, null, null, MobjState.BossRaise6, 0, 0), // State.BossRaise5
            // new MobjStateDef(554, Sprite.BOSS, 9, 8, null, null, MobjState.BossRaise7, 0, 0), // State.BossRaise6
            // new MobjStateDef(555, Sprite.BOSS, 8, 8, null, null, MobjState.BossRun1, 0, 0), // State.BossRaise7
            // new MobjStateDef(556, Sprite.BOS2, 0, 10, null, ma.Look, MobjState.Bos2Stnd2, 0, 0), // State.Bos2Stnd
            // new MobjStateDef(557, Sprite.BOS2, 1, 10, null, ma.Look, MobjState.Bos2Stnd, 0, 0), // State.Bos2Stnd2
            // new MobjStateDef(558, Sprite.BOS2, 0, 3, null, ma.Chase, MobjState.Bos2Run2, 0, 0), // State.Bos2Run1
            // new MobjStateDef(559, Sprite.BOS2, 0, 3, null, ma.Chase, MobjState.Bos2Run3, 0, 0), // State.Bos2Run2
            // new MobjStateDef(560, Sprite.BOS2, 1, 3, null, ma.Chase, MobjState.Bos2Run4, 0, 0), // State.Bos2Run3
            // new MobjStateDef(561, Sprite.BOS2, 1, 3, null, ma.Chase, MobjState.Bos2Run5, 0, 0), // State.Bos2Run4
            // new MobjStateDef(562, Sprite.BOS2, 2, 3, null, ma.Chase, MobjState.Bos2Run6, 0, 0), // State.Bos2Run5
            // new MobjStateDef(563, Sprite.BOS2, 2, 3, null, ma.Chase, MobjState.Bos2Run7, 0, 0), // State.Bos2Run6
            // new MobjStateDef(564, Sprite.BOS2, 3, 3, null, ma.Chase, MobjState.Bos2Run8, 0, 0), // State.Bos2Run7
            // new MobjStateDef(565, Sprite.BOS2, 3, 3, null, ma.Chase, MobjState.Bos2Run1, 0, 0), // State.Bos2Run8
            // new MobjStateDef(566, Sprite.BOS2, 4, 8, null, ma.FaceTarget, MobjState.Bos2Atk2, 0, 0), // State.Bos2Atk1
            // new MobjStateDef(567, Sprite.BOS2, 5, 8, null, ma.FaceTarget, MobjState.Bos2Atk3, 0, 0), // State.Bos2Atk2
            // new MobjStateDef(568, Sprite.BOS2, 6, 8, null, ma.BruisAttack, MobjState.Bos2Run1, 0, 0), // State.Bos2Atk3
            // new MobjStateDef(569, Sprite.BOS2, 7, 2, null, null, MobjState.Bos2Pain2, 0, 0), // State.Bos2Pain
            // new MobjStateDef(570, Sprite.BOS2, 7, 2, null, ma.Pain, MobjState.Bos2Run1, 0, 0), // State.Bos2Pain2
            // new MobjStateDef(571, Sprite.BOS2, 8, 8, null, null, MobjState.Bos2Die2, 0, 0), // State.Bos2Die1
            // new MobjStateDef(572, Sprite.BOS2, 9, 8, null, ma.Scream, MobjState.Bos2Die3, 0, 0), // State.Bos2Die2
            // new MobjStateDef(573, Sprite.BOS2, 10, 8, null, null, MobjState.Bos2Die4, 0, 0), // State.Bos2Die3
            // new MobjStateDef(574, Sprite.BOS2, 11, 8, null, ma.Fall, MobjState.Bos2Die5, 0, 0), // State.Bos2Die4
            // new MobjStateDef(575, Sprite.BOS2, 12, 8, null, null, MobjState.Bos2Die6, 0, 0), // State.Bos2Die5
            // new MobjStateDef(576, Sprite.BOS2, 13, 8, null, null, MobjState.Bos2Die7, 0, 0), // State.Bos2Die6
            // new MobjStateDef(577, Sprite.BOS2, 14, -1, null, null, MobjState.Null, 0, 0), // State.Bos2Die7
            // new MobjStateDef(578, Sprite.BOS2, 14, 8, null, null, MobjState.Bos2Raise2, 0, 0), // State.Bos2Raise1
            // new MobjStateDef(579, Sprite.BOS2, 13, 8, null, null, MobjState.Bos2Raise3, 0, 0), // State.Bos2Raise2
            // new MobjStateDef(580, Sprite.BOS2, 12, 8, null, null, MobjState.Bos2Raise4, 0, 0), // State.Bos2Raise3
            // new MobjStateDef(581, Sprite.BOS2, 11, 8, null, null, MobjState.Bos2Raise5, 0, 0), // State.Bos2Raise4
            // new MobjStateDef(582, Sprite.BOS2, 10, 8, null, null, MobjState.Bos2Raise6, 0, 0), // State.Bos2Raise5
            // new MobjStateDef(583, Sprite.BOS2, 9, 8, null, null, MobjState.Bos2Raise7, 0, 0), // State.Bos2Raise6
            // new MobjStateDef(584, Sprite.BOS2, 8, 8, null, null, MobjState.Bos2Run1, 0, 0), // State.Bos2Raise7
            // new MobjStateDef(585, Sprite.SKUL, 32768, 10, null, ma.Look, MobjState.SkullStnd2, 0, 0), // State.SkullStnd
            // new MobjStateDef(586, Sprite.SKUL, 32769, 10, null, ma.Look, MobjState.SkullStnd, 0, 0), // State.SkullStnd2
            // new MobjStateDef(587, Sprite.SKUL, 32768, 6, null, ma.Chase, MobjState.SkullRun2, 0, 0), // State.SkullRun1
            // new MobjStateDef(588, Sprite.SKUL, 32769, 6, null, ma.Chase, MobjState.SkullRun1, 0, 0), // State.SkullRun2
            // new MobjStateDef(589, Sprite.SKUL, 32770, 10, null, ma.FaceTarget, MobjState.SkullAtk2, 0, 0), // State.SkullAtk1
            // new MobjStateDef(590, Sprite.SKUL, 32771, 4, null, ma.SkullAttack, MobjState.SkullAtk3, 0, 0), // State.SkullAtk2
            // new MobjStateDef(591, Sprite.SKUL, 32770, 4, null, null, MobjState.SkullAtk4, 0, 0), // State.SkullAtk3
            // new MobjStateDef(592, Sprite.SKUL, 32771, 4, null, null, MobjState.SkullAtk3, 0, 0), // State.SkullAtk4
            // new MobjStateDef(593, Sprite.SKUL, 32772, 3, null, null, MobjState.SkullPain2, 0, 0), // State.SkullPain
            // new MobjStateDef(594, Sprite.SKUL, 32772, 3, null, ma.Pain, MobjState.SkullRun1, 0, 0), // State.SkullPain2
            // new MobjStateDef(595, Sprite.SKUL, 32773, 6, null, null, MobjState.SkullDie2, 0, 0), // State.SkullDie1
            // new MobjStateDef(596, Sprite.SKUL, 32774, 6, null, ma.Scream, MobjState.SkullDie3, 0, 0), // State.SkullDie2
            // new MobjStateDef(597, Sprite.SKUL, 32775, 6, null, null, MobjState.SkullDie4, 0, 0), // State.SkullDie3
            // new MobjStateDef(598, Sprite.SKUL, 32776, 6, null, ma.Fall, MobjState.SkullDie5, 0, 0), // State.SkullDie4
            // new MobjStateDef(599, Sprite.SKUL, 9, 6, null, null, MobjState.SkullDie6, 0, 0), // State.SkullDie5
            // new MobjStateDef(600, Sprite.SKUL, 10, 6, null, null, MobjState.Null, 0, 0), // State.SkullDie6
            // new MobjStateDef(601, Sprite.SPID, 0, 10, null, ma.Look, MobjState.SpidStnd2, 0, 0), // State.SpidStnd
            // new MobjStateDef(602, Sprite.SPID, 1, 10, null, ma.Look, MobjState.SpidStnd, 0, 0), // State.SpidStnd2
            // new MobjStateDef(603, Sprite.SPID, 0, 3, null, ma.Metal, MobjState.SpidRun2, 0, 0), // State.SpidRun1
            // new MobjStateDef(604, Sprite.SPID, 0, 3, null, ma.Chase, MobjState.SpidRun3, 0, 0), // State.SpidRun2
            // new MobjStateDef(605, Sprite.SPID, 1, 3, null, ma.Chase, MobjState.SpidRun4, 0, 0), // State.SpidRun3
            // new MobjStateDef(606, Sprite.SPID, 1, 3, null, ma.Chase, MobjState.SpidRun5, 0, 0), // State.SpidRun4
            // new MobjStateDef(607, Sprite.SPID, 2, 3, null, ma.Metal, MobjState.SpidRun6, 0, 0), // State.SpidRun5
            // new MobjStateDef(608, Sprite.SPID, 2, 3, null, ma.Chase, MobjState.SpidRun7, 0, 0), // State.SpidRun6
            // new MobjStateDef(609, Sprite.SPID, 3, 3, null, ma.Chase, MobjState.SpidRun8, 0, 0), // State.SpidRun7
            // new MobjStateDef(610, Sprite.SPID, 3, 3, null, ma.Chase, MobjState.SpidRun9, 0, 0), // State.SpidRun8
            // new MobjStateDef(611, Sprite.SPID, 4, 3, null, ma.Metal, MobjState.SpidRun10, 0, 0), // State.SpidRun9
            // new MobjStateDef(612, Sprite.SPID, 4, 3, null, ma.Chase, MobjState.SpidRun11, 0, 0), // State.SpidRun10
            // new MobjStateDef(613, Sprite.SPID, 5, 3, null, ma.Chase, MobjState.SpidRun12, 0, 0), // State.SpidRun11
            // new MobjStateDef(614, Sprite.SPID, 5, 3, null, ma.Chase, MobjState.SpidRun1, 0, 0), // State.SpidRun12
            // new MobjStateDef(615, Sprite.SPID, 32768, 20, null, ma.FaceTarget, MobjState.SpidAtk2, 0, 0), // State.SpidAtk1
            // new MobjStateDef(616, Sprite.SPID, 32774, 4, null, ma.SPosAttack, MobjState.SpidAtk3, 0, 0), // State.SpidAtk2
            // new MobjStateDef(617, Sprite.SPID, 32775, 4, null, ma.SPosAttack, MobjState.SpidAtk4, 0, 0), // State.SpidAtk3
            // new MobjStateDef(618, Sprite.SPID, 32775, 1, null, ma.SpidRefire, MobjState.SpidAtk2, 0, 0), // State.SpidAtk4
            // new MobjStateDef(619, Sprite.SPID, 8, 3, null, null, MobjState.SpidPain2, 0, 0), // State.SpidPain
            // new MobjStateDef(620, Sprite.SPID, 8, 3, null, ma.Pain, MobjState.SpidRun1, 0, 0), // State.SpidPain2
            // new MobjStateDef(621, Sprite.SPID, 9, 20, null, ma.Scream, MobjState.SpidDie2, 0, 0), // State.SpidDie1
            // new MobjStateDef(622, Sprite.SPID, 10, 10, null, ma.Fall, MobjState.SpidDie3, 0, 0), // State.SpidDie2
            // new MobjStateDef(623, Sprite.SPID, 11, 10, null, null, MobjState.SpidDie4, 0, 0), // State.SpidDie3
            // new MobjStateDef(624, Sprite.SPID, 12, 10, null, null, MobjState.SpidDie5, 0, 0), // State.SpidDie4
            // new MobjStateDef(625, Sprite.SPID, 13, 10, null, null, MobjState.SpidDie6, 0, 0), // State.SpidDie5
            // new MobjStateDef(626, Sprite.SPID, 14, 10, null, null, MobjState.SpidDie7, 0, 0), // State.SpidDie6
            // new MobjStateDef(627, Sprite.SPID, 15, 10, null, null, MobjState.SpidDie8, 0, 0), // State.SpidDie7
            // new MobjStateDef(628, Sprite.SPID, 16, 10, null, null, MobjState.SpidDie9, 0, 0), // State.SpidDie8
            // new MobjStateDef(629, Sprite.SPID, 17, 10, null, null, MobjState.SpidDie10, 0, 0), // State.SpidDie9
            // new MobjStateDef(630, Sprite.SPID, 18, 30, null, null, MobjState.SpidDie11, 0, 0), // State.SpidDie10
            // new MobjStateDef(631, Sprite.SPID, 18, -1, null, ma.BossDeath, MobjState.Null, 0, 0), // State.SpidDie11
            // new MobjStateDef(632, Sprite.BSPI, 0, 10, null, ma.Look, MobjState.BspiStnd2, 0, 0), // State.BspiStnd
            // new MobjStateDef(633, Sprite.BSPI, 1, 10, null, ma.Look, MobjState.BspiStnd, 0, 0), // State.BspiStnd2
            // new MobjStateDef(634, Sprite.BSPI, 0, 20, null, null, MobjState.BspiRun1, 0, 0), // State.BspiSight
            // new MobjStateDef(635, Sprite.BSPI, 0, 3, null, ma.BabyMetal, MobjState.BspiRun2, 0, 0), // State.BspiRun1
            // new MobjStateDef(636, Sprite.BSPI, 0, 3, null, ma.Chase, MobjState.BspiRun3, 0, 0), // State.BspiRun2
            // new MobjStateDef(637, Sprite.BSPI, 1, 3, null, ma.Chase, MobjState.BspiRun4, 0, 0), // State.BspiRun3
            // new MobjStateDef(638, Sprite.BSPI, 1, 3, null, ma.Chase, MobjState.BspiRun5, 0, 0), // State.BspiRun4
            // new MobjStateDef(639, Sprite.BSPI, 2, 3, null, ma.Chase, MobjState.BspiRun6, 0, 0), // State.BspiRun5
            // new MobjStateDef(640, Sprite.BSPI, 2, 3, null, ma.Chase, MobjState.BspiRun7, 0, 0), // State.BspiRun6
            // new MobjStateDef(641, Sprite.BSPI, 3, 3, null, ma.BabyMetal, MobjState.BspiRun8, 0, 0), // State.BspiRun7
            // new MobjStateDef(642, Sprite.BSPI, 3, 3, null, ma.Chase, MobjState.BspiRun9, 0, 0), // State.BspiRun8
            // new MobjStateDef(643, Sprite.BSPI, 4, 3, null, ma.Chase, MobjState.BspiRun10, 0, 0), // State.BspiRun9
            // new MobjStateDef(644, Sprite.BSPI, 4, 3, null, ma.Chase, MobjState.BspiRun11, 0, 0), // State.BspiRun10
            // new MobjStateDef(645, Sprite.BSPI, 5, 3, null, ma.Chase, MobjState.BspiRun12, 0, 0), // State.BspiRun11
            // new MobjStateDef(646, Sprite.BSPI, 5, 3, null, ma.Chase, MobjState.BspiRun1, 0, 0), // State.BspiRun12
            // new MobjStateDef(647, Sprite.BSPI, 32768, 20, null, ma.FaceTarget, MobjState.BspiAtk2, 0, 0), // State.BspiAtk1
            // new MobjStateDef(648, Sprite.BSPI, 32774, 4, null, ma.BspiAttack, MobjState.BspiAtk3, 0, 0), // State.BspiAtk2
            // new MobjStateDef(649, Sprite.BSPI, 32775, 4, null, null, MobjState.BspiAtk4, 0, 0), // State.BspiAtk3
            // new MobjStateDef(650, Sprite.BSPI, 32775, 1, null, ma.SpidRefire, MobjState.BspiAtk2, 0, 0), // State.BspiAtk4
            // new MobjStateDef(651, Sprite.BSPI, 8, 3, null, null, MobjState.BspiPain2, 0, 0), // State.BspiPain
            // new MobjStateDef(652, Sprite.BSPI, 8, 3, null, ma.Pain, MobjState.BspiRun1, 0, 0), // State.BspiPain2
            // new MobjStateDef(653, Sprite.BSPI, 9, 20, null, ma.Scream, MobjState.BspiDie2, 0, 0), // State.BspiDie1
            // new MobjStateDef(654, Sprite.BSPI, 10, 7, null, ma.Fall, MobjState.BspiDie3, 0, 0), // State.BspiDie2
            // new MobjStateDef(655, Sprite.BSPI, 11, 7, null, null, MobjState.BspiDie4, 0, 0), // State.BspiDie3
            // new MobjStateDef(656, Sprite.BSPI, 12, 7, null, null, MobjState.BspiDie5, 0, 0), // State.BspiDie4
            // new MobjStateDef(657, Sprite.BSPI, 13, 7, null, null, MobjState.BspiDie6, 0, 0), // State.BspiDie5
            // new MobjStateDef(658, Sprite.BSPI, 14, 7, null, null, MobjState.BspiDie7, 0, 0), // State.BspiDie6
            // new MobjStateDef(659, Sprite.BSPI, 15, -1, null, ma.BossDeath, MobjState.Null, 0, 0), // State.BspiDie7
            // new MobjStateDef(660, Sprite.BSPI, 15, 5, null, null, MobjState.BspiRaise2, 0, 0), // State.BspiRaise1
            // new MobjStateDef(661, Sprite.BSPI, 14, 5, null, null, MobjState.BspiRaise3, 0, 0), // State.BspiRaise2
            // new MobjStateDef(662, Sprite.BSPI, 13, 5, null, null, MobjState.BspiRaise4, 0, 0), // State.BspiRaise3
            // new MobjStateDef(663, Sprite.BSPI, 12, 5, null, null, MobjState.BspiRaise5, 0, 0), // State.BspiRaise4
            // new MobjStateDef(664, Sprite.BSPI, 11, 5, null, null, MobjState.BspiRaise6, 0, 0), // State.BspiRaise5
            // new MobjStateDef(665, Sprite.BSPI, 10, 5, null, null, MobjState.BspiRaise7, 0, 0), // State.BspiRaise6
            // new MobjStateDef(666, Sprite.BSPI, 9, 5, null, null, MobjState.BspiRun1, 0, 0), // State.BspiRaise7
            // new MobjStateDef(667, Sprite.APLS, 32768, 5, null, null, MobjState.ArachPlaz2, 0, 0), // State.ArachPlaz
            // new MobjStateDef(668, Sprite.APLS, 32769, 5, null, null, MobjState.ArachPlaz, 0, 0), // State.ArachPlaz2
            // new MobjStateDef(669, Sprite.APBX, 32768, 5, null, null, MobjState.ArachPlex2, 0, 0), // State.ArachPlex
            // new MobjStateDef(670, Sprite.APBX, 32769, 5, null, null, MobjState.ArachPlex3, 0, 0), // State.ArachPlex2
            // new MobjStateDef(671, Sprite.APBX, 32770, 5, null, null, MobjState.ArachPlex4, 0, 0), // State.ArachPlex3
            // new MobjStateDef(672, Sprite.APBX, 32771, 5, null, null, MobjState.ArachPlex5, 0, 0), // State.ArachPlex4
            // new MobjStateDef(673, Sprite.APBX, 32772, 5, null, null, MobjState.Null, 0, 0), // State.ArachPlex5
            // new MobjStateDef(674, Sprite.CYBR, 0, 10, null, ma.Look, MobjState.CyberStnd2, 0, 0), // State.CyberStnd
            // new MobjStateDef(675, Sprite.CYBR, 1, 10, null, ma.Look, MobjState.CyberStnd, 0, 0), // State.CyberStnd2
            // new MobjStateDef(676, Sprite.CYBR, 0, 3, null, ma.Hoof, MobjState.CyberRun2, 0, 0), // State.CyberRun1
            // new MobjStateDef(677, Sprite.CYBR, 0, 3, null, ma.Chase, MobjState.CyberRun3, 0, 0), // State.CyberRun2
            // new MobjStateDef(678, Sprite.CYBR, 1, 3, null, ma.Chase, MobjState.CyberRun4, 0, 0), // State.CyberRun3
            // new MobjStateDef(679, Sprite.CYBR, 1, 3, null, ma.Chase, MobjState.CyberRun5, 0, 0), // State.CyberRun4
            // new MobjStateDef(680, Sprite.CYBR, 2, 3, null, ma.Chase, MobjState.CyberRun6, 0, 0), // State.CyberRun5
            // new MobjStateDef(681, Sprite.CYBR, 2, 3, null, ma.Chase, MobjState.CyberRun7, 0, 0), // State.CyberRun6
            // new MobjStateDef(682, Sprite.CYBR, 3, 3, null, ma.Metal, MobjState.CyberRun8, 0, 0), // State.CyberRun7
            // new MobjStateDef(683, Sprite.CYBR, 3, 3, null, ma.Chase, MobjState.CyberRun1, 0, 0), // State.CyberRun8
            // new MobjStateDef(684, Sprite.CYBR, 4, 6, null, ma.FaceTarget, MobjState.CyberAtk2, 0, 0), // State.CyberAtk1
            // new MobjStateDef(685, Sprite.CYBR, 5, 12, null, ma.CyberAttack, MobjState.CyberAtk3, 0, 0), // State.CyberAtk2
            // new MobjStateDef(686, Sprite.CYBR, 4, 12, null, ma.FaceTarget, MobjState.CyberAtk4, 0, 0), // State.CyberAtk3
            // new MobjStateDef(687, Sprite.CYBR, 5, 12, null, ma.CyberAttack, MobjState.CyberAtk5, 0, 0), // State.CyberAtk4
            // new MobjStateDef(688, Sprite.CYBR, 4, 12, null, ma.FaceTarget, MobjState.CyberAtk6, 0, 0), // State.CyberAtk5
            // new MobjStateDef(689, Sprite.CYBR, 5, 12, null, ma.CyberAttack, MobjState.CyberRun1, 0, 0), // State.CyberAtk6
            // new MobjStateDef(690, Sprite.CYBR, 6, 10, null, ma.Pain, MobjState.CyberRun1, 0, 0), // State.CyberPain
            // new MobjStateDef(691, Sprite.CYBR, 7, 10, null, null, MobjState.CyberDie2, 0, 0), // State.CyberDie1
            // new MobjStateDef(692, Sprite.CYBR, 8, 10, null, ma.Scream, MobjState.CyberDie3, 0, 0), // State.CyberDie2
            // new MobjStateDef(693, Sprite.CYBR, 9, 10, null, null, MobjState.CyberDie4, 0, 0), // State.CyberDie3
            // new MobjStateDef(694, Sprite.CYBR, 10, 10, null, null, MobjState.CyberDie5, 0, 0), // State.CyberDie4
            // new MobjStateDef(695, Sprite.CYBR, 11, 10, null, null, MobjState.CyberDie6, 0, 0), // State.CyberDie5
            // new MobjStateDef(696, Sprite.CYBR, 12, 10, null, ma.Fall, MobjState.CyberDie7, 0, 0), // State.CyberDie6
            // new MobjStateDef(697, Sprite.CYBR, 13, 10, null, null, MobjState.CyberDie8, 0, 0), // State.CyberDie7
            // new MobjStateDef(698, Sprite.CYBR, 14, 10, null, null, MobjState.CyberDie9, 0, 0), // State.CyberDie8
            // new MobjStateDef(699, Sprite.CYBR, 15, 30, null, null, MobjState.CyberDie10, 0, 0), // State.CyberDie9
            // new MobjStateDef(700, Sprite.CYBR, 15, -1, null, ma.BossDeath, MobjState.Null, 0, 0), // State.CyberDie10
            // new MobjStateDef(701, Sprite.PAIN, 0, 10, null, ma.Look, MobjState.PainStnd, 0, 0), // State.PainStnd
            // new MobjStateDef(702, Sprite.PAIN, 0, 3, null, ma.Chase, MobjState.PainRun2, 0, 0), // State.PainRun1
            // new MobjStateDef(703, Sprite.PAIN, 0, 3, null, ma.Chase, MobjState.PainRun3, 0, 0), // State.PainRun2
            // new MobjStateDef(704, Sprite.PAIN, 1, 3, null, ma.Chase, MobjState.PainRun4, 0, 0), // State.PainRun3
            // new MobjStateDef(705, Sprite.PAIN, 1, 3, null, ma.Chase, MobjState.PainRun5, 0, 0), // State.PainRun4
            // new MobjStateDef(706, Sprite.PAIN, 2, 3, null, ma.Chase, MobjState.PainRun6, 0, 0), // State.PainRun5
            // new MobjStateDef(707, Sprite.PAIN, 2, 3, null, ma.Chase, MobjState.PainRun1, 0, 0), // State.PainRun6
            // new MobjStateDef(708, Sprite.PAIN, 3, 5, null, ma.FaceTarget, MobjState.PainAtk2, 0, 0), // State.PainAtk1
            // new MobjStateDef(709, Sprite.PAIN, 4, 5, null, ma.FaceTarget, MobjState.PainAtk3, 0, 0), // State.PainAtk2
            // new MobjStateDef(710, Sprite.PAIN, 32773, 5, null, ma.FaceTarget, MobjState.PainAtk4, 0, 0), // State.PainAtk3
            // new MobjStateDef(711, Sprite.PAIN, 32773, 0, null, ma.PainAttack, MobjState.PainRun1, 0, 0), // State.PainAtk4
            // new MobjStateDef(712, Sprite.PAIN, 6, 6, null, null, MobjState.PainPain2, 0, 0), // State.PainPain
            // new MobjStateDef(713, Sprite.PAIN, 6, 6, null, ma.Pain, MobjState.PainRun1, 0, 0), // State.PainPain2
            // new MobjStateDef(714, Sprite.PAIN, 32775, 8, null, null, MobjState.PainDie2, 0, 0), // State.PainDie1
            // new MobjStateDef(715, Sprite.PAIN, 32776, 8, null, ma.Scream, MobjState.PainDie3, 0, 0), // State.PainDie2
            // new MobjStateDef(716, Sprite.PAIN, 32777, 8, null, null, MobjState.PainDie4, 0, 0), // State.PainDie3
            // new MobjStateDef(717, Sprite.PAIN, 32778, 8, null, null, MobjState.PainDie5, 0, 0), // State.PainDie4
            // new MobjStateDef(718, Sprite.PAIN, 32779, 8, null, ma.PainDie, MobjState.PainDie6, 0, 0), // State.PainDie5
            // new MobjStateDef(719, Sprite.PAIN, 32780, 8, null, null, MobjState.Null, 0, 0), // State.PainDie6
            // new MobjStateDef(720, Sprite.PAIN, 12, 8, null, null, MobjState.PainRaise2, 0, 0), // State.PainRaise1
            // new MobjStateDef(721, Sprite.PAIN, 11, 8, null, null, MobjState.PainRaise3, 0, 0), // State.PainRaise2
            // new MobjStateDef(722, Sprite.PAIN, 10, 8, null, null, MobjState.PainRaise4, 0, 0), // State.PainRaise3
            // new MobjStateDef(723, Sprite.PAIN, 9, 8, null, null, MobjState.PainRaise5, 0, 0), // State.PainRaise4
            // new MobjStateDef(724, Sprite.PAIN, 8, 8, null, null, MobjState.PainRaise6, 0, 0), // State.PainRaise5
            // new MobjStateDef(725, Sprite.PAIN, 7, 8, null, null, MobjState.PainRun1, 0, 0), // State.PainRaise6
            // new MobjStateDef(726, Sprite.SSWV, 0, 10, null, ma.Look, MobjState.SswvStnd2, 0, 0), // State.SswvStnd
            // new MobjStateDef(727, Sprite.SSWV, 1, 10, null, ma.Look, MobjState.SswvStnd, 0, 0), // State.SswvStnd2
            // new MobjStateDef(728, Sprite.SSWV, 0, 3, null, ma.Chase, MobjState.SswvRun2, 0, 0), // State.SswvRun1
            // new MobjStateDef(729, Sprite.SSWV, 0, 3, null, ma.Chase, MobjState.SswvRun3, 0, 0), // State.SswvRun2
            // new MobjStateDef(730, Sprite.SSWV, 1, 3, null, ma.Chase, MobjState.SswvRun4, 0, 0), // State.SswvRun3
            // new MobjStateDef(731, Sprite.SSWV, 1, 3, null, ma.Chase, MobjState.SswvRun5, 0, 0), // State.SswvRun4
            // new MobjStateDef(732, Sprite.SSWV, 2, 3, null, ma.Chase, MobjState.SswvRun6, 0, 0), // State.SswvRun5
            // new MobjStateDef(733, Sprite.SSWV, 2, 3, null, ma.Chase, MobjState.SswvRun7, 0, 0), // State.SswvRun6
            // new MobjStateDef(734, Sprite.SSWV, 3, 3, null, ma.Chase, MobjState.SswvRun8, 0, 0), // State.SswvRun7
            // new MobjStateDef(735, Sprite.SSWV, 3, 3, null, ma.Chase, MobjState.SswvRun1, 0, 0), // State.SswvRun8
            // new MobjStateDef(736, Sprite.SSWV, 4, 10, null, ma.FaceTarget, MobjState.SswvAtk2, 0, 0), // State.SswvAtk1
            // new MobjStateDef(737, Sprite.SSWV, 5, 10, null, ma.FaceTarget, MobjState.SswvAtk3, 0, 0), // State.SswvAtk2
            // new MobjStateDef(738, Sprite.SSWV, 32774, 4, null, ma.CPosAttack, MobjState.SswvAtk4, 0, 0), // State.SswvAtk3
            // new MobjStateDef(739, Sprite.SSWV, 5, 6, null, ma.FaceTarget, MobjState.SswvAtk5, 0, 0), // State.SswvAtk4
            // new MobjStateDef(740, Sprite.SSWV, 32774, 4, null, ma.CPosAttack, MobjState.SswvAtk6, 0, 0), // State.SswvAtk5
            // new MobjStateDef(741, Sprite.SSWV, 5, 1, null, ma.CPosRefire, MobjState.SswvAtk2, 0, 0), // State.SswvAtk6
            // new MobjStateDef(742, Sprite.SSWV, 7, 3, null, null, MobjState.SswvPain2, 0, 0), // State.SswvPain
            // new MobjStateDef(743, Sprite.SSWV, 7, 3, null, ma.Pain, MobjState.SswvRun1, 0, 0), // State.SswvPain2
            // new MobjStateDef(744, Sprite.SSWV, 8, 5, null, null, MobjState.SswvDie2, 0, 0), // State.SswvDie1
            // new MobjStateDef(745, Sprite.SSWV, 9, 5, null, ma.Scream, MobjState.SswvDie3, 0, 0), // State.SswvDie2
            // new MobjStateDef(746, Sprite.SSWV, 10, 5, null, ma.Fall, MobjState.SswvDie4, 0, 0), // State.SswvDie3
            // new MobjStateDef(747, Sprite.SSWV, 11, 5, null, null, MobjState.SswvDie5, 0, 0), // State.SswvDie4
            // new MobjStateDef(748, Sprite.SSWV, 12, -1, null, null, MobjState.Null, 0, 0), // State.SswvDie5
            // new MobjStateDef(749, Sprite.SSWV, 13, 5, null, null, MobjState.SswvXdie2, 0, 0), // State.SswvXdie1
            // new MobjStateDef(750, Sprite.SSWV, 14, 5, null, ma.XScream, MobjState.SswvXdie3, 0, 0), // State.SswvXdie2
            // new MobjStateDef(751, Sprite.SSWV, 15, 5, null, ma.Fall, MobjState.SswvXdie4, 0, 0), // State.SswvXdie3
            // new MobjStateDef(752, Sprite.SSWV, 16, 5, null, null, MobjState.SswvXdie5, 0, 0), // State.SswvXdie4
            // new MobjStateDef(753, Sprite.SSWV, 17, 5, null, null, MobjState.SswvXdie6, 0, 0), // State.SswvXdie5
            // new MobjStateDef(754, Sprite.SSWV, 18, 5, null, null, MobjState.SswvXdie7, 0, 0), // State.SswvXdie6
            // new MobjStateDef(755, Sprite.SSWV, 19, 5, null, null, MobjState.SswvXdie8, 0, 0), // State.SswvXdie7
            // new MobjStateDef(756, Sprite.SSWV, 20, 5, null, null, MobjState.SswvXdie9, 0, 0), // State.SswvXdie8
            // new MobjStateDef(757, Sprite.SSWV, 21, -1, null, null, MobjState.Null, 0, 0), // State.SswvXdie9
            // new MobjStateDef(758, Sprite.SSWV, 12, 5, null, null, MobjState.SswvRaise2, 0, 0), // State.SswvRaise1
            // new MobjStateDef(759, Sprite.SSWV, 11, 5, null, null, MobjState.SswvRaise3, 0, 0), // State.SswvRaise2
            // new MobjStateDef(760, Sprite.SSWV, 10, 5, null, null, MobjState.SswvRaise4, 0, 0), // State.SswvRaise3
            // new MobjStateDef(761, Sprite.SSWV, 9, 5, null, null, MobjState.SswvRaise5, 0, 0), // State.SswvRaise4
            // new MobjStateDef(762, Sprite.SSWV, 8, 5, null, null, MobjState.SswvRun1, 0, 0), // State.SswvRaise5
            // new MobjStateDef(763, Sprite.KEEN, 0, -1, null, null, MobjState.Keenstnd, 0, 0), // State.Keenstnd
            // new MobjStateDef(764, Sprite.KEEN, 0, 6, null, null, MobjState.Commkeen2, 0, 0), // State.Commkeen
            // new MobjStateDef(765, Sprite.KEEN, 1, 6, null, null, MobjState.Commkeen3, 0, 0), // State.Commkeen2
            // new MobjStateDef(766, Sprite.KEEN, 2, 6, null, ma.Scream, MobjState.Commkeen4, 0, 0), // State.Commkeen3
            // new MobjStateDef(767, Sprite.KEEN, 3, 6, null, null, MobjState.Commkeen5, 0, 0), // State.Commkeen4
            // new MobjStateDef(768, Sprite.KEEN, 4, 6, null, null, MobjState.Commkeen6, 0, 0), // State.Commkeen5
            // new MobjStateDef(769, Sprite.KEEN, 5, 6, null, null, MobjState.Commkeen7, 0, 0), // State.Commkeen6
            // new MobjStateDef(770, Sprite.KEEN, 6, 6, null, null, MobjState.Commkeen8, 0, 0), // State.Commkeen7
            // new MobjStateDef(771, Sprite.KEEN, 7, 6, null, null, MobjState.Commkeen9, 0, 0), // State.Commkeen8
            // new MobjStateDef(772, Sprite.KEEN, 8, 6, null, null, MobjState.Commkeen10, 0, 0), // State.Commkeen9
            // new MobjStateDef(773, Sprite.KEEN, 9, 6, null, null, MobjState.Commkeen11, 0, 0), // State.Commkeen10
            // new MobjStateDef(774, Sprite.KEEN, 10, 6, null, ma.KeenDie, MobjState.Commkeen12, 0, 0), // State.Commkeen11
            // new MobjStateDef(775, Sprite.KEEN, 11, -1, null, null, MobjState.Null, 0, 0), // State.Commkeen12
            // new MobjStateDef(776, Sprite.KEEN, 12, 4, null, null, MobjState.Keenpain2, 0, 0), // State.Keenpain
            // new MobjStateDef(777, Sprite.KEEN, 12, 8, null, ma.Pain, MobjState.Keenstnd, 0, 0), // State.Keenpain2
            // new MobjStateDef(778, Sprite.BBRN, 0, -1, null, null, MobjState.Null, 0, 0), // State.Brain
            // new MobjStateDef(779, Sprite.BBRN, 1, 36, null, ma.BrainPain, MobjState.Brain, 0, 0), // State.BrainPain
            // new MobjStateDef(780, Sprite.BBRN, 0, 100, null, ma.BrainScream, MobjState.BrainDie2, 0, 0), // State.BrainDie1
            // new MobjStateDef(781, Sprite.BBRN, 0, 10, null, null, MobjState.BrainDie3, 0, 0), // State.BrainDie2
            // new MobjStateDef(782, Sprite.BBRN, 0, 10, null, null, MobjState.BrainDie4, 0, 0), // State.BrainDie3
            // new MobjStateDef(783, Sprite.BBRN, 0, -1, null, ma.BrainDie, MobjState.Null, 0, 0), // State.BrainDie4
            // new MobjStateDef(784, Sprite.SSWV, 0, 10, null, ma.Look, MobjState.Braineye, 0, 0), // State.Braineye
            // new MobjStateDef(785, Sprite.SSWV, 0, 181, null, ma.BrainAwake, MobjState.Braineye1, 0, 0), // State.Braineyesee
            // new MobjStateDef(786, Sprite.SSWV, 0, 150, null, ma.BrainSpit, MobjState.Braineye1, 0, 0), // State.Braineye1
            // new MobjStateDef(787, Sprite.BOSF, 32768, 3, null, ma.SpawnSound, MobjState.Spawn2, 0, 0), // State.Spawn1
            // new MobjStateDef(788, Sprite.BOSF, 32769, 3, null, ma.SpawnFly, MobjState.Spawn3, 0, 0), // State.Spawn2
            // new MobjStateDef(789, Sprite.BOSF, 32770, 3, null, ma.SpawnFly, MobjState.Spawn4, 0, 0), // State.Spawn3
            // new MobjStateDef(790, Sprite.BOSF, 32771, 3, null, ma.SpawnFly, MobjState.Spawn1, 0, 0), // State.Spawn4
            // new MobjStateDef(791, Sprite.FIRE, 32768, 4, null, ma.Fire, MobjState.Spawnfire2, 0, 0), // State.Spawnfire1
            // new MobjStateDef(792, Sprite.FIRE, 32769, 4, null, ma.Fire, MobjState.Spawnfire3, 0, 0), // State.Spawnfire2
            // new MobjStateDef(793, Sprite.FIRE, 32770, 4, null, ma.Fire, MobjState.Spawnfire4, 0, 0), // State.Spawnfire3
            // new MobjStateDef(794, Sprite.FIRE, 32771, 4, null, ma.Fire, MobjState.Spawnfire5, 0, 0), // State.Spawnfire4
            // new MobjStateDef(795, Sprite.FIRE, 32772, 4, null, ma.Fire, MobjState.Spawnfire6, 0, 0), // State.Spawnfire5
            // new MobjStateDef(796, Sprite.FIRE, 32773, 4, null, ma.Fire, MobjState.Spawnfire7, 0, 0), // State.Spawnfire6
            // new MobjStateDef(797, Sprite.FIRE, 32774, 4, null, ma.Fire, MobjState.Spawnfire8, 0, 0), // State.Spawnfire7
            // new MobjStateDef(798, Sprite.FIRE, 32775, 4, null, ma.Fire, MobjState.Null, 0, 0), // State.Spawnfire8
            // new MobjStateDef(799, Sprite.MISL, 32769, 10, null, null, MobjState.Brainexplode2, 0, 0), // State.Brainexplode1
            // new MobjStateDef(800, Sprite.MISL, 32770, 10, null, null, MobjState.Brainexplode3, 0, 0), // State.Brainexplode2
            // new MobjStateDef(801, Sprite.MISL, 32771, 10, null, ma.BrainExplode, MobjState.Null, 0, 0), // State.Brainexplode3
            // new MobjStateDef(802, Sprite.ARM1, 0, 6, null, null, MobjState.Arm1A, 0, 0), // State.Arm1
            // new MobjStateDef(803, Sprite.ARM1, 32769, 7, null, null, MobjState.Arm1, 0, 0), // State.Arm1A
            // new MobjStateDef(804, Sprite.ARM2, 0, 6, null, null, MobjState.Arm2A, 0, 0), // State.Arm2
            // new MobjStateDef(805, Sprite.ARM2, 32769, 6, null, null, MobjState.Arm2, 0, 0), // State.Arm2A
            // new MobjStateDef(806, Sprite.BAR1, 0, 6, null, null, MobjState.Bar2, 0, 0), // State.Bar1
            // new MobjStateDef(807, Sprite.BAR1, 1, 6, null, null, MobjState.Bar1, 0, 0), // State.Bar2
            // new MobjStateDef(808, Sprite.BEXP, 32768, 5, null, null, MobjState.Bexp2, 0, 0), // State.Bexp
            // new MobjStateDef(809, Sprite.BEXP, 32769, 5, null, ma.Scream, MobjState.Bexp3, 0, 0), // State.Bexp2
            // new MobjStateDef(810, Sprite.BEXP, 32770, 5, null, null, MobjState.Bexp4, 0, 0), // State.Bexp3
            // new MobjStateDef(811, Sprite.BEXP, 32771, 10, null, ma.Explode, MobjState.Bexp5, 0, 0), // State.Bexp4
            // new MobjStateDef(812, Sprite.BEXP, 32772, 10, null, null, MobjState.Null, 0, 0), // State.Bexp5
            // new MobjStateDef(813, Sprite.FCAN, 32768, 4, null, null, MobjState.Bbar2, 0, 0), // State.Bbar1
            // new MobjStateDef(814, Sprite.FCAN, 32769, 4, null, null, MobjState.Bbar3, 0, 0), // State.Bbar2
            // new MobjStateDef(815, Sprite.FCAN, 32770, 4, null, null, MobjState.Bbar1, 0, 0), // State.Bbar3
            // new MobjStateDef(816, Sprite.BON1, 0, 6, null, null, MobjState.Bon1A, 0, 0), // State.Bon1
            // new MobjStateDef(817, Sprite.BON1, 1, 6, null, null, MobjState.Bon1B, 0, 0), // State.Bon1A
            // new MobjStateDef(818, Sprite.BON1, 2, 6, null, null, MobjState.Bon1C, 0, 0), // State.Bon1B
            // new MobjStateDef(819, Sprite.BON1, 3, 6, null, null, MobjState.Bon1D, 0, 0), // State.Bon1C
            // new MobjStateDef(820, Sprite.BON1, 2, 6, null, null, MobjState.Bon1E, 0, 0), // State.Bon1D
            // new MobjStateDef(821, Sprite.BON1, 1, 6, null, null, MobjState.Bon1, 0, 0), // State.Bon1E
            // new MobjStateDef(822, Sprite.BON2, 0, 6, null, null, MobjState.Bon2A, 0, 0), // State.Bon2
            // new MobjStateDef(823, Sprite.BON2, 1, 6, null, null, MobjState.Bon2B, 0, 0), // State.Bon2A
            // new MobjStateDef(824, Sprite.BON2, 2, 6, null, null, MobjState.Bon2C, 0, 0), // State.Bon2B
            // new MobjStateDef(825, Sprite.BON2, 3, 6, null, null, MobjState.Bon2D, 0, 0), // State.Bon2C
            // new MobjStateDef(826, Sprite.BON2, 2, 6, null, null, MobjState.Bon2E, 0, 0), // State.Bon2D
            // new MobjStateDef(827, Sprite.BON2, 1, 6, null, null, MobjState.Bon2, 0, 0), // State.Bon2E
            // new MobjStateDef(828, Sprite.BKEY, 0, 10, null, null, MobjState.Bkey2, 0, 0), // State.Bkey
            // new MobjStateDef(829, Sprite.BKEY, 32769, 10, null, null, MobjState.Bkey, 0, 0), // State.Bkey2
            // new MobjStateDef(830, Sprite.RKEY, 0, 10, null, null, MobjState.Rkey2, 0, 0), // State.Rkey
            // new MobjStateDef(831, Sprite.RKEY, 32769, 10, null, null, MobjState.Rkey, 0, 0), // State.Rkey2
            // new MobjStateDef(832, Sprite.YKEY, 0, 10, null, null, MobjState.Ykey2, 0, 0), // State.Ykey
            // new MobjStateDef(833, Sprite.YKEY, 32769, 10, null, null, MobjState.Ykey, 0, 0), // State.Ykey2
            // new MobjStateDef(834, Sprite.BSKU, 0, 10, null, null, MobjState.Bskull2, 0, 0), // State.Bskull
            // new MobjStateDef(835, Sprite.BSKU, 32769, 10, null, null, MobjState.Bskull, 0, 0), // State.Bskull2
            // new MobjStateDef(836, Sprite.RSKU, 0, 10, null, null, MobjState.Rskull2, 0, 0), // State.Rskull
            // new MobjStateDef(837, Sprite.RSKU, 32769, 10, null, null, MobjState.Rskull, 0, 0), // State.Rskull2
            // new MobjStateDef(838, Sprite.YSKU, 0, 10, null, null, MobjState.Yskull2, 0, 0), // State.Yskull
            // new MobjStateDef(839, Sprite.YSKU, 32769, 10, null, null, MobjState.Yskull, 0, 0), // State.Yskull2
            // new MobjStateDef(840, Sprite.STIM, 0, -1, null, null, MobjState.Null, 0, 0), // State.Stim
            // new MobjStateDef(841, Sprite.MEDI, 0, -1, null, null, MobjState.Null, 0, 0), // State.Medi
            // new MobjStateDef(842, Sprite.SOUL, 32768, 6, null, null, MobjState.Soul2, 0, 0), // State.Soul
            // new MobjStateDef(843, Sprite.SOUL, 32769, 6, null, null, MobjState.Soul3, 0, 0), // State.Soul2
            // new MobjStateDef(844, Sprite.SOUL, 32770, 6, null, null, MobjState.Soul4, 0, 0), // State.Soul3
            // new MobjStateDef(845, Sprite.SOUL, 32771, 6, null, null, MobjState.Soul5, 0, 0), // State.Soul4
            // new MobjStateDef(846, Sprite.SOUL, 32770, 6, null, null, MobjState.Soul6, 0, 0), // State.Soul5
            // new MobjStateDef(847, Sprite.SOUL, 32769, 6, null, null, MobjState.Soul, 0, 0), // State.Soul6
            // new MobjStateDef(848, Sprite.PINV, 32768, 6, null, null, MobjState.Pinv2, 0, 0), // State.Pinv
            // new MobjStateDef(849, Sprite.PINV, 32769, 6, null, null, MobjState.Pinv3, 0, 0), // State.Pinv2
            // new MobjStateDef(850, Sprite.PINV, 32770, 6, null, null, MobjState.Pinv4, 0, 0), // State.Pinv3
            // new MobjStateDef(851, Sprite.PINV, 32771, 6, null, null, MobjState.Pinv, 0, 0), // State.Pinv4
            // new MobjStateDef(852, Sprite.PSTR, 32768, -1, null, null, MobjState.Null, 0, 0), // State.Pstr
            // new MobjStateDef(853, Sprite.PINS, 32768, 6, null, null, MobjState.Pins2, 0, 0), // State.Pins
            // new MobjStateDef(854, Sprite.PINS, 32769, 6, null, null, MobjState.Pins3, 0, 0), // State.Pins2
            // new MobjStateDef(855, Sprite.PINS, 32770, 6, null, null, MobjState.Pins4, 0, 0), // State.Pins3
            // new MobjStateDef(856, Sprite.PINS, 32771, 6, null, null, MobjState.Pins, 0, 0), // State.Pins4
            // new MobjStateDef(857, Sprite.MEGA, 32768, 6, null, null, MobjState.Mega2, 0, 0), // State.Mega
            // new MobjStateDef(858, Sprite.MEGA, 32769, 6, null, null, MobjState.Mega3, 0, 0), // State.Mega2
            // new MobjStateDef(859, Sprite.MEGA, 32770, 6, null, null, MobjState.Mega4, 0, 0), // State.Mega3
            // new MobjStateDef(860, Sprite.MEGA, 32771, 6, null, null, MobjState.Mega, 0, 0), // State.Mega4
            // new MobjStateDef(861, Sprite.SUIT, 32768, -1, null, null, MobjState.Null, 0, 0), // State.Suit
            // new MobjStateDef(862, Sprite.PMAP, 32768, 6, null, null, MobjState.Pmap2, 0, 0), // State.Pmap
            // new MobjStateDef(863, Sprite.PMAP, 32769, 6, null, null, MobjState.Pmap3, 0, 0), // State.Pmap2
            // new MobjStateDef(864, Sprite.PMAP, 32770, 6, null, null, MobjState.Pmap4, 0, 0), // State.Pmap3
            // new MobjStateDef(865, Sprite.PMAP, 32771, 6, null, null, MobjState.Pmap5, 0, 0), // State.Pmap4
            // new MobjStateDef(866, Sprite.PMAP, 32770, 6, null, null, MobjState.Pmap6, 0, 0), // State.Pmap5
            // new MobjStateDef(867, Sprite.PMAP, 32769, 6, null, null, MobjState.Pmap, 0, 0), // State.Pmap6
            // new MobjStateDef(868, Sprite.PVIS, 32768, 6, null, null, MobjState.Pvis2, 0, 0), // State.Pvis
            // new MobjStateDef(869, Sprite.PVIS, 1, 6, null, null, MobjState.Pvis, 0, 0), // State.Pvis2
            // new MobjStateDef(870, Sprite.CLIP, 0, -1, null, null, MobjState.Null, 0, 0), // State.Clip
            // new MobjStateDef(871, Sprite.AMMO, 0, -1, null, null, MobjState.Null, 0, 0), // State.Ammo
            // new MobjStateDef(872, Sprite.ROCK, 0, -1, null, null, MobjState.Null, 0, 0), // State.Rock
            // new MobjStateDef(873, Sprite.BROK, 0, -1, null, null, MobjState.Null, 0, 0), // State.Brok
            // new MobjStateDef(874, Sprite.CELL, 0, -1, null, null, MobjState.Null, 0, 0), // State.Cell
            // new MobjStateDef(875, Sprite.CELP, 0, -1, null, null, MobjState.Null, 0, 0), // State.Celp
            // new MobjStateDef(876, Sprite.SHEL, 0, -1, null, null, MobjState.Null, 0, 0), // State.Shel
            // new MobjStateDef(877, Sprite.SBOX, 0, -1, null, null, MobjState.Null, 0, 0), // State.Sbox
            // new MobjStateDef(878, Sprite.BPAK, 0, -1, null, null, MobjState.Null, 0, 0), // State.Bpak
            // new MobjStateDef(879, Sprite.BFUG, 0, -1, null, null, MobjState.Null, 0, 0), // State.Bfug
            // new MobjStateDef(880, Sprite.MGUN, 0, -1, null, null, MobjState.Null, 0, 0), // State.Mgun
            // new MobjStateDef(881, Sprite.CSAW, 0, -1, null, null, MobjState.Null, 0, 0), // State.Csaw
            // new MobjStateDef(882, Sprite.LAUN, 0, -1, null, null, MobjState.Null, 0, 0), // State.Laun
            // new MobjStateDef(883, Sprite.PLAS, 0, -1, null, null, MobjState.Null, 0, 0), // State.Plas
            // new MobjStateDef(884, Sprite.SHOT, 0, -1, null, null, MobjState.Null, 0, 0), // State.Shot
            // new MobjStateDef(885, Sprite.SGN2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Shot2
            // new MobjStateDef(886, Sprite.COLU, 32768, -1, null, null, MobjState.Null, 0, 0), // State.Colu
            // new MobjStateDef(887, Sprite.SMT2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Stalag
            // new MobjStateDef(888, Sprite.GOR1, 0, 10, null, null, MobjState.Bloodytwitch2, 0, 0), // State.Bloodytwitch
            // new MobjStateDef(889, Sprite.GOR1, 1, 15, null, null, MobjState.Bloodytwitch3, 0, 0), // State.Bloodytwitch2
            // new MobjStateDef(890, Sprite.GOR1, 2, 8, null, null, MobjState.Bloodytwitch4, 0, 0), // State.Bloodytwitch3
            // new MobjStateDef(891, Sprite.GOR1, 1, 6, null, null, MobjState.Bloodytwitch, 0, 0), // State.Bloodytwitch4
            // new MobjStateDef(892, Sprite.PLAY, 13, -1, null, null, MobjState.Null, 0, 0), // State.Deadtorso
            // new MobjStateDef(893, Sprite.PLAY, 18, -1, null, null, MobjState.Null, 0, 0), // State.Deadbottom
            // new MobjStateDef(894, Sprite.POL2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Headsonstick
            // new MobjStateDef(895, Sprite.POL5, 0, -1, null, null, MobjState.Null, 0, 0), // State.Gibs
            // new MobjStateDef(896, Sprite.POL4, 0, -1, null, null, MobjState.Null, 0, 0), // State.Headonastick
            // new MobjStateDef(897, Sprite.POL3, 32768, 6, null, null, MobjState.Headcandles2, 0, 0), // State.Headcandles
            // new MobjStateDef(898, Sprite.POL3, 32769, 6, null, null, MobjState.Headcandles, 0, 0), // State.Headcandles2
            // new MobjStateDef(899, Sprite.POL1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Deadstick
            // new MobjStateDef(900, Sprite.POL6, 0, 6, null, null, MobjState.Livestick2, 0, 0), // State.Livestick
            // new MobjStateDef(901, Sprite.POL6, 1, 8, null, null, MobjState.Livestick, 0, 0), // State.Livestick2
            // new MobjStateDef(902, Sprite.GOR2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Meat2
            // new MobjStateDef(903, Sprite.GOR3, 0, -1, null, null, MobjState.Null, 0, 0), // State.Meat3
            // new MobjStateDef(904, Sprite.GOR4, 0, -1, null, null, MobjState.Null, 0, 0), // State.Meat4
            // new MobjStateDef(905, Sprite.GOR5, 0, -1, null, null, MobjState.Null, 0, 0), // State.Meat5
            // new MobjStateDef(906, Sprite.SMIT, 0, -1, null, null, MobjState.Null, 0, 0), // State.Stalagtite
            // new MobjStateDef(907, Sprite.COL1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Tallgrncol
            // new MobjStateDef(908, Sprite.COL2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Shrtgrncol
            // new MobjStateDef(909, Sprite.COL3, 0, -1, null, null, MobjState.Null, 0, 0), // State.Tallredcol
            // new MobjStateDef(910, Sprite.COL4, 0, -1, null, null, MobjState.Null, 0, 0), // State.Shrtredcol
            // new MobjStateDef(911, Sprite.CAND, 32768, -1, null, null, MobjState.Null, 0, 0), // State.Candlestik
            // new MobjStateDef(912, Sprite.CBRA, 32768, -1, null, null, MobjState.Null, 0, 0), // State.Candelabra
            // new MobjStateDef(913, Sprite.COL6, 0, -1, null, null, MobjState.Null, 0, 0), // State.Skullcol
            // new MobjStateDef(914, Sprite.TRE1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Torchtree
            // new MobjStateDef(915, Sprite.TRE2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Bigtree
            // new MobjStateDef(916, Sprite.ELEC, 0, -1, null, null, MobjState.Null, 0, 0), // State.Techpillar
            // new MobjStateDef(917, Sprite.CEYE, 32768, 6, null, null, MobjState.Evileye2, 0, 0), // State.Evileye
            // new MobjStateDef(918, Sprite.CEYE, 32769, 6, null, null, MobjState.Evileye3, 0, 0), // State.Evileye2
            // new MobjStateDef(919, Sprite.CEYE, 32770, 6, null, null, MobjState.Evileye4, 0, 0), // State.Evileye3
            // new MobjStateDef(920, Sprite.CEYE, 32769, 6, null, null, MobjState.Evileye, 0, 0), // State.Evileye4
            // new MobjStateDef(921, Sprite.FSKU, 32768, 6, null, null, MobjState.Floatskull2, 0, 0), // State.Floatskull
            // new MobjStateDef(922, Sprite.FSKU, 32769, 6, null, null, MobjState.Floatskull3, 0, 0), // State.Floatskull2
            // new MobjStateDef(923, Sprite.FSKU, 32770, 6, null, null, MobjState.Floatskull, 0, 0), // State.Floatskull3
            // new MobjStateDef(924, Sprite.COL5, 0, 14, null, null, MobjState.Heartcol2, 0, 0), // State.Heartcol
            // new MobjStateDef(925, Sprite.COL5, 1, 14, null, null, MobjState.Heartcol, 0, 0), // State.Heartcol2
            // new MobjStateDef(926, Sprite.TBLU, 32768, 4, null, null, MobjState.Bluetorch2, 0, 0), // State.Bluetorch
            // new MobjStateDef(927, Sprite.TBLU, 32769, 4, null, null, MobjState.Bluetorch3, 0, 0), // State.Bluetorch2
            // new MobjStateDef(928, Sprite.TBLU, 32770, 4, null, null, MobjState.Bluetorch4, 0, 0), // State.Bluetorch3
            // new MobjStateDef(929, Sprite.TBLU, 32771, 4, null, null, MobjState.Bluetorch, 0, 0), // State.Bluetorch4
            // new MobjStateDef(930, Sprite.TGRN, 32768, 4, null, null, MobjState.Greentorch2, 0, 0), // State.Greentorch
            // new MobjStateDef(931, Sprite.TGRN, 32769, 4, null, null, MobjState.Greentorch3, 0, 0), // State.Greentorch2
            // new MobjStateDef(932, Sprite.TGRN, 32770, 4, null, null, MobjState.Greentorch4, 0, 0), // State.Greentorch3
            // new MobjStateDef(933, Sprite.TGRN, 32771, 4, null, null, MobjState.Greentorch, 0, 0), // State.Greentorch4
            // new MobjStateDef(934, Sprite.TRED, 32768, 4, null, null, MobjState.Redtorch2, 0, 0), // State.Redtorch
            // new MobjStateDef(935, Sprite.TRED, 32769, 4, null, null, MobjState.Redtorch3, 0, 0), // State.Redtorch2
            // new MobjStateDef(936, Sprite.TRED, 32770, 4, null, null, MobjState.Redtorch4, 0, 0), // State.Redtorch3
            // new MobjStateDef(937, Sprite.TRED, 32771, 4, null, null, MobjState.Redtorch, 0, 0), // State.Redtorch4
            // new MobjStateDef(938, Sprite.SMBT, 32768, 4, null, null, MobjState.Btorchshrt2, 0, 0), // State.Btorchshrt
            // new MobjStateDef(939, Sprite.SMBT, 32769, 4, null, null, MobjState.Btorchshrt3, 0, 0), // State.Btorchshrt2
            // new MobjStateDef(940, Sprite.SMBT, 32770, 4, null, null, MobjState.Btorchshrt4, 0, 0), // State.Btorchshrt3
            // new MobjStateDef(941, Sprite.SMBT, 32771, 4, null, null, MobjState.Btorchshrt, 0, 0), // State.Btorchshrt4
            // new MobjStateDef(942, Sprite.SMGT, 32768, 4, null, null, MobjState.Gtorchshrt2, 0, 0), // State.Gtorchshrt
            // new MobjStateDef(943, Sprite.SMGT, 32769, 4, null, null, MobjState.Gtorchshrt3, 0, 0), // State.Gtorchshrt2
            // new MobjStateDef(944, Sprite.SMGT, 32770, 4, null, null, MobjState.Gtorchshrt4, 0, 0), // State.Gtorchshrt3
            // new MobjStateDef(945, Sprite.SMGT, 32771, 4, null, null, MobjState.Gtorchshrt, 0, 0), // State.Gtorchshrt4
            // new MobjStateDef(946, Sprite.SMRT, 32768, 4, null, null, MobjState.Rtorchshrt2, 0, 0), // State.Rtorchshrt
            // new MobjStateDef(947, Sprite.SMRT, 32769, 4, null, null, MobjState.Rtorchshrt3, 0, 0), // State.Rtorchshrt2
            // new MobjStateDef(948, Sprite.SMRT, 32770, 4, null, null, MobjState.Rtorchshrt4, 0, 0), // State.Rtorchshrt3
            // new MobjStateDef(949, Sprite.SMRT, 32771, 4, null, null, MobjState.Rtorchshrt, 0, 0), // State.Rtorchshrt4
            // new MobjStateDef(950, Sprite.HDB1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangnoguts
            // new MobjStateDef(951, Sprite.HDB2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangbnobrain
            // new MobjStateDef(952, Sprite.HDB3, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangtlookdn
            // new MobjStateDef(953, Sprite.HDB4, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangtskull
            // new MobjStateDef(954, Sprite.HDB5, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangtlookup
            // new MobjStateDef(955, Sprite.HDB6, 0, -1, null, null, MobjState.Null, 0, 0), // State.Hangtnobrain
            // new MobjStateDef(956, Sprite.POB1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Colongibs
            // new MobjStateDef(957, Sprite.POB2, 0, -1, null, null, MobjState.Null, 0, 0), // State.Smallpool
            // new MobjStateDef(958, Sprite.BRS1, 0, -1, null, null, MobjState.Null, 0, 0), // State.Brainstem
            // new MobjStateDef(959, Sprite.TLMP, 32768, 4, null, null, MobjState.Techlamp2, 0, 0), // State.Techlamp
            // new MobjStateDef(960, Sprite.TLMP, 32769, 4, null, null, MobjState.Techlamp3, 0, 0), // State.Techlamp2
            // new MobjStateDef(961, Sprite.TLMP, 32770, 4, null, null, MobjState.Techlamp4, 0, 0), // State.Techlamp3
            // new MobjStateDef(962, Sprite.TLMP, 32771, 4, null, null, MobjState.Techlamp, 0, 0), // State.Techlamp4
            // new MobjStateDef(963, Sprite.TLP2, 32768, 4, null, null, MobjState.Tech2Lamp2, 0, 0), // State.Tech2Lamp
            // new MobjStateDef(964, Sprite.TLP2, 32769, 4, null, null, MobjState.Tech2Lamp3, 0, 0), // State.Tech2Lamp2
            // new MobjStateDef(965, Sprite.TLP2, 32770, 4, null, null, MobjState.Tech2Lamp4, 0, 0), // State.Tech2Lamp3
            // new MobjStateDef(966, Sprite.TLP2, 32771, 4, null, null, MobjState.Tech2Lamp, 0, 0) // State.Tech2Lamp4
        };
    }
}
