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

        

        public Form1()
        {
            InitializeComponent();

            // Hardcoded tag, will change 
            pictureBox1.Tag = "01";
            pictureBox4.Tag = "01";
            pictureBox2.Tag = "02";

            List<int> numbers = new List<int>();


        }

        private void flip(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources._00;
        }

        private void compare(PictureBox box1, PictureBox box2)
        {
            if (box1.Tag == box2.Tag)
            {
                MessageBox.Show("gut", "gut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
            if (firstClicked == null)
            {
                pictureBox1.Image = Properties.Resources._01;
                firstClicked = pictureBox1;
            }
            else if (firstClicked != null && secondClicked == null)
            {
                pictureBox1.Image = Properties.Resources._01;
                secondClicked = pictureBox1;

                compare(firstClicked, secondClicked);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (firstClicked == null)
            {
                pictureBox4.Image = Properties.Resources._01;
                firstClicked = pictureBox4;
            }
            else if (firstClicked != null && secondClicked == null)
            {
                pictureBox4.Image = Properties.Resources._01;
                secondClicked = pictureBox4;

                compare(firstClicked, secondClicked);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (firstClicked == null)
            {
                pictureBox3.Image = Properties.Resources._02;
                firstClicked = pictureBox4;
            }
            else if (firstClicked != null && secondClicked == null)
            {
                pictureBox3.Image = Properties.Resources._02;
                secondClicked = pictureBox4;

                compare(firstClicked, secondClicked);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (firstClicked == null)
            {
                pictureBox2.Image = Properties.Resources._02;
                firstClicked = pictureBox2;
            }
            else if (firstClicked != null && secondClicked == null)
            {
                pictureBox2.Image = Properties.Resources._02;
                secondClicked = pictureBox2;

                compare(firstClicked, secondClicked);

            }
        }
    }
}
