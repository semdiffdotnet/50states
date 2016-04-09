namespace UnitedStates.Cities
{
    public class Annapolis : ICity
    {
        private Annapolis()
        { }

        public static Annapolis Instance { get; } = new Annapolis();
        public string Name => "Annapolis";
    }
}