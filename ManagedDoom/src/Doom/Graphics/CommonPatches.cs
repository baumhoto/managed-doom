﻿using System;
using System.Collections.Generic;

namespace ManagedDoom
{
    public sealed class CommonPatches
    {
        private Patch statusBar;
        private Patch[] tallNumbers;
        private Patch[] shortNumbers;
        private Patch tallMinus;
        private Patch tallPercent;
        private Patch[] keys;
        private Patch armsBg;
        private Patch[][] arms;
        private Patch[] faces;
        private Patch[] faceBacks;





        // background (map of levels).
        private Patch background;
        private Patch[] mapPictures;

        // "Kills", "Scrt", "Items", "Frags"
        private Patch kills;
        private Patch secret;
        private Patch sp_secret;
        private Patch items;
        private Patch frags;

        // Time sucks.
        private Patch time;
        private Patch par;
        private Patch sucks;

        // minus sign
        private Patch wiminus;

        // 0-9 graphic
        private Patch[] numbers;

        // %, : graphics
        private Patch percent;
        private Patch colon;

        // "Finished!" graphics
        private Patch finished;

        // "Entering" graphic
        private Patch entering;

        // "killers", "victims"
        private Patch killers;
        private Patch victims;

        // "Total", your face, your dead face
        private Patch total;
        private Patch star;
        private Patch bstar;




        // You Are Here graphic
        private Patch youAreHere1;
        private Patch youAreHere2;

        // splat
        private Patch splat;

        // "red P[1..MAXPLAYERS]"
        private Patch[] p;

        // "gray P[1..MAXPLAYERS]"
        private Patch[] bp;

        // Name graphics of each level (centered)
        private Patch[][] lnames;

        public CommonPatches(Wad wad)
        {
            statusBar = Patch.FromWad("STBAR", wad);
            tallNumbers = new Patch[10];
            shortNumbers = new Patch[10];
            for (var i = 0; i < 10; i++)
            {
                tallNumbers[i] = Patch.FromWad("STTNUM" + i, wad);
                shortNumbers[i] = Patch.FromWad("STYSNUM" + i, wad);
            }
            tallMinus = Patch.FromWad("STTMINUS", wad);
            tallPercent = Patch.FromWad("STTPRCNT", wad);
            keys = new Patch[(int)CardType.Count];
            for (var i = 0; i < keys.Length; i++)
            {
                keys[i] = Patch.FromWad("STKEYS" + i, wad);
            }
            armsBg = Patch.FromWad("STARMS", wad);
            arms = new Patch[6][];
            for (var i = 0; i < 6; i++)
            {
                var num = i + 2;
                arms[i] = new Patch[2];
                arms[i][0] = Patch.FromWad("STGNUM" + num, wad);
                arms[i][1] = shortNumbers[num];
            }
            faceBacks = new Patch[Player.MaxPlayerCount];
            for (var i = 0; i < faceBacks.Length; i++)
            {
                faceBacks[i] = Patch.FromWad("STFB" + i, wad);
            }

            faces = new Patch[DoomInfo.FaceInfos.ST_NUMFACES];
            var facenum = 0;
            for (var i = 0; i < DoomInfo.FaceInfos.ST_NUMPAINFACES; i++)
            {
                for (var j = 0; j < DoomInfo.FaceInfos.ST_NUMSTRAIGHTFACES; j++)
                {
                    faces[facenum++] = Patch.FromWad("STFST" + i + j, wad);
                }
                faces[facenum++] = Patch.FromWad("STFTR" + i + "0", wad);
                faces[facenum++] = Patch.FromWad("STFTL" + i + "0", wad);
                faces[facenum++] = Patch.FromWad("STFOUCH" + i, wad);
                faces[facenum++] = Patch.FromWad("STFEVL" + i, wad);
                faces[facenum++] = Patch.FromWad("STFKILL" + i, wad);
            }
            faces[facenum++] = Patch.FromWad("STFGOD0", wad);
            faces[facenum++] = Patch.FromWad("STFDEAD0", wad);


            if (wad.GameMode == GameMode.Commercial)
            {
                background = Patch.FromWad("INTERPIC", wad);
            }
            else
            {
                mapPictures = new Patch[3];
                for (var e = 0; e < 3; e++)
                {
                    var patchName = "WIMAP" + e;
                    if (wad.GetLumpNumber(patchName) != -1)
                    {
                        mapPictures[e] = Patch.FromWad(patchName, wad);
                    }
                }
                if (wad.GetLumpNumber("INTERPIC") != -1)
                {
                    background = Patch.FromWad("INTERPIC", wad);
                }
            }

            kills = Patch.FromWad("WIOSTK", wad);
            secret = Patch.FromWad("WIOSTS", wad);
            sp_secret = Patch.FromWad("WISCRT2", wad);
            items = Patch.FromWad("WIOSTI", wad);
            frags = Patch.FromWad("WIFRGS", wad);

            time = Patch.FromWad("WITIME", wad);
            par = Patch.FromWad("WIPAR", wad);
            sucks = Patch.FromWad("WISUCKS", wad);

            wiminus = Patch.FromWad("WIMINUS", wad);

            numbers = new Patch[10];
            for (var i = 0; i < 10; i++)
            {
                numbers[i] = Patch.FromWad("WINUM" + i, wad);
            }

            percent = Patch.FromWad("WIPCNT", wad);
            colon = Patch.FromWad("WICOLON", wad);

            finished = Patch.FromWad("WIF", wad);

            entering = Patch.FromWad("WIENTER", wad);

            killers = Patch.FromWad("WIKILRS", wad);
            victims = Patch.FromWad("WIVCTMS", wad);

            total = Patch.FromWad("WIMSTT", wad);
            star = Patch.FromWad("STFST01", wad);
            bstar = Patch.FromWad("STFDEAD0", wad);


            if (wad.GameMode == GameMode.Commercial)
            {
                var numMaps = 32;
                lnames = new Patch[1][];
                lnames[0] = new Patch[numMaps];
                for (var i = 0; i < numMaps; i++)
                {
                    lnames[0][i] = Patch.FromWad("CWILV" + i.ToString("00"), wad);
                }
            }
            else
            {
                var numEpisodes = 4;
                var numMaps = 9;
                lnames = new Patch[numEpisodes][];
                for (var e = 0; e < numEpisodes; e++)
                {
                    lnames[e] = new Patch[numMaps];
                    for (var m = 0; m < numMaps; m++)
                    {
                        var patchName = "WILV" + e + m;
                        if (wad.GetLumpNumber(patchName) != -1)
                        {
                            lnames[e][m] = Patch.FromWad(patchName, wad);
                        }
                    }
                }

                youAreHere1 = Patch.FromWad("WIURH0", wad);
                youAreHere2 = Patch.FromWad("WIURH1", wad);
                splat = Patch.FromWad("WISPLAT", wad);
            }

            Console.WriteLine("All patches are OK.");
        }





        public Patch StatusBar => statusBar;
        public Patch[] TallNumbers => tallNumbers;
        public Patch[] ShortNumbers => shortNumbers;
        public Patch TallMinus => tallMinus;
        public Patch TallPercent => tallPercent;
        public Patch[] Keys => keys;
        public Patch ArmsBg => armsBg;
        public Patch[][] Arms => arms;
        public Patch[] Faces => faces;
        public Patch[] FaceBacks => faceBacks;




        public Patch Background => background;
        public IReadOnlyList<Patch> MapPictures => mapPictures;

        public Patch Kills => kills;
        public Patch Secret => secret;
        public Patch SP_Secret => sp_secret;
        public Patch Items => items;
        public Patch Frags => frags;

        public Patch Time => time;
        public Patch Par => par;
        public Patch Sucks => sucks;

        public Patch Minus => wiminus;

        public IReadOnlyList<Patch> Numbers => numbers;

        public Patch Percent => percent;
        public Patch Colon => colon;

        public Patch Finished => finished;

        public Patch Entering => entering;

        public Patch Killers => killers;
        public Patch Victims => victims;

        public Patch Total => total;
        public Patch Star => star;
        public Patch BStar => BStar;

        public IReadOnlyList<IReadOnlyList<Patch>> LevelNames => lnames;
    }
}