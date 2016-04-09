namespace UnitedStates.Flowers
{
    public class Magnolia : IFlower
    {
        private Magnolia()
        { }

        public static Magnolia Instance { get; } = new Magnolia();
        public string Name => "Magnolia";
    }
}