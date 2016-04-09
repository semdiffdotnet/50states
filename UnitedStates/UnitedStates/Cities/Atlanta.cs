namespace UnitedStates.Cities
{
    public class Atlanta : ICity
    {
        private Atlanta()
        { }

        public static Atlanta Instance { get; } = new Atlanta();
        public string Name => "Atlanta";
    }
}