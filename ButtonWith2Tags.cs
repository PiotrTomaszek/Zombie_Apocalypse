using System.Windows.Forms;

namespace Zombie_Apocalypse_Tomaszek_Piotr
{
    public class ButtonWith2Tags : Button
    {
        private int _tag1;
        private int _tag2;
        private string _toolTipString;

        public string ToolTipString
        {
            get
            {
                return _toolTipString;
            }
            set
            {
                _toolTipString = value;
            }
        }

        public int Tag1
        {
            get
            {
                return _tag1;
            }
            set
            {
                _tag1 = value;
            }
        }
        public int Tag2
        {
            get
            {
                return _tag2;
            }
            set
            {
                _tag2 = value;
            }
        }
    }
}
