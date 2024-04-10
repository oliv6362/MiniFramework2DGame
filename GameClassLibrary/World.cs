namespace GameClassLibrary
{
    using GameClassLibraryFramework.TracingAndLogger;
    using System.Diagnostics;
    public class World
    {
        public int MaxY { get; private set; }
        public int MaxX { get; private set; }

        private List<Creature> Creatures = new List<Creature>();
        private List<WorldObject> WorldObjects = new List<WorldObject>();

        public World()
        {
        }
        public World(int maxY, int maxX)
        {
            MaxY = maxY;
            MaxX = maxX;

            GameLogger.Instance.LogInformation("World is being created... " + "Max width is:" + MaxX + " Max height is:" + MaxY);
        }


    }
}
