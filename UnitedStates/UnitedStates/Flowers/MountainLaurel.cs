namespace UnitedStates.Flowers
{
    public class MountainLaurel : IFlower
    {
        private MountainLaurel()
        { }

        public static MountainLaurel Instance { get; } = new MountainLaurel();
        public string Name => "Mountain Laurel";
    }
}