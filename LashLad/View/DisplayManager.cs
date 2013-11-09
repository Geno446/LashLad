using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.View
{
    class DisplayManager : IDisplayManager
    {
        IList<IDisplayObject> DisplayObjects = new List<IDisplayObject>();
        public void UpdateScene(IEnumerable<Model.IEntity> displayEntities)
        {
            DisplayObjects.Clear();
            foreach (var de in displayEntities)
            {
                DisplayObjects.Add(new DisplayObject(de.X, de.Y, de.DisplayType));
            }
        }

        public IEnumerable<IDisplayObject> GetDisplayObjects()
        {
            return DisplayObjects;
        }
    }
}
