namespace UnitedStates.Flowers
{
    public class WoodViolet : IFlower
    {
        private WoodViolet()
        { }

        public static WoodViolet Instance { get; } = new WoodViolet();
        public string Name => "Wood Violet";
    }
}