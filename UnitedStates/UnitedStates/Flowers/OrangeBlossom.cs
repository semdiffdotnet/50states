namespace UnitedStates.Flowers
{
    public class OrangeBlossom : IFlower
    {
        private OrangeBlossom()
        { }

        public static OrangeBlossom Instance { get; } = new OrangeBlossom();
        public string Name => "Orange Blossom";
    }
}