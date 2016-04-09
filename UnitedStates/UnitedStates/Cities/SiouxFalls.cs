namespace UnitedStates.Cities
{
    public class SiouxFalls : ICity
    {
        private SiouxFalls()
        { }

        public static SiouxFalls Instance { get; } = new SiouxFalls();
        public string Name => "Sioux Falls";
    }
}