namespace UnitedStates.Flowers
{
    public class OregonGrape : IFlower
    {
        private OregonGrape()
        { }

        public static OregonGrape Instance { get; } = new OregonGrape();
        public string Name => "Oregon Grape";
    }
}