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
                while (!Regex.IsMatch(value, @"^[a-zA-Z]{6}$")) {
                    System.Console.WriteLine("Please check your SubjectCode (6 characters)");
                    System.Console.Write("Please input SubjectCode: ");
                    value = Console.ReadLine();
                } 
                _subjectCode = value;
            }
        }

        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set { 
                while (value.Length > 50 || value.Length == 0) {
                    System.Console.WriteLine("Please check your SubjectName (can not be null and less than 50 charaters)");
                    System.Console.Write("Please input SubjectName: ");
                    value = Console.ReadLine();
                }
                _subjectName = value; 
            }
        }
        
        
        private int _practice;
        public int Practice
        {
            get { return _practice; }
            set { 
                while (value < 0 || value > 100) {
                    System.Console.WriteLine("Please check Number of Practice lesson(0-100)");
                    System.Console.Write("Please input Number of Practice lessons: ");
                    try {
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                }
                _practice = value; 
            }
        }
        
        private int _theory;
        public int Theory
        {
            get { return _theory; }
            set { 
                while (value < 0 || value > 100) {
                    System.Console.WriteLine("Please check Number of Theory lesson(0-100)");
                    System.Console.Write("Please input Number of Theory lessons: ");
                    try {
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                }
                _theory = value; 
            }
        }

        public Subject() {
            _subjectCode = _subjectName = "";
            _theory = _practice = -1;    
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
            System.Console.WriteLine("Please input Subject Code: ");
            this.SubjectCode = Console.ReadLine();
            System.Console.WriteLine("Please input Subject Name: ");
            this.SubjectName = Console.ReadLine();

            while(true) {
                System.Console.WriteLine("Please input number of Theory lesson");
                try {
                    this.Theory = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Please input a number!!!");
                    continue;
                }
                break;
            }

            while(true) {
                System.Console.WriteLine("Please input number of Practice lesson");
                try {
                    this.Practice = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Please input a number!!!");
                    continue;
                }
                break;
            }
        }

        public void printInfo() {
            System.Console.WriteLine($"Subject Code: {SubjectCode} - Subject Name: {SubjectName} - Theory lesson: {Theory} - Practice lesson: {Practice}");        
        }
    }
}