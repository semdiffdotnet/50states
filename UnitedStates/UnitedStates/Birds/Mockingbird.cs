namespace UnitedStates.Birds
{
    public class Mockingbird : IBird
    {
        private Mockingbird()
        { }

        public static Mockingbird Instance { get; } = new Mockingbird();
        public string Name => "Mockingbird";
        public string BinomialNomenclature => "Mimus polyglottos";
    }
}