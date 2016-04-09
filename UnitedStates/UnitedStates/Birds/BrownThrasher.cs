namespace UnitedStates.Birds
{
    public class BrownThrasher : IBird
    {
        private BrownThrasher()
        { }

        public static BrownThrasher Instance { get; } = new BrownThrasher();
        public string Name => "Brown Thrasher";
    }
}