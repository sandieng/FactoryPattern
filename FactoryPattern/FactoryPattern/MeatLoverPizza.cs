using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class MeatLoverPizza : Pizza, IPizza
    {
        public MeatLoverPizza()
        {
            Name = "Meatlover Pizza";

            Ingredients = new List<string>
            {
                "Onions",
                "Ham",
                "Capsicum"
            };

            Calories = 2000;
        }

        public void Prepare()
        {
            //
            Console.WriteLine("Preparing Meat Lover pizza");
        }

        public void Bake()
        {
            //
            Console.WriteLine("Baking Meat Lover Pizza to 220 degress for 18 minutes");
        }

        public void Cut()
        {
            //
            Console.WriteLine("Cutting Meat Lover Pizza");
        }

        public void Box()
        {
            //
            Console.WriteLine("Placing Meat Lover Pizza in the box");
        }

        public override string Information()
        {
            StringBuilder sb = new StringBuilder();
            var info = base.Information();
            sb.AppendLine(info);

            return sb.ToString();
        }
    }
}