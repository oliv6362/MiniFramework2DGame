using GameClassLibraryFramework.Config;
using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Manager
{
    public class GameWorldManager
    {
        World gameWorld = new World();
        GameConfig gameConfig = new GameConfig();


        public void LoadingGameWorld(string ConfigPath)
        {
            gameConfig.LoadConfig(ConfigPath);

            gameWorld.MaxX = gameConfig.MaxX;
            gameWorld.MaxY = gameConfig.MaxY;

            GameLogger.Instance.LogInformation("World is being created... " + "World Size is: " + gameWorld.MaxX + "x" + gameWorld.MaxY);
        }

        public void AddCreature()
        {
            // Add Creature
            GameLogger.Instance.LogInformation("Creature is being added...");
        }

        public void RemoveCreature()
        {
            // Remove Creature
            GameLogger.Instance.LogInformation("Creature is being removed...");
        }

        public void AddWorldObject()
        {
            // Add World Object
            GameLogger.Instance.LogInformation("WorldObject is being added...");
        }

        public void RemoveWorldObject()
        {
            // Remove World Object
            GameLogger.Instance.LogInformation("WorldObject is being removed...");
        }





    }
}
