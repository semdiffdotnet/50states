namespace UnitedStates.Cities
{
    public class Raleigh : ICity
    {
        private Raleigh()
        { }

        public static Raleigh Instance { get; } = new Raleigh();
        public string Name => "Raleigh";
    }
}