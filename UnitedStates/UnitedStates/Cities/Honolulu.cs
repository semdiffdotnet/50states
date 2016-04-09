namespace UnitedStates.Cities
{
    public class Honolulu : ICity
    {
        private Honolulu()
        { }

        public static Honolulu Instance { get; } = new Honolulu();
        public string Name => "Honolulu";
    }
}