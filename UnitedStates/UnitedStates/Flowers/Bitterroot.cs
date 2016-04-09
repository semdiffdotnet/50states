namespace UnitedStates.Flowers
{
    public class Bitterroot : IFlower
    {
        private Bitterroot()
        { }

        public static Bitterroot Instance { get; } = new Bitterroot();
        public string Name => "Bitterroot";
    }
}