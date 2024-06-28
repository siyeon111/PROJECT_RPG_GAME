using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class taza : Form
    {
        List<string> textlist;
        public int count = 0;
        public int makecount = 0;
        bool bend = false;
        public taza()
        {
            InitializeComponent();
            textlist = new List<string>
        {
          "비누",
          "보리보리쌀",
          "게임",
          "프로젝트",
          "컴퓨터",
          "모블",
          "파이썬",
          "인공지능",
          "저주받은검",
          "드래곤길들이기",
          "쉬는시간",
          "미니게임"
        };

            textboxlist = new List<TextBox>();

            //  List <string>.Add (string);
            //  textlist.Add(string.string);

            textboxlist.Add(textBox1);
            textboxlist.Add(textBox2);
            textboxlist.Add(textBox3);
            textboxlist.Add(textBox4);
            textboxlist.Add(textBox5);
            textboxlist.Add(textBox6);
            textboxlist.Add(textBox7);
            textboxlist.Add(textBox8);
            textboxlist.Add(textBox9);
            textboxlist.Add(textBox10);
            textboxlist.Add(textBox11);
            textboxlist.Add(textBox12);
            Random random = new Random();

            for (int i = 0; i < textlist.Count; i++)
            {
                int randnum = random.Next(12, 625);
                textboxlist[i].Text = textlist[i];
                textboxlist[i].Visible = false;
                textboxlist[i].Location = new Point(randnum, 12);
            }

            timermake.Start();
            timermake.Interval = 2000;

            timermove.Start();
            timermake.Interval = 1000;



        }

        private void tbTaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void timermake_Tick(object sender, EventArgs e)
        {
            if (makecount <= 11)
            {
                textboxlist[makecount].Visible = true;
                makecount++;
            }

            if(makecount==12 &&bend ==false)
            {
                int cnt = 0;
                for (int i = 0; i < textlist.Count; i++)
                {
                    if (textboxlist[i].Visible == false)
                        ++cnt;
                }

                if (cnt == 12)
                {
                    int a = 0;
                    int.TryParse(label1.Text, out a);

                    if (a > 7)
                    {
                        label1.Text = "미션 성공";
                    }
                    else
                    {
                        label1.Text = "미션 실패";
                    }
                        bend = true;
                }
            }

            
           


        }

        private void timermove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < textboxlist.Count; i++)
            {
                if (textboxlist[i].Visible == true)
                {
                    textboxlist[i].Location = new Point(textboxlist[i].Location.X, textboxlist[i].Location.Y + 5);
                }
                if (textboxlist[i].Location.Y > 363)
                {
                    textboxlist[i].Visible = false;
                }

            }


        }

        private void tbTaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < textlist.Count; i++)
                {
                    if (tbTaja.Text == textboxlist[i].Text && textboxlist[i].Visible == true)
                    {
                        textboxlist[i].Visible = false;
                        count++;
                        tbTaja.Text = "";
                        label1.Text = count.ToString();



                        break;


                    }
                    else
                    {

                    }
                   

                }



            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
