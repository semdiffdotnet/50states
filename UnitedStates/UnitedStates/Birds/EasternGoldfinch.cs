namespace UnitedStates.Birds
{
    public class EasternGoldfinch : IBird
    {
        private EasternGoldfinch()
        { }

        public static EasternGoldfinch Instance { get; } = new EasternGoldfinch();
        public string Name => "Eastern Goldfinch";
        public string BinomialNomenclature => "Spinus tristis";
    }
}