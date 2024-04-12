using GameClassLibraryFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Interfaces
{
    public interface IGameWorld
    {
        List<Creature> Creatures { get; }
        List<WorldObject> WorldObjects { get; }

        void AddCreature(Creature creature);
        void RemoveCreature(Creature creature);
        void AddWorldObject(WorldObject worldObject);
        void RemoveWorldObject(WorldObject worldObject);
    }
}
