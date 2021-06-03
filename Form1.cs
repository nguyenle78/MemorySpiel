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

        string[] pbTag = { "_01", "_01", "_02", "_02" };
        Image[] pbImages = { Properties.Resources._01, Properties.Resources._02, Properties.Resources._01, Properties.Resources._02 };
        // Hardcoded tag, will change 
        PictureBox[] pictureBoxes = new PictureBox[4];

        public Form1()
        {
            InitializeComponent();
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            string[] pbTag = { "_01", "_01", "_02", "_02" };
            // Hardcoded tag, will change 
            shuffle(pbTag);
            for (int i = 0; i < pbTag.Length; i++)
            {
                pictureBoxes[i].Image = defaultImage;
                pictureBoxes[i].Tag = pbTag[i];
            }
        }

        private static void shuffle(string[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                string temp = array[i];
                int index = random.Next(0, array.Length);
                array[i] = array[index];
                array[index] = temp;
            }
        }

        private void flipImage(PictureBox pictureBox)
        {
            if (pictureBox.Image == defaultImage)
            {
                //pictureBox.Image = Properties.Resources.;

            }
            else
                pictureBox.Image = defaultImage;
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
            int i = Convert.ToInt32(pb.Name.Substring(10))-1;
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
