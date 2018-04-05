using AbstractFactoryPattern.Ingredients;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    public interface PizzaIngredientsFactory
    {
        Dough MakeDough();
        Sauce MakeSauce();
        Cheese GrateCheese();
        List<Vegetable> MixVegetables();
        Pepperoni SlicePepperoni();
        Clam GetClam();
    }
}
