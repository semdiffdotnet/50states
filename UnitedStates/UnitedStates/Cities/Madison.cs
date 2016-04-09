namespace UnitedStates.Cities
{
    public class Madison : ICity
    {
        private Madison()
        { }

        public static Madison Instance { get; } = new Madison();
        public string Name => "Madison";
    }
}