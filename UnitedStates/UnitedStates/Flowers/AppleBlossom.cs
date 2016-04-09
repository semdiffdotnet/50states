namespace UnitedStates.Flowers
{
    public class AppleBlossom : IFlower
    {
        private AppleBlossom()
        { }

        public static AppleBlossom Instance { get; } = new AppleBlossom();
        public string Name => "Apple Blossom";
        public string BinomialNomenclature => "Malus";
    }
}