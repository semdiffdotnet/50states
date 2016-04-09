namespace UnitedStates.Cities
{
    public class Nashville : ICity
    {
        private Nashville()
        { }

        public static Nashville Instance { get; } = new Nashville();
        public string Name => "Nashville";
    }
}