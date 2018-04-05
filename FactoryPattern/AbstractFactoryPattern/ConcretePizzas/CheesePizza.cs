using System;

namespace AbstractFactoryPattern.ConcretePizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientsFactory _ingredientsFactory;

        public CheesePizza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
            Name = "Cheese Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientsFactory.MakeDough();
            Sauce = _ingredientsFactory.MakeSauce();
            Cheese = _ingredientsFactory.GrateCheese();
        }
    }
}
