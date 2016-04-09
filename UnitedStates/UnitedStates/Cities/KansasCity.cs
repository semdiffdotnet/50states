namespace UnitedStates.Cities
{
    public class KansasCity : ICity
    {
        private KansasCity()
        { }

        public static KansasCity Instance { get; } = new KansasCity();
        public string Name => "Kansas City";
    }
}