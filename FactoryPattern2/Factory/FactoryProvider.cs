namespace FactoryPattern2.Factory;

internal class FactoryProvider
{
    public static IFurnitureAbstractFactory GetFactory(FurnitureType furnitureType)
    {
        IFurnitureAbstractFactory furnitureAbstractFactory = null;
        switch (furnitureType)
        {
            case FurnitureType.ART:
                furnitureAbstractFactory = new ArtFurnitureFactory();
                break;

            case FurnitureType.VICTORIAN:
                furnitureAbstractFactory = new VictorianFurnitureFactory();
                break;
        }
        return furnitureAbstractFactory;
    }
}
