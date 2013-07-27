using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Ssd: AddonDecorator
    {
        public Ssd(Machine machine) : base(machine)
        {
            this.Price = 300;
        }
    }
}
