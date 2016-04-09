namespace UnitedStates.Cities
{
    public class Tallahassee : ICity
    {
        private Tallahassee()
        { }

        public static Tallahassee Instance { get; } = new Tallahassee();
        public string Name => "Tallahassee";
    }
}