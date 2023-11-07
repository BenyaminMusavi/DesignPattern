using FactoryPattern2.Chair;
using FactoryPattern2.CoffeTable;
using FactoryPattern2.Sofa;

namespace FactoryPattern2.Factory;

internal class ArtFurnitureFactory : IFurnitureAbstractFactory
{
    public IChair CreateChair()
    {
        IChair artChair = new ArtChair();
        return artChair;
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        ICoffeeTable artcoffeeTable = new ArtCoffeeTable();
        return artcoffeeTable;
    }

    public ISofa CreateSofa()
    {
        ISofa artsofa = new ArtSofa();
        return artsofa;
    }
}
