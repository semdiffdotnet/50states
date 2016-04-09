namespace UnitedStates.Cities
{
    public class StPaul : ICity
    {
        private StPaul()
        { }

        public static StPaul Instance { get; } = new StPaul();
        public string Name => "St. Paul";
    }
}