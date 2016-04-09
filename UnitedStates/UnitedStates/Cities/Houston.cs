namespace UnitedStates.Cities
{
    public class Houston : ICity
    {
        private Houston()
        { }

        public static Houston Instance { get; } = new Houston();
        public string Name => "Houston";
    }
}