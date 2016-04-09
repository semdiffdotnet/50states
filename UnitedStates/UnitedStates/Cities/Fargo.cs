namespace UnitedStates.Cities
{
    public class Fargo : ICity
    {
        private Fargo()
        { }

        public static Fargo Instance { get; } = new Fargo();
        public string Name => "Fargo";
    }
}