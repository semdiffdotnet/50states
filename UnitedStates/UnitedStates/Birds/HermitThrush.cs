namespace UnitedStates.Birds
{
    public class HermitThrush : IBird
    {
        private HermitThrush()
        { }

        public static HermitThrush Instance { get; } = new HermitThrush();
        public string Name => "Hermit Thrush";
    }
}