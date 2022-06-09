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
                if (!Regex.IsMatch(value, @"^[AB]{1}[0-9]{3}[1-9]{1}$")) 
                    System.Console.WriteLine("Please check your TeacherCode !!(A0001-A9999 or B0001-B9999)");
                else 
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
                if (dt1 <= value && value <= dt2) {
                    _joinedDate = value; 
                } else 
                    System.Console.WriteLine("Please check your Joined Date (dd/mm/yyyy)");
                }
        }

        private int _subjectsSize;
        public int SubjectsSize
        {
            get { return _subjectsSize; }
            set { 
                if (value < 0) 
                    System.Console.WriteLine("Please check your Number of Subject !!");
                else 
                    _subjectsSize = value; 
            }
        }

        private string[] _subjects;
        public string this[int index]
        {
            get { return _subjects[index]; }
            set { 
                if (value.Trim().Equals("")) {
                    System.Console.WriteLine("Please check your Subject !!");
                    _subjects[index] = "";
                } else 
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
            while(true) {
                System.Console.Write("Please input Teacher Code (A0001-A9999 or B0001-B9999): ");
                this.TeacherCode = Console.ReadLine();
                if (!this.TeacherCode.Equals("")) break;
            }

            while(true) {
                try {
                System.Console.Write("Please input Joined Date (dd/mm/yyyy): ");
                this.JoinedDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } catch (Exception) {
                    //System.Console.WriteLine(e);
                }
                if (this.JoinedDate != (new DateTime())) break;
            }

            while(true) {
                try {
                    System.Console.Write("Please input Number of Subject: ");
                    this.SubjectsSize = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    //System.Console.WriteLine(e);
                }
                if (SubjectsSize != 0) break;        
            }

            _subjects = new string[SubjectsSize];
            for (int i = 0; i < SubjectsSize; ++i) {
                while(true) {
                    System.Console.Write($"Please input Subject {i+1}'s name: ");
                    this[i] = (Console.ReadLine());
                    if (!this[i].Equals("")) break;           
                }
            }
            
        }

        public new void printInfo() {
            base.printInfo();
            System.Console.WriteLine($" - TeacherCode: {TeacherCode} - Joined Date: {JoinedDate.ToString("dd/MM/yyyy")}");          
        }

    }
}