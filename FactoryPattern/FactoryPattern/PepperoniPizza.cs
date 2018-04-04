using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class PepperoniPizza : Pizza, IPizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";

            Ingredients = new List<string>
            {
                "Onions",
                "Pepperoni",
                "Capsicum"
            };

            Calories = 1800;
        }

        public void Prepare()
        {
            //
        }

        public void Bake()
        {
            //
        }

        public void Cut()
        {
            //
        }

        public void Box()
        {
            //
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