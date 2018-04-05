using AbstractFactoryPattern.Ingredients;
using System.Collections.Generic;
using AbstractFactoryPattern.ConcreteIngredients;

namespace AbstractFactoryPattern
{
    public class NYPizzaIngredientFactory : IPizzaIngredientsFactory
    {
        public Dough MakeDough()
        {
            return new ThinCrustDough();
        }

        public Sauce MakeSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese GrateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Vegetable> MixVegetables()
        {
            return new List<Vegetable>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public Pepperoni SlicePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam GetClam()
        {
            return new FreshClam();
        }
    }
}
