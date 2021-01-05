using System;

namespace ManagedDoom
{
    public static partial class DoomInfo
    {
        public static readonly TerrainType[] TerrainTypes = new TerrainType[]
        {
            new TerrainType("FLTWAWA1", FloorType.Water),
            new TerrainType("FLTFLWW1", FloorType.Water),
            new TerrainType("FLTLAVA1", FloorType.Lava),
            new TerrainType("FLTHUH1", FloorType.Lava),
            new TerrainType("FLTSLUD1", FloorType.Sludge),
            new TerrainType("END", FloorType.End)
        };
    }
}