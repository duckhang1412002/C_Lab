using System;

namespace C_Lab.Models
{
    public abstract class Marks
    {
        protected int _mark;
        public int Mark
        {
            get { return _mark; }
            set {
                while (value < 0 || value > 100) {
                    System.Console.WriteLine("Please check your mark input"); 
                    System.Console.Write("Please input Mark: ");
                    try {
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                } 
                _mark = value; 
            }
        }

        protected int _passLevel;
        public int PassLevel
        {
            get { return _passLevel; }
            set {
                while (value < 40 || value > 100) {
                    System.Console.WriteLine("Please check your pass Level"); 
                    System.Console.Write("Please input Pass Level: ");
                    try {
                        value = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        continue;
                    }
                } 
                _passLevel = value; 
            }
        }

        public Marks()
        {
            _mark = _passLevel = -1;
        }

        public Marks(int Mark, int PassLevel)
        {
            this._mark = Mark;
            this._passLevel = PassLevel; 
        }

        public void inputMarks() {
            while(true) {
                try {
                    System.Console.Write("Please input Marks of Subject(0-100): ");
                    this.Mark = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Pease input a number!");
                    continue;
                }
                break;        
            }

            while(true) {
                try {
                    System.Console.Write("Please input Pass Level for Subject(40-100): ");
                    this.PassLevel = Convert.ToInt32(Console.ReadLine());
                } catch (Exception) {
                    System.Console.WriteLine("Pease input a number!");
                    continue;
                }
                break;        
            }
        }
        
        public bool checkPass() => (Mark >= PassLevel);
        
        public abstract bool getBonus();    
    }
}