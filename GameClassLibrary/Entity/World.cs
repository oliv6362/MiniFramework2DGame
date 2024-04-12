namespace GameClassLibraryFramework.Entity
{
    using GameClassLibraryFramework.Interfaces;
    using System.Diagnostics;

    public class World : IGameWorld
    {
        public int MaxY { get; set; }
        public int MaxX { get; set; }

        private List<Creature> Creatures = new List<Creature>();
        private List<WorldObject> WorldObjects = new List<WorldObject>();

        public World()
        {
          
        }
        public World(int maxY, int maxX)
        {
            MaxY = maxY;
            MaxX = maxX;
        }

        public void AddCreature(Creature creature)
        {
            Creatures.Add(creature);
        }

        public void RemoveCreature(Creature creature)
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
