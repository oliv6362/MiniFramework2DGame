using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GameClassLibraryFramework.TracingAndLogger;


namespace GameClassLibraryFramework.Entity
{
    public class WorldObject
    {
        public int ObjectID { get; private set; }
        public string? ObjectName { get; private set; }
        public Vector2 position { get; private set; }
        public bool lootable { get; private set; }
        public bool removeable { get; private set; }

        public WorldObject()
        {

        }

        public WorldObject(int objectID, string? objectName, Vector2 position, bool lootable, bool removeable)
        {
            ObjectID = objectID;
            ObjectName = objectName;
            this.position = position;
            this.lootable = lootable;
            this.removeable = removeable;
        }
    }
}
