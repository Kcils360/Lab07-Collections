using System;

namespace lab07Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Dukes' Handpie Shop!");
            //Console.Read();

            Inventory<Product> inventory = new Inventory<Product>(); //creates my Inventory list called inventory

            Product BroccoliCheese = new Product();
            BroccoliCheese.HandPieFlavor = Flavor.Broccoli_Cheese_Rice;

            Product MacAndCheese = new Product();
            BroccoliCheese.HandPieFlavor = Flavor.Mac_N_Cheese;

            Product CheeseBurger = new Product();
            BroccoliCheese.HandPieFlavor = Flavor.Cheeseburger;



            inventory.Add(BroccoliCheese);
            inventory.Add(MacAndCheese);
            inventory.Add(CheeseBurger);
            inventory.Add(new Product { HandPieFlavor = Flavor.Peperoni_Sausage_Pizza });
            inventory.Add(new Product { HandPieFlavor = Flavor.Chicken_GreenChili });
            inventory.Add(new Product { HandPieFlavor = Flavor.Pot_Pie_Chicken });
            inventory.Add(new Product { HandPieFlavor = Flavor.Pot_Pie_Veggie });
            inventory.Add(new Product { HandPieFlavor = Flavor.Garden_Veggi });
            inventory.Add(new Product { HandPieFlavor = Flavor.BBQ_Pork });
            inventory.Add(new Product { HandPieFlavor = Flavor.Cordon_Blue });
            inventory.Add(new Product { HandPieFlavor = Flavor.Beef_Stew });


            foreach (Product pie in inventory)
            {
                Console.WriteLine(pie.HandPieFlavor);
                
                Console.WriteLine("$"+pie.Price);
                Console.WriteLine(pie.Frozen);
                Console.WriteLine("");
            }
            inventory.Remove(CheeseBurger);
            inventory.Remove(MacAndCheese);
            inventory.Remove(BroccoliCheese);

            foreach (Product pie in inventory)
            {
                Console.WriteLine(pie.HandPieFlavor);
            }



                Console.Read();
        }
    }
}
