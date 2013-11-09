using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.View
{
    interface IDisplayManager
    {
        void UpdateScene(IEnumerable<Model.IEntity> displayEntities);
        IEnumerable<IDisplayObject> GetDisplayObjects();
    }
}
