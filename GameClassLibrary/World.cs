namespace GameClassLibrary
{
    public class World
    {
        private int MaxY { get; set; }
        private int MaxX { get; set; }

        private List<Creature> Creatures = new List<Creature>();
        private List<WorldObject> WorldObjects = new List<WorldObject>();

    }
}
