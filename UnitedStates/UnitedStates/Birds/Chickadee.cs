namespace UnitedStates.Birds
{
    public class Chickadee : IBird
    {
        private Chickadee()
        { }

        public static Chickadee Instance { get; } = new Chickadee();
        public string Name => "Chickadee";
    }
}