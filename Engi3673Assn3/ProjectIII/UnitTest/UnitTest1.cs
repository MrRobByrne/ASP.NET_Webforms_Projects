using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectIII;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ResultTest()
        {

            Class1.Main();
            long expected = 99862;
            
            Class1.Main();


            Assert.IsTrue(ProjectIII.Class1.count >= 0, "The Count is not greater than 0");
            Assert.AreEqual(expected, ProjectIII.Class1.count);
           

            Assert.IsTrue(ProjectIII.Class1.count2 > 0, "The Count2 is not greater than 0");
            Assert.AreEqual(expected, ProjectIII.Class1.count2);

            
            System.Diagnostics.Debug.WriteLine(ProjectIII.Class1.count);



        }
        [TestMethod]
        public void ResultTest2()
        {

            Assert.AreEqual(ProjectIII.Class1.count, ProjectIII.Class1.count2);
            Assert.IsTrue(ProjectIII.Class1.count > 0);
            System.Diagnostics.Debug.WriteLine(ProjectIII.Class1.count2);
        }


        [TestMethod]
        public void ResultTest3()
        {
            //  Class1.Main();
            // Assert.IsTrue(ProjectIII.Class1.sw.Elapsed > ProjectIII.Class1.sw2.Elapsed);

        }


    }
}
