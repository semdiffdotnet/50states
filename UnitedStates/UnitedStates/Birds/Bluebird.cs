namespace UnitedStates.Birds
{
    public class Bluebird : IBird
    {
        private Bluebird()
        { }

        public static Bluebird Instance { get; } = new Bluebird();
        public string Name => "Bluebird";
        public string BinomialNomenclature => "Sialia sialis";
    }
}