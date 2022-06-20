using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace C_Lab.Models
{
    public class Teacher : People
    {
        private string _teacherCode;
        public string TeacherCode
        {
            get { return _teacherCode; }
            set { 
                //A0001 to A9999 or B0001-B9999
                while (!Regex.IsMatch(value, @"^[AB]{1}[0-9]{3}[1-9]{1}$")) {
                    System.Console.WriteLine("Please check your TeacherCode !!(A0001-A9999 or B0001-B9999)");
                    System.Console.Write("Please input your TeacherCode: ");
                    value = Console.ReadLine();
                }
                _teacherCode = value; 
            }
        }
        

        private DateTime _joinedDate;
        public DateTime JoinedDate
        {
            get { return _joinedDate; }
            set { 
                DateTime dt1 = DateTime.Parse("01/01/1900");
                DateTime dt2 = DateTime.Now;
                while (dt1 > value && value > dt2) {
                    System.Console.WriteLine("Please check your Joined Date (dd/mm/yyyy)");
                    try {
                        System.Console.Write("Please input Joined Date: ");
                        value = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    } catch (Exception) {
                        continue;
                    }

                }
                _joinedDate = value; 
            }
        }

        private int _subjectsSize;
        public int SubjectsSize
        {
            get { return _subjectsSize; }
            set { 
                while (value < 0) { 
                    System.Console.WriteLine("Please check your Number of Subject !!");
                    System.Console.Write("Please input Number of Subject: ");
                    try {
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                }
                _subjectsSize = value; 
            }
        }

        private string[] _subjects;
        public string this[int index]
        {
            get { return _subjects[index]; }
            set { 
                while (!Regex.IsMatch(value, @"^[a-zA-Z]{6}$")) {
                    System.Console.WriteLine("Please check your SubjectCode (6 characters)");
                    System.Console.Write("Please input SubjectCode: ");
                    value = Console.ReadLine();
                } 
                _subjects[index] = value; 
            }
        }

        public Teacher() : base() {
            this._teacherCode = "";
            this._subjectsSize = 0;
            this._joinedDate = new DateTime();
        }

        public Teacher(string FullName) : base(FullName) {
            this._teacherCode = "";
            this._subjectsSize = 0;
            this._joinedDate = new DateTime();
        }
        
        public int getWorkedYears() {
            return Convert.ToInt32(DateTime.Now.Year - JoinedDate.Year);        
        }

        public void inputTeacher() {
            base.inputPeople();
            System.Console.Write("Please input Teacher Code (A0001-A9999 or B0001-B9999): ");
            this.TeacherCode = Console.ReadLine();
            
            while(true) {
                System.Console.Write("Please input Joined Date (dd/mm/yyyy): ");
                try {
                    this.JoinedDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } catch (Exception) {
                    System.Console.WriteLine("Please input a valid date!");
                    continue;
                }
                break;
            }

            while(true) {
                System.Console.Write("Please input Number of Subjects: ");
                try {
                    this.SubjectsSize = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Please input a number!!");
                    continue;
                }
                break;        
            }

            _subjects = new string[SubjectsSize];
            for (int i = 0; i < SubjectsSize; ++i) {
                System.Console.Write($"Please input Subject {i+1}'s code: ");
                this[i] = (Console.ReadLine());       
            }
            
        }

        public override void printInfo() {
            System.Console.WriteLine($" - TeacherCode: {TeacherCode} - Joined Date: {JoinedDate.ToString("dd/MM/yyyy")}");          
        }

    }
}