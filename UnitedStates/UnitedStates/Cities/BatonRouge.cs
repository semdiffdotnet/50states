namespace UnitedStates.Cities
{
    public class BatonRouge : ICity
    {
        private BatonRouge()
        { }

        public static BatonRouge Instance { get; } = new BatonRouge();
        public string Name => "Baton Rouge";
    }
}