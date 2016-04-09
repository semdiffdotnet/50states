namespace UnitedStates.Flowers
{
    public class GoldenPoppy : IFlower
    {
        private GoldenPoppy()
        { }

        public static GoldenPoppy Instance { get; } = new GoldenPoppy();
        public string Name => "Golden Poppy";
    }
}