using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace C_Lab.Models
{
    public class People {
        private string _id;
        public string ID
        {
            get { return _id; }
            set { 
                if (!Regex.IsMatch(value, @"^[0-9]{9}$")) 
                    System.Console.WriteLine("Please check your ID");
                else 
                    _id = value; 
            }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { 
                if (!Regex.IsMatch(value, @"^[A-Z a-z]{1,50}$")) 
                    System.Console.WriteLine("Please check your FullName");
                else 
                    _fullName = value; 
            }
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
                DateTime dt1 = DateTime.Parse("01/01/1900");
                DateTime dt2 = DateTime.Now;
                if (dt1 <= value && value <= dt2) {
                    _birthDay = value; 
                    Age = dt2.Year - value.Year;
                } else 
                    System.Console.WriteLine("Please check your Birthday");
            }
        }
        
        private string _address;
        public string Address
        {
            get { return _address; }
            set {
                if (value.Trim().Equals(""))
                    System.Console.WriteLine("Please check your Address"); 
                else 
                    _address = value; }
        }
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set { 
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]+@+[A-Za-z0-9]+.+[A-Za-z0-9]$")) 
                    System.Console.WriteLine("Please check your Email");
                else 
                    _email = value; 
            }
        }
        
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { 
                if (!Regex.IsMatch(value, @"^[0-9]{10,11}")) 
                    System.Console.WriteLine("Please check your Phone");
                else 
                    _phone = value; 
            }
        }

        public People(){
            _age = 0;
            _id = _fullName = _address = _email = _phone = "";
            _birthDay = new DateTime();
        }

        public People(string FullName)
        {
            this._fullName = FullName;
        }

        public People(string ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone) {
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
            while(true) {
                System.Console.Write("Please input ID: ");
                this.ID = Console.ReadLine();
                if (!this.ID.Equals("")) break;
            }

            while(true) {
                System.Console.Write("Please input FullName: ");
                this.FullName = Console.ReadLine();
                if (!this.FullName.Equals("")) break;     
            }

            while(true) {
                try {
                System.Console.Write("Please input BirthDay: ");
                this.BirthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } catch (Exception e) {
                    //nothing
                }
                if (this.BirthDay != (new DateTime())) break;
            }
            
            while(true) {
                System.Console.Write("Please input Address: ");
                this.Address = Console.ReadLine();
                if (!this.Address.Equals("")) break;   
            }

            while(true) {
                System.Console.Write("Please input Email: ");
                this.Email = Console.ReadLine();
                if (!this.Email.Equals("")) break;   
            }

            while(true) {
                System.Console.Write("Please input Phone: ");
                this.Phone = Console.ReadLine();
                if (!this.Phone.Equals("")) break;   
            }
        }

        public void printInfo() {
            System.Console.Write($"Full name: {FullName} - Birthday: {BirthDay.ToString("dd/MM/yyyy")}");
        }
        
    }
}