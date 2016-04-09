namespace UnitedStates.Cities
{
    public class Jackson : ICity
    {
        private Jackson()
        { }

        public static Jackson Instance { get; } = new Jackson();
        public string Name => "Jackson";
    }
}