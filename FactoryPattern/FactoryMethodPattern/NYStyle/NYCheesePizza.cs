namespace FactoryMethodPattern
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY style Cheese Pizza";
            Dough = "Thin crusty dough";
            Sauce = "BBQ sauce";
        }
    }
}
