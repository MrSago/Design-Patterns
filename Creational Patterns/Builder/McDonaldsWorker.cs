
namespace Builder
{
    class McDonaldsWorker : IBurgerBuilder
    {
        private Burger _product;
        public McDonaldsWorker(float size = 0.0f)
        {
            ResetProduct(size);
        }
        public void SetSize(float size)
        {
            _product.Size = size;
        }
        public void AddCheese(uint count = 1)
        {
            _product.Add(BurgerProps.Cheese, count);
        }
        public void AddPepperoni(uint count = 1)
        {
            _product.Add(BurgerProps.Pepperoni, count);
        }
        public void AddLettuce(uint count = 1)
        {
            _product.Add(BurgerProps.Lettuce, count);
        }
        public void AddTomato(uint count = 1)
        {
            _product.Add(BurgerProps.Tomato, count);
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
}

