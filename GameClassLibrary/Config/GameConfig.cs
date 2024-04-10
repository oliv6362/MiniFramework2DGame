using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameClassLibraryFramework.Config
{
    public class GameConfig
    {
        public int MaxX { get; private set; }
        public int MaxY { get; private set; }

        public void LoadConfig()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load("GameConfig.xml");
   

            XmlNode? maxXNode = configDoc.SelectSingleNode("/GameConfig/MaxX");
            if (maxXNode != null)
            {
                int maxX = int.Parse(maxXNode.InnerText);
                MaxX = maxX;
            }

            XmlNode? maxYNode = configDoc.SelectSingleNode("/GameConfig/MaxY");
            if (maxYNode != null)
            {
                int maxY = int.Parse(maxYNode.InnerText);
                MaxY = maxY;
            }
        }
    }
}
