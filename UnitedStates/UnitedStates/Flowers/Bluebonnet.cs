namespace UnitedStates.Flowers
{
    public class Bluebonnet : IFlower
    {
        private Bluebonnet()
        { }

        public static Bluebonnet Instance { get; } = new Bluebonnet();
        public string Name => "Bluebonnet";
    }
}