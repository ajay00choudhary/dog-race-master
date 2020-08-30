using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class GamePlay : Form
    {
        public int players = 3;
        public int counter1 = 0;
        public int f1=0, f2=0, f3=0, f4=0;
        public int num;
        Joe object1 = new Joe();
        Bob object2 = new Bob();
        Al object3 = new Al();

        string s1, s2, s3;
        public GamePlay(string f,string g, string h)
        {
            InitializeComponent();
            s1 = f;
            s2 = g;
            s3 = h;

            JoeRadio1.Text = s1;
            BobRadio.Text = s2;
            AlRadio.Text = s3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RaceGroundPBox.ImageLocation = @"Images\first.png";
            RaceGroundPBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object1.amt = 50;
            object1.joe_bet_amt = 0;
            object1.joe_bet_runer = 0;
            object2.amt = 50;
            object2.bob_bet_amt = 0;
            object2.bob_bet_runer = 0;
            object3.amt = 50;
            object3.al_bet_amt = 0;
            object3.al_bet_runer = 0;

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

            FirstText.Text = "";
            SecondText.Text = "";
            ThirdText.Text = "";

            FirstPBox.Location = new Point(50, FirstPBox.Location.Y);
            SecondPBox.Location = new Point(50, SecondPBox.Location.Y);
            ThirdPBox.Location = new Point(50, ThirdPBox.Location.Y);
            FourthPBox.Location = new Point(50, FourthPBox.Location.Y);
            counter1 = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (object1.amt == 0)
            {
                numericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = object1.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object1.amt);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (object2.amt == 0)
            {
                numericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = object2.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object2.amt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (object3.amt == 0)
            {
                numericUpDown1.Value = 1;
                MaxBetAmtLabel.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = object3.amt;
                MaxBetAmtLabel.Text = Convert.ToString("$"+object3.amt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (JoeRadio1.Checked == true)
            {
                if (object1.joe_bet_runer != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    object1.joe_bet_amt = Convert.ToInt16(numericUpDown1.Value);
                    object1.joe_bet_runer = Convert.ToInt16(numericUpDown2.Value);
                    object1.amt = object1.amt - object1.joe_bet_amt;
                    MaxBetAmtLabel.Text = object1.amt.ToString();
                    FirstText.Text = s1+" bets $" + object1.joe_bet_amt + " on runer " + object1.joe_bet_runer;
                }
            }
            else if (BobRadio.Checked==true)
            {
                if (object2.bob_bet_runer != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    object2.bob_bet_amt = Convert.ToInt16(numericUpDown1.Value);
                    object2.bob_bet_runer = Convert.ToInt16(numericUpDown2.Value);
                    object2.amt = object2.amt - object2.bob_bet_amt;
                    MaxBetAmtLabel.Text = object2.amt.ToString();
                    SecondText.Text = s2+" bets $" + object2.bob_bet_amt + " on runer " + object2.bob_bet_runer;
                }
            }
            else if (AlRadio.Checked==true)
            {
                if (object3.al_bet_runer!=0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    object3.al_bet_amt = Convert.ToInt16(numericUpDown1.Value);
                    object3.al_bet_runer = Convert.ToInt16(numericUpDown2.Value);
                    object3.amt = object3.amt - object3.al_bet_amt;
                    MaxBetAmtLabel.Text = object3.amt.ToString();
                    ThirdText.Text = s3+" bets $" + object3.al_bet_amt + " on runer " + object3.al_bet_runer;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i;
            Random r = new Random();
            num = r.Next(1, 5);

            t1.Enabled = true;
            t2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 1)
            {
                f1 = 1;
                FirstPBox.Left = FirstPBox.Left + 95;
                counter1++;
            }
            else if (num==2)
            {
                f2 = 1;
                SecondPBox.Left = SecondPBox.Left + 95;
                counter1++;
            }
            else if (num==3)
            {
                f3 = 1;
                ThirdPBox.Left = ThirdPBox.Left + 95;
                counter1++;
            }
            else if(num==4)
            {
                f4 = 1;
                FourthPBox.Left = FourthPBox.Left + 95;
                counter1++;
            }
            if (counter1 == 7)
            {
                t1.Enabled = false;
                t2.Enabled = false;

                MessageBox.Show("Winning bet is " + num);

                if (object1.joe_bet_runer == num)
                {
                    object1.amt = object1.amt + object1.joe_bet_amt;
                }

                if (object2.bob_bet_runer == num)
                {
                    object2.amt = object2.amt + object2.bob_bet_amt;
                }

                if (object3.al_bet_runer == num)
                {
                    object3.amt = object3.amt + object3.al_bet_amt;
                }

                if (object1.amt == 0)
                {
                    JoeRadio1.Enabled = false;
                    FirstText.Text = "Busted";
                    FirstText.ForeColor = Color.Red;
                    players--;
                }

                if (object2.amt == 0)
                {
                    BobRadio.Enabled = false;
                    SecondText.Text = "Busted";
                    SecondText.ForeColor = Color.Red;
                    players--;
                }

                if (object3.amt == 0)
                {
                    AlRadio.Enabled = false;
                    ThirdText.Text = "Busted";
                    ThirdText.ForeColor = Color.Red;
                    players--;
                }

                if (players == 0)
                {
                    MessageBox.Show("All Players Lose");
                    JoeRadio1.Checked = false;
                    BobRadio.Checked = false;
                    AlRadio.Checked = false;
                    BetButton.Enabled = false;
                    GetSetButton.Enabled = false;
                }
                else if (players == 1)
                {
                    MessageBox.Show("Bet End");
                    JoeRadio1.Checked = false;
                    BobRadio.Checked = false;
                    AlRadio.Checked = false;
                    BetButton.Enabled = false;
                    GetSetButton.Enabled = false;
                }
                object1.joe_bet_amt = 0;
                object1.joe_bet_runer = 0;
                object2.bob_bet_amt = 0;
                object2.bob_bet_runer = 0;
                object3.al_bet_amt = 0;
                object3.al_bet_runer = 0;

                FirstText.Text = "";
                SecondText.Text = "";
                ThirdText.Text = "";

                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;

                FirstPBox.Location = new Point(50,FirstPBox.Location.Y);
                SecondPBox.Location = new Point(50, SecondPBox.Location.Y);
                ThirdPBox.Location = new Point(50, ThirdPBox.Location.Y);
                FourthPBox.Location = new Point(50, FourthPBox.Location.Y);
                counter1 = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (f1 == 1)
            {
                SecondPBox.Left = SecondPBox.Left + 65;
                ThirdPBox.Left = ThirdPBox.Left + 70;
                FourthPBox.Left = FourthPBox.Left + 80;
            }
            else if (f2 == 1)
            {
                FirstPBox.Left = FirstPBox.Left + 50;
                ThirdPBox.Left = ThirdPBox.Left + 75;
                FourthPBox.Left = FourthPBox.Left + 50;
            }
            else if (f3 == 1)
            {
                SecondPBox.Left = SecondPBox.Left + 50;
                FirstPBox.Left = FirstPBox.Left + 70;
                FourthPBox.Left = FourthPBox.Left + 80;
            }
            else if (f4==1)
            {
                SecondPBox.Left = SecondPBox.Left + 80;
                ThirdPBox.Left = ThirdPBox.Left + 85;
                FirstPBox.Left = FirstPBox.Left + 66;
            }
        }
    }
}
