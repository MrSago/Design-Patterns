
namespace Builder
{
    interface IBurgerBuilder
    {
        void SetSize(float size);
        void AddCheese(uint count);
        void AddLettuce(uint count);
        void AddTomato(uint count);
        void AddPepperoni(uint count);
    }
}

