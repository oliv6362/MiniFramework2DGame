﻿using GameClassLibraryFramework.Config;
using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.FactoryDesignPattern;
using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.TemplateDesignPattern;
using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        private IWorldObjectFactory worldObjectFactory;  


        public GameWorldManager(IGameWorld gameWorld, IGameConfig gameConfig, IWorldObjectFactory factory)
        {
            this.gameWorld = gameWorld;
            this.gameConfig = gameConfig;
            this.worldObjectFactory = factory;
            GameLogger.Instance.LogInformation("World has been created. " + "World Size is: " + gameConfig.MaxX + "x" + gameConfig.MaxY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creature"></param>
        public void AddCreature(AbstractCreature creature)
        {
            GameLogger.Instance.LogInformation(creature.CreatureName + " Creature added. Position: " + creature.Position);
            gameWorld.AddCreature(creature);
        }

        public void RemoveCreature(AbstractCreature creature)
        {
            GameLogger.Instance.LogInformation(creature.CreatureName + " Creature is being removed...");
            gameWorld.RemoveCreature(creature);
        }

        public void AddWorldObject(WorldObject worldObject)
        {
            GameLogger.Instance.LogInformation(worldObject.ObjectName + " WorldObject added. Position: " + worldObject.position);
            gameWorld.AddWorldObject(worldObject);
        }

        public void RemoveWorldObject(WorldObject worldObject)
        {
            GameLogger.Instance.LogInformation("WorldObject is being removed...");
            gameWorld.RemoveWorldObject(worldObject);
        }

        /// <summary>
        /// This method adds a new WorldObject to the game world using The factory pattern
        /// </summary>
        /// <param name="objectID"></param>
        /// <param name="objectName"></param>
        /// <param name="position"></param>
        /// <param name="lootable"></param>
        /// <param name="removable"></param>
        public void AddWorldObject(int objectID, string objectName, Vector2 position, bool lootable, bool removable)
        {
            var worldObject = worldObjectFactory.CreateWorldObject(objectID, objectName, position, lootable, removable);
            GameLogger.Instance.LogInformation(worldObject.ObjectName + " WorldObject added. Position: " + worldObject.position);
            gameWorld.AddWorldObject(worldObject);
        }


        public void DisplayAllWorldObjects()
        {
            GameLogger.Instance.LogInformation("Listing all lootable or removable World Objects:");

            var objects = gameWorld.WorldObjects;

            List<WorldObject> filteredObjects = objects
                .Where(obj => obj.lootable || obj.removeable)
                .OrderBy(obj => obj.position.X)
                .ThenBy(obj => obj.position.Y)
                .ToList();

            GameLogger.Instance.LogInformation($"Total lootable or removable objects found: {filteredObjects.Count}");

            if (filteredObjects.Any())
            {
                foreach (var obj in filteredObjects)
                {
                    GameLogger.Instance.LogInformation($"Lootable or removable Object: {obj.ObjectName}, Position: ({obj.position.X}, {obj.position.Y})");
                }
            }
        }
    }
}
