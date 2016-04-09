namespace UnitedStates.Flowers
{
    public class Nativeviolet : IFlower
    {
        private Nativeviolet()
        { }

        public static Nativeviolet Instance { get; } = new Nativeviolet();
        public string Name => "Native violet";
    }
}