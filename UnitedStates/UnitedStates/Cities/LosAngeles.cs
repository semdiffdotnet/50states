namespace UnitedStates.Cities
{
    public class LosAngeles : ICity
    {
        private LosAngeles()
        { }

        public static LosAngeles Instance { get; } = new LosAngeles();
        public string Name => "Los Angeles";
    }
}