using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode_CS.Medium
{
    [TestClass()]
    public class Medium
    {
        [TestMethod()]
        public void Rob_Test()
        {

            // Arrange
            List<(int[], int)> cases = new List<(int[], int)>();
            cases.Add((new int[] { 2, 3, 2 }, 3));
            cases.Add((new int[] { 1, 2, 3, 1 }, 4));

            LC0213_HouseRobber2 student = new LC0213_HouseRobber2();

            int[] caseInput;
            int caseAnswer;
            int receivedAnswer;
            foreach ((int[], int) c in cases)
            {
                // Act
                (caseInput, caseAnswer) = c;
                receivedAnswer = student.Rob(caseInput);

                // Assert
                Assert.AreEqual(caseAnswer, receivedAnswer);

            }


        }
    }
}