using AbstractFactoryPattern.ConcretePizzas;

namespace AbstractFactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            PizzaIngredientsFactory ingredientsFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese": return new CheesePizza(ingredientsFactory);
                case "veggie": return new VegetablePizza(ingredientsFactory);
            }

            return null;
        }
    }
}
