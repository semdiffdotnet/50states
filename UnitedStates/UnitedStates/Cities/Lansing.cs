namespace UnitedStates.Cities
{
    public class Lansing : ICity
    {
        private Lansing()
        { }

        public static Lansing Instance { get; } = new Lansing();
        public string Name => "Lansing";
    }
}