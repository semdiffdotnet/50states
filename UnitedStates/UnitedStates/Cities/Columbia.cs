namespace UnitedStates.Cities
{
    public class Columbia : ICity
    {
        private Columbia()
        { }

        public static Columbia Instance { get; } = new Columbia();
        public string Name => "Columbia";
    }
}