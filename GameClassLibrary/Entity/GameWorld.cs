namespace GameClassLibraryFramework.Entity
{
    using GameClassLibraryFramework.Interfaces;
    using GameClassLibraryFramework.TemplateDesignPattern;
    using System.Diagnostics;

    public class GameWorld : IGameWorld
    {
        public int MaxY { get; set; }
        public int MaxX { get; set; }

         public List<AbstractCreature> Creatures { get; private set; } = new List<AbstractCreature>();
         public List<WorldObject> WorldObjects { get; private set; } = new List<WorldObject>();

        public GameWorld()
        {
          
        }
        public GameWorld(int maxY, int maxX)
        {
            MaxY = maxY;
            MaxX = maxX;
        }

        public void AddCreature(AbstractCreature creature)
        {
            Creatures.Add(creature);
        }

        public void RemoveCreature(AbstractCreature creature)
        {
            Creatures.Remove(creature);
        }

        public void AddWorldObject(WorldObject worldObject)
        {
            WorldObjects.Add(worldObject);
        }

        public void RemoveWorldObject(WorldObject worldObject)
        {
            WorldObjects.Remove(worldObject);
        }
    }
}
