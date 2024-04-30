using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Yogurt();
            Yogurt yogurt = new Yogurt();
            product.Mostrar();
            yogurt.Mostrar();
            Console.ReadLine();
            //Console.WriteLine("Ingrese la cantidad actualizada");
            //int CantAct = int.Parse(Console.ReadLine());
            //product.Actualizar(CantAct);
        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AvailableQuantity { get; set; }
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

        public Product (Product p) 
        {
        Name = p.Name;
        Price = p.Price;
        AvailableQuantity = p.AvailableQuantity;
        }

        public virtual void Mostrar()
        {
          Console.WriteLine(Name + "." + "\nPrecio: " + Price + "\nCantidad disponible: " + AvailableQuantity + "\n");
        }
        //public void Actualizar(int CantAct)
        //{
        //    AvailableQuantity = CantAct;
        //}
    }
    class Yogurt : Product
    {
        public int Gr { get; set; }
        public Yogurt (int gr, string name, int price, int availableQuantity) : base (name, price, availableQuantity)
        {
            Gr = gr;
        }

        public Yogurt () : base ()
        {
            Gr = 100;
        }

        public Yogurt(Yogurt y) : base (y) 
        {
        Gr = y.Gr;
        }

        public override void Mostrar()
        {
            Console.WriteLine(Name + "." + "\nPrecio: " + Price + "\nCantidad disponible: " + AvailableQuantity + "\nGramos: " + Gr + "\n");
        }
    }
}
