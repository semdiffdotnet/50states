namespace UnitedStates.Flowers
{
    public class Camellia : IFlower
    {
        private Camellia()
        { }

        public static Camellia Instance { get; } = new Camellia();
        public string Name => "Camellia";
    }
}