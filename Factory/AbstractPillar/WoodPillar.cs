using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractPillar
{
    class WoodPillar : AbstractPillar
    {
        public WoodPillar()
        {
            Console.WriteLine("Create WoodPillar");
        }
    }
}
