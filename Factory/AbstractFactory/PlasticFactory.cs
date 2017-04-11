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
    class PlasticFactory : AbstractFactory
    {
        public PlasticFactory()
        {
            Console.WriteLine("Create PlasticFactory");
        }
        public override AbstractCarcass.AbstractCarcass CreateCarcass()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractCarcass.PlasticCarcass();
            }
            else return null;
        }

        public override AbstractPannier.AbstractPannier CreatePannier()
        {
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPannier.PlasticPannier();
            }
            else return null;
        }

        public override AbstractPillar.AbstractPillar CreatePillar()
        {
          
            if (!IsEmpty())
            {
                --Resourses;
                return new AbstractPillar.PlasticPillar();
            }
            else return null;
        }
    }
}
