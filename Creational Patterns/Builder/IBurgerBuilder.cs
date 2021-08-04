
namespace Builder
{
    interface IBurgerBuilder
    {
        void SetSize(float _size);
        void AddCheese(uint _count);
        void AddLettuce(uint _count);
        void AddTomato(uint _count);
        void AddPepperoni(uint _count);
    }
}

