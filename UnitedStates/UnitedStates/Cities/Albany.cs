namespace UnitedStates.Cities
{
    public class Albany : ICity
    {
        private Albany()
        { }

        public static Albany Instance { get; } = new Albany();
        public string Name => "Albany";
    }
}