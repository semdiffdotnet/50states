namespace UnitedStates.Cities
{
    public class Dover : ICity
    {
        private Dover()
        { }

        public static Dover Instance { get; } = new Dover();
        public string Name => "Dover";
    }
}