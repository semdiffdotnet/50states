namespace UnitedStates.Cities
{
    public class Denver : ICity
    {
        private Denver()
        { }

        public static Denver Instance { get; } = new Denver();
        public string Name => "Denver";
    }
}