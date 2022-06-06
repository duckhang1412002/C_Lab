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
        
        public bool checkPasss() => (Mark >= PassLevel);
        
        public abstract bool getBonus();
    }
}