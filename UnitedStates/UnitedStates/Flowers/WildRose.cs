namespace UnitedStates.Flowers
{
    public class WildRose : IFlower
    {
        private WildRose()
        { }

        public static WildRose Instance { get; } = new WildRose();
        public string Name => "Wild Rose";
    }
}