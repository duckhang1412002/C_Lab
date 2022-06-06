using System;
using System.Globalization;

namespace C_Lab.Models
{
    public class People {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        

        private DateTime _birthDay;
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { 
                _birthDay = value; 
                Age = 0;
            }
        }
        
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public People(){
            _id = _age = 0;
            _fullName = _address = _email = _phone = "";
        }

        public People(string FullName)
        {
            this._fullName = FullName;
        }

        public People(int ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone) {
            this._id = ID;
            this._fullName = FullName;
            this._birthDay = BirthDay;
            this._address = Address;
            this._email = Email;
            this._phone = Phone;
        }

        public override string ToString() {
            return $"{FullName} --- {Age} --- {Phone}"; 
        }

        public void inputPeople() {
            System.Console.WriteLine("Please input ID: ");
            this.ID = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please input FullName");
            this.FullName = Console.ReadLine();
            System.Console.WriteLine("Please input BirthDay");
            this.BirthDay = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Please input Address");
            this.Address = Console.ReadLine();
            System.Console.WriteLine("Please input Email");
            this.Email = Console.ReadLine();
            System.Console.WriteLine("Please input Phone");
            this.Phone = Console.ReadLine();
        }

        public void printInfo() {
            System.Console.WriteLine($"Full name: {FullName} - Birthday: {BirthDay}");
        }
        
    }
}