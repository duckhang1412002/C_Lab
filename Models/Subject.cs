using System.Globalization;
using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace C_Lab.Models
{
    public class Subject {
        private string _subjectCode;
        public string SubjectCode
        {
            get { return _subjectCode; }
            set {       
                if (!Regex.IsMatch(value, @"^[a-zA-Z]{6}$")) {
                    System.Console.WriteLine("Please check your input");
                } else {
                    _subjectCode = value;
                }
            }
        }

        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set { 
                if (value.Length > 50) 
                    System.Console.WriteLine("Please check your input");
                else 
                    _subjectName = value; 
            }
        }
        
        
        private int _practice;
        public int Practice
        {
            get { return _practice; }
            set { 
                if (value < 0 || value > 100) 
                    System.Console.WriteLine("Please check your input");
                else 
                    _practice = value; 
            }
        }
        
        private int _theory;
        public int Theory
        {
            get { return _theory; }
            set { 
                if (value < 0 || value > 100) 
                    System.Console.WriteLine("Please check your input");
                else 
                    _theory = value; 
            }
        }

        public Subject() {
            _subjectCode = _subjectName = "";
            _theory = _practice = 0;    
        }

        public Subject(string SubjectCode, string SubjectName, int Theory, int Practice) {
            this._subjectCode = SubjectCode;
            this._subjectName = SubjectName;
            this._theory = Theory;
            this._practice = Practice;
        }

        public int getTotalLessons() => Theory + Practice;

        public override string ToString() => $"{SubjectCode} -- {SubjectName} -- {getTotalLessons()}";
    
        public void inputSubject() {
            while(true) {
                System.Console.WriteLine("Please input Subject Code: ");
                this.SubjectCode = Console.ReadLine();
                if (!this.SubjectCode.Equals("")) break;
            }

            while(true) {
                System.Console.WriteLine("Please input Subject Name: ");
                this.SubjectName = Console.ReadLine();
                if (!this.SubjectName.Equals("")) break;
            }

            while(true) {
                System.Console.WriteLine("Please input number of Theory lesson");
                this.Theory = Convert.ToInt32(Console.ReadLine());
                if (Theory != 0) break;
            }

            while(true) {
                System.Console.WriteLine("Please input number of Practice lesson");
                this.Practice = Convert.ToInt32(Console.ReadLine());
                if (Practice != 0) break;
            }
        }

        public void printInfo() {
            System.Console.WriteLine($"Subject Code: {SubjectCode} - Subject Name: {SubjectName} - Theory lesson: {Theory} - Practice lesson: {Practice}");        
        }
    }
}