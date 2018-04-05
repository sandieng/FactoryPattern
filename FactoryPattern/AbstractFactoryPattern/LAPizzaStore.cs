using AbstractFactoryPattern.ConcretePizzas;

namespace AbstractFactoryPattern
{
    public class LAPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            IPizzaIngredientsFactory ingredientsFactory = new LAPizzaIngredientFactory();

            switch (type)
            {
                case "cheese": return new CheesePizza(ingredientsFactory);
                case "veggie": return new VegetablePizza(ingredientsFactory);
            }

            return null;
        }
    }
}
