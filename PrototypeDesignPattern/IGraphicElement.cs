using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public interface IGraphicElement
    {
        void ShallowCopy();
        void DeepCopy();
    }
}
