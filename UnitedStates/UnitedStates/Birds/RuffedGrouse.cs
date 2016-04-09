namespace UnitedStates.Birds
{
    public class RuffedGrouse : IBird
    {
        private RuffedGrouse()
        { }

        public static RuffedGrouse Instance { get; } = new RuffedGrouse();
        public string Name => "Ruffed Grouse";
        public string BinomialNomenclature => "Bonasa umbellus";
    }
}