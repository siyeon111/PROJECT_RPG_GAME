using System.Collections.Generic;
using System.Windows.Forms;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class taza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public List<TextBox> textboxlist;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taza));
            tbTaja = new TextBox();
            label1 = new Label();
            timermake = new Timer(components);
            timermove = new Timer(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // tbTaja
            // 
            tbTaja.BackColor = System.Drawing.Color.Fuchsia;
            tbTaja.ForeColor = System.Drawing.SystemColors.Window;
            tbTaja.Location = new System.Drawing.Point(282, 515);
            tbTaja.Name = "tbTaja";
            tbTaja.Size = new System.Drawing.Size(214, 23);
            tbTaja.TabIndex = 0;
            tbTaja.TextChanged += tbTaja_TextChanged;
            tbTaja.KeyDown += tbTaja_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Fuchsia;
            label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(660, 514);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 36);
            label1.TabIndex = 1;
            label1.Text = "score";
            label1.Click += label1_Click;
            // 
            // timermake
            // 
            timermake.Tick += timermake_Tick;
            // 
            // timermove
            // 
            timermove.Tick += timermove_Tick;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(129, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(440, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(0, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(799, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(53, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(159, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(224, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(265, 31);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(100, 23);
            textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(371, 12);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(100, 23);
            textBox8.TabIndex = 3;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(546, 31);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(100, 23);
            textBox9.TabIndex = 4;
            // 
            // textBox10
            // 
            textBox10.Location = new System.Drawing.Point(519, 11);
            textBox10.Name = "textBox10";
            textBox10.Size = new System.Drawing.Size(100, 23);
            textBox10.TabIndex = 6;
            // 
            // textBox11
            // 
            textBox11.Location = new System.Drawing.Point(307, 12);
            textBox11.Name = "textBox11";
            textBox11.Size = new System.Drawing.Size(100, 23);
            textBox11.TabIndex = 7;
            // 
            // textBox12
            // 
            textBox12.Location = new System.Drawing.Point(625, 12);
            textBox12.Name = "textBox12";
            textBox12.Size = new System.Drawing.Size(100, 23);
            textBox12.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Black;
            pictureBox2.Location = new System.Drawing.Point(0, 396);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(73, 10);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Black;
            pictureBox3.Location = new System.Drawing.Point(80, 396);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(73, 10);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Black;
            pictureBox4.Location = new System.Drawing.Point(159, 396);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(73, 10);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.Black;
            pictureBox5.Location = new System.Drawing.Point(238, 396);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(73, 10);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.Black;
            pictureBox6.Location = new System.Drawing.Point(317, 396);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(73, 10);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.Black;
            pictureBox7.Location = new System.Drawing.Point(396, 396);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(73, 10);
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = System.Drawing.Color.Black;
            pictureBox8.Location = new System.Drawing.Point(475, 396);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(73, 10);
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = System.Drawing.Color.Black;
            pictureBox9.Location = new System.Drawing.Point(554, 396);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(73, 10);
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = System.Drawing.Color.Black;
            pictureBox10.Location = new System.Drawing.Point(633, 396);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new System.Drawing.Size(73, 10);
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = System.Drawing.Color.Black;
            pictureBox11.Location = new System.Drawing.Point(712, 396);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(73, 10);
            pictureBox11.TabIndex = 9;
            pictureBox11.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(625, 484);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 15);
            label2.TabIndex = 10;
            label2.Text = "8개 이상 맞춰야 미션성공";
            // 
            // taza
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonShadow;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(797, 559);
            Controls.Add(label2);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox12);
            Controls.Add(textBox6);
            Controls.Add(textBox11);
            Controls.Add(textBox5);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(tbTaja);
            Controls.Add(pictureBox1);
            Name = "taza";
            Text = "taza";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbTaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timermake;
        private System.Windows.Forms.Timer timermove;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label label2;
    }
}