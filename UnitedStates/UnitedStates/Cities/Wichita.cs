namespace UnitedStates.Cities
{
    public class Wichita : ICity
    {
        private Wichita()
        { }

        public static Wichita Instance { get; } = new Wichita();
        public string Name => "Wichita";
    }
}