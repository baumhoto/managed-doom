//
// Copyright (C) 1993-1996 Id Software, Inc.
// Copyright (C) 2019-2020 Nobuaki Tanaka
// Copyright (C) 2020-2021 Tobias Baumhöver

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
    [Flags]
    public enum MobjFlags2  //* logic for new flags is still missing
    {
        None = 0,
        // alternate gravity setting
        LogRav = 1,

        // gets pushed around bt the wind specials.
        WindThrust = 2,

        // bounces off the Floor.
        FloorBounce = 4,

        // missile will pass through ghosts
        ThruGhost = 8,

        // fly mode is active
        Fly = 16,
        
        // if feet are allowed to be clipped
        FootClip = 32,

        // spawn random float z
        SpawnFloat = 64,

        // does not teleport
        NoTeleport = 128,
        // missle rips through solid targets
        Rip = 256,
        // can be pushed my other moving mobjs
        Pushable = 512,
        // slides against walls
        Silde = 0x400,
        // mobj ist resting on top of another mobj
        OnMobj = 0x800,
        // enable z block checking. if on this flag
        // will allow the mobj to pass over/under other mobjs
        PassMobj = 0x1000,
        // can not push other pushable mobjs
        CanNotPush = 0x2000,
        // a mobj's feet are now being cut
        FeetAreClipped = 0x4000,
        // mobj is a major boss
        Boss,
        // does fire damage
        FireDamage,
        // does not thrust target when damaging
        NoDamageThrust,
        // mobj an stomp another
        TeleStomp,
        // use float bobbing z movement
        FloatBob,
        // don't generate a vissprite
        DontDraw
    }
}