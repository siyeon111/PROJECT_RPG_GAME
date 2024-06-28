using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class bar : Form
    {
        Random rand = new Random();
        int quest = 0;
        NPC npcs;
        public static bool swi = true;
        public static bool end_vis;

        public bar(int x)
        {
            InitializeComponent();
            quest = x;
            button4.Visible = false;
            pc_roll.Visible = false;
            my_roll.Visible = false;
            end_vis = false;
            timer1.Stop();
            npc();
            q_what();
            label1.Visible = false;
        }

        // 퀘스트 정하기
        public void q_what()
        {
            if (quest == 3)
            {
                lb_say.Text = "내가 비켜야할 이유가 뭐지";
            }
            else if (quest == 4)
            {
                lb_say.Text = "게임에서 이기면 비켜주겠네";
            }
        }

        // npc 사진 
        public void npc()
        {
            npcs = new NPC(rand.Next(1, 5));
            pictureBox1.Image = npcs.NPCImg;
        }

        // 제안 받아들이기
        private void button2_Click(object sender, EventArgs e)
        {

            if (quest == 4)
            {
                if (swi == true)
                {
                    blackjack game1 = new blackjack();
                    game1.Visible = true;
                    swi = false;
                }
            }
            else if (quest == 3)
            {
                button4.Visible = true;
                label1.Visible = true;
            }
        }

        // 주사위 굴리기
        private void button4_Click(object sender, EventArgs e)
        {
            pc_roll.Visible = true;
            my_roll.Visible = true;

            int pc = rand.Next(0, 6);
            int my = rand.Next(0, 6);

            pc_roll.Image = imageList1.Images[pc];
            my_roll.Image = imageList1.Images[my];

            button4.Visible = false;

            if (pc <= my)
            {
                lb_say.Text = "설득했다";
                Quset_info.monster_cont = 0;
                button2.Visible = false;
                timer1.Start();
            }
            else
            {
                lb_say.Text = "돌아가게";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Quset_info.swi = true;
        }

        private void bar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Quset_info.swi = true;
        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {
            if (end_vis == true)
            {
                this.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            bar.end_vis = true;
            Quset_info.swi = true;
        }
    }
}
