namespace FactoryMethodPattern
{
    public class NYClamPizza : Pizza
    {
        public NYClamPizza()
        {
            Name = "NY style Clam Pizza";
            Dough = "Thin crusty dough";
            Sauce = "Hoisin sauce";
        }
    }
}