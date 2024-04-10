using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClassLibraryFramework.TracingAndLogger;


namespace GameClassLibrary
{
    public class WorldObject
    {
        private string ObjectID { get; set; }
        private string ObjectName { get; set; }
        private bool lootable { get; set; }
        private bool removeable { get; set; }

        public WorldObject()
        {

        }

        public WorldObject(string objectID, string objectName, bool lootable, bool removeable)
        {
            ObjectID = objectID;
            ObjectName = objectName;
            this.lootable = lootable;
            this.removeable = removeable;
        }

        public void AddWorldObject(WorldObject obj)
        {
            //WorldObjects.Add(obj);
            GameLogger.Instance.LogInformation("WorldObject is being added...");
        }

        public void RemoveWorldObject(WorldObject obj)
        {
            //WorldObjects.Remove(this);
            GameLogger.Instance.LogInformation("WorldObject is being removed...");
        }
    }
}
