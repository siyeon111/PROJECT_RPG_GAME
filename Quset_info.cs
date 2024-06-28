using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{

    public partial class Quset_info : Form
    {
        Random rand = new Random();
        public int[] quest_list = new int[4];     // 퀘스트 값 저장
        public int[] dice_cut = new int[2] { 0, 4 }; // 확정 값 저장
        public static bool swi = true;      // 폼 1개만 열기
        public static bool[] q_clear = new bool[4];  // 클리어 할 시 true
        public static int cont = 0;                  // 클리어 카운트
        public static int monster_cont = 1;          // 몬스터 카운트
        bar ba;
        public int Stuffcnt = 0;
        bool Check = false;

        Form inven;


        public void DiscountQuest()
        {
            --monster_cont;
        }
        public void DiscntMon()
        {
            monster_cont = 0;
        }


        public void clearboss()
        {
            monster_cont = 0;
        }




        public bool KillMonster()
        {
            int i = 0;
            for (i = 0; i < 4; ++i)
            {
                if (q_clear[i] == false)
                    break;
            }

            if (quest_list[i] == 1)
                return true;
            else
                return false;

        }

        public bool CollectStuff()
        {
            int i = 0;
            for (i = 0; i < 4; ++i)
            {
                if (q_clear[i] == false)
                    break;
            }
            if (i == 4)
                return false;

            if (quest_list[i] == 2)
                return true;
            else
                return false;

        }

        public bool StuffEnd()
        {
            if (CollectStuff() == true)
            {
                if (monster_cont == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }





        // 퀘스트 배정 
        public string quest(int cut)
        {
            string quest0 = "-------------잠김-------------";
            string quest1 = "몬스터를 " + monster_cont + "마리 물리치세요";
            string quest2 = "몬스터의 부속품을 " + Stuffcnt + "개 모으세요";
            string quest3 = "낯선 사람을 설득하세요";
            string quest4 = "낯선 사람과 게임에서 이기세요";
            string quest5 = "모험의 끝입니다. \n최종보스를 쓰러트리세요.";
            string quest6 = "-------------해결-------------";


            if (cut == 0) return quest0;
            else if (cut == 1) return quest1;
            else if (cut == 2) return quest2;
            else if (cut == 3) return quest3;
            else if (cut == 4) return quest4;
            else if (cut == 5) return quest5;
            else if (cut == 6) return quest6;
            else return "알수없는 오류입니다.";
        }

        // 랜덤 퀘스트 생성
        public void ran_no(int N)
        {
            for (int i = (N - 1); i < N;)
            {
                int randNumber = rand.Next(1, 5);

                if (!Array.Exists(quest_list, x => x == randNumber))
                {
                    // 퀘스트 랜덤 배정 
                    if (i == 3)
                        quest_list[i] = 5;   // 최종보스
                    else
                        quest_list[i] = randNumber;

                    // 쓰러트려야 할 몬스터 수
                    monster_cont = rand.Next(3, 5);
                    if (quest_list[i] == 2)
                    {
                        Stuffcnt = monster_cont;

                    }
                    if (quest_list[i] == 3 || quest_list[i] == 4 || quest_list[i] == 5)
                    {
                        monster_cont = 1;
                    }

                    this.Controls["quest_" + (i + 1)].Text = quest(quest_list[i]);
                    lb_monster_cont.Text = "퀘스트 완료까지 : " + monster_cont.ToString();

                    //label1.Text = quest_list[i];

                    i++; // 중복이 아닌 퀘스트가 추가될 때만 i를 증가
                }

            }

            if (quest_list[cont] == 2)
            {
                monster_cont -= ((Inven)inven).checknumStuff();
                if (monster_cont < 0)
                { monster_cont = 0; }
            }

        }

        // 변경 제한 3회
        public void dice_roll(int x)
        {
            if (quest_list[x] != 0 && this.Controls["quest_" + (x + 1)].Text != quest(6))
            {
                if (dice_cut[0] < 4)
                {
                    ran_no(cont + 1);
                    this.Controls["quest_" + (x + 1)].Text = quest(quest_list[x]);
                    dice_cut[0] += 1;
                    dice_cut[1] -= 1;
                    roll_cut.Text = "변경 횟수 :" + dice_cut[1].ToString() + "회";
                }
            }
        }

        // 퀘스트 출력 (생성자)
        public Quset_info()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//윈도우테두리제거방법
            ran_no(cont + 1);
            roll_cut.Text = "변경 횟수 :" + dice_cut[1].ToString() + "회";
            q_what();

        }

        public void SetInv(Inven iv)
        {
            inven = iv;
        }



        // 1번 퀘스트 변경
        private void Dice_button_Click(object sender, EventArgs e)
        {
            dice_roll(0);
            q_what();
        }

        // 2번 퀘스트 변경
        private void button1_Click(object sender, EventArgs e)
        {
            dice_roll(1);
            q_what();
        }

        // 3번 퀘스트 변경
        private void button2_Click(object sender, EventArgs e)
        {
            dice_roll(2);
            q_what();
        }

        // 치트 (퀘스트 클리어 했을 시)
        private void button4_Click(object sender, EventArgs e)
        {
            /// 강제 몬스터 수 줄이기
            if (monster_cont > 0)
            {
                monster_cont--;

            }

            Q_clear();
            q_what();
        }


        public bool GameClear()
        {
            if (GetClearCnt() == 4)
                return true;
            else
                return false;
        }



        // 몬스터 잡아서 퀘스트
        public void Q_clear()
        {

            // 몬스터를 다 잡으면 다음 퀘스트 해금
            if (monster_cont <= 0)
            {
                //퀘스트 클리어   
                if (cont < 3)
                {
                    ran_no(cont + 2);
                    this.Controls["quest_" + (cont + 1)].Text = quest(6);
                    q_clear[cont] = true;
                    cont++;
                }
                else
                {
                    quest_4.Text = quest(6);
                    q_clear[3] = true;
                }
            }



        }

        public int GetClearCnt()
        {
            int cnt = 0;
            for (int i = 0; i < 4; ++i)
            {
                if (q_clear[i] == true)
                    cnt++;
            }

            return cnt;
        }




        // 선술집
        public void q_what()
        {
            if (quest_list[cont] == 3 || quest_list[cont] == 4)
            {
                bt_bar.Visible = true;
            }
            else
            {
                bt_bar.Visible = false;
            }
        }

        private void Quset_info_Load(object sender, EventArgs e)
        {
            this.Location = new Point(1300, 0);
        }

        // 선술집
        private void bt_bar_Click_1(object sender, EventArgs e)
        {
            if (swi)
            {
                ba = new bar(quest_list[cont]);
                ba.Visible = true;
                swi = false;
            }
        }

        // 퀘스트 완료
        private void button3_Click(object sender, EventArgs e)
        {

            if (monster_cont < 0)
            {
                MessageBox.Show("조건을 만족하지 못했습니다.");
            }
            else
            {
                if (StuffEnd() == true)
                {
                    ((Inven)inven).deleteStuff(Stuffcnt);
                }
                Q_clear();
                q_what();
            }

        }

        private void Quset_info_Paint(object sender, PaintEventArgs e)
        {
            if (monster_cont < 0)
                monster_cont = 0;
            StuffEnd();

            lb_monster_cont.Text = "퀘스트 완료까지 : " + monster_cont.ToString();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_monster_cont.Text = "퀘스트 완료까지 : " + monster_cont.ToString();
        }
    }
}
