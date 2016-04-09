namespace UnitedStates.Flowers
{
    public class ScarletCarnation : IFlower
    {
        private ScarletCarnation()
        { }

        public static ScarletCarnation Instance { get; } = new ScarletCarnation();
        public string Name => "Scarlet Carnation";
        public string BinomialNomenclature => "Dianthus caryophyllus";
    }
}