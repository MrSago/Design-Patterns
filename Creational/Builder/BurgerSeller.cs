namespace Builder;

class BurgerSeller
{
    private IBurgerBuilder _builder;
    public IBurgerBuilder Builder
    {
        set => _builder = value;
    }

    public void BuildCheeseBurger()
    {
        _builder.SetSize(18.5f).AddCheese(5).AddTomato(3);
    }

    public void BuildTomatoBurger()
    {
        _builder.SetSize(17.7f).AddTomato(6).AddPepperoni(3);
    }

    public void BuildFullBurger()
    {
        _builder.SetSize(20.2f).AddCheese(3).AddLettuce(3).AddPepperoni(3).AddTomato(3);
    }
}
