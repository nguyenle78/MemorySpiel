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
        private int timeClicked = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void flip(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources._00;
        }
        private void compare(PictureBox box1, PictureBox box2)
        {
            if (box1.Image.Tag == box2.Image.Tag)
            {
                MessageBox.Show("gut", "gut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                box1.Enabled = false;
                box2.Enabled = false;
            }
            else
            {
                flip(box1);
                flip(box2);
                MessageBox.Show("falsch", "flasch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void click(PictureBox pictureBox, String tag)
        {
            if ((timeClicked % 2) == 0)
            {
                pictureBox1.Image = Properties.Resources._02;
                pictureBox1.Image.Tag = tag;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._00;
                pictureBox1.Image.Tag = "00";
            }
            timeClicked++;
            labelTimeClicked.Text = "Time Clicked: " + timeClicked.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((timeClicked % 2) == 0)
            {
                pictureBox1.Image = Properties.Resources._01;
                pictureBox1.Image.Tag = "01";
            }
            else
            {
                pictureBox1.Image = Properties.Resources._00;
                pictureBox1.Image.Tag = "00";
            }
            timeClicked++;
            labelTimeClicked.Text = "Time Clicked: " + timeClicked.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if ((timeClicked % 2) == 0)
            {
                pictureBox4.Image = Properties.Resources._02;
                pictureBox4.Image.Tag = "02";
            }
            else
            {
                pictureBox4.Image = Properties.Resources._00;
                pictureBox4.Image.Tag = "00";
            }
            timeClicked++;
            labelTimeClicked.Text = "Time Clicked: " + timeClicked.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool clicked;
            if ((timeClicked % 2) == 0)
            {
                clicked = false;
            }
            else
            {
                clicked = true;
            }
            if (clicked == false)
            {
                pictureBox2.Image = Properties.Resources._01;
                pictureBox2.Image.Tag = "01";
            }
            else
            {
                pictureBox2.Image = Properties.Resources._00;
                pictureBox2.Image.Tag = "00";
            }
            timeClicked++;
            labelTimeClicked.Text = "Time Clicked: " + timeClicked.ToString();
        }
    }
}
