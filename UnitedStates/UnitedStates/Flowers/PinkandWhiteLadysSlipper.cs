namespace UnitedStates.Flowers
{
    public class PinkAndWhiteLadysSlipper : IFlower
    {
        private PinkAndWhiteLadysSlipper()
        { }

        public static PinkAndWhiteLadysSlipper Instance { get; } = new PinkAndWhiteLadysSlipper();
        public string Name => "Pink and White Lady's Slipper";
        public string BinomialNomenclature => "Cypripedium reginae";
    }
}