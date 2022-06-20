using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace C_Lab.Models
{
    public abstract class People {
        protected string _id;
        public string ID
        {
            get { return _id; }
            set { 
                while (!Regex.IsMatch(value, @"^[0-9]{9}$")) {
                    System.Console.WriteLine("Please check your ID(9 digit number)");
                    System.Console.Write("Please input ID(9 digits): ");
                    value = Console.ReadLine();
                }
                _id = value; 
            }
        }

        protected string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { 
                while (!Regex.IsMatch(value, @"^[A-Za-z][A-Z a-z]+$") || value.Length > 50) { 
                    System.Console.WriteLine("Please check your FullName");
                    System.Console.Write("Please input FullName: ");
                    value = Console.ReadLine();
                }
                _fullName = value; 
            }
        }

        protected DateTime _birthDay;
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { 
                DateTime dt1 = DateTime.Parse("01/01/1900");
                DateTime dt2 = DateTime.Now;
                while (value < dt1 || value > dt2) {
                    System.Console.WriteLine("Please check your Birthday (dd/mm/yyyy)");      
                    System.Console.Write("Please input Birthday: ");     
                    try {
                        value = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);       
                    } 
                    catch (Exception) {
                        continue;
                    }
                } 
                _birthDay = value;  
            }
        }
        
        protected string _address;
        public string Address
        {
            get { return _address; }
            set {
                while (value.Trim().Equals("")) {
                    System.Console.WriteLine("Please check your Address"); 
                    System.Console.Write("Please input Address: ");
                    value = Console.ReadLine();
                }
                _address = value; 
            }
        }
        
        protected string _email;
        public string Email
        {
            get { return _email; }
            set { 
                while (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) {
                    System.Console.WriteLine("Please check your Email (Ex: abc@email.com)");
                    System.Console.Write("Please input Email: ");
                    value = Console.ReadLine();
                }
                _email = value; 
            }
        }
        
        protected string _phone;
        public string Phone
        {
            get { return _phone; }
            set { 
                while (!Regex.IsMatch(value, @"^[\+\d{2}|0]\d{9,}")) {
                    System.Console.WriteLine("Please check your Phone (10 or 11 numbers)");
                    System.Console.Write("Please input Phone: ");
                    value = Console.ReadLine();
                }
                _phone = value; 
            }
        }

        public People(){
            // _id = _fullName = _address = _email = _phone = "";
            // _birthDay = new DateTime();
        }

        public People(string FullName)
        {
            this.FullName = FullName;
        }

        public People(string ID, string FullName, DateTime BirthDay, string Address, string Email, string Phone) {
            this.ID = ID;
            this.FullName = FullName;
            this.BirthDay = BirthDay;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
        }

        public int getAge() {
            return DateTime.Now.Year - BirthDay.Year;
        }

        public void inputPeople() {
            System.Console.Write("Please input ID(9 digits): ");
            this.ID = Console.ReadLine();
            System.Console.Write("Please input FullName: ");
            this.FullName = Console.ReadLine();

            while(true) {
                try {
                System.Console.Write("Please input BirthDay (dd/mm/yyyy): ");
                this.BirthDay = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                } 
                catch (Exception) {
                    System.Console.WriteLine("Please check your Birthday (dd/mm/yyyy)");
                    continue;
                }
                break;
            }
            
            System.Console.Write("Please input Address: ");
            this.Address = Console.ReadLine();
            System.Console.Write("Please input Email (Ex: abc@email.com): ");
            this.Email = Console.ReadLine();
            System.Console.Write("Please input Phone (10 or 11 digits): ");
            this.Phone = Console.ReadLine();
        }

        public abstract void printInfo();
            //System.Console.Write($"Full name: {FullName} - Birthday: {BirthDay.ToString("dd/MM/yyyy")}");
        

        public override string ToString() {
            return $"{FullName} --- {getAge()} --- {Phone}"; 
        }
        
    }
}