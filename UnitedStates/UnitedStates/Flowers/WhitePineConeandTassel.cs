namespace UnitedStates.Flowers
{
    public class WhitePineConeAndTassel : IFlower
    {
        private WhitePineConeAndTassel()
        { }

        public static WhitePineConeAndTassel Instance { get; } = new WhitePineConeAndTassel();
        public string Name => "White Pine Cone and Tassel";
        public string BinomialNomenclature => "Pinus strobus";
    }
}