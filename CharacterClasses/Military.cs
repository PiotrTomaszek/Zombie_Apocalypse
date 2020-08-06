namespace Zombie_Apocalypse_Tomaszek_Piotr
{
    public class Military : Character
    {
        protected int _endurance;

        public int Endurance
        {
            get
            {
                return _endurance;
            }
            set
            {
                _endurance = value;
            }
        }

        public Military(int x, int y, double m, int e) : base(x, y, m)
        {
            _endurance = e;
        }
    }
}
