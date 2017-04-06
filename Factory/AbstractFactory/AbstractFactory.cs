using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    abstract class AbstractFactory
    {
        public int Resourses { get; set; }
        public abstract AbstractPannier.AbstractPannier CreatePannier();
        public abstract AbstractPillar.AbstractPillar CreatePillar();
        public abstract AbstractCarcass.AbstractCarcass CreateCarcass();
        public bool IsEmpty()
        {
            if (Resourses == 0)
                return true;
            return false;
        }
    }
}
