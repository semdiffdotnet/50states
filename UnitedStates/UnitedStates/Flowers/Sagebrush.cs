namespace UnitedStates.Flowers
{
    public class Sagebrush : IFlower
    {
        private Sagebrush()
        { }

        public static Sagebrush Instance { get; } = new Sagebrush();
        public string Name => "Sagebrush";
    }
}