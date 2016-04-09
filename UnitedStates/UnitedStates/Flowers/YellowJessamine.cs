namespace UnitedStates.Flowers
{
    public class YellowJessamine : IFlower
    {
        private YellowJessamine()
        { }

        public static YellowJessamine Instance { get; } = new YellowJessamine();
        public string Name => "Yellow Jessamine";
        public string BinomialNomenclature => "Gelsemium sempervirens";
    }
}