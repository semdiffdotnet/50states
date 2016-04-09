namespace UnitedStates.Cities
{
    public class WashingtonDc : ICity
    {
        private WashingtonDc()
        { }

        public static WashingtonDc Instance { get; } = new WashingtonDc();
        public string Name => "Washington, D.C.";
    }
}