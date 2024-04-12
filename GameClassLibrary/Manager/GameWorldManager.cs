using GameClassLibraryFramework.Config;
using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Manager
{
    /// <summary>
    /// 
    /// </summary>
    public class GameWorldManager
    {
        private IGameWorld gameWorld;
        private IGameConfig gameConfig;


        public GameWorldManager(IGameWorld gameWorld, IGameConfig gameConfig)
        {
            this.gameWorld = gameWorld;
            this.gameConfig = gameConfig;
            GameLogger.Instance.LogInformation("World has been created. " + "World Size is: " + gameConfig.MaxX + "x" + gameConfig.MaxY);
        }   
           
        /// <summary>
        /// 
        /// </summary>
        /// <param name="creature"></param>
        public void AddCreature(Creature creature)
        {
            GameLogger.Instance.LogInformation(creature.CreatureName + " Creature added. Position: " + creature.Position);
            gameWorld.AddCreature(creature);
        }

        public void RemoveCreature(Creature creature)
        {
            GameLogger.Instance.LogInformation(creature.CreatureName + " Creature is being removed...");
            gameWorld.RemoveCreature(creature);
        }

        public void AddWorldObject(WorldObject worldObject)
        {
            GameLogger.Instance.LogInformation(worldObject.ObjectName + " WorldObject added. Position: " + worldObject.position);
            gameWorld.AddWorldObject(worldObject);
        }

        public void RemoveWorldObject()
        {
            // Remove World Object
            GameLogger.Instance.LogInformation("WorldObject is being removed...");
        }





    }
}
