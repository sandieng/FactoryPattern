namespace FactoryMethodPattern
{
    public class NyPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese": return new NYCheesePizza();
                case "veggie": return new NYVeggiePizza();
                case "clam": return new NYClamPizza();
            }

            return null;
        }
    }
}
