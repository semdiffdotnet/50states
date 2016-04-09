namespace UnitedStates.Flowers
{
    public class WildPrairieRose : IFlower
    {
        private WildPrairieRose()
        { }

        public static WildPrairieRose Instance { get; } = new WildPrairieRose();
        public string Name => "Wild Prairie Rose";
    }
}