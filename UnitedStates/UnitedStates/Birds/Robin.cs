namespace UnitedStates.Birds
{
    public class Robin : IBird
    {
        private Robin()
        { }

        public static Robin Instance { get; } = new Robin();
        public string Name => "Robin";
        public string BinomialNomenclature => "Turdus migratorius";
    }
}