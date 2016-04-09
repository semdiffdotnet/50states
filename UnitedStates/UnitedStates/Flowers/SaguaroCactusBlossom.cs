namespace UnitedStates.Flowers
{
    public class SaguaroCactusBlossom : IFlower
    {
        private SaguaroCactusBlossom()
        { }

        public static SaguaroCactusBlossom Instance { get; } = new SaguaroCactusBlossom();
        public string Name => "Saguaro Cactus Blossom";
        public string BinomialNomenclature => "Carnegiea gigantea";
    }
}