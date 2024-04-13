using GameClassLibraryFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.FactoryDesignPattern
{
    public interface IWorldObjectFactory
    {
        WorldObject CreateWorldObject(int objectID, string objectName, Vector2 position, bool lootable, bool removable);
    }
}
