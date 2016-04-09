namespace UnitedStates.Birds
{
    public class RhodeIslandRed : IBird
    {
        private RhodeIslandRed()
        { }

        public static RhodeIslandRed Instance { get; } = new RhodeIslandRed();
        public string Name => "Rhode Island Red";
    }
}