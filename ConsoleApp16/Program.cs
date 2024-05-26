using ConsoleApp16;

IFurnitureFactory factory = new FurnitureFactory();

IFurniture chair = factory.CreateChair();
chair.Deliver();

IFurniture sofa = factory.CreateSofa();
sofa.Deliver();

IFurniture coffeeTable = factory.CreateCoffeeTable();
coffeeTable.Deliver();