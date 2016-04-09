namespace UnitedStates.Birds
{
    public class BaltimoreOriole : IBird
    {
        private BaltimoreOriole()
        { }

        public static BaltimoreOriole Instance { get; } = new BaltimoreOriole();
        public string Name => "Baltimore Oriole";
        public string BinomialNomenclature => "Icterus galbula";
    }
}