namespace UnitedStates.Cities
{
    public class Cheyenne : ICity
    {
        private Cheyenne()
        { }

        public static Cheyenne Instance { get; } = new Cheyenne();
        public string Name => "Cheyenne";
    }
}