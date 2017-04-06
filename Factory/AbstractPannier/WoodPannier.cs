using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.AbstractCarcass;
using Factory.AbstractPillar;
using Factory.ItemsForFurniture;

namespace Factory.AbstractPannier
{
    class WoodPannier : AbstractPannier
    {
        public WoodPannier()
        {
            Console.WriteLine("Create WoodPannier");
        }
        public override void Interact(AbstractCarcass.AbstractCarcass carcass)
        {
            Console.WriteLine(this + " interacts with " + carcass);
        }

        public override void Interact(AbstractPillar.AbstractPillar pillar)
        {
            Console.WriteLine(this + " interacts with " + pillar);

        }

        public override void Interact(BoxItems items)
        {
            Console.WriteLine(this + " interacts with " + items);

        }
    }
}
