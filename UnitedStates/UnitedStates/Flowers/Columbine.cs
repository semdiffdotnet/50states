namespace UnitedStates.Flowers
{
    public class Columbine : IFlower
    {
        private Columbine()
        { }

        public static Columbine Instance { get; } = new Columbine();
        public string Name => "Columbine";
        public string BinomialNomenclature => "Aquilegia caerulea";
    }
}