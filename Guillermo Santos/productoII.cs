using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yogurt yogurt = new Yogurt();
            yogurt.Mostrar();
            YLight yLight = new YLight(30, 12, "Wasa", 133, -3);
            yLight.Mostrar();
            Console.ReadLine();
        }
    }
    abstract class Product
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        private int _price;
        public int Price
        {
            get { return this._price; }
            set { this._price = Valor(value); }
        }
        private int _availableQuantity;
        public int AvailableQuantity
        {
            get { return this._availableQuantity; }
            set { this._availableQuantity = Valor(value); }
        }
        public Product(string name, int price, int availableQuantity)
        {
            Name = name;
            Price = price;
            AvailableQuantity = availableQuantity;
        }

        public Product()
        {
            Name = "Alimento";
            Price = 100;
            AvailableQuantity = 20;
        }

        public Product(Product p)
        {
            Name = p.Name;
            Price = p.Price;
            AvailableQuantity = p.AvailableQuantity;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("\n" + Name + "." + "\nPrecio: " + Price + "\nCantidad disponible: " + AvailableQuantity);
        }


        protected int Valor(int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            return num;
        }

        public abstract void ShowName();
    }
    class Yogurt : Product
    {
        private int _gr;
        public int Gr
        {
            get { return this._gr; }
            set { this._gr = Valor(value); }
        }
        public Yogurt(int gr, string name, int price, int availableQuantity) : base(name, price, availableQuantity)
        {
            Gr = gr;
        }

        public Yogurt() : base()
        {
            Gr = 100;
        }

        public Yogurt(Yogurt y) : base(y)
        {
            Gr = y.Gr;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Gramos: " + Gr + "\n");
        }

        public override void ShowName() 
        {
            Console.WriteLine("Wasasa");
        }
    }
    class YLight : Yogurt
    {
        private int _pGraso;
        public int PGraso
        {
            get { return this._pGraso; }
            set { this.PGraso = value; }
        }

        public YLight(int pGraso, int gr, string name, int price, int availableQuantity) : base(gr, name, price, availableQuantity)
        {
            PGraso = pGraso;
        }

        public YLight() : base()
        {
            PGraso = 30;
        }

        public YLight(YLight y) : base(y)
        {
            PGraso = y.PGraso;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Porcentaje Graso: %" + PGraso + "\n");
        }
    }
}
