namespace UnitedStates.Birds
{
    public class BaldEagle : IBird
    {
        private BaldEagle()
        { }

        public static BaldEagle Instance { get; } = new BaldEagle();
        public string Name => "Bald eagle";
        public string BinomialNomenclature => "Haliaeetus leucocephalus";
    }
}