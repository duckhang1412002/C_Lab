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
                    System.Console.WriteLine("Please check your Birthday");
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

        private int[] _subjects;
        public int this[int index]
        {
            get { return _subjects[index]; }
            set { 
                if (_subjects[index] < 0 || _subjects[index] > 100) {
                    System.Console.WriteLine("Please check your Marks !!");
                    _subjects[index] = 0;
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
            
        }

        public void printInfo() {

        }

    }
}