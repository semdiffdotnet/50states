namespace UnitedStates.Flowers
{
    public class YuccaFlower : IFlower
    {
        private YuccaFlower()
        { }

        public static YuccaFlower Instance { get; } = new YuccaFlower();
        public string Name => "Yucca Flower";
    }
}