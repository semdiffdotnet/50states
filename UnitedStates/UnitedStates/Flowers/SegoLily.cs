namespace UnitedStates.Flowers
{
    public class SegoLily : IFlower
    {
        private SegoLily()
        { }

        public static SegoLily Instance { get; } = new SegoLily();
        public string Name => "Sego Lily";
    }
}