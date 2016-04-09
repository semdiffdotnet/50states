namespace UnitedStates.Flowers
{
    public class Rose : IFlower
    {
        private Rose()
        { }

        public static Rose Instance { get; } = new Rose();
        public string Name => "Rose";
    }
}