using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HaveFun.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PairsWithPositiveNegativeValues_Test()
        {
            int[] arr = { 1, -3, 2, 3, 6, -1 };
            int[] result  = PairsWithPositiveNegativeValues.Generate(arr);

            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(-3, result[2]);
            Assert.AreEqual(3, result[3]);

        }

        [TestMethod]
        public void RoofTop_Test()
        {
            int[] arr = { 1, 2, 2, 3, 2 };
            int result = Problems.RoofTop(arr);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RoofTop_Test2()
        {
            int[] arr = { 1, 2, 3, 4 };
            int result = Problems.RoofTop(arr);

            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void NumberofPpairsWithMaximumSum_Test()
        {
            int[] arr = { 1, 1, 1, 2, 2 ,2};
            int result = Problems.NumberofPpairsWithMaximumSum(arr);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumberofPpairsWithMaximumSum_Test2()
        {
            int[] arr = { 1, 4, 3, 3, 5, 1 };
            int result = Problems.NumberofPpairsWithMaximumSum(arr);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindFine_Test2()
        {
            int date = 12;
            int[] arrCarNumbers = { 2375, 7682, 2325, 2352 };
            int[] arrFines = { 250 ,500 ,350 ,200 };
            int result = Problems.FindFine(date, arrCarNumbers, arrFines);

            Assert.AreEqual(600, result);
        }
        [TestMethod]
        public void RemoveCommonCharactersAndConcatenate_Test()
        {
            string result = Problems.RemoveCommonCharactersAndConcatenate("aacdb", "gafd");

            Assert.AreEqual("cbgf", result);
        }

        [TestMethod]
        public void BooleanStringValue_Test()
        {
            int result = Problems.BooleanStringValue("1C1B1B0A0");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SumOfTwoLargeNumbers_Test()
        {
            string result = Problems.SumOfTwoLargeNumbers(1234,45678);

            Assert.AreEqual((1234 + 45678).ToString(), result);
        }

        [TestMethod]
        public void Substring_Test()
        {
            int result = Problems.Substring("asdf", "df");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Substring_Test2()
        {
            int result = Problems.Substring("asdf", "asd");

            Assert.AreEqual(0, result);
        }

    }
}
