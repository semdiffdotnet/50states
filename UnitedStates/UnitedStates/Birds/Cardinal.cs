namespace UnitedStates.Birds
{
    public class Cardinal : IBird
    {
        private Cardinal()
        { }

        public static Cardinal Instance { get; } = new Cardinal();
        public string Name => "Cardinal";
        public string BinomialNomenclature => "Cardinalis cardinalis";
    }
}