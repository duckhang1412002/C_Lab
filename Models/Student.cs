using System;
using System.Text.RegularExpressions;
using System.Reflection;

namespace C_Lab.Models
{
    public class Student : People {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set {
                //A12001-A12999
                while (!Regex.IsMatch(value, @"^A12[0-9]{2}[1-9]{1}$")) {
                    System.Console.WriteLine("Please check your RollNo !!(A12001-A12999)");
                    System.Console.Write("Please input your RollNo: ");
                    value = Console.ReadLine();
                }
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
                while (!Regex.IsMatch(value, @"^((CP)|(DI)|(DM))[1-9]{1}[0-9]{3}(0?[1-9]|1[012])[GHIJKFM]{1}[0-9]{2}$")) {
                    System.Console.WriteLine("Please check your ClassNo !!(Ex: CP201210G17 or DM201301M05)");
                    System.Console.Write("Please input your ClassNo: ");
                    value = Console.ReadLine();
                }
                _classNo = value; 
            }
        }
        
        private int _marksSize;
        public int MarksSize
        {
            get { return _marksSize; }
            set { 
                while (value < 0) {
                    System.Console.WriteLine("Please check your Number of mark !!");
                    try {
                        System.Console.Write("Please input your Number of marks");
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                }
                _marksSize = value; 
                _marks = new int[_marksSize];
            }
        }
        

        private int[] _marks;
        public int this[int index]
        {
            get { return _marks[index]; }
            set { 
                while (_marks[index] < 0 || _marks[index] > 100) {
                    System.Console.WriteLine("Please check your Mark (0-100)!!");
                    try {
                        System.Console.Write("Please input your Mark: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                } 
                _marks[index] = value; 
            }
        }

        public Student() : base() {
            _rollNo = _classNo = "";    
            _marksSize = 0;
        }

        public Student(string FullName) : base(FullName) {
             _rollNo = _classNo = "";  
             _marksSize = 0;
        }

        public Student(string ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone, string RollNo, string ClassNo) 
        :base(ID, FullName, BirthDay, Address, Email, Phone) {
            this._rollNo = RollNo;
            this._classNo = ClassNo;
        }

        //not yet done
        public double getAvgMark() {
            double avg = 0.0;
            for (int i = 0; i < _marksSize; ++i) {
                avg += _marks[i];
            }
            return (_marksSize > 0) ? avg/_marksSize : 0;
        }

        public void inputStudent() {
            base.inputPeople();
            System.Console.Write("Please input Student RollNo(A12001-A12999): ");
            this.RollNo = Console.ReadLine();
            System.Console.Write("Please input Student ClassNo(Ex: CP201210G17 or DM201301M05): ");
            this.ClassNo = Console.ReadLine();

            //input Size of indexer
            while(true) {
                try {
                    System.Console.Write("Please input Number of Marks: ");
                    this.MarksSize = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Please input a number!!");
                    continue;
                }
                break;       
            }
            
            for (int i = 0; i < MarksSize; ++i) {
                while(true) {
                    try {
                        System.Console.Write($"Please input Marks for Subject {i+1}: ");
                        this[i] = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        System.Console.WriteLine("Please input a number!!");
                        continue;
                    }
                    break;       
                }
            }
        }

        public override void printInfo()
        {
            System.Console.WriteLine($" - RollNo: {RollNo} - ClassNo: {ClassNo}");
        }

        public override string ToString()
        {
            return base.ToString() + $"--- RollNo: {RollNo} --- ClassNo: {ClassNo}";
        }
    }
}