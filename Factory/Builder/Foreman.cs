using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.AbstractFactory;

namespace Factory.Builder
{
    class Foreman
    {
        Builder builder;
        AbstractFactory.AbstractFactory abstractFactory;
        AbstractCarcass.AbstractCarcass abstractCarcass;
        AbstractPannier.AbstractPannier abstractPannier;
        AbstractPillar.AbstractPillar abstractPillar;

        public Foreman(Builder builder, AbstractFactory.AbstractFactory factory)
        {
            this.builder = builder;
            abstractFactory = factory;
        }
        public void CreateAbstractElements()
        {
            abstractCarcass = abstractFactory.CreateCarcass();
            abstractPannier = abstractFactory.CreatePannier();
            abstractPillar = abstractFactory.CreatePillar();
            
        }
        internal AbstractFactory.AbstractFactory AbstractFactory { get => abstractFactory; set => abstractFactory = value; }

        public void Construct()
        {
            
            abstractPannier.Interact(abstractCarcass);
            abstractPannier.Interact(abstractPillar);
            builder.BuildDoorHandle();
            builder.BuildFasad();
            builder.BuildMattresses();
            abstractPannier.Interact(builder.GetResult());
        }
    }
}
