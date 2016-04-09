namespace UnitedStates.Birds
{
    public class KentuckyCardinal : IBird
    {
        private KentuckyCardinal()
        { }

        public static KentuckyCardinal Instance { get; } = new KentuckyCardinal();
        public string Name => "Kentucky Cardinal";
    }
}