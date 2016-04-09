namespace UnitedStates.Birds
{
    public class WesternMeadowlark : IBird
    {
        private WesternMeadowlark()
        { }

        public static WesternMeadowlark Instance { get; } = new WesternMeadowlark();
        public string Name => "Western Meadowlark";
        public string BinomialNomenclature => "Sturnella neglecta";
    }
}