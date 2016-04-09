namespace UnitedStates.Flowers
{
    public class PinkandWhiteLadysSlipper : IFlower
    {
        private PinkandWhiteLadysSlipper()
        { }

        public static PinkandWhiteLadysSlipper Instance { get; } = new PinkandWhiteLadysSlipper();
        public string Name => "Pink and White Lady's Slipper";
    }
}