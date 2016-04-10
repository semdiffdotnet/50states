using System;

namespace UnitedStates.Birds
{
    public class Yellowhammer : IBird
    {
        private Yellowhammer()
        { }

        public static Yellowhammer Instance { get; } = new Yellowhammer();
        public string Name => "Yellowhammer";
        public string BinomialNomenclature => "Colaptes auratus";
    }
}