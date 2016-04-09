namespace UnitedStates.Cities
{
    public class Olympia : ICity
    {
        private Olympia()
        { }

        public static Olympia Instance { get; } = new Olympia();
        public string Name => "Olympia";
    }
}