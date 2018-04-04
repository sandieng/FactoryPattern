using System;
using System.Collections.Generic;

namespace SimpleFactoryPattern
{
    public class CheesePizza : Pizza, IPizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";

            Ingredients = new List<string>
            {
                "Onions",
                "Mozzarella",
                "Capsicum"
            };

            Calories = 2300;
        }
          
        
        public void Prepare()
        {
            //
            Console.WriteLine("Preparing Cheese Pizza");
        }

        public void Bake()
        {
            //
            Console.WriteLine("Baking Cheese Pizza");
        }

        public void Cut()
        {
            //
            Console.WriteLine("Cutting Cheese Pizza");
        }

        public void Box()
        {
            //
            Console.WriteLine("Placing cheese pizza in the box");
        }

        public override string Information()
        {
            var info = base.Information();
            return info;
        }
    }
}