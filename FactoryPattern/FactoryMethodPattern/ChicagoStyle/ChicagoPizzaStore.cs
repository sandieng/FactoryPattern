namespace FactoryMethodPattern.ChicagoStyle
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese": return new ChicagoCheesePizza();
                case "veggie": return new ChicagoVeggiePizza();
                case "clam": return new ChicagoClamPizza();
            }

            return null;
        }
    }
}
