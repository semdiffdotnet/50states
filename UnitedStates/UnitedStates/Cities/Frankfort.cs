namespace UnitedStates.Cities
{
    public class Frankfort : ICity
    {
        private Frankfort()
        { }

        public static Frankfort Instance { get; } = new Frankfort();
        public string Name => "Frankfort";
    }
}