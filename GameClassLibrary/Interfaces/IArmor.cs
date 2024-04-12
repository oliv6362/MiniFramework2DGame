using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Interfaces
{
    public interface IArmor
    {
        int ArmorID { get; }
        string ArmorName { get; }
        int ReduceHitPoint { get; }
    }
}
