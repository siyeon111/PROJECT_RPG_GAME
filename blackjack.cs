using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class blackjack : Form
    {
        List<PictureBox> my_pic = new List<PictureBox>();
        List<PictureBox> pc_pic = new List<PictureBox>();
        int my_card = 0;    // 카드 합
        int pc_card = 0;
        bool timer = false;
        bool winlose = false;
        int x = 0;

        // 승리 패배
        public void winer()
        {
            if (my_card >= pc_card)
            {
                pictureBox1.Image = Resources.win;
                Quset_info.monster_cont = 0;
                winlose = true;
                timer2.Start();
            }
            else
            {
                pictureBox1.Image = Resources.lose;
                winlose = false;
                timer2.Start();
            }

            bust();

        }

        // 카드 생성
        public void picbox(int a)
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Size = new Size(169, 237);
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;

            if (a == 1)
            {
                pictureBox.Location = new Point(229 + x, 400);
                pictureBox.Image = card_draw(1);
                my_pic.Add(pictureBox);
            }
            else if (a == 2)
            {
                pictureBox.Location = new Point(727 - x, 44);
                pictureBox.Image = card_draw(2);
                pc_pic.Add(pictureBox);
            }

            x += 35;
            this.Controls.Add(pictureBox);

            sum();
            bust();
        }

        // 생성자
        public blackjack()
        {
            InitializeComponent();

            picbox(1);
            timer1.Start();
            timer2.Stop();
        }

        // 카드 뽑기
        public Image card_draw(int a)
        {
            Random rand = new Random();
            int ran = rand.Next(1, 13);

            switch (ran)
            {
                case 0:
                    if (a == 1)
                        my_card += 11;
                    else
                        pc_card += 11;
                    A11();
                    return Resources._1;
                case 1:
                    if (a == 1)
                        my_card += 2;
                    else
                        pc_card += 2;
                    return Resources._2;
                case 2:
                    if (a == 1)
                        my_card += 3;
                    else
                        pc_card += 3;
                    return Resources._3;
                case 3:
                    if (a == 1)
                        my_card += 4;
                    else
                        pc_card += 4;
                    return Resources._4;
                case 4:
                    if (a == 1)
                        my_card += 5;
                    else
                        pc_card += 5;
                    return Resources._5;
                case 5:
                    if (a == 1)
                        my_card += 6;
                    else
                        pc_card += 6;
                    return Resources._6;
                case 6:
                    if (a == 1)
                        my_card += 7;
                    else
                        pc_card += 7;
                    return Resources._7;
                case 7:
                    if (a == 1)
                        my_card += 8;
                    else
                        pc_card += 8;
                    return Resources._8;
                case 8:
                    if (a == 1)
                        my_card += 9;
                    else
                        pc_card += 9;
                    return Resources._9;
                case 9:
                    if (a == 1)
                        my_card += 10;
                    else
                        pc_card += 10;
                    return Resources._10;
                case 10:
                    if (a == 1)
                        my_card += 10;
                    else
                        pc_card += 10;
                    return Resources.J;
                case 11:
                    if (a == 1)
                        my_card += 10;
                    else
                        pc_card += 10;
                    return Resources.Q;
                case 12:
                    if (a == 1)
                        my_card += 10;
                    else
                        pc_card += 10;
                    return Resources.K;
            }
            return Resources._6;
        }

        // 카드 합 표시
        public void sum()
        {
            lb_my.Text = my_card.ToString();
            lb_pc.Text = pc_card.ToString();
        }

        // 버스트 및 블랙잭 확인
        public void bust()
        {
            if (my_card > 21)
            {
                timer = true;
                lb_my.Text = "버스트";
                bt_hit.Visible = false;
                bt_stand.Visible = false;
                timer1.Start();
                my_card = 0;
            }
            else if (my_card == 21)
            {
                lb_my.Text = "블랙잭";
                bt_hit.Visible = false;
                bt_stand.Visible = false;
                if (pc_card > 21 || pc_card < 21)
                {
                    timer = true;
                    timer1.Start();
                }
            }
            if (pc_card > 21)
            {
                lb_pc.Text = "버스트";
                pc_card = 0;
                if (my_card <= 21)
                {
                    timer = true;
                    timer1.Start();
                }
            }
            else if (pc_card == 21)
            {
                timer = true;
                lb_pc.Text = "블랙잭";
                bt_hit.Visible = false;
                bt_stand.Visible = false;
                timer1.Start();
            }
        }

        // 에이스 확인
        public void A11()
        {
            if (my_card > 21)
            {
                my_card -= 10;
            }
            if (pc_card > 21)
            {
                pc_card -= 10;
            }
        }

        // hit
        private void bt_hit_Click(object sender, EventArgs e)
        {
            bt_hit.Visible = false;
            bt_stand.Visible = false;
            picbox(1);
            timer1.Start();
        }

        // 스탠드
        private void bt_stand_Click(object sender, EventArgs e)
        {
            bt_hit.Visible = false;
            bt_stand.Visible = false;
            timer1.Start();
            timer = true;
            label2.Text = "스탠드";
        }

        //종료 버튼
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (pc_card < 15)
            {
                picbox(2);
                if (pc_card >= 15)
                {
                    label1.Text = "스탠드";
                }
            }
            else
            {
                label1.Text = "스탠드";
            }

            if (timer)
            {
                winer();
            }
            else
            {
                bt_hit.Visible = true;
                bt_stand.Visible = true;
            }

        }

        private void blackjack_FormClosing(object sender, FormClosingEventArgs e)
        {
            bar.swi = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

            if (winlose == true)
            {           
                this.Visible = false;
                bar.end_vis = true;
                Quset_info.swi = true;
            }
            else if (winlose == false)
            {
                this.Visible = false;
                bar.swi = true;
            }
        }
    }
}
