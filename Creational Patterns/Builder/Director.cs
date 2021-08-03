
namespace Builder
{
    class Director
    {
        private IBuilder builder;
        public IBuilder Builder
        {
            set { builder = value; }
        }
        public void BuildMinProduct()
        {
            builder.BuildPartA();
        }
        public void BuildMaxProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}

