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
    public enum MobjState
    {
        Null,
        //* Lightdone,
        // Punch,
        // Punchdown,
        // Punchup,
        // Punch1,
        // Punch2,
        // Punch3,
        // Punch4,
        // Punch5,
        Play,
        PlayRun1,
        PlayRun2,
        PlayRun3,
        PlayRun4,
        PlayAtk1,
        PlayAtk2,
        PlayPain,
        PlayPain2,
        PlayDie1,
        PlayDie2,
        PlayDie3,
        PlayDie4,
        PlayDie5,
        PlayDie6,
        PlayDie7,
        PlayXdie1,
        PlayXdie2,
        PlayXdie3,
        PlayXdie4,
        PlayXdie5,
        PlayXdie6,
        PlayXdie7,
        PlayXdie8,
        PlayXdie9,
         Ykyy,
         Ykyy2,
         Ykyy3,
         Ykyy4,
         Ykyy5,
         Ykyy6,
         Ykyy7,
         Ykyy8,
         Ykyy9,
        Elvenwand,
        ElvenwandDown,
        ElvenwandUp,
        Elvenwand1,
        Elvenwand2,
        Elvenwand3,
        Elvenwand4,
        Puf21,
        Puf22,
        Puf23,
        Puf24
        // Pistolup,
        // Pistol1,
        // Pistol2,
        // Pistol3,
        // Pistol4,
        // Pistolflash,
        // Sgun,
        // Sgundown,
        // Sgunup,
        // Sgun1,
        // Sgun2,
        // Sgun3,
        // Sgun4,
        // Sgun5,
        // Sgun6,
        // Sgun7,
        // Sgun8,
        // Sgun9,
        // Sgunflash1,
        // Sgunflash2,
        // Dsgun,
        // Dsgundown,
        // Dsgunup,
        // Dsgun1,
        // Dsgun2,
        // Dsgun3,
        // Dsgun4,
        // Dsgun5,
        // Dsgun6,
        // Dsgun7,
        // Dsgun8,
        // Dsgun9,
        // Dsgun10,
        // Dsnr1,
        // Dsnr2,
        // Dsgunflash1,
        // Dsgunflash2,
        // Chain,
        // Chaindown,
        // Chainup,
        // Chain1,
        // Chain2,
        // Chain3,
        // Chainflash1,
        // Chainflash2,
        // Missile,
        // Missiledown,
        // Missileup,
        // Missile1,
        // Missile2,
        // Missile3,
        // Missileflash1,
        // Missileflash2,
        // Missileflash3,
        // Missileflash4,
        // Saw,
        // Sawb,
        // Sawdown,
        // Sawup,
        // Saw1,
        // Saw2,
        // Saw3,
        // Plasma,
        // Plasmadown,
        // Plasmaup,
        // Plasma1,
        // Plasma2,
        // Plasmaflash1,
        // Plasmaflash2,
        // Bfg,
        // Bfgdown,
        // Bfgup,
        // Bfg1,
        // Bfg2,
        // Bfg3,
        // Bfg4,
        // Bfgflash1,
        // Bfgflash2,
        // Blood1,
        // Blood2,
        // Blood3,
        // Puff1,
        // Puff2,
        // Puff3,
        // Puff4,
        // Tball1,
        // Tball2,
        // Tballx1,
        // Tballx2,
        // Tballx3,
        // Rball1,
        // Rball2,
        // Rballx1,
        // Rballx2,
        // Rballx3,
        // Plasball,
        // Plasball2,
        // Plasexp,
        // Plasexp2,
        // Plasexp3,
        // Plasexp4,
        // Plasexp5,
        // Rocket,
        // Bfgshot,
        // Bfgshot2,
        // Bfgland,
        // Bfgland2,
        // Bfgland3,
        // Bfgland4,
        // Bfgland5,
        // Bfgland6,
        // Bfgexp,
        // Bfgexp2,
        // Bfgexp3,
        // Bfgexp4,
        // Explode1,
        // Explode2,
        // Explode3,
        // Tfog,
        // Tfog01,
        // Tfog02,
        // Tfog2,
        // Tfog3,
        // Tfog4,
        // Tfog5,
        // Tfog6,
        // Tfog7,
        // Tfog8,
        // Tfog9,
        // Tfog10,
        // Ifog,
        // Ifog01,
        // Ifog02,
        // Ifog2,
        // Ifog3,
        // Ifog4,
        // Ifog5,
       
        // PossStnd,
        // PossStnd2,
        // PossRun1,
        // PossRun2,
        // PossRun3,
        // PossRun4,
        // PossRun5,
        // PossRun6,
        // PossRun7,
        // PossRun8,
        // PossAtk1,
        // PossAtk2,
        // PossAtk3,
        // PossPain,
        // PossPain2,
        // PossDie1,
        // PossDie2,
        // PossDie3,
        // PossDie4,
        // PossDie5,
        // PossXdie1,
        // PossXdie2,
        // PossXdie3,
        // PossXdie4,
        // PossXdie5,
        // PossXdie6,
        // PossXdie7,
        // PossXdie8,
        // PossXdie9,
        // PossRaise1,
        // PossRaise2,
        // PossRaise3,
        // PossRaise4,
        // SposStnd,
        // SposStnd2,
        // SposRun1,
        // SposRun2,
        // SposRun3,
        // SposRun4,
        // SposRun5,
        // SposRun6,
        // SposRun7,
        // SposRun8,
        // SposAtk1,
        // SposAtk2,
        // SposAtk3,
        // SposPain,
        // SposPain2,
        // SposDie1,
        // SposDie2,
        // SposDie3,
        // SposDie4,
        // SposDie5,
        // SposXdie1,
        // SposXdie2,
        // SposXdie3,
        // SposXdie4,
        // SposXdie5,
        // SposXdie6,
        // SposXdie7,
        // SposXdie8,
        // SposXdie9,
        // SposRaise1,
        // SposRaise2,
        // SposRaise3,
        // SposRaise4,
        // SposRaise5,
        // VileStnd,
        // VileStnd2,
        // VileRun1,
        // VileRun2,
        // VileRun3,
        // VileRun4,
        // VileRun5,
        // VileRun6,
        // VileRun7,
        // VileRun8,
        // VileRun9,
        // VileRun10,
        // VileRun11,
        // VileRun12,
        // VileAtk1,
        // VileAtk2,
        // VileAtk3,
        // VileAtk4,
        // VileAtk5,
        // VileAtk6,
        // VileAtk7,
        // VileAtk8,
        // VileAtk9,
        // VileAtk10,
        // VileAtk11,
        // VileHeal1,
        // VileHeal2,
        // VileHeal3,
        // VilePain,
        // VilePain2,
        // VileDie1,
        // VileDie2,
        // VileDie3,
        // VileDie4,
        // VileDie5,
        // VileDie6,
        // VileDie7,
        // VileDie8,
        // VileDie9,
        // VileDie10,
        // Fire1,
        // Fire2,
        // Fire3,
        // Fire4,
        // Fire5,
        // Fire6,
        // Fire7,
        // Fire8,
        // Fire9,
        // Fire10,
        // Fire11,
        // Fire12,
        // Fire13,
        // Fire14,
        // Fire15,
        // Fire16,
        // Fire17,
        // Fire18,
        // Fire19,
        // Fire20,
        // Fire21,
        // Fire22,
        // Fire23,
        // Fire24,
        // Fire25,
        // Fire26,
        // Fire27,
        // Fire28,
        // Fire29,
        // Fire30,
        // Smoke1,
        // Smoke2,
        // Smoke3,
        // Smoke4,
        // Smoke5,
        // Tracer,
        // Tracer2,
        // Traceexp1,
        // Traceexp2,
        // Traceexp3,
        // SkelStnd,
        // SkelStnd2,
        // SkelRun1,
        // SkelRun2,
        // SkelRun3,
        // SkelRun4,
        // SkelRun5,
        // SkelRun6,
        // SkelRun7,
        // SkelRun8,
        // SkelRun9,
        // SkelRun10,
        // SkelRun11,
        // SkelRun12,
        // SkelFist1,
        // SkelFist2,
        // SkelFist3,
        // SkelFist4,
        // SkelMiss1,
        // SkelMiss2,
        // SkelMiss3,
        // SkelMiss4,
        // SkelPain,
        // SkelPain2,
        // SkelDie1,
        // SkelDie2,
        // SkelDie3,
        // SkelDie4,
        // SkelDie5,
        // SkelDie6,
        // SkelRaise1,
        // SkelRaise2,
        // SkelRaise3,
        // SkelRaise4,
        // SkelRaise5,
        // SkelRaise6,
        // Fatshot1,
        // Fatshot2,
        // Fatshotx1,
        // Fatshotx2,
        // Fatshotx3,
        // FattStnd,
        // FattStnd2,
        // FattRun1,
        // FattRun2,
        // FattRun3,
        // FattRun4,
        // FattRun5,
        // FattRun6,
        // FattRun7,
        // FattRun8,
        // FattRun9,
        // FattRun10,
        // FattRun11,
        // FattRun12,
        // FattAtk1,
        // FattAtk2,
        // FattAtk3,
        // FattAtk4,
        // FattAtk5,
        // FattAtk6,
        // FattAtk7,
        // FattAtk8,
        // FattAtk9,
        // FattAtk10,
        // FattPain,
        // FattPain2,
        // FattDie1,
        // FattDie2,
        // FattDie3,
        // FattDie4,
        // FattDie5,
        // FattDie6,
        // FattDie7,
        // FattDie8,
        // FattDie9,
        // FattDie10,
        // FattRaise1,
        // FattRaise2,
        // FattRaise3,
        // FattRaise4,
        // FattRaise5,
        // FattRaise6,
        // FattRaise7,
        // FattRaise8,
        // CposStnd,
        // CposStnd2,
        // CposRun1,
        // CposRun2,
        // CposRun3,
        // CposRun4,
        // CposRun5,
        // CposRun6,
        // CposRun7,
        // CposRun8,
        // CposAtk1,
        // CposAtk2,
        // CposAtk3,
        // CposAtk4,
        // CposPain,
        // CposPain2,
        // CposDie1,
        // CposDie2,
        // CposDie3,
        // CposDie4,
        // CposDie5,
        // CposDie6,
        // CposDie7,
        // CposXdie1,
        // CposXdie2,
        // CposXdie3,
        // CposXdie4,
        // CposXdie5,
        // CposXdie6,
        // CposRaise1,
        // CposRaise2,
        // CposRaise3,
        // CposRaise4,
        // CposRaise5,
        // CposRaise6,
        // CposRaise7,
        // TrooStnd,
        // TrooStnd2,
        // TrooRun1,
        // TrooRun2,
        // TrooRun3,
        // TrooRun4,
        // TrooRun5,
        // TrooRun6,
        // TrooRun7,
        // TrooRun8,
        // TrooAtk1,
        // TrooAtk2,
        // TrooAtk3,
        // TrooPain,
        // TrooPain2,
        // TrooDie1,
        // TrooDie2,
        // TrooDie3,
        // TrooDie4,
        // TrooDie5,
        // TrooXdie1,
        // TrooXdie2,
        // TrooXdie3,
        // TrooXdie4,
        // TrooXdie5,
        // TrooXdie6,
        // TrooXdie7,
        // TrooXdie8,
        // TrooRaise1,
        // TrooRaise2,
        // TrooRaise3,
        // TrooRaise4,
        // TrooRaise5,
        // SargStnd,
        // SargStnd2,
        // SargRun1,
        // SargRun2,
        // SargRun3,
        // SargRun4,
        // SargRun5,
        // SargRun6,
        // SargRun7,
        // SargRun8,
        // SargAtk1,
        // SargAtk2,
        // SargAtk3,
        // SargPain,
        // SargPain2,
        // SargDie1,
        // SargDie2,
        // SargDie3,
        // SargDie4,
        // SargDie5,
        // SargDie6,
        // SargRaise1,
        // SargRaise2,
        // SargRaise3,
        // SargRaise4,
        // SargRaise5,
        // SargRaise6,
        // HeadStnd,
        // HeadRun1,
        // HeadAtk1,
        // HeadAtk2,
        // HeadAtk3,
        // HeadPain,
        // HeadPain2,
        // HeadPain3,
        // HeadDie1,
        // HeadDie2,
        // HeadDie3,
        // HeadDie4,
        // HeadDie5,
        // HeadDie6,
        // HeadRaise1,
        // HeadRaise2,
        // HeadRaise3,
        // HeadRaise4,
        // HeadRaise5,
        // HeadRaise6,
        // Brball1,
        // Brball2,
        // Brballx1,
        // Brballx2,
        // Brballx3,
        // BossStnd,
        // BossStnd2,
        // BossRun1,
        // BossRun2,
        // BossRun3,
        // BossRun4,
        // BossRun5,
        // BossRun6,
        // BossRun7,
        // BossRun8,
        // BossAtk1,
        // BossAtk2,
        // BossAtk3,
        // BossPain,
        // BossPain2,
        // BossDie1,
        // BossDie2,
        // BossDie3,
        // BossDie4,
        // BossDie5,
        // BossDie6,
        // BossDie7,
        // BossRaise1,
        // BossRaise2,
        // BossRaise3,
        // BossRaise4,
        // BossRaise5,
        // BossRaise6,
        // BossRaise7,
        // Bos2Stnd,
        // Bos2Stnd2,
        // Bos2Run1,
        // Bos2Run2,
        // Bos2Run3,
        // Bos2Run4,
        // Bos2Run5,
        // Bos2Run6,
        // Bos2Run7,
        // Bos2Run8,
        // Bos2Atk1,
        // Bos2Atk2,
        // Bos2Atk3,
        // Bos2Pain,
        // Bos2Pain2,
        // Bos2Die1,
        // Bos2Die2,
        // Bos2Die3,
        // Bos2Die4,
        // Bos2Die5,
        // Bos2Die6,
        // Bos2Die7,
        // Bos2Raise1,
        // Bos2Raise2,
        // Bos2Raise3,
        // Bos2Raise4,
        // Bos2Raise5,
        // Bos2Raise6,
        // Bos2Raise7,
        // SkullStnd,
        // SkullStnd2,
        // SkullRun1,
        // SkullRun2,
        // SkullAtk1,
        // SkullAtk2,
        // SkullAtk3,
        // SkullAtk4,
        // SkullPain,
        // SkullPain2,
        // SkullDie1,
        // SkullDie2,
        // SkullDie3,
        // SkullDie4,
        // SkullDie5,
        // SkullDie6,
        // SpidStnd,
        // SpidStnd2,
        // SpidRun1,
        // SpidRun2,
        // SpidRun3,
        // SpidRun4,
        // SpidRun5,
        // SpidRun6,
        // SpidRun7,
        // SpidRun8,
        // SpidRun9,
        // SpidRun10,
        // SpidRun11,
        // SpidRun12,
        // SpidAtk1,
        // SpidAtk2,
        // SpidAtk3,
        // SpidAtk4,
        // SpidPain,
        // SpidPain2,
        // SpidDie1,
        // SpidDie2,
        // SpidDie3,
        // SpidDie4,
        // SpidDie5,
        // SpidDie6,
        // SpidDie7,
        // SpidDie8,
        // SpidDie9,
        // SpidDie10,
        // SpidDie11,
        // BspiStnd,
        // BspiStnd2,
        // BspiSight,
        // BspiRun1,
        // BspiRun2,
        // BspiRun3,
        // BspiRun4,
        // BspiRun5,
        // BspiRun6,
        // BspiRun7,
        // BspiRun8,
        // BspiRun9,
        // BspiRun10,
        // BspiRun11,
        // BspiRun12,
        // BspiAtk1,
        // BspiAtk2,
        // BspiAtk3,
        // BspiAtk4,
        // BspiPain,
        // BspiPain2,
        // BspiDie1,
        // BspiDie2,
        // BspiDie3,
        // BspiDie4,
        // BspiDie5,
        // BspiDie6,
        // BspiDie7,
        // BspiRaise1,
        // BspiRaise2,
        // BspiRaise3,
        // BspiRaise4,
        // BspiRaise5,
        // BspiRaise6,
        // BspiRaise7,
        // ArachPlaz,
        // ArachPlaz2,
        // ArachPlex,
        // ArachPlex2,
        // ArachPlex3,
        // ArachPlex4,
        // ArachPlex5,
        // CyberStnd,
        // CyberStnd2,
        // CyberRun1,
        // CyberRun2,
        // CyberRun3,
        // CyberRun4,
        // CyberRun5,
        // CyberRun6,
        // CyberRun7,
        // CyberRun8,
        // CyberAtk1,
        // CyberAtk2,
        // CyberAtk3,
        // CyberAtk4,
        // CyberAtk5,
        // CyberAtk6,
        // CyberPain,
        // CyberDie1,
        // CyberDie2,
        // CyberDie3,
        // CyberDie4,
        // CyberDie5,
        // CyberDie6,
        // CyberDie7,
        // CyberDie8,
        // CyberDie9,
        // CyberDie10,
        // PainStnd,
        // PainRun1,
        // PainRun2,
        // PainRun3,
        // PainRun4,
        // PainRun5,
        // PainRun6,
        // PainAtk1,
        // PainAtk2,
        // PainAtk3,
        // PainAtk4,
        // PainPain,
        // PainPain2,
        // PainDie1,
        // PainDie2,
        // PainDie3,
        // PainDie4,
        // PainDie5,
        // PainDie6,
        // PainRaise1,
        // PainRaise2,
        // PainRaise3,
        // PainRaise4,
        // PainRaise5,
        // PainRaise6,
        // SswvStnd,
        // SswvStnd2,
        // SswvRun1,
        // SswvRun2,
        // SswvRun3,
        // SswvRun4,
        // SswvRun5,
        // SswvRun6,
        // SswvRun7,
        // SswvRun8,
        // SswvAtk1,
        // SswvAtk2,
        // SswvAtk3,
        // SswvAtk4,
        // SswvAtk5,
        // SswvAtk6,
        // SswvPain,
        // SswvPain2,
        // SswvDie1,
        // SswvDie2,
        // SswvDie3,
        // SswvDie4,
        // SswvDie5,
        // SswvXdie1,
        // SswvXdie2,
        // SswvXdie3,
        // SswvXdie4,
        // SswvXdie5,
        // SswvXdie6,
        // SswvXdie7,
        // SswvXdie8,
        // SswvXdie9,
        // SswvRaise1,
        // SswvRaise2,
        // SswvRaise3,
        // SswvRaise4,
        // SswvRaise5,
        // Keenstnd,
        // Commkeen,
        // Commkeen2,
        // Commkeen3,
        // Commkeen4,
        // Commkeen5,
        // Commkeen6,
        // Commkeen7,
        // Commkeen8,
        // Commkeen9,
        // Commkeen10,
        // Commkeen11,
        // Commkeen12,
        // Keenpain,
        // Keenpain2,
        // Brain,
        // BrainPain,
        // BrainDie1,
        // BrainDie2,
        // BrainDie3,
        // BrainDie4,
        // Braineye,
        // Braineyesee,
        // Braineye1,
        // Spawn1,
        // Spawn2,
        // Spawn3,
        // Spawn4,
        // Spawnfire1,
        // Spawnfire2,
        // Spawnfire3,
        // Spawnfire4,
        // Spawnfire5,
        // Spawnfire6,
        // Spawnfire7,
        // Spawnfire8,
        // Brainexplode1,
        // Brainexplode2,
        // Brainexplode3,
        // Arm1,
        // Arm1A,
        // Arm2,
        // Arm2A,
        // Bar1,
        // Bar2,
        // Bexp,
        // Bexp2,
        // Bexp3,
        // Bexp4,
        // Bexp5,
        // Bbar1,
        // Bbar2,
        // Bbar3,
        // Bon1,
        // Bon1A,
        // Bon1B,
        // Bon1C,
        // Bon1D,
        // Bon1E,
        // Bon2,
        // Bon2A,
        // Bon2B,
        // Bon2C,
        // Bon2D,
        // Bon2E,
        // Bkey,
        // Bkey2,
        // Rkey,
        // Rkey2,
       
        // Bskull,
        // Bskull2,
        // Rskull,
        // Rskull2,
        // Yskull,
        // Yskull2,
        // Stim,
        // Medi,
        // Soul,
        // Soul2,
        // Soul3,
        // Soul4,
        // Soul5,
        // Soul6,
        // Pinv,
        // Pinv2,
        // Pinv3,
        // Pinv4,
        // Pstr,
        // Pins,
        // Pins2,
        // Pins3,
        // Pins4,
        // Mega,
        // Mega2,
        // Mega3,
        // Mega4,
        // Suit,
        // Pmap,
        // Pmap2,
        // Pmap3,
        // Pmap4,
        // Pmap5,
        // Pmap6,
        // Pvis,
        // Pvis2,
        // Clip,
        // Ammo,
        // Rock,
        // Brok,
        // Cell,
        // Celp,
        // Shel,
        // Sbox,
        // Bpak,
        // Bfug,
        // Mgun,
        // Csaw,
        // Laun,
        // Plas,
        // Shot,
        // Shot2,
        // Colu,
        // Stalag,
        // Bloodytwitch,
        // Bloodytwitch2,
        // Bloodytwitch3,
        // Bloodytwitch4,
        // Deadtorso,
        // Deadbottom,
        // Headsonstick,
        // Gibs,
        // Headonastick,
        // Headcandles,
        // Headcandles2,
        // Deadstick,
        // Livestick,
        // Livestick2,
        // Meat2,
        // Meat3,
        // Meat4,
        // Meat5,
        // Stalagtite,
        // Tallgrncol,
        // Shrtgrncol,
        // Tallredcol,
        // Shrtredcol,
        // Candlestik,
        // Candelabra,
        // Skullcol,
        // Torchtree,
        // Bigtree,
        // Techpillar,
        // Evileye,
        // Evileye2,
        // Evileye3,
        // Evileye4,
        // Floatskull,
        // Floatskull2,
        // Floatskull3,
        // Heartcol,
        // Heartcol2,
        // Bluetorch,
        // Bluetorch2,
        // Bluetorch3,
        // Bluetorch4,
        // Greentorch,
        // Greentorch2,
        // Greentorch3,
        // Greentorch4,
        // Redtorch,
        // Redtorch2,
        // Redtorch3,
        // Redtorch4,
        // Btorchshrt,
        // Btorchshrt2,
        // Btorchshrt3,
        // Btorchshrt4,
        // Gtorchshrt,
        // Gtorchshrt2,
        // Gtorchshrt3,
        // Gtorchshrt4,
        // Rtorchshrt,
        // Rtorchshrt2,
        // Rtorchshrt3,
        // Rtorchshrt4,
        // Hangnoguts,
        // Hangbnobrain,
        // Hangtlookdn,
        // Hangtskull,
        // Hangtlookup,
        // Hangtnobrain,
        // Colongibs,
        // Smallpool,
        // Brainstem,
        // Techlamp,
        // Techlamp2,
        // Techlamp3,
        // Techlamp4,
        // Tech2Lamp,
        // Tech2Lamp2,
        // Tech2Lamp3,
        // Tech2Lamp4
    }
}
