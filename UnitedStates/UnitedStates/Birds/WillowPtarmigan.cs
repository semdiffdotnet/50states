namespace UnitedStates.Birds
{
    public class WillowPtarmigan : IBird
    {
        private WillowPtarmigan()
        { }

        public static WillowPtarmigan Instance { get; } = new WillowPtarmigan();
        public string Name => "Willow Ptarmigan";
    }
}