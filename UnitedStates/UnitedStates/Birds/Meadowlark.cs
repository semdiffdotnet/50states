namespace UnitedStates.Birds
{
    public class Meadowlark : IBird
    {
        private Meadowlark()
        { }

        public static Meadowlark Instance { get; } = new Meadowlark();
        public string Name => "Meadowlark";
        public string BinomialNomenclature => "Sturnella neglecta";
    }
}