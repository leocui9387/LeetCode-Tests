using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_CS.Easy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_CS.Easy
{
    [TestClass()]
    public class Easy_Test
    {
        [TestMethod()]
        public void LC0198_Rob_Test()
        {
            List<(int[], int)> cases = new List<(int[], int)>();
            cases.Add((new int[] { 1, 2, 3, 1 } , 4));
            cases.Add((new int[] { 2, 7, 9, 3, 1 },12));

            LC0198_HouseRobber student = new LC0198_HouseRobber();

            int[] dataInput;
            int expectedOutput, receivedOutput;

            foreach( (int[],int) c in cases)
            {
                (dataInput, expectedOutput) = c;

                receivedOutput = student.Rob(dataInput);
                Assert.AreEqual(expectedOutput, receivedOutput);
                

            }

        }

        [TestMethod()]
        public void Reverse_Test()
        {
            List<(int, int)> cases = new List<(int, int)>();

            cases.Add((123, 321));
            cases.Add((452, 254));
            cases.Add((-392, -293));
            cases.Add((1239, 9321));
            cases.Add((15336469, 96463351));

            LC07_ReverseInteger student = new LC07_ReverseInteger();

            int dataIn, expectedOut, receivedOut;
            
            foreach ((int, int) c in cases)
            {
                (dataIn, expectedOut) = c;
                receivedOut = student.Reverse(dataIn);
                Assert.AreEqual(expectedOut,receivedOut);
            }

        }

        [TestMethod()]
        public void numJewelsInStones_Test()
        {
            // Arrange

            Dictionary<(String, String), int> cases = new Dictionary<(string, string), int>();
            cases.Add(("aA", "aAAbbbb"), 3);
            cases.Add(("z", "ZZ"), 0);

            LC0771_JewelsNStones student = new LC0771_JewelsNStones();

            String J;
            String S;
            int output;

            foreach ((String, String) k in cases.Keys)
            {
                // Act
                (J, S) = k;
                output = student.numJewelsInStones(J, S);

                // Assert
                Assert.AreEqual(cases[k], output, 0, $"Got:{output}|Expected:{cases[k]}");
            }
        }
    }
}