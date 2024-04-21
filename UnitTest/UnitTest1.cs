using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentTypePassWithDistinction()
        {
       
            Students students = new Students("21612345","Todd"); 
            string expected =students.Student_Name+"("+students.Student_Number+")"+ ":Distinction";
            string actual = students.PassType(average); 

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void StudentTypePass()
        {
    
            Students students = new Students("2161433","Bill"); 
            double average = 49;
            string expected = students.Student_Name + "(" + students.Student_Number + ")" + ":Pass";
            string actual = students.PassType(average); 
            //Assert
            Assert.AreEqual(expected, actual);
        

    }

        [TestMethod]
        public void StudentTypeFail()
        {

        }

        [TestMethod]
        public void StudentTypeIncorrectAverageGreaterThan100()
        {


        }
       
        [TestMethod]
        public void ChangeName()
        {


        }

    }
}
