namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
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
