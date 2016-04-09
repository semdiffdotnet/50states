namespace UnitedStates.Cities
{
    public class Billings : ICity
    {
        private Billings()
        { }

        public static Billings Instance { get; } = new Billings();
        public string Name => "Billings";
    }
}