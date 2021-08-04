
namespace Builder
{
    class McDonaldsWorker : IBurgerBuilder
    {
        private Burger product;

        public McDonaldsWorker(float _size = 0.0f)
        {
            ResetProduct(_size);
        }

        public void SetSize(float size)
        {
            product.Size = size;
        }

        public void AddCheese(uint _count = 1)
        {
            product.Add(BurgerProps.Cheese, _count);
        }

        public void AddPepperoni(uint _count = 1)
        {
            product.Add(BurgerProps.Pepperoni, _count);
        }

        public void AddLettuce(uint _count = 1)
        {
            product.Add(BurgerProps.Lettuce, _count);
        }

        public void AddTomato(uint _count = 1)
        {
            product.Add(BurgerProps.Tomato, _count);
        }

        public Burger GetBurger()
        {
            Burger burger = product;
            ResetProduct();
            return burger;
        }

        private void ResetProduct(float _size = 0.0f)
        {
            product = new(_size);
        }
    }
}

