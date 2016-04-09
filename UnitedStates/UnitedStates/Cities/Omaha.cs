namespace UnitedStates.Cities
{
    public class Omaha : ICity
    {
        private Omaha()
        { }

        public static Omaha Instance { get; } = new Omaha();
        public string Name => "Omaha";
    }
}