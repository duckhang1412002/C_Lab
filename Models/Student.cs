using System;
namespace C_Lab.Models
{
    public class Student : People {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }
        
        private string _classNo;
        public string ClassNo
        {
            get { return _classNo; }
            set { _classNo = value; }
        }
        
        private int[] _marks;
        public int this[int index]
        {
            get { return _marks[index]; }
            set { _marks[index] = value; }
        }

        public Student() : base() {
            
        }

        public Student(string FullName) : base(FullName) {
            
        }

        public Student(int ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone, string RollNo, string ClassNo) 
        :base(ID, FullName, BirthDay, Address, Email, Phone) {
            this._rollNo = RollNo;
            this._classNo = ClassNo;
        }

        //not yet done
        public double getAvgMark() {
            return 0.0;
        }

        public void inputStudent() {
            base.inputPeople();
            System.Console.WriteLine("Please input Student RollNo: ");
            this.RollNo = Console.ReadLine();
            System.Console.WriteLine("Please input Student ClassNo: ");
            this.ClassNo = Console.ReadLine();
        }

        public void printInfo() {
            base.printInfo();
            System.Console.WriteLine($" - RollNo: {RollNo} - ClassNo: {ClassNo}");
        }
    }
}