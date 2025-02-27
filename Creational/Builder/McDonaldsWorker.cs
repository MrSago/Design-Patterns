namespace Builder;

class McDonaldsWorker : IBurgerBuilder
{
    private Burger _product;

    public McDonaldsWorker(float size = 0.0f)
    {
        ResetProduct(size);
    }

    public IBurgerBuilder SetSize(float size)
    {
        _product.Size = size;
        return this;
    }

    public IBurgerBuilder AddCheese(uint count = 1)
    {
        _product.Add(BurgerProps.Cheese, count);
        return this;
    }

    public IBurgerBuilder AddPepperoni(uint count = 1)
    {
        _product.Add(BurgerProps.Pepperoni, count);
        return this;
    }

    public IBurgerBuilder AddLettuce(uint count = 1)
    {
        _product.Add(BurgerProps.Lettuce, count);
        return this;
    }

    public IBurgerBuilder AddTomato(uint count = 1)
    {
        _product.Add(BurgerProps.Tomato, count);
        return this;
    }

    public Burger GetBurger()
    {
        Burger burger = _product;
        ResetProduct();
        return burger;
    }

    private void ResetProduct(float size = 0.0f)
    {
        _product = new(size);
    }
}
