namespace UnitedStates.Flowers
{
    public class Peony : IFlower
    {
        private Peony()
        { }

        public static Peony Instance { get; } = new Peony();
        public string Name => "Peony";
    }
}