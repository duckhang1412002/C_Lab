using System;
using System.Text.RegularExpressions;

namespace C_Lab.Models
{
    public class Student : People {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set {
                //A12001-A12999
                if (!Regex.IsMatch(value, @"^A12[0-9]{2}[1-9]{1}$")) 
                    System.Console.WriteLine("Please check your RollNo !!(A12001-A12999)");
                else 
                    _rollNo = value; 
            }
        }
        
        private string _classNo;
        public string ClassNo
        {
            get { return _classNo; }
            set { 
                //CP / DI / DM + year + month + G/H/I/J/K/F/M + xx
                //Ex: CP201210G17 or DM201301M05
                if (!Regex.IsMatch(value, @"^((CP)|(DI)|(DM))[1-9]{1}[0-9]{3}(0?[1-9]|1[012])[GHIJKFM]{1}[0-9]{2}$"))
                    System.Console.WriteLine("Please check your ClassNo !!(Ex: CP201210G17 or DM201301M05)");
                else 
                    _classNo = value; 
            }
        }
        
        private int _subject;
        public int Subject
        {
            get { return _subject; }
            set { 
                if (value < 0 || value > 100) 
                    System.Console.WriteLine("Please check your Number of Subject !!");
                else 
                    _subject = value; 
            }
        }
        

        private int[] _marks;
        public int this[int index]
        {
            get { return _marks[index]; }
            set { 
                if (_marks[index] < 0 || _marks[index] > 100) {
                    System.Console.WriteLine("Please check your Marks !!");
                    _marks[index] = 0;
                } else 
                    _marks[index] = value; 
            }
        }

        public Student() : base() {
            _rollNo = _classNo = "";    
            _subject = 0;
        }

        public Student(string FullName) : base(FullName) {
             _rollNo = _classNo = "";  
             _subject = 0;
        }

        public Student(string ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone, string RollNo, string ClassNo) 
        :base(ID, FullName, BirthDay, Address, Email, Phone) {
            this._rollNo = RollNo;
            this._classNo = ClassNo;
        }

        //not yet done
        public double getAvgMark() {
            double avg = 0.0;
            for (int i = 0; i < _subject; ++i) {
                avg += _marks[i];
            }
            return (_subject > 0) ? avg/_subject : 0;
        }

        public void inputStudent() {
            base.inputPeople();
            while(true) {
                System.Console.Write("Please input Student RollNo: ");
                this.RollNo = Console.ReadLine();
                if (!this.RollNo.Equals("")) break;
            }

            while(true) {
                System.Console.Write("Please input Student ClassNo: ");
                this.ClassNo = Console.ReadLine();
                if (!this.ClassNo.Equals("")) break;
            }

            while(true) {
                try {
                    System.Console.Write("Please input Number of Subject: ");
                    this.Subject = Convert.ToInt32(Console.ReadLine());
                } catch (Exception e) {
                    //nothing
                }
                if (_subject != 0) break;        
            }

            _marks = new int[_subject];
            for (int i = 0; i < Subject; ++i) {
                while(true) {
                    try {
                        System.Console.Write($"Please input Marks for Subject {i+1}: ");
                        this[i] = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception e) {
                        //nothing
                    }
                    if (this[i] != 0) break;           
                }
            }
        }

        public void printInfo() {
            base.printInfo();
            System.Console.WriteLine($" - RollNo: {RollNo} - ClassNo: {ClassNo}");
        }
    }
}