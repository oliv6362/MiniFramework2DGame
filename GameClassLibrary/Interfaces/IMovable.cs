using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Interfaces
{
    public interface IMovable
    {
        Vector2 Position { get; set; }
        void Move(Vector2 newPosition);
    }
}
