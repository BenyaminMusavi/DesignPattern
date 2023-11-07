using FactoryPattern2.Chair;
using FactoryPattern2.CoffeTable;
using FactoryPattern2.Sofa;

namespace FactoryPattern2.Factory;

internal class VictorianFurnitureFactory : IFurnitureAbstractFactory
{
    public IChair CreateChair()
    {
        IChair victorianChair = new VictorianChair();
        return victorianChair;
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        ICoffeeTable victorianCoffeeTable = new VictorianCoffeeTable();
        return victorianCoffeeTable;
    }

    public ISofa CreateSofa()
    {
        ISofa victorianSofa = new VictorianSofa();
        return victorianSofa;
    }
}
