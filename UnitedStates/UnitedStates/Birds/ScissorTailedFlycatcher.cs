namespace UnitedStates.Birds
{
    public class ScissorTailedFlycatcher : IBird
    {
        private ScissorTailedFlycatcher()
        { }

        public static ScissorTailedFlycatcher Instance { get; } = new ScissorTailedFlycatcher();
        public string Name => "Scissor-Tailed Flycatcher";
        public string BinomialNomenclature => "Tyrannus forficatus";
    }
}