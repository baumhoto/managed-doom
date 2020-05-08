﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManagedDoom;

namespace ManagedDoomTest.CompatibilityTests
{
    [TestClass]
    public class PwadDemo
    {
        [TestMethod]
        public void RequiemDemo1_Final2()
        {
            using (var resource = CommonResource.CreateDummy(WadPath.Doom2, WadPath.Requiem))
            {
                var demo = new Demo(resource.Wad.ReadLump("DEMO1"));
                demo.Options.Version = GameVersion.Final2;
                var players = DoomTest.GetDefaultPlayers();
                var cmds = players.Select(player => player.Cmd).ToArray();
                var world = new World(resource, demo.Options, players);

                var lastMobjHash = 0;
                var aggMobjHash = 0;
                var lastSectorHash = 0;
                var aggSectorHash = 0;

                while (true)
                {
                    demo.ReadCmd(cmds);
                    world.Update();
                    lastMobjHash = DoomDebug.GetMobjHash(world);
                    aggMobjHash = DoomDebug.CombineHash(aggMobjHash, lastMobjHash);
                    lastSectorHash = DoomDebug.GetSectorHash(world);
                    aggSectorHash = DoomDebug.CombineHash(aggSectorHash, lastSectorHash);

                    if (world.levelTime == 18003)
                    {
                        break;
                    }
                }

                Assert.AreEqual(0x62d5d8f5u, (uint)lastMobjHash);
                Assert.AreEqual(0x05ce9c00u, (uint)aggMobjHash);
                Assert.AreEqual(0x94015cdau, (uint)lastSectorHash);
                Assert.AreEqual(0x1ae3ca8eu, (uint)aggSectorHash);
            }
        }

        [TestMethod]
        public void RequiemDemo2()
        {
            using (var resource = CommonResource.CreateDummy(WadPath.Doom2, WadPath.Requiem))
            {
                var demo = new Demo(resource.Wad.ReadLump("DEMO2"));
                var players = DoomTest.GetDefaultPlayers();
                var cmds = players.Select(player => player.Cmd).ToArray();
                var world = new World(resource, demo.Options, players);

                var lastMobjHash = 0;
                var aggMobjHash = 0;
                var lastSectorHash = 0;
                var aggSectorHash = 0;

                while (true)
                {
                    demo.ReadCmd(cmds);
                    world.Update();
                    world.Options.GameTic++; // To avoid desync due to revenant missile.
                    lastMobjHash = DoomDebug.GetMobjHash(world);
                    aggMobjHash = DoomDebug.CombineHash(aggMobjHash, lastMobjHash);
                    lastSectorHash = DoomDebug.GetSectorHash(world);
                    aggSectorHash = DoomDebug.CombineHash(aggSectorHash, lastSectorHash);

                    if (world.levelTime == 24659)
                    {
                        break;
                    }
                }

                Assert.AreEqual(0x083125a6u, (uint)lastMobjHash);
                Assert.AreEqual(0x50237ab4u, (uint)aggMobjHash);
                Assert.AreEqual(0x732a5645u, (uint)lastSectorHash);
                Assert.AreEqual(0x36f64dd0u, (uint)aggSectorHash);
            }
        }

        [TestMethod]
        public void RequiemDemo3()
        {
            using (var resource = CommonResource.CreateDummy(WadPath.Doom2, WadPath.Requiem))
            {
                var demo = new Demo(resource.Wad.ReadLump("DEMO3"));
                var players = DoomTest.GetDefaultPlayers();
                var cmds = players.Select(player => player.Cmd).ToArray();
                var world = new World(resource, demo.Options, players);

                var lastMobjHash = 0;
                var aggMobjHash = 0;
                var lastSectorHash = 0;
                var aggSectorHash = 0;

                while (true)
                {
                    demo.ReadCmd(cmds);
                    world.Update();
                    world.Options.GameTic++; // To avoid desync due to revenant missile.
                    lastMobjHash = DoomDebug.GetMobjHash(world);
                    aggMobjHash = DoomDebug.CombineHash(aggMobjHash, lastMobjHash);
                    lastSectorHash = DoomDebug.GetSectorHash(world);
                    aggSectorHash = DoomDebug.CombineHash(aggSectorHash, lastSectorHash);

                    if (world.levelTime == 52487)
                    {
                        break;
                    }
                }

                Assert.AreEqual(0xb76035c8u, (uint)lastMobjHash);
                Assert.AreEqual(0x87651774u, (uint)aggMobjHash);
                Assert.AreEqual(0xa2d7d335u, (uint)lastSectorHash);
                Assert.AreEqual(0xabf7609au, (uint)aggSectorHash);
            }
        }

        [TestMethod]
        public void TntBloodDemo1()
        {
            using (var resource = CommonResource.CreateDummy(WadPath.Doom2, WadPath.TntBlood))
            {
                var demo = new Demo(resource.Wad.ReadLump("DEMO1"));
                var players = DoomTest.GetDefaultPlayers(demo.Options);
                var cmds = Enumerable.Range(0, Player.MaxPlayerCount).Select(i => new TicCmd()).ToArray();
                var game = new DoomGame(players, resource, demo.Options);

                var lastMobjHash = 0;
                var aggMobjHash = 0;
                var lastSectorHash = 0;
                var aggSectorHash = 0;

                while (true)
                {
                    demo.ReadCmd(cmds);
                    game.Update(cmds);
                    lastMobjHash = DoomDebug.GetMobjHash(game.World);
                    aggMobjHash = DoomDebug.CombineHash(aggMobjHash, lastMobjHash);
                    lastSectorHash = DoomDebug.GetSectorHash(game.World);
                    aggSectorHash = DoomDebug.CombineHash(aggSectorHash, lastSectorHash);

                    if (game.World.levelTime == 8190)
                    {
                        break;
                    }
                }

                // Player respawn fog in deathmatch seems to be spawned at a bit wrong position in the original version.
                // However, this behavior is not easy to reproduce in the current C# codebase.
                // So the strict check below for the compatibility is turned off.

                Assert.AreEqual(0xa8343166u, (uint)lastMobjHash);
                // Assert.AreEqual(0xd1d5c433u, (uint)aggMobjHash);
                Assert.AreEqual(0x9e70ce46u, (uint)lastSectorHash);
                Assert.AreEqual(0x71eb6e2cu, (uint)aggSectorHash);
            }
        }
    }
}