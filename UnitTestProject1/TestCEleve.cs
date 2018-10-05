using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Eleve
{
    [TestClass]
    public class TestCEleve
    {
        [TestMethod]
        public void Student_Create_Success()
        {
            //given
            Student testStudentActual;
            string testNameExpected = "Roberto";
            Boolean testIsCaptExpected = true;
            List<int> testListOfChoiceExpected = new List<int> { 1, 2, 3, 4 };
            //then
            testStudentActual = new Student(testNameExpected,testIsCaptExpected,testListOfChoiceExpected);
            //when
            Assert.AreEqual(testNameExpected, testStudentActual.Name);
            Assert.AreEqual(testIsCaptExpected, testStudentActual.IsCapt);
            Assert.AreEqual(testListOfChoiceExpected.Count, testStudentActual.ListOfChoices.Count);
        }
    }
}
