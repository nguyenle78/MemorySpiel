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
    public partial class GameSetiing : Form
    {
        public int gameMode;
        private String collection;

        public int GameMode { get => gameMode; set => gameMode = value; }
        public string Collection { get => collection; set => collection = value; }

        public GameSetiing()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    GameMode = 8;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    GameMode = 16;
                }
                else
                    GameMode = 24;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form1 newgame = new Form1(this, GameMode,Collection);
            newgame.Show();
            this.Hide();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close(); //Quit Program
        }

        private void pictureBoxCats_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Collection = "Cats";
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        
        private void pictureBoxDogs_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Collection = "Dogs";
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

    }
}
