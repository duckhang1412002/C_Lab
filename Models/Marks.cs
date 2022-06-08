using System;

namespace C_Lab.Models
{
    public abstract class Marks
    {
        private int _mark;
        public int Mark
        {
            get { return _mark; }
            set {
                if (value < 0 || value > 100) 
                    System.Console.WriteLine("Please check your mark input"); 
                else 
                    _mark = value; 
            }
        }

        private int _passLevel;
        public int PassLevel
        {
            get { return _passLevel; }
            set {
                if (value < 40 || value > 100) 
                    System.Console.WriteLine("Please check your mark input"); 
                else 
                    _passLevel = value; 
            }
        }

        public Marks()
        {
            _mark = _passLevel = 0;
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
                } catch (Exception e) {
                    System.Console.WriteLine(e);
                }
                if (Mark != 0) break;        
            }

            while(true) {
                try {
                    System.Console.Write("Please input Pass Level for Subject(40-100): ");
                    this.PassLevel = Convert.ToInt32(Console.ReadLine());
                } catch (Exception e) {
                    System.Console.WriteLine(e);
                }
                if (PassLevel != 0) break;        
            }
        }
        
        public bool checkPasss() => (Mark >= PassLevel);
        
        public abstract bool getBonus();    
    }
}