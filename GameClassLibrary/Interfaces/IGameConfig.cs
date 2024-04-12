using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Interfaces
{
    public interface IGameConfig
    {
        int MaxX { get; }
        int MaxY { get; }
        void LoadConfig(string configPath);
    }
}
