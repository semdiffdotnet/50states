namespace UnitedStates.Flowers
{
    public class AmericanPasqueflower : IFlower
    {
        private AmericanPasqueflower()
        { }

        public static AmericanPasqueflower Instance { get; } = new AmericanPasqueflower();
        public string Name => "American Pasqueflower";
        public string BinomialNomenclature => "Pulsatilla hirsutissima";
    }
}