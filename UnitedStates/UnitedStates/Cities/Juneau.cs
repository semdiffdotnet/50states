namespace UnitedStates.Cities
{
    public class Juneau : ICity
    {
        private Juneau()
        { }

        public static Juneau Instance { get; } = new Juneau();
        public string Name => "Juneau";
    }
}