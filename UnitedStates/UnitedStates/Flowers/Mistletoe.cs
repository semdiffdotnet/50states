namespace UnitedStates.Flowers
{
    public class Mistletoe : IFlower
    {
        private Mistletoe()
        { }

        public static Mistletoe Instance { get; } = new Mistletoe();
        public string Name => "Mistletoe";
        public string BinomialNomenclature => "Phoradendron serotinum";
    }
}