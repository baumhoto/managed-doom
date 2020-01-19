﻿using System;

namespace ManagedDoom
{
    public sealed class TicCmd
    {
        public byte ForwardMove;   // *2048 for move
        public byte SideMove;  // *2048 for move
        public short AngleTurn;    // <<16 for angle delta
        public short Consistancy;  // checks for net game
        public byte ChatChar;
        public byte Buttons;
    }
}