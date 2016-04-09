namespace UnitedStates.Flowers
{
    public class PurpleLilac : IFlower
    {
        private PurpleLilac()
        { }

        public static PurpleLilac Instance { get; } = new PurpleLilac();
        public string Name => "Purple Lilac";
        public string BinomialNomenclature => "Syringa vulgaris";
    }
}