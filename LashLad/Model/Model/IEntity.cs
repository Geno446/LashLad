using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    public interface IEntity
    {
        int X { get; }
        int Y { get; }
        DisplayType DisplayType { get; }
    }
}
