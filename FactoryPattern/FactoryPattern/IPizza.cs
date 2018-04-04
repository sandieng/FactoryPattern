namespace SimpleFactoryPattern
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
        string Information();
    }
}