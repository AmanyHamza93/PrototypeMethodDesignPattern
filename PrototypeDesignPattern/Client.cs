using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Client
    {
        public void CreateShallowCopy()
        {           
            IGraphicElement oldCopy = new Logo("Original Logo", "Blue", new Shape { Width = 100, Height = 50 });
            oldCopy.ShallowCopy();
        }
        public void CreateDeepCopy()
        {
            IGraphicElement oldCopy = new Logo("Original Logo", "Blue", new Shape { Width = 100, Height = 50 });
            oldCopy.DeepCopy();
        }
    }
}
