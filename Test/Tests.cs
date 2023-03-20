
namespace Test
{
    [TestClass]
    public class LeapTest
    {
        [TestMethod]
        public void TestLeap1()
        {
            Leap leap = new Leap();
            Assert.IsTrue(leap.leap.Invoke(2024));
        }
    }

    [TestClass]
    public class RandomListTest
    {
        [TestMethod]
        public void TestRandomList1()
        {
            RandomList<int> randomList = new RandomList<int>();
            Assert.IsTrue(randomList.IsEmpty());
        }
    }
}