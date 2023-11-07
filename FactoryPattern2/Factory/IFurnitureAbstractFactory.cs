using FactoryPattern2.Chair;
using FactoryPattern2.CoffeTable;
using FactoryPattern2.Sofa;

namespace FactoryPattern2.Factory;

internal interface IFurnitureAbstractFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
}


