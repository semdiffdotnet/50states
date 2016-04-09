namespace UnitedStates.Cities
{
    public class Providence : ICity
    {
        private Providence()
        { }

        public static Providence Instance { get; } = new Providence();
        public string Name => "Providence";
    }
}