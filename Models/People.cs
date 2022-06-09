using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace C_Lab.Models
{
    public class People {
        protected string _id;
        public string ID
        {
            get { return _id; }
            set { 
                if (!Regex.IsMatch(value, @"^[0-9]{9}$")) 
                    System.Console.WriteLine("Please check your ID(9 digit number)");
                else 
                    _id = value; 
            }
        }

        protected string _fullName;
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
        
        protected int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        

        protected DateTime _birthDay;
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
                    System.Console.WriteLine("Please check your Birthday (dd/mm/yyyy)");
            }
        }
        
        protected string _address;
        public string Address
        {
            get { return _address; }
            set {
                if (value.Trim().Equals(""))
                    System.Console.WriteLine("Please check your Address"); 
                else 
                    _address = value; }
        }
        
        protected string _email;
        public string Email
        {
            get { return _email; }
            set { 
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) 
                    System.Console.WriteLine("Please check your Email (Ex: abc@email.com)");
                else 
                    _email = value; 
            }
        }
        
        protected string _phone;
        public string Phone
        {
            get { return _phone; }
            set { 
                if (!Regex.IsMatch(value, @"^[0-9]{10,11}")) 
                    System.Console.WriteLine("Please check your Phone (10 or 11 numbers)");
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
                System.Console.Write("Please input ID(9 digits): ");
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
                System.Console.Write("Please input BirthDay (dd/mm/yyyy): ");
                this.BirthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } 
                #pragma warning disable 0168 
                catch (Exception) 
                {
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
                System.Console.Write("Please input Email (Ex: abc@email.com): ");
                this.Email = Console.ReadLine();
                if (!this.Email.Equals("")) break;   
            }

            while(true) {
                System.Console.Write("Please input Phone (10 or 11 digits): ");
                this.Phone = Console.ReadLine();
                if (!this.Phone.Equals("")) break;   
            }
        }

        public void printInfo() {
            System.Console.Write($"Full name: {FullName} - Birthday: {BirthDay.ToString("dd/MM/yyyy")}");
        }
        
    }
}