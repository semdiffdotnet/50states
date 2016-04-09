namespace UnitedStates.Birds
{
    public class CarolinaWren : IBird
    {
        private CarolinaWren()
        { }

        public static CarolinaWren Instance { get; } = new CarolinaWren();
        public string Name => "Carolina Wren";
    }
}