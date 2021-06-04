
namespace MemorySpiel
{
    partial class GameSetiing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelColection = new System.Windows.Forms.Label();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxCats = new System.Windows.Forms.PictureBox();
            this.pictureBoxDogs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColection
            // 
            this.labelColection.AutoSize = true;
            this.labelColection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColection.Location = new System.Drawing.Point(29, 74);
            this.labelColection.Name = "labelColection";
            this.labelColection.Size = new System.Drawing.Size(106, 25);
            this.labelColection.TabIndex = 0;
            this.labelColection.Text = "Collection: ";
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGameMode.Location = new System.Drawing.Point(29, 232);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(114, 25);
            this.labelGameMode.TabIndex = 1;
            this.labelGameMode.Text = "Game mode";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(40, 304);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(86, 36);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Weiter";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(197, 304);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(84, 36);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = "Ende";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4x2",
            "4x4",
            "4x6"});
            this.comboBox1.Location = new System.Drawing.Point(149, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 38);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBoxCats
            // 
            this.pictureBoxCats.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxCats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCats.Image = global::MemorySpiel.Properties.Resources._00;
            this.pictureBoxCats.Location = new System.Drawing.Point(141, 55);
            this.pictureBoxCats.Name = "pictureBoxCats";
            this.pictureBoxCats.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCats.TabIndex = 5;
            this.pictureBoxCats.TabStop = false;
            this.pictureBoxCats.Click += new System.EventHandler(this.pictureBoxCats_Click);
            this.pictureBoxCats.MouseLeave += new System.EventHandler(this.pictureBoxCats_MouseLeave);
            this.pictureBoxCats.MouseHover += new System.EventHandler(this.pictureBoxCats_MouseHover);
            // 
            // pictureBoxDogs
            // 
            this.pictureBoxDogs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxDogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDogs.Image = global::MemorySpiel.Properties.Resources.d1;
            this.pictureBoxDogs.Location = new System.Drawing.Point(260, 55);
            this.pictureBoxDogs.Name = "pictureBoxDogs";
            this.pictureBoxDogs.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxDogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDogs.TabIndex = 6;
            this.pictureBoxDogs.TabStop = false;
            this.pictureBoxDogs.MouseLeave += new System.EventHandler(this.pictureBoxCats_MouseLeave);
            this.pictureBoxDogs.MouseHover += new System.EventHandler(this.pictureBoxCats_MouseHover);
            // 
            // GameSetiing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 442);
            this.Controls.Add(this.pictureBoxDogs);
            this.Controls.Add(this.pictureBoxCats);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelGameMode);
            this.Controls.Add(this.labelColection);
            this.Name = "GameSetiing";
            this.Text = "GameSetiing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColection;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxCats;
        private System.Windows.Forms.PictureBox pictureBoxDogs;
    }
}