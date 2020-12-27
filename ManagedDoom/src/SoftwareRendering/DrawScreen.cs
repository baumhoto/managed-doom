//
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
using System.Collections.Generic;

namespace ManagedDoom.SoftwareRendering
{
    public sealed class DrawScreen
    {
        private int width;
        private int height;
        private byte[] data;

        private Patch[] charsFontA;
        private Patch[] charsFontB;

        public DrawScreen(Wad wad, int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new byte[width * height];
            var fontAStart = wad.GetLumpNumber("FONTA_S") + 1;
            var fontAEnd = wad.GetLumpNumber("FONTA_E") - 1;
            var count = fontAEnd - fontAStart + 1;

            charsFontA = new Patch[count];
            for (var i = 1; i < charsFontA.Length; i++)
            {
                var name = "FONTA" + i.ToString("00");
                var lump = wad.GetLumpNumber(name);
                if (lump != -1)
                {
                    charsFontA[i] = Patch.FromData(name, wad.ReadLump(lump));
                }
            }

            var fontBStart = wad.GetLumpNumber("FONTB_S") + 1;
            var fontBEnd = wad.GetLumpNumber("FONTB_E") - 1;
            count = fontAEnd - fontAStart + 1;

            charsFontB = new Patch[count];
            for (var i = 1; i < charsFontB.Length; i++)
            {
                var name = "FONTB" + i.ToString("00");
                var lump = wad.GetLumpNumber(name);
                if (lump != -1)
                {
                    charsFontB[i] = Patch.FromData(name, wad.ReadLump(lump));
                }
            }
        }

        public void DrawRaw(byte[] rawData, int scale) {
            this.data = rawData;
            // var drawX = 320 - scale * 0;
            // var drawY = 200 - scale * 0;
            // var drawWidth = scale * 320;
            // var drawHeight = scale * 200;

            // var i = 0;
            // var step = Fixed.One / scale;
            // for(int col = 0; col < drawWidth; col++ ){
            //     var frac = Fixed.One / scale - Fixed.Epsilon;
            //     for(int row = 0; row < drawHeight; row++) {
            //         var index = (col / scale * 200) + frac.ToIntFloor();
            //         if(index < rawData.Length) 
            //         {
            //             data[i] = rawData[index];
            //         }
            //         else {
            //             Console.WriteLine(index);
            //         }
            //         i++;
            //         frac += step;
            //     }
            // }
        }

        public void DrawPatch(Patch patch, int x, int y, int scale)
        {
            var drawX = x - scale * patch.LeftOffset;
            var drawY = y - scale * patch.TopOffset;
            var drawWidth = scale * patch.Width;

            var i = 0;
            var frac = Fixed.One / scale - Fixed.Epsilon;
            var step = Fixed.One / scale;

            if (drawX < 0)
            {
                var exceed = -drawX;
                frac += exceed * step;
                i += exceed;
            }

            if (drawX + drawWidth > width)
            {
                var exceed = drawX + drawWidth - width;
                drawWidth -= exceed;
            }

            for (; i < drawWidth; i++)
            {
                DrawColumn(patch.Columns[frac.ToIntFloor()], drawX + i, drawY, scale);
                frac += step;
            }
        }

        public void DrawPatchFlip(Patch patch, int x, int y, int scale)
        {
            var drawX = x - scale * patch.LeftOffset;
            var drawY = y - scale * patch.TopOffset;
            var drawWidth = scale * patch.Width;

            var i = 0;
            var frac = Fixed.One / scale - Fixed.Epsilon;
            var step = Fixed.One / scale;

            if (drawX < 0)
            {
                var exceed = -drawX;
                frac += exceed * step;
                i += exceed;
            }

            if (drawX + drawWidth > width)
            {
                var exceed = drawX + drawWidth - width;
                drawWidth -= exceed;
            }

            for (; i < drawWidth; i++)
            {
                var col = patch.Width - frac.ToIntFloor() - 1;
                DrawColumn(patch.Columns[col], drawX + i, drawY, scale);
                frac += step;
            }
        }

        private void DrawColumn(Column[] source, int x, int y, int scale)
        {
            var step = Fixed.One / scale;

            foreach (var column in source)
            {
                var exTopDelta = scale * column.TopDelta;
                var exLength = scale * column.Length;

                var sourceIndex = column.Offset;
                var drawY = y + exTopDelta;
                var drawLength = exLength;

                var i = 0;
                var p = height * x + drawY;
                var frac = Fixed.One / scale - Fixed.Epsilon;

                if (drawY < 0)
                {
                    var exceed = -drawY;
                    p += exceed;
                    frac += exceed * step;
                    i += exceed;
                }

                if (drawY + drawLength > height)
                {
                    var exceed = drawY + drawLength - height;
                    drawLength -= exceed;
                }

                for (; i < drawLength; i++)
                {
                    data[p] = column.Data[sourceIndex + frac.ToIntFloor()];
                    p++;
                    frac += step;
                }
            }
        }

        public void DrawTextB(IReadOnlyList<char> text, int x, int y, int scale)
        {
            var drawX = x;
            var drawY = y - 7 * scale;
            foreach (var ch in text)
            {
                if (ch >= charsFontB.Length)
                {
                    continue;
                }

                if (ch == 32)
                {
                    drawX += 4 * scale;
                    continue;
                }

                var index = (int)ch;
                if ('a' <= index && index <= 'z')
                {
                    index = index - 'a' + 'A';
                }

                var patch = charsFontB[index];
                if (patch == null)
                {
                    continue;
                }

                DrawPatch(patch, drawX, drawY, scale);

                drawX += scale * patch.Width;
            }
        }

        public void DrawCharB(char ch, int x, int y, int scale)
        {
            var drawX = x;
            var drawY = y - 7 * scale;

            if (ch >= charsFontB.Length)
            {
                return;
            }

            if (ch == 32)
            {
                return;
            }

            var index = (int)ch;
            if ('a' <= index && index <= 'z')
            {
                index = index - 'a' + 'A';
            }

            var patch = charsFontB[index];
            if (patch == null)
            {
                return;
            }

            DrawPatch(patch, drawX, drawY, scale);
        }

        public void DrawTextB(string text, int x, int y, int scale)
        {
            var drawX = x;
            var drawY = y - 7 * scale;
            foreach (var ch in text)
            {
                // if (ch >= charsFontB.Length)
                // {
                //     continue;
                // }

                if (ch < 33)
                {
                    drawX += 8 * scale;
                    continue;
                }

                var index = (int)ch;
                if ('a' <= index && index <= 'z')
                {
                    index = index - 'a' + 'A';
                }

                var patch = charsFontB[index-32];
                if (patch == null)
                {
                    continue;
                }

                DrawPatch(patch, drawX, drawY, scale);

                drawX += scale * patch.Width;
            }
        }

        public int MeasureChar(char ch, int scale)
        {
            if (ch >= charsFontB.Length)
            {
                return 0;
            }

            if (ch == 32)
            {
                return 4 * scale;
            }

            var index = (int)ch;
            if ('a' <= index && index <= 'z')
            {
                index = index - 'a' + 'A';
            }

            var patch = charsFontB[index];
            if (patch == null)
            {
                return 0;
            }

            return scale * patch.Width;
        }

        public int MeasureText(IReadOnlyList<char> text, int scale)
        {
            var width = 0;

            foreach (var ch in text)
            {
                if (ch >= charsFontB.Length)
                {
                    continue;
                }

                if (ch == 32)
                {
                    width += 4 * scale;
                    continue;
                }

                var index = (int)ch;
                if ('a' <= index && index <= 'z')
                {
                    index = index - 'a' + 'A';
                }

                var patch = charsFontB[index];
                if (patch == null)
                {
                    continue;
                }

                width += scale * patch.Width;
            }

            return width;
        }

        public int MeasureText(string text, int scale)
        {
            var width = 0;

            foreach (var ch in text)
            {
                if (ch >= charsFontB.Length)
                {
                    continue;
                }

                if (ch == 32)
                {
                    width += 4 * scale;
                    continue;
                }

                var index = (int)ch;
                if ('a' <= index && index <= 'z')
                {
                    index = index - 'a' + 'A';
                }

                var patch = charsFontB[index];
                if (patch == null)
                {
                    continue;
                }

                width += scale * patch.Width;
            }

            return width;
        }

        public void FillRect(int x, int y, int w, int h, int color)
        {
            var x1 = x;
            var x2 = x + w;
            for (var drawX = x1; drawX < x2; drawX++)
            {
                var pos = height * drawX + y;
                for (var i = 0; i < h; i++)
                {
                    data[pos] = (byte)color;
                    pos++;
                }
            }
        }



        [Flags]
        private enum OutCode
        {
            Inside = 0,
            Left = 1,
            Right = 2,
            Bottom = 4,
            Top = 8
        }

        private OutCode ComputeOutCode(float x, float y)
        {
            var code = OutCode.Inside;

            if (x < 0)
            {
                code |= OutCode.Left;
            }
            else if (x > width)
            {
                code |= OutCode.Right;
            }

            if (y < 0)
            {
                code |= OutCode.Bottom;
            }
            else if (y > height)
            {
                code |= OutCode.Top;
            }

            return code;
        }

        public void DrawLine(float x1, float y1, float x2, float y2, int color)
        {
            var outCode1 = ComputeOutCode(x1, y1);
            var outCode2 = ComputeOutCode(x2, y2);

            var accept = false;

            while (true)
            {
                if ((outCode1 | outCode2) == 0)
                {
                    accept = true;
                    break;
                }
                else if ((outCode1 & outCode2) != 0)
                {
                    break;
                }
                else
                {
                    var x = 0.0F;
                    var y = 0.0F;

                    var outcodeOut = outCode2 > outCode1 ? outCode2 : outCode1;

                    if ((outcodeOut & OutCode.Top) != 0)
                    {
                        x = x1 + (x2 - x1) * (height - y1) / (y2 - y1);
                        y = height;
                    }
                    else if ((outcodeOut & OutCode.Bottom) != 0)
                    {
                        x = x1 + (x2 - x1) * (0 - y1) / (y2 - y1);
                        y = 0;
                    }
                    else if ((outcodeOut & OutCode.Right) != 0)
                    {
                        y = y1 + (y2 - y1) * (width - x1) / (x2 - x1);
                        x = width;
                    }
                    else if ((outcodeOut & OutCode.Left) != 0)
                    {
                        y = y1 + (y2 - y1) * (0 - x1) / (x2 - x1);
                        x = 0;
                    }

                    if (outcodeOut == outCode1)
                    {
                        x1 = x;
                        y1 = y;
                        outCode1 = ComputeOutCode(x1, y1);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        outCode2 = ComputeOutCode(x2, y2);
                    }
                }
            }

            if (accept)
            {
                var bx1 = Math.Clamp((int)x1, 0, width - 1);
                var by1 = Math.Clamp((int)y1, 0, height - 1);
                var bx2 = Math.Clamp((int)x2, 0, width - 1);
                var by2 = Math.Clamp((int)y2, 0, height - 1);
                Bresenham(bx1, by1, bx2, by2, color);
            }
        }

        private void Bresenham(int x1, int y1, int x2, int y2, int color)
        {
            var dx = x2 - x1;
            var ax = 2 * (dx < 0 ? -dx : dx);
            var sx = dx < 0 ? -1 : 1;

            var dy = y2 - y1;
            var ay = 2 * (dy < 0 ? -dy : dy);
            var sy = dy < 0 ? -1 : 1;

            var x = x1;
            var y = y1;

            if (ax > ay)
            {
                var d = ay - ax / 2;

                while (true)
                {
                    data[height * x + y] = (byte)color;

                    if (x == x2)
                    {
                        return;
                    }

                    if (d >= 0)
                    {
                        y += sy;
                        d -= ax;
                    }

                    x += sx;
                    d += ay;
                }
            }
            else
            {
                var d = ax - ay / 2;
                while (true)
                {
                    data[height * x + y] = (byte)color;

                    if (y == y2)
                    {
                        return;
                    }

                    if (d >= 0)
                    {
                        x += sx;
                        d -= ay;
                    }

                    y += sy;
                    d += ax;
                }
            }
        }

        public int Width => width;
        public int Height => height;
        public byte[] Data => data;
    }
}
