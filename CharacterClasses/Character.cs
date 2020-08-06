namespace Zombie_Apocalypse_Tomaszek_Piotr
{
    public abstract class Character
    {
        protected double _money;
        protected int _valueY;
        protected int _valueX;

        public int X
        {
            get { return _valueX; }
            set
            {
                if (value < 25 && value > -1)
                    _valueX = value;
            }
        }
        public int Y
        {
            get { return _valueY; }
            set
            {
                if (value < 25 && value > -1)
                    _valueY = value;
            }
        }
        public double Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
                if (_money <= 0)
                {
                    _money = 0;
                }
            }
        }

        public Character(int x, int y, double m)
        {
            X = x;
            Y = y;
            Money = m;
        }
    }
}
