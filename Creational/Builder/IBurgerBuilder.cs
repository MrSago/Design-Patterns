namespace Builder;

interface IBurgerBuilder
{
    IBurgerBuilder SetSize(float size);
    IBurgerBuilder AddCheese(uint count = 1);
    IBurgerBuilder AddLettuce(uint count = 1);
    IBurgerBuilder AddTomato(uint count = 1);
    IBurgerBuilder AddPepperoni(uint count = 1);
    Burger GetBurger();
}
