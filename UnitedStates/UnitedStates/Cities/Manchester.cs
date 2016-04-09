namespace UnitedStates.Cities
{
    public class Manchester : ICity
    {
        private Manchester()
        { }

        public static Manchester Instance { get; } = new Manchester();
        public string Name => "Manchester";
    }
}