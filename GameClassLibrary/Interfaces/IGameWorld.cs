using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.TemplateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Interfaces
{
    public interface IGameWorld
    {
        List<AbstractCreature> Creatures { get; }
        List<WorldObject> WorldObjects { get; }

        void AddCreature(AbstractCreature creature);
        void RemoveCreature(AbstractCreature creature);
        void AddWorldObject(WorldObject worldObject);
        void RemoveWorldObject(WorldObject worldObject);
    }
}
