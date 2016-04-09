namespace UnitedStates.Cities
{
    public class Wilmington : ICity
    {
        private Wilmington()
        { }

        public static Wilmington Instance { get; } = new Wilmington();
        public string Name => "Wilmington";
    }
}