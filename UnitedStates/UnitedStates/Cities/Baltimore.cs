namespace UnitedStates.Cities
{
    public class Baltimore : ICity
    {
        private Baltimore()
        { }

        public static Baltimore Instance { get; } = new Baltimore();
        public string Name => "Baltimore";
    }
}