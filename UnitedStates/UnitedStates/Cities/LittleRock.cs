namespace UnitedStates.Cities
{
    public class LittleRock : ICity
    {
        private LittleRock()
        { }

        public static LittleRock Instance { get; } = new LittleRock();
        public string Name => "Little Rock";
    }
}