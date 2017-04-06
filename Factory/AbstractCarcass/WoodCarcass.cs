using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractCarcass
{
    class WoodCarcass : AbstractCarcass
    {
        public WoodCarcass()
        {
            Console.WriteLine("Create WoodCarcass");
           
        }
    }
}
