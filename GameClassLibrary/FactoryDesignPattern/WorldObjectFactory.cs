using GameClassLibraryFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.FactoryDesignPattern
{
    public class WorldObjectFactory : IWorldObjectFactory
    {
        public WorldObject CreateWorldObject(int objectID, string objectName, Vector2 position, bool lootable, bool removable)
        {

            return new WorldObject(objectID, objectName, position, lootable, removable);
        }
    }
}
