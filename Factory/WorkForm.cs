using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory.Builder;
namespace Factory
{
    public partial class WorkForm : Form
    {
        string type;
        Foreman foreman;
        ConcreteBuilder builder;
        DAL dal;
        int id;
        public WorkForm(int id, string type)
        {
            InitializeComponent();
            this.type = type;
            this.dal = new DAL();
            this.id = id;
        }
        private AbstractFactory.AbstractFactory IdentifyTypeFactory()
        {
            if (type == TypeFurniture.Metal.ToString())
                return new AbstractFactory.MetalFactory();
            else if (type == TypeFurniture.Plastic.ToString())
                return new AbstractFactory.PlasticFactory();
            else
                return new AbstractFactory.WoodFactory();
        }
        private void CreateFurnityreButton_Click(object sender, EventArgs e)
        {
            foreman.CreateAbstractElements();
            foreman.Construct();
        }

        private void FindWorker_Click(object sender, EventArgs e)
        {
            builder = new ConcreteBuilder();
            foreman = new Foreman(builder, IdentifyTypeFactory());
        }

        private void SendFurniture_Click(object sender, EventArgs e)
        {
            dal.EditStatusOrder(id, "Можете забирать!");
            this.Close();
            Console.WriteLine("Furniture send!");
        }

        private void buttonBuyMaterial_Click(object sender, EventArgs e)
        {
            foreman.AbstractFactory.Resourses += 3;
            Console.WriteLine("Resourses +3");
        }
    }
}
