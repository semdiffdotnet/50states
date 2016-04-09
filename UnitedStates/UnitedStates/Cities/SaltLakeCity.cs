namespace UnitedStates.Cities
{
    public class SaltLakeCity : ICity
    {
        private SaltLakeCity()
        { }

        public static SaltLakeCity Instance { get; } = new SaltLakeCity();
        public string Name => "Salt Lake City";
    }
}