namespace UnitedStates.Cities
{
    public class OklahomaCity : ICity
    {
        private OklahomaCity()
        { }

        public static OklahomaCity Instance { get; } = new OklahomaCity();
        public string Name => "Oklahoma City";
    }
}