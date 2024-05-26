namespace ConsoleApp16
{
    public interface IFurniture
    {
        void Deliver();
    }
    public interface IFurnitureFactory
    {
        IFurniture CreateChair();
        IFurniture CreateSofa();
        IFurniture CreateCoffeeTable();
    }
}
