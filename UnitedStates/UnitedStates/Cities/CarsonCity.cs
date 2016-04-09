namespace UnitedStates.Cities
{
    public class CarsonCity : ICity
    {
        private CarsonCity()
        { }

        public static CarsonCity Instance { get; } = new CarsonCity();
        public string Name => "Carson City";
    }
}