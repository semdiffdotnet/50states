namespace UnitedStates.Flowers
{
    public class PeachBlossom : IFlower
    {
        private PeachBlossom()
        { }

        public static PeachBlossom Instance { get; } = new PeachBlossom();
        public string Name => "Peach Blossom";
    }
}