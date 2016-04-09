namespace UnitedStates.Cities
{
    public class Boise : ICity
    {
        private Boise()
        { }

        public static Boise Instance { get; } = new Boise();
        public string Name => "Boise";
    }
}