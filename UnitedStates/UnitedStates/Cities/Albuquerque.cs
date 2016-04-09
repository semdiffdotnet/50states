namespace UnitedStates.Cities
{
    public class Albuquerque : ICity
    {
        private Albuquerque()
        { }

        public static Albuquerque Instance { get; } = new Albuquerque();
        public string Name => "Albuquerque";
    }
}