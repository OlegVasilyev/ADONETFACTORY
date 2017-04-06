using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractPannier
{
    abstract class AbstractPannier
    {
        public abstract void Interact(AbstractCarcass.AbstractCarcass carcass);
        public abstract void Interact(AbstractPillar.AbstractPillar pillar);
        public abstract void Interact(ItemsForFurniture.BoxItems items);
    }
}
