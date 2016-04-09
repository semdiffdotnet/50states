namespace UnitedStates.Flowers
{
    public class Violet : IFlower
    {
        private Violet()
        { }

        public static Violet Instance { get; } = new Violet();
        public string Name => "Violet";
    }
}