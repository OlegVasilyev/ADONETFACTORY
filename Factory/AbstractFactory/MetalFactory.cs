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
    class MetalFactory : AbstractFactory
    {
        public MetalFactory()
        {
            Console.WriteLine("Create MetalFactory");
        }
        public override AbstractCarcass.AbstractCarcass CreateCarcass()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractCarcass.MetalCarcass();
            }
            else return null;
        }

        public override AbstractPannier.AbstractPannier CreatePannier()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPannier.MetalPannier();
            }
            else return null;
        }

        public override AbstractPillar.AbstractPillar CreatePillar()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPillar.MetalPillar();
            }
            else return null;
        }
    }
}
