using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardMatching1;


namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class Monster_Form1 : Form
    {
        public Monster_Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//윈도우테두리제거방법
            this.Location = new System.Drawing.Point(10, 10);
        }

        public static bool swi = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (swi)
            {
                Form1 form1 = new Form1(0);
                form1.Show();
                swi = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(1);
            form1.Show();
            swi = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(2);
            form1.Show();
            swi = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(3);
            form1.Show();
            swi = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(4);
            form1.Show();
            swi = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(5);
            form1.Show();
            swi = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(6);
            form1.Show();
            swi = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(7);
            form1.Show();
            swi = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(8);
            form1.Show();
            swi = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(9);
            form1.Show();
            swi = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(10);
            form1.Show();
            swi = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(11);
            form1.Show();
            swi = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(12);
            form1.Show();
            swi = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(13);
            form1.Show();
            swi = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(14);
            form1.Show();
            swi = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(15);
            form1.Show();
            swi = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardMatching temp = new CardMatching();
            temp.Show();
        }
    }
}
