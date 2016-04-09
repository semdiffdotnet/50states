namespace UnitedStates.Cities
{
    public class Newark : ICity
    {
        private Newark()
        { }

        public static Newark Instance { get; } = new Newark();
        public string Name => "Newark";
    }
}