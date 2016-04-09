namespace UnitedStates.Birds
{
    public class CaliforniaGull : IBird
    {
        private CaliforniaGull()
        { }

        public static CaliforniaGull Instance { get; } = new CaliforniaGull();
        public string Name => "California Gull";
        public string BinomialNomenclature => "Larus californicus";
    }
}