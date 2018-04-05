using AbstractFactoryPattern.Ingredients;
using System.Collections.Generic;
using AbstractFactoryPattern.ConcreteIngredients;

namespace AbstractFactoryPattern
{
    public class LAPizzaIngredientFactory : PizzaIngredientsFactory
    {
        public Dough MakeDough()
        {
            return new ThickDough();
        }

        public Sauce MakeSauce()
        {
            return new GarlicSauce();
        }

        public Cheese GrateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<Vegetable> MixVegetables()
        {
            return new List<Vegetable>()
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper(),
                new Tomato()
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
