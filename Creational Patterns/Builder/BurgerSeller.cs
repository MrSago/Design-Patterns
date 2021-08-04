
namespace Builder
{
    class BurgerSeller
    {
        private IBurgerBuilder builder;
        public IBurgerBuilder Builder { set { builder = value; } }
        public void BuildCheeseBurger()
        {
            builder.SetSize(18.5f);
            builder.AddCheese(5);
            builder.AddTomato(3);
        }
        public void BuildTomatoBurger()
        {
            builder.SetSize(17.7f);
            builder.AddTomato(6);
            builder.AddPepperoni(3);
        }
        public void BuildFullBurger()
        {
            builder.SetSize(20.2f);
            builder.AddCheese(3);
            builder.AddLettuce(3);
            builder.AddPepperoni(3);
            builder.AddTomato(3);
        }
    }
}

