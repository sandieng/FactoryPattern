using System;

namespace AbstractFactoryPattern.ConcretePizzas
{
    public class VegetablePizza : Pizza
    {
        private readonly PizzaIngredientsFactory _ingredientsFactory;

        public VegetablePizza(PizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
            Name = "Vegetable Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientsFactory.MakeDough();
            Sauce = _ingredientsFactory.MakeSauce();
            Cheese = _ingredientsFactory.GrateCheese();
            Vegetables = _ingredientsFactory.MixVegetables();
        }
    }
}
