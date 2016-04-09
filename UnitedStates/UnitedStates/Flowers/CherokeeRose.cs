namespace UnitedStates.Flowers
{
    public class CherokeeRose : IFlower
    {
        private CherokeeRose()
        { }

        public static CherokeeRose Instance { get; } = new CherokeeRose();
        public string Name => "Cherokee Rose";
    }
}