namespace UnitedStates.Flowers
{
    public class WesternRhododendron : IFlower
    {
        private WesternRhododendron()
        { }

        public static WesternRhododendron Instance { get; } = new WesternRhododendron();
        public string Name => "Western Rhododendron";
    }
}