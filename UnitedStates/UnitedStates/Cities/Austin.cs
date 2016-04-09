namespace UnitedStates.Cities
{
    public class Austin : ICity
    {
        private Austin()
        { }

        public static Austin Instance { get; } = new Austin();
        public string Name => "Austin";
    }
}