namespace UnitedStates.Birds
{
    public class Pelican : IBird
    {
        private Pelican()
        { }

        public static Pelican Instance { get; } = new Pelican();
        public string Name => "Pelican";
        public string BinomialNomenclature => "Pelecanus occidentalis";
    }
}