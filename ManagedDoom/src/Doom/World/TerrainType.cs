using System;

namespace ManagedDoom
{
    public class TerrainType
    {
        private string name;
        private FloorType type;

        public TerrainType(string name, FloorType type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name => name;

        public FloorType Type => type;

    }
    
   
}
