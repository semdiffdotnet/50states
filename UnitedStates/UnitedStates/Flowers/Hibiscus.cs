namespace UnitedStates.Flowers
{
    public class Hibiscus : IFlower
    {
        private Hibiscus()
        { }

        public static Hibiscus Instance { get; } = new Hibiscus();
        public string Name => "Hibiscus";
    }
}