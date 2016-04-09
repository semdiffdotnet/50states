namespace UnitedStates.Cities
{
    public class Bridgeport : ICity
    {
        private Bridgeport()
        { }

        public static Bridgeport Instance { get; } = new Bridgeport();
        public string Name => "Bridgeport";
    }
}