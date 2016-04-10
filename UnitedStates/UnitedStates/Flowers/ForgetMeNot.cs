namespace UnitedStates.Flowers
{
    public class ForgetMeNot : IFlower
    {
        private ForgetMeNot()
        { }

        public static ForgetMeNot Instance { get; } = new ForgetMeNot();
        public string Name => "Forget-me-not";
        public string BinomialNomenclature => "Myosotis alpestris";
    }
}