using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorySpiel
{
    public partial class Form1 : Form
    {
        private int gameMode;
        private Form parentForm;

        private Image defaultImage = Properties.Resources._00;
        private PictureBox firstClicked, secondClicked;

        string[] pbTag = { "_01", "_01", "_02", "_02", "_03", "_03", "_04", "_04",
                           "_05", "_05", "_06", "_06", "_07", "_07", "_08", "_08",
                           "_09", "_09", "_10", "_10", "_11", "_11", "_12", "_12"
        };

        private Image[] pbImages = {    Properties.Resources._01, Properties.Resources._01,
                                Properties.Resources._02, Properties.Resources._02,
                                Properties.Resources._03, Properties.Resources._03,
                                Properties.Resources._04, Properties.Resources._04,
                                Properties.Resources._05, Properties.Resources._05,
                                Properties.Resources._06, Properties.Resources._06,
                                Properties.Resources._07, Properties.Resources._07,
                                Properties.Resources._08, Properties.Resources._08,
                                Properties.Resources._09, Properties.Resources._09,
                                Properties.Resources._10, Properties.Resources._10,
                                Properties.Resources._11, Properties.Resources._11,
                                Properties.Resources._12, Properties.Resources._12
                           };

        private PictureBox[] pictureBoxes = new PictureBox[24];

        public int GameMode { get => gameMode; set => gameMode = value; }

        // Hardcoded tag, will change 

        public Form1()
        {
            InitializeComponent();
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;

            pictureBoxes[10] = pictureBox11;
            pictureBoxes[11] = pictureBox12;
            pictureBoxes[12] = pictureBox13;
            pictureBoxes[13] = pictureBox14;
            pictureBoxes[14] = pictureBox15;
            pictureBoxes[15] = pictureBox16;
            pictureBoxes[16] = pictureBox17;
            pictureBoxes[17] = pictureBox18;
            pictureBoxes[18] = pictureBox19;
            pictureBoxes[19] = pictureBox20;

            pictureBoxes[20] = pictureBox21;
            pictureBoxes[21] = pictureBox22;
            pictureBoxes[22] = pictureBox23;
            pictureBoxes[23] = pictureBox24;

            shuffle(pictureBoxes, 8);
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = defaultImage;
                pictureBoxes[i].Tag = pbTag[i];
            }

        }

        public Form1(Form parentForm, int gameMode)
        {
            GameMode = gameMode;
            this.parentForm = parentForm;
            InitializeComponent();

            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;

            pictureBoxes[10] = pictureBox11;
            pictureBoxes[11] = pictureBox12;
            pictureBoxes[12] = pictureBox13;
            pictureBoxes[13] = pictureBox14;
            pictureBoxes[14] = pictureBox15;
            pictureBoxes[15] = pictureBox16;
            pictureBoxes[16] = pictureBox17;
            pictureBoxes[17] = pictureBox18;
            pictureBoxes[18] = pictureBox19;
            pictureBoxes[19] = pictureBox20;

            pictureBoxes[20] = pictureBox21;
            pictureBoxes[21] = pictureBox22;
            pictureBoxes[22] = pictureBox23;
            pictureBoxes[23] = pictureBox24;

            shuffle(pictureBoxes, GameMode);
            for (int i = 0; i < GameMode; i++)
            {
                pictureBoxes[i].Image = defaultImage;
                pictureBoxes[i].Tag = pbTag[i];
                pictureBoxes[i].Show();
            }

            switch (gameMode)
            {
                case 8:
                    labelGameMode.Text = "Game Mode: 4x2" ;
                    break;
                case 16:
                    labelGameMode.Text = "Game Mode: 4x4";
                    break;
                case 24:
                    labelGameMode.Text = "Game Mode: 4x6";
                    break;
            }
        }

        private void loadImage(int gamemode)
        {

        }

        private static void shuffle(PictureBox[] pictureBoxes, int gameMode)
        {
            // Funktion to swap location of PictureBox
            Random random = new Random();
            Point temp = new Point();

            for (int i = 0; i < gameMode; i++)
            {
                temp = pictureBoxes[i].Location;
                int randomIndex = random.Next(0, gameMode);
                pictureBoxes[i].Location = pictureBoxes[randomIndex].Location;
                pictureBoxes[randomIndex].Location = temp;
            }
        }

        private void compare(PictureBox box1, PictureBox box2)
        {
            if (box1.Tag == box2.Tag)
            {
                MessageBox.Show("Match!", "Gratz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                firstClicked.Visible = false;
                secondClicked.Visible = false;

                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.Image = defaultImage;
            secondClicked.Image = defaultImage;

            firstClicked = null;
            secondClicked = null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Cast type PictureBox to sender-Object
            PictureBox pb = (PictureBox)sender;

            // Substring, extract the number behind the name picturebox1 -> 1 , 10 space, then -1 for index
            int i = Convert.ToInt32(pb.Name.Substring(10)) - 1;
            if (firstClicked == null)
            {
                pb.Image = pbImages[i];
                firstClicked = pb;
            }
            else if (firstClicked != null && secondClicked == null)
            {
                pb.Image = pbImages[i];
                secondClicked = pb;

                if (secondClicked.Equals(firstClicked))  // Compare 2 instance of object with Equals
                {
                    MessageBox.Show("Cheat", "Cheat");
                    firstClicked.Image = defaultImage;
                    secondClicked.Image = defaultImage;

                    firstClicked = null;
                    secondClicked = null;
                }
                else
                    compare(firstClicked, secondClicked);
            }
        }
    }
}
