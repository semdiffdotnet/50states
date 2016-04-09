namespace UnitedStates.Flowers
{
    public class NativeSunflower : IFlower
    {
        private NativeSunflower()
        { }

        public static NativeSunflower Instance { get; } = new NativeSunflower();
        public string Name => "Native Sunflower";
    }
}