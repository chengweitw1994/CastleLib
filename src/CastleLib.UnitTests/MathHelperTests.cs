namespace CastleLib.UnitTests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void AddTest_一加二_等於三()
        {
            // arrange
            var summand = 1;
            var addend = 2;
            var expected = 3;

            // act
            var actual = MathHelper.Add(summand, addend);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
