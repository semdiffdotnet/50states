using System;
using System.Collections;
using System.Collections.Generic;
using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;
using UnitedStates.States;
using NewYorkState = UnitedStates.States.NewYork;

namespace UnitedStates
{
    public class UnitedStates : IState, IEnumerable<IState> //Has same properties!
    {
        private UnitedStates()
        { }

        public static UnitedStates Instance { get; } = new UnitedStates();
        public string Name => "United States of America";
        public ICity Capital => WashingtonDc.Instance;
        public ICity LargestCity => Cities.NewYork.Instance;
        public IBird Bird => BaldEagle.Instance;
        public IFlower Flower => Rose.Instance;

        public IEnumerable<IState> States { get; } = new IState[]
        {
            Alabama.Instance, Alaska.Instance, Arizona.Instance,
            Arkansas.Instance, California.Instance, Colorado.Instance,
            Connecticut.Instance, Delaware.Instance, Florida.Instance,
            Georgia.Instance, Hawaii.Instance, Idaho.Instance,
            Illinois.Instance, Indiana.Instance, Iowa.Instance,
            Kansas.Instance, Kentucky.Instance, Louisiana.Instance,
            Maine.Instance, Maryland.Instance, Massachusetts.Instance,
            Michigan.Instance, Minnesota.Instance, Mississippi.Instance,
            Missouri.Instance, Montana.Instance, Nebraska.Instance,
            Nevada.Instance, NewHampshire.Instance, NewJersey.Instance,
            NewMexico.Instance, NewYorkState.Instance,
            NorthCarolina.Instance, NorthDakota.Instance, Ohio.Instance,
            Oklahoma.Instance, Oregon.Instance, Pennsylvania.Instance,
            RhodeIsland.Instance, SouthCarolina.Instance,
            SouthDakota.Instance, Tennessee.Instance, Texas.Instance,
            Utah.Instance, Vermont.Instance, Virginia.Instance,
            Washington.Instance, WestVirginia.Instance, Wisconsin.Instance,
            Wyoming.Instance
        };

        public IEnumerator<IState> GetEnumerator()
        {
            return States.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return States.GetEnumerator();
        }
    }
}