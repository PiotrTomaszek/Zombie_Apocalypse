namespace Zombie_Apocalypse_Tomaszek_Piotr
{
    public class Zombie : Human
    {
        private int _strength;
        private int _turnsToBeNormal;

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
        public int TurnsToBeNormal
        {
            get { return _turnsToBeNormal; }
            set { _turnsToBeNormal = value; }
        }


        public Zombie(int x, int y, double m, int s, int turns) : base(x, y, m)
        {
            _strength = s;
            _turnsToBeNormal = turns;
        }
    }
}
