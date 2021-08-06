
namespace Builder
{
    class BurgerSeller
    {
        private IBurgerBuilder _builder;
        public IBurgerBuilder Builder { set => _builder = value; }

        public void BuildCheeseBurger()
        {
            _builder.SetSize(18.5f);
            _builder.AddCheese(5);
            _builder.AddTomato(3);
        }

        public void BuildTomatoBurger()
        {
            _builder.SetSize(17.7f);
            _builder.AddTomato(6);
            _builder.AddPepperoni(3);
        }

        public void BuildFullBurger()
        {
            _builder.SetSize(20.2f);
            _builder.AddCheese(3);
            _builder.AddLettuce(3);
            _builder.AddPepperoni(3);
            _builder.AddTomato(3);
        }
    }
}

