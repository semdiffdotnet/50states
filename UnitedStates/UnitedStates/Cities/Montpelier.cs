namespace UnitedStates.Cities
{
    public class Montpelier : ICity
    {
        private Montpelier()
        { }

        public static Montpelier Instance { get; } = new Montpelier();
        public string Name => "Montpelier";
    }
}