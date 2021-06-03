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
        private int timeClicked = 0;
        Image defaultImage = Properties.Resources._00;
        PictureBox firstClicked, secondClicked;

        string[] pbTag = { "_01", "_01", "_02", "_02", "_03", "_03", "_04", "_04", "_05", "_05" };
        Image[] pbImages = { Properties.Resources._01, Properties.Resources._01,
        Properties.Resources._02, Properties.Resources._02,
        Properties.Resources._03,Properties.Resources._03,
        Properties.Resources._04,Properties.Resources._04,
        Properties.Resources._05,Properties.Resources._05};

        PictureBox[] pictureBoxes = new PictureBox[10];
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

            shuffle(pictureBoxes);
            for (int i = 0; i < pbTag.Length; i++)
            {
                pictureBoxes[i].Image = defaultImage;
                pictureBoxes[i].Tag = pbTag[i];
            }
        }

        private static void shuffle(PictureBox[] pictureBoxes)
        {
            // Funktion to swap location of PictureBox
            Random random = new Random();
            Point temp = new Point();

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                temp = pictureBoxes[i].Location;
                int randomIndex = random.Next(0, pictureBoxes.Length);
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
