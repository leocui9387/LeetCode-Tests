using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using LeetCode_CS.Easy;



namespace LeetCode_Tests
{
    [TestClass]
    public class Easy
    {
        [TestMethod]
        public void LC0771_JewelsNStones()
        {
            // Arrange

            Dictionary<(String, String), int> cases = new Dictionary<(string, string),int>();
            cases.Add(("aA", "aAAbbbb"),3 );
            cases.Add(("z", "ZZ"),0);

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
                Assert.AreEqual(cases[k] ,output,0,$"Got:{output}|Expected:{cases[k]}");
            }

        }
    }
}
