using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Students
    {
       
        private string StudentNumber;
        private string StudentName;
       

        private Students()
        {

        }
        public Students(string studentnumber,string studentname)
        {
            StudentNumber = studentnumber;
            StudentName = studentname;
          
        }
        public string Student_Number
        {
            get {return StudentNumber; }
        }
        public string Student_Name
        {
            get { return StudentName; }
        }
       

        public string PassType(double average)
        {
            string Start = StudentName + "(" + StudentNumber + ")";
            if (average>=75 && average<=100)
            {
                return Start+":Distinction";
            }
            else if(average >=50 && average <75)
            {
                return Start + ":Pass";
            }
            else if(average>=0 && average <50)
            {
                return Start + ":Fail";
            }
            else
            {
                return Start + ":Inccorect Average";
            }
        }
    }
}
