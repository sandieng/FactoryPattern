namespace FactoryMethodPattern
{
    public class NYVeggiePizza : Pizza
    {
        public NYVeggiePizza()
        {
            Name = "NY style Veggie Pizza";
            Dough = "Thin crusty dough";
            Sauce = "Caesar sauce";
        }
    }
}