using System;
using System.Collections.Generic;
using System.Text;

namespace lab07Collections
{
    class Product
    {
        public Flavor HandPieFlavor { get; set; }

        public double Price { get => 9.00; set { } }

        public string Frozen
        {
            get
            {
                return "All pies shipped frozen";
            }
            set
            {

            }
        }

        public void Bake()
        {
            Console.WriteLine("From frozen, bake hand pie at 450 for 13 minuts.");
        }

    }    

    enum Flavor 
    {
        Peperoni_Sausage_Pizza,
        Chicken_GreenChili,
        Mac_N_Cheese,
        Cheeseburger,
        Cordon_Blue,
        Pot_Pie_Veggie,
        Pot_Pie_Chicken,
        Garden_Veggi,
        BBQ_Pork,
        Broccoli_Cheese_Rice,
        Beef_Stew
    }


}
