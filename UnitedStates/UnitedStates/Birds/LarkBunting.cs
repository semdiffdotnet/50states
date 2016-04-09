namespace UnitedStates.Birds
{
    public class LarkBunting : IBird
    {
        private LarkBunting()
        { }

        public static LarkBunting Instance { get; } = new LarkBunting();
        public string Name => "Lark Bunting";
    }
}