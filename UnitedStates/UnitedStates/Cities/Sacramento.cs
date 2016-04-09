namespace UnitedStates.Cities
{
    public class Sacramento : ICity
    {
        private Sacramento()
        { }

        public static Sacramento Instance { get; } = new Sacramento();
        public string Name => "Sacramento";
    }
}