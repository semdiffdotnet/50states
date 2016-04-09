namespace UnitedStates.Flowers
{
    public class WhitePineConeandTassel : IFlower
    {
        private WhitePineConeandTassel()
        { }

        public static WhitePineConeandTassel Instance { get; } = new WhitePineConeandTassel();
        public string Name => "White Pine Cone and Tassel";
    }
}