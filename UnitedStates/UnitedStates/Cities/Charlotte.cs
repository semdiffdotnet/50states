namespace UnitedStates.Cities
{
    public class Charlotte : ICity
    {
        private Charlotte()
        { }

        public static Charlotte Instance { get; } = new Charlotte();
        public string Name => "Charlotte";
    }
}