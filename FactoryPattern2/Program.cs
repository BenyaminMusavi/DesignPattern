using FactoryPattern2.Chair;
using FactoryPattern2.Factory;
// Super Class                                                 
IFurnitureAbstractFactory furnitureAbstractFactory = FactoryProvider.GetFactory(FactoryPattern2.FurnitureType.ART);
IChair chair = furnitureAbstractFactory.CreateChair();
Console.WriteLine(chair);
