using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedStates
{
    public interface IState
    {
        string Name { get; }
        ICity Capital { get; }
        ICity LargestCity { get; }
        IBird Bird { get; }
        IFlower Flower { get; }
    }
}