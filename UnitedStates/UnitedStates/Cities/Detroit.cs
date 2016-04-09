namespace UnitedStates.Cities
{
    public class Detroit : ICity
    {
        private Detroit()
        { }

        public static Detroit Instance { get; } = new Detroit();
        public string Name => "Detroit";
    }
}