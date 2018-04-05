using AbstractFactoryPattern.Ingredients;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    public class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Vegetable> Vegetables { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clam Clam { get; set; }

        public virtual void Prepare()
        {
            // Regional pizza store overrides this method to prepare the kind of pizza unique to them
        }

        public void Bake()
        {
            // Standard baking process for all kinds of pizzas
        }

        public void Cut()
        {
            // Standard way of cutting pizzas
        }

        public void Box()
        {
            // Standard way of boxing a pizza
        }
    }
}
