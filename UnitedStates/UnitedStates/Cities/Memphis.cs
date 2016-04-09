namespace UnitedStates.Cities
{
    public class Memphis : ICity
    {
        private Memphis()
        { }

        public static Memphis Instance { get; } = new Memphis();
        public string Name => "Memphis";
    }
}