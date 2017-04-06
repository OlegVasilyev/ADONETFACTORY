using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Builder
{
    abstract class Builder
    {
        public abstract void BuildDoorHandle();
        public abstract void BuildFasad();
        public abstract void BuildMattresses();
        public abstract ItemsForFurniture.BoxItems GetResult();
    }
}
