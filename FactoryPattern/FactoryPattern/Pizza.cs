using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    public class Pizza 
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public int Calories { get; set; }

        public virtual string Information()
        {
            StringBuilder sb = new StringBuilder();
            var ingredients = "";
            Ingredients.ForEach(x => { ingredients += x + ", "; });
            ingredients = ingredients.Remove(ingredients.LastIndexOf(",", StringComparison.Ordinal));
            sb.AppendLine($"Pizza type: {Name}");
            sb.AppendLine($"Ingredients: {ingredients}");
            sb.AppendLine($"Calories: {Calories}");

            return sb.ToString();
        }
    }
}
