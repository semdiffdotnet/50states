using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var source = @"State,Capital,Largest City,Bird,Flower,,,,
Alabama,Montgomery,Birmingham,Yellowhammer,Camellia,,,,
Alaska,Juneau,Anchorage,Willow Ptarmigan,Forget-me-not,,,,
Arizona,Phoenix,Phoenix,Cactus Wren,Saguaro Cactus Blossom,,,,
Arkansas,Little Rock,Little Rock,Mockingbird,Apple Blossom,,,,
California,Sacramento,Los Angeles,California Valley Quail,Golden Poppy,,,,
Colorado,Denver,Denver,Lark Bunting,Columbine,,,,
Connecticut,Hartford,Bridgeport,American Robin,Mountain Laurel,,,,
Delaware,Dover,Wilmington,Blue Hen Chicken,Peach Blossom,,,,
Florida,Tallahassee,Jacksonville,Mockingbird,Orange Blossom,,,,
Georgia,Atlanta,Atlanta,Brown Thrasher,Cherokee Rose,,,,
Hawaii,Honolulu,Honolulu,Nene (Hawaiian Goose),Hibiscus,,,,
Idaho,Boise,Boise,Mountain Bluebird,Syringa,,,,
Illinois,Springfield,Chicago,Cardinal,Native violet,,,,
Indiana,Indianapolis,Indianapolis,Cardinal,Peony,,,,
Iowa,Des Moines,Des Moines,Eastern Goldfinch,Wild Rose,,,,
Kansas,Topeka,Wichita,Western Meadowlark,Native Sunflower,,,,
Kentucky,Frankfort,Louisville,Kentucky Cardinal,Goldenrod,,,,
Louisiana,Baton Rouge,New Orleans,Pelican,Magnolia,,,,
Maine,Augusta,Portland,Chickadee,White Pine Cone and Tassel,,,,
Maryland,Annapolis,Baltimore,Baltimore Oriole,Black-Eyed Susan,,,,
Massachusetts,Boston,Boston,Chickadee,Mayflower,,,,
Michigan,Lansing,Detroit,Robin,Apple Blossom,,,,
Minnesota,St. Paul,Minneapolis,Common Loon,Pink and White Lady's Slipper,,,,
Mississippi,Jackson,Jackson,Mockingbird,Magnolia,,,,
Missouri,Jefferson City,Kansas City,Bluebird,Hawthorn,,,,
Montana,Helena,Billings,Western Meadowlark,Bitterroot,,,,
Nebraska,Lincoln,Omaha,Western Meadowlark,Goldenrod,,,,
Nevada,Carson City,Las Vegas,Mountain Bluebird,Sagebrush,,,,
New Hampshire,Concord,Manchester,Purple Finch,Purple Lilac,,,,
New Jersey,Trenton,Newark,Eastern Goldfinch,Purple Violet,,,,
New Mexico,Santa Fe,Albuquerque,Roadrunner,Yucca Flower,,,,
New York,Albany,New York,Bluebird,Rose,,,,
North Carolina,Raleigh,Charlotte,Cardinal,Dogwood,,,,
North Dakota,Bismarck,Fargo,Western Meadowlark,Wild Prairie Rose,,,,
Ohio,Columbus,Columbus,Cardinal,Scarlet Carnation,,,,
Oklahoma,Oklahoma City,Oklahoma City,Scissor-Tailed Flycatcher,Mistletoe,,,,
Oregon,Salem,Portland,Western Meadowlark,Oregon Grape,,,,
Pennsylvania,Harrisburg,Philadelphia,Ruffed Grouse,Mountain Laurel,,,,
Rhode Island,Providence,Providence,Rhode Island Red,Violet,,,,
South Carolina,Columbia,Columbia,Carolina Wren,Yellow Jessamine,,,,
South Dakota,Pierre,Sioux Falls,Ring-Necked Pheasant,American Pasqueflower,,,,
Tennessee,Nashville,Memphis,Mockingbird,Iris,,,,
Texas,Austin,Houston,Mockingbird,Bluebonnet,,,,
Utah,Salt Lake City,Salt Lake City,California Gull,Sego Lily,,,,
Vermont,Montpelier,Burlington,Hermit Thrush,Red Clover,,,,
Virginia,Richmond,Virginia Beach,Cardinal,Dogwood,,,,
Washington,Olympia,Seattle,Willow Goldfinch,Western Rhododendron,,,,
West Virginia,Charleston,Charleston,Cardinal,Big Rhododendron,,,,
Wisconsin,Madison,Milwaukee,Robin,Wood Violet,,,,
Wyoming,Cheyenne,Cheyenne,Meadowlark,Indian Paintbrush,,,,";
            var data = source.Split('\r').Select(line => line.Split(',')).ToArray();
            Directory.CreateDirectory("States");
            Directory.CreateDirectory("Cities");
            Directory.CreateDirectory("Birds");
            Directory.CreateDirectory("Flowers");
            foreach (var state in data)
            {
                var st = state[0].Trim();
                var capital = state[1].Trim();
                var largestCity = state[2].Trim();
                var bird = state[3].Trim();
                var flower = state[4].Trim();

                var clsState = st.Replace(" ", "");
                var clsCapital = capital.Replace(" ", "");
                var clsLargestCity = largestCity.Replace(" ", "");
                var clsBird = bird.Replace(" ", "");
                var clsFlower = flower.Replace(" ", "");

                var stateText = $@"using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{{
    public class {clsState} : IState
    {{
        private {clsState}()
        {{ }}

        public static {clsState} Instance {{ get; }} = new {clsState}();
        public string Name => ""{st}"";
        public ICity Capital => {clsCapital}.Instance;
        public ICity LargestCity => {clsLargestCity}.Instance;
        public IBird Bird => {clsBird}.Instance;
        public IFlower Flower => {clsFlower}.Instance;
    }}
}}";
                var capitalText = $@"namespace UnitedStates.Cities
{{
    public class {clsCapital} : ICity
    {{
        private {clsCapital}()
        {{ }}

        public static {clsCapital} Instance {{ get; }} = new {clsCapital}();
        public string Name => ""{capital}"";
    }}
}}";
                var largestText = $@"namespace UnitedStates.Cities
{{
    public class {clsLargestCity} : ICity
    {{
        private {clsLargestCity}()
        {{ }}

        public static {clsLargestCity} Instance {{ get; }} = new {clsLargestCity}();
        public string Name => ""{largestCity}"";
    }}
}}";
                var birdText = $@"namespace UnitedStates.Birds
{{
    public class {clsBird} : IBird
    {{
        private {clsBird}()
        {{ }}

        public static {clsBird} Instance {{ get; }} = new {clsBird}();
        public string Name => ""{bird}"";
    }}
}}";
                var flowerText = $@"namespace UnitedStates.Flowers
{{
    public class {clsFlower} : IFlower
    {{
        private {clsFlower}()
        {{ }}

        public static {clsFlower} Instance {{ get; }} = new {clsFlower}();
        public string Name => ""{flower}"";
    }}
}}";
                File.WriteAllText(Path.Combine("States", clsState + ".cs"), stateText);
                File.WriteAllText(Path.Combine("Cities", clsCapital + ".cs"), capitalText);
                File.WriteAllText(Path.Combine("Cities", clsLargestCity + ".cs"), largestText);
                File.WriteAllText(Path.Combine("Birds", clsBird + ".cs"), birdText);
                File.WriteAllText(Path.Combine("Flowers", clsFlower + ".cs"), flowerText);
            }
        }
    }
}