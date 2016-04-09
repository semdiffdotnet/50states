namespace UnitedStates.Birds
{
    public class WillowGoldfinch : IBird
    {
        private WillowGoldfinch()
        { }

        public static WillowGoldfinch Instance { get; } = new WillowGoldfinch();
        public string Name => "Willow Goldfinch";
        public string BinomialNomenclature => "Spinus tristis";
    }
}