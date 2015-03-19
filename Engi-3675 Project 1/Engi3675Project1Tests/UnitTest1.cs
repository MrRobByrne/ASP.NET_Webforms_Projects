using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using paintmodelASP;


namespace paintmodelASPUtest
{
/// <summary>
/// Purpose of the TestWebAppProj1 class is to define a dictionary, that will be used to compare against the database values
/// </summary>
    [TestClass]
    public class TestWebAppProj1
    {
        // int i is used for incrementing the float values within the foreach loop in public void DBTest()
        int i = 0;
        // Here is the dictionary that has the expected values,contains string and floats 
        Dictionary<string, float> ExpectedValues = new Dictionary<string, float>()
        {
            {"red", 3},
            {"Turquore", 17},
            {"Grey", 5},
            {"Indigo", 6}
        };
        /// <summary>
        /// DBTest is the method that does all the comparing from the database with the expected 
        /// </summary>
        [TestMethod]
        public void DBTest()
        {
            //in paintmodel.cs lists are used to store the values from the database
            //so here in the unit test two lists were created to be filled by thoes values that were received in painmodel.cs
            List<string> testNames = new List<string>();
            List<float> testQuantities = new List<float>();
            Paint_input.Values(out testNames, out testQuantities);
           
            //the bottom six lines are there just to see if testNames and testQuantites have actualy values and arent empty
            Assert.IsFalse(testNames.Count == 0);
            Assert.IsFalse(testQuantities.Count == 0);
            if (testNames.Count == 0); 
            Console.WriteLine("Database has no contents to test");
            if (testQuantities.Count == 0); 
            Console.WriteLine("Database has no contents to test");
            
            //this foreach is actually what compares the expected with the test values
            //it uses asserts, and the test will keep going as long as the assert conditions are met 
            foreach (string entry in testNames)
            {
                //the test key in this case is entry              
                Assert.IsTrue(ExpectedValues.ContainsKey(entry));
                Assert.AreEqual(ExpectedValues[entry], testQuantities[i]);
                i++;
            }

            
        }
    }
}
   