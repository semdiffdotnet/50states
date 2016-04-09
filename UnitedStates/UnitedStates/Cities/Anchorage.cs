namespace UnitedStates.Cities
{
    public class Anchorage : ICity
    {
        private Anchorage()
        { }

        public static Anchorage Instance { get; } = new Anchorage();
        public string Name => "Anchorage";
    }
}