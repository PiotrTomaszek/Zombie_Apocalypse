using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Zombie_Apocalypse_Tomaszek_Piotr
{
    // Piotr Tomaszek
    // Informatyka
    // Semestr 4

    public partial class Form1 : Form
    {
        private List<Character> characters;
        private Random random;
        private int whichTurn;
        private bool canPlay = false;

        public Form1()
        {
            InitializeComponent();
            CreateGameGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tBxCzlowiek_TextChanged(object sender, EventArgs e)
        {

        }
        private void btbStartGame_Click(object sender, EventArgs e)
        {
            bool isHumanOk = int.TryParse(tBxCzlowiek.Text, out int humanValue);
            bool isZombiekOk = int.TryParse(tBxZombie.Text, out int zombieValue);
            bool isMilitarykOk = int.TryParse(tBxWojsko.Text, out int militaryValue);
            bool isTotalValueOk = (humanValue + zombieValue + militaryValue) <= 625;

            if (isHumanOk && isZombiekOk && isMilitarykOk && isTotalValueOk)
            {
                random = new Random();

                canPlay = true;
                btbStartGame.Enabled = false;
                tBxCzlowiek.Enabled = false;
                tBxZombie.Enabled = false;
                tBxWojsko.Enabled = false;

                characters = new List<Character>();

                for (int i = 0; i < humanValue; i++)
                {
                    var hum = new Human(random.Next(26), random.Next(26), random.NextDouble() * 1000);
                    characters.Add(hum);
                }
                for (int i = 0; i < militaryValue; i++)
                {
                    var mil = new Military(random.Next(26), random.Next(26), random.NextDouble() * 1000, random.Next(101));
                    characters.Add(mil);
                }
                for (int i = 0; i < zombieValue; i++)
                {
                    var zom = new Zombie(random.Next(26), random.Next(26), random.NextDouble() * 1000, random.Next(101), random.Next(3, 11));
                    characters.Add(zom);
                }
                GameEngine();
            }
            else
            {
                MessageBox.Show("Wprowadzono błędne dane początkowe! Popraw je i spróbuj ponownie. Pamiętaj, że łączna ilość jednostek nie może przekroczyć 625.", "ZŁE DANE");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //button Next Turn !!!
            if (canPlay)
            {
                whichTurn++;
                lblTurnNumber.Text = $"Turn: {whichTurn}";
                GameEngine();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            whichTurn = 0;
            this.Close();
        }

        private void GameEngine()
        {
            UpdateZombie();
            UpdateGrid();
            UpdateMovement();
            MilitaryInteractions();
            ZombieInteractions();
            UpdateLegend();
        }
        private void ZombieInteractions()
        {
            foreach (var item in characters.OfType<Zombie>().ToList<Zombie>())
            {
                foreach (var item2 in characters.ToList<Character>())
                {
                    if (item.X == item2.X && item.Y == item2.Y)
                    {
                        if (!(item2 is Zombie) || (item2 is Military))
                        {
                            characters[characters.IndexOf(item2)] = new Zombie(item2.X, item2.Y, item2.Money, random.Next(101), random.Next(5, 11));
                        }
                    }
                }
            }
        }
        private void MilitaryInteractions()
        {
            var tempMilitary = characters.OfType<Military>();

            foreach (var item in tempMilitary.ToList<Military>())
            {
                foreach (var subItem in characters.ToList<Character>())
                {
                    if ((item.X == subItem.X) && (item.Y == subItem.Y))
                    {
                        switch (subItem)
                        {
                            case Zombie z:
                                if (item.Endurance >= z.Strength)
                                {
                                    characters[characters.IndexOf(z)] = new Human(z.X, z.Y, z.Money);
                                    item.Endurance -= z.Strength;
                                }
                                else
                                {
                                    // Maybe error
                                    characters[characters.IndexOf(z)] = new Zombie(z.X, z.Y, z.Money, random.Next(101), random.Next(5, 11));
                                }
                                break;
                            case Human c:
                                if (c.Money > 0)
                                    subItem.Money -= 500;
                                else
                                {
                                    characters[characters.IndexOf(c)] = new Military(c.X, c.Y, c.Money, random.Next(101));
                                }
                                break;
                            case null:
                                MessageBox.Show("Błąd?!");
                                break;
                        }
                    }
                }
            }
        }
        private void UpdateZombie()
        {
            foreach (var item in characters.ToList<Character>())
            {
                if (item is Zombie)
                {
                    var z = (Zombie)item;
                    if (z.TurnsToBeNormal <= 1)
                    {
                        characters[characters.IndexOf(item)] = new Human(z.X, z.Y, z.Money);
                    }
                    else
                    {
                        z.TurnsToBeNormal--;
                    }
                }
            }
        }
        private void UpdateLegend()
        {
            var zombieNumber = characters.Where(x => x is Zombie).Count();
            lblMilitary.Text = $"Military: {characters.Where(x => x is Military).Count()}";
            lblZombie.Text = $"Zombies: {zombieNumber}";
            lblHuman.Text = $"Humans: {characters.OfType<Human>().Count() - zombieNumber}";
        }
        private void UpdateGrid()
        {
            foreach (var item in pnlGame.Controls.OfType<ButtonWith2Tags>())
            {
                item.ForeColor = Button.DefaultForeColor;
                item.BackColor = Button.DefaultBackColor;
                toolTip.SetToolTip(item, null);
            }

            foreach (var item in characters)
            {
                ButtonWith2Tags btn = pnlGame.Controls.OfType<ButtonWith2Tags>()
                    .Where(x => x.Tag1 == item.X && x.Tag2 == item.Y)
                    .FirstOrDefault();
                switch (item)
                {
                    case Zombie z:
                        toolTip.SetToolTip(btn, $"Money: {Math.Round(z.Money)}\nTurns to heal: {z.TurnsToBeNormal}\nStrength: {z.Strength}");
                        btn.BackColor = Color.LawnGreen;
                        break;
                    case Human c:
                        toolTip.SetToolTip(btn, $"Money: {Math.Round(c.Money, 2)}\n");
                        btn.BackColor = Color.Yellow;
                        break;
                    case Military w:
                        toolTip.SetToolTip(btn, $"Money: {Math.Round(w.Money)}\nEndurance: {w.Endurance}");
                        btn.BackColor = Color.Brown;
                        break;
                    case null:
                        MessageBox.Show("NULL??");
                        break;
                }
            }
        }
        private void UpdateMovement()
        {
            foreach (var item in characters)
            {
                if (!((item is Human) && !(item is Zombie) && (item.Money <= 0)))
                {
                    item.X += random.Next(-1, 2);
                    item.Y += random.Next(-1, 2);
                }
            }
        }
        private void CreateGameGrid()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    var btn = new ButtonWith2Tags
                    {
                        Width = 20,
                        Height = 20,
                        Top = 20 * i,
                        Left = 20 * j,
                        Tag = (i, j),
                        Tag1 = i,
                        Tag2 = j,
                        Parent = this,
                        TabStop = false
                    };
                    pnlGame.Controls.Add(btn);
                }
            }
        }
    }
}
