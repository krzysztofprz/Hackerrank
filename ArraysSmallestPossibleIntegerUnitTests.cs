using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSmallestPossibleInteger
{
    [TestFixture]
    public class UnitTests
    {      
        [Test]
        public void SolutionMethodTest()
        {
            //Arrange
            int expectedEmpty = 1;
            int expectedZeros = 1;
            int onlyMinuses = 1;
            int validInput = 2;
            int failedInput = 6;

            int[] empty = { };
            int[] zeros = { 0, 0, 0,0 };
            int[] minuses = { -1000000, -9, -8, -3 };
            int[] valid = {-2, 1, 3, 4, 6, 81, 1};


            //Act
            int resultEmpty = Program.Solution(empty);
            int resultZeros = Program.Solution(zeros);
            int resultMinuses = Program.Solution(minuses);
            int resultValid = Program.Solution(valid);

            //Assert
            Assert.AreEqual(expectedEmpty, resultEmpty);
            Assert.AreEqual(expectedZeros, resultZeros);
            Assert.AreEqual(onlyMinuses, resultMinuses);
            Assert.AreEqual(validInput, resultValid);
            Assert.AreNotEqual(failedInput, resultValid);
        }
    }
}
