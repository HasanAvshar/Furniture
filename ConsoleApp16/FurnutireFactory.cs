namespace ConsoleApp16
{
    public class FurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateChair()
        {
            return new Chair();
        }

        public IFurniture CreateSofa()
        {
            return new Sofa();
        }

        public IFurniture CreateCoffeeTable()
        {
            return new CoffeeTable();
        }
    }

}
