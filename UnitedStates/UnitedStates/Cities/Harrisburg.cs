namespace UnitedStates.Cities
{
    public class Harrisburg : ICity
    {
        private Harrisburg()
        { }

        public static Harrisburg Instance { get; } = new Harrisburg();
        public string Name => "Harrisburg";
    }
}