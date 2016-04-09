namespace UnitedStates.Cities
{
    public class Concord : ICity
    {
        private Concord()
        { }

        public static Concord Instance { get; } = new Concord();
        public string Name => "Concord";
    }
}