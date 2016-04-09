namespace UnitedStates.Flowers
{
    public class Mayflower : IFlower
    {
        private Mayflower()
        { }

        public static Mayflower Instance { get; } = new Mayflower();
        public string Name => "Mayflower";
    }
}