namespace UnitedStates.Flowers
{
    public class IndianPaintbrush : IFlower
    {
        private IndianPaintbrush()
        { }

        public static IndianPaintbrush Instance { get; } = new IndianPaintbrush();
        public string Name => "Indian Paintbrush";
    }
}