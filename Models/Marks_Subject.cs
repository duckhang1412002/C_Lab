using System;
using System.Text.RegularExpressions;

namespace C_Lab.Models
{
    public class Marks_Subject : Marks, IMarks
    {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set { 
                //A12001-A12999
                if (!Regex.IsMatch(value, @"^A12[0-9]{2}[1-9]{1}$")) 
                    System.Console.WriteLine("Please check your RollNo");
                else 
                    _rollNo = value; 
            }
        }

        private string _studentName;
        public string StudentName
        {
            get { return _studentName; }
            set { 
                if (!Regex.IsMatch(value, @"^[A-Z a-z]{1,50}$")) 
                    System.Console.WriteLine("Please check your StudentName");
                else 
                    _studentName = value; 
            }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { 
                if (value.Trim().Equals(""))
                    System.Console.WriteLine("Please check your Subject");
                else 
                    _subject = value; 
            }
        }
        
        private int _testTime;
        public int TestTime
        {
            get { return _testTime; }
            set {
                if (value < 1 || value > 4) 
                    System.Console.WriteLine("Please check your TestTime");
                else 
                    _testTime = value; 
            }
        }
        

        public Marks_Subject() : base() 
        {
            this._rollNo = this._studentName = this._subject = "";
            this._testTime = 0;
        }

        public Marks_Subject(int Mark, int PassLevel, string RollNo, string StudentName, string Subject, int TestTime)
        : base(Mark, PassLevel) {
            this._rollNo = RollNo;
            this._studentName = StudentName;
            this._subject = Subject;
            this._testTime = TestTime;
        }

        public void inputMarks() {
                        
        }

        public void printMarks() {

        }
        
        public override bool getBonus(){
            return true;
        }


    }
}