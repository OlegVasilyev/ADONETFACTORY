using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.ItemsForFurniture;

namespace Factory.Builder
{
    class ConcreteBuilder : Builder
    {
        BoxItems box = new BoxItems();
        public override void BuildDoorHandle()
        {
            box.Add(new DoorHandle());
        }

        public override void BuildFasad()
        {
            box.Add(new Fasad());
        }

        public override void BuildMattresses()
        {
            box.Add(new Mattresses());
        }

        public override BoxItems GetResult()
        {
            return box;
        }
    }
}
