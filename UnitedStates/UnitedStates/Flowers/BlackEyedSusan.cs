namespace UnitedStates.Flowers
{
    public class BlackEyedSusan : IFlower
    {
        private BlackEyedSusan()
        { }

        public static BlackEyedSusan Instance { get; } = new BlackEyedSusan();
        public string Name => "Black-Eyed Susan";
        public string BinomialNomenclature => "Rudbeckia hirta";
    }
}