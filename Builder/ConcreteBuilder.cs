
namespace Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Product product;
        public ConcreteBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            product = new();
        }
        public void BuildPartA()
        {
            product.Add("PartA");
        }

        public void BuildPartB()
        {
            product.Add("PartB");
        }

        public void BuildPartC()
        {
            product.Add("PartC");
        }
        public Product GetProduct()
        {
            Product result = product;
            Reset();
            return result;
        }
    }
}

