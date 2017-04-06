using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.AbstractCarcass;
using Factory.AbstractPannier;
using Factory.AbstractPillar;

namespace Factory.AbstractFactory
{
    class WoodFactory : AbstractFactory
    {
        public WoodFactory()
        {
            Console.WriteLine("Create WoodFactory");
        }
        public override AbstractCarcass.AbstractCarcass CreateCarcass()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractCarcass.WoodCarcass();
            }
            else return null;
        }

        public override AbstractPannier.AbstractPannier CreatePannier()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPannier.WoodPannier();
            }
            else return null;
        }

        public override AbstractPillar.AbstractPillar CreatePillar()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPillar.WoodPillar();
            }
            else return null;
        }
    }
}
