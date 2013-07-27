using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class ExternalMic : AddonDecorator
    {
        public ExternalMic(Machine machine): base(machine)
        {
            this.Price = 15;
        }

       
    }
}
