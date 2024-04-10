using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
