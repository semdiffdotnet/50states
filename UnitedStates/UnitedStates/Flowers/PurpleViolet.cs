namespace UnitedStates.Flowers
{
    public class PurpleViolet : IFlower
    {
        private PurpleViolet()
        { }

        public static PurpleViolet Instance { get; } = new PurpleViolet();
        public string Name => "Purple Violet";
    }
}