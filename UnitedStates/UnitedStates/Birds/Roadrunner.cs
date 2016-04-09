namespace UnitedStates.Birds
{
    public class Roadrunner : IBird
    {
        private Roadrunner()
        { }

        public static Roadrunner Instance { get; } = new Roadrunner();
        public string Name => "Roadrunner";
    }
}