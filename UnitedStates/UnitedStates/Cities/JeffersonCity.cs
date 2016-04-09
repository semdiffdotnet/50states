namespace UnitedStates.Cities
{
    public class JeffersonCity : ICity
    {
        private JeffersonCity()
        { }

        public static JeffersonCity Instance { get; } = new JeffersonCity();
        public string Name => "Jefferson City";
    }
}