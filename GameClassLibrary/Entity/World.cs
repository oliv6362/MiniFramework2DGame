namespace GameClassLibraryFramework.Entity
{

    using System.Diagnostics;

    public class World
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

        public void checkvalues()
        {
            Console.WriteLine("MaxX: " + MaxX);
            Console.WriteLine("MaxY: " + MaxY);
        }
    }
}
