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
                while (!Regex.IsMatch(value, @"^A12[0-9]{2}[1-9]{1}$")) {
                    System.Console.WriteLine("Please check your RollNo (A12001-A12999)");
                    System.Console.Write("Please input RollNo: ");
                    value = Console.ReadLine();
                } 
                _rollNo = value; 
            }
        }

        private string _studentName;
        public string StudentName
        {
            get { return _studentName; }
            set { 
                while (!Regex.IsMatch(value, @"^[A-Za-z][A-Z a-z]+$") || value.Length > 50) { 
                    System.Console.WriteLine("Please check your StudentName");
                    System.Console.Write("Please input Student Name: ");
                    value = Console.ReadLine();
                }
                _studentName = value; 
            }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { 
                while (!Regex.IsMatch(value, @"^[a-zA-Z]{6}$")) {
                    System.Console.WriteLine("Please check your SubjectCode (6 characters)");
                    System.Console.Write("Please input SubjectCode: ");
                    value = Console.ReadLine();
                } 
                _subject = value; 
            }
        }
        
        private int _testTime;
        public int TestTime
        {
            get { return _testTime; }
            set {
                while (value < 1 || value > 4) {
                    System.Console.WriteLine("Please check your TestTime (1-4)");
                    System.Console.Write("Please input Test time: ");
                }
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

        public void inputMarks_Subject() {
            System.Console.Write("Please input Student RollNo (A12001-A12999): ");
            this.RollNo = Console.ReadLine();
            System.Console.Write("Please input Student Name: ");
            this.StudentName = Console.ReadLine();
            System.Console.Write("Please input Subject Code: ");
            this.Subject = Console.ReadLine();
                
            while(true) {
                try {
                    System.Console.Write("Please input Testing time for Subject (1-4): ");
                    this.TestTime = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Please input a number!!!");
                    continue;
                }
                break;        
            }

            base.inputMarks();
        }

        public override bool getBonus(){
            return PassLevel == 1;
        }

        public void printMarks() {
            System.Console.WriteLine($"RollNo: {RollNo} -- StudentName: {StudentName} -- Subject: {Subject} -- Mark: {base.Mark}");
        }
        
        public void printStatus() {
            System.Console.Write($"RollNo: {RollNo} -- StudentName: {StudentName} -- Subject: {Subject} -- Mark: {base.Mark}");
            System.Console.WriteLine(" -- Status: {0} -- Bonus: {1}", (base.checkPass() == true) ? "Passed" : "Failed", (this.getBonus() == true) ? "Yes" : "No");
        }
    } 
}