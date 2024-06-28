using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class Battle : Form
    {
        STAGETYPE eCurStage;

        Player player;
        Monster monster;

        bool monsterdie = false;
        bool monrealdie = false;
        bool playerdie = false;
        bool prealdie = false;

        bool test = false;
        bool test2 = false;
        int testcnt = 0;

        bool Runcheck = false;

        bool Helper = false;

        Form QuestForm;

        Point helperstart;

        public Battle(STAGETYPE curStage, Player P, Monster M, Form Quest)
        {
            InitializeComponent();
            QuestForm = Quest;
            eCurStage = curStage;
            player = P;
            monster = M;
            player.SetState(Player.PlayerState.Idle);
            PlayerImg.Image = player.GetImg();
            MonsterImg.Image = monster.GetImg();


            playerhpbar.Maximum = player.ObjInfo.Hp;
            playerhpbar.Value = player.CurHp;
            monsterhpbar.Maximum = monster.CurHp;
            monsterhpbar.Value = monster.CurHp;
            monsterdie = false;
            HelperImg.Visible = false;

            helperstart = HelperImg.Location;

        }


        private void Battle_Load(object sender, EventArgs e)
        {
            switch (eCurStage)
            {
                case STAGETYPE.FOREST:
                    this.BackgroundImage = Resources.Forest;
                    break;
                case STAGETYPE.MOUNTAIN:
                    this.BackgroundImage = Resources.mountain;
                    break;
                case STAGETYPE.DESERT:
                    this.BackgroundImage = Resources.Desert;
                    break;
                case STAGETYPE.ISLAND:
                    this.BackgroundImage = Resources.island;
                    break;
                case STAGETYPE.PLAIN:
                    this.BackgroundImage = Resources.Plain;
                    break;
                case STAGETYPE.ABYSS:
                    this.BackgroundImage = Resources.Abyss;
                    break;
                case STAGETYPE.SPECAIL:
                    this.BackgroundImage = Resources.special;
                    break;
                case STAGETYPE.BOSS:
                    this.BackgroundImage = Resources.Bossstage;
                    break;
                default:
                    break;
            }

            player.GetPicBox().Visible = false;
            lb_Text.Visible = false;
            lb_Text.Parent = ConverseImg;
            lb_Text.Location = new Point(20, 10);

            lb_Atk.Parent = ConverseImg;
            lb_Atk.Location = new Point(120, 25);
            lb_Skill1.Parent = ConverseImg;
            lb_Skill1.Location = new Point(460, 25);
            lb_skill2.Parent = ConverseImg;
            lb_skill2.Location = new Point(120, 90);
            lb_Run.Parent = ConverseImg;
            lb_Run.Location = new Point(460, 90);

        }

        public void BattleStart()
        {

        }

        private void Battle_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.CheckLR();
            player.GetPicBox().Visible = true;
            player.Battle = false;
        }


        private void Lboff()
        {
            lb_Atk.Visible = false;
            lb_Skill1.Visible = false;
            lb_skill2.Visible = false;
            lb_Run.Visible = false;
        }
        private void Lbon()
        {
            lb_Atk.Visible = true;
            lb_Skill1.Visible = true;
            lb_skill2.Visible = true;
            lb_Run.Visible = true;
        }



        private void lb_Atk_Click(object sender, EventArgs e)
        {

            PlayerImg.Image = Resources.player_atk;
            Lboff();
            lb_Text.Visible = true;
            lb_Text.Text = string.Format("{0}가 {1}의 데미지를 주었다..!", player.ObjInfo.Name, player.ObjInfo.Atk);
            PlayerAtkTime.Start();
            PlayerAtkTime.Interval = 2000;
        }

        private void PlayerAtkTime_Tick(object sender, EventArgs e)
        {
            PlayerImg.Image = Resources.player_idle;
            PlayerAtkTime.Stop();

            if (monster.CurHp > player.ObjInfo.Atk)
            {
                monster.CurHp -= player.ObjInfo.Atk;
                monsterhpbar.Value -= player.ObjInfo.Atk;
                MonsterAtk();
            }
            else
            {
                monster.CurHp = 0;
                monsterhpbar.Value = 0;
                monsterdie = true;
            }
        }

        private void MonsterAtk()
        {
            PlayerImg.Image = Resources.Player_Hitted;
            lb_Text.Text = string.Format("{0}가 {1}의 데미지를 주었다..!", monster.ObjInfo.Name, monster.ObjInfo.Atk);
            MonsterAtkTime.Start();
            MonsterAtkTime.Interval = 2170;

        }

        private void MonsterAtkTime_Tick(object sender, EventArgs e)
        {
            if (player.CurHp > monster.ObjInfo.Atk)
            {
                player.CurHp -= monster.ObjInfo.Atk;
                playerhpbar.Value -= monster.ObjInfo.Atk;
                PlayerImg.Image = Resources.player_idle;
                lb_Text.Visible = false;
                MonsterAtkTime.Stop();
            }
            else
            {
                player.CurHp = 0;
                playerhpbar.Value = 0;
                playerdie = true;
            }
            if (playerdie == false)
                Lbon();


        }

        private void Battle_Paint(object sender, PaintEventArgs e)
        {
            playerhpbar.Maximum = player.ObjInfo.Hp;
            playerhpbar.Value = player.CurHp;


            if (monrealdie == true)
            {
                monrealdie = false;

                if (Helper == true)
                {
                    lb_Text.Text += string.Format("치트키사용!!!!!!");
                    Helper = false;
                }

                Thread.Sleep(2000);
                Close();
            }
            if (monsterdie == true)
            {
                monsterdie = false;
                monrealdie = true;

               

                if (Helper == false)
                {
                    if (player.LvUp(monster.ObjInfo.Exp))
                    {
                        playerhpbar.Maximum = player.ObjInfo.Hp;
                        playerhpbar.Value = playerhpbar.Maximum;
                        lb_Text.Text = string.Format("{0} Level Up! {0}lv:{1}->{2}\n", player.ObjInfo.Name, player.Lv - 1, player.Lv);
                        player.ObjInfo.Gold += monster.ObjInfo.Gold;
                    }
                    else
                    {
                        player.ObjInfo.Gold += monster.ObjInfo.Gold;
                        lb_Text.Text = string.Format("{0}는 쓰러졌다...!\n", monster.ObjInfo.Name);
                        lb_Text.Text += string.Format("{0}의 경험치를 얻었다\n", monster.ObjInfo.Exp);
                        lb_Text.Text += string.Format("{0}의 골드를 얻었다\n", monster.ObjInfo.Gold);
                    }


                    if (eCurStage == STAGETYPE.BOSS)
                        ((Quset_info)QuestForm).clearboss();

                    if (((Quset_info)QuestForm).KillMonster())
                        ((Quset_info)QuestForm).DiscountQuest();


                    Random r = new Random();
                    int rd = r.Next(0, 2);
                    Item item;
                    if (rd == 0)
                        item = new Item(ITEMTYPE.POTION, new INFO(OBJJTYPE.ITEM, "포션", 5, 0));
                    else
                    {
                        item = new Item(ITEMTYPE.STUFF, new INFO(OBJJTYPE.ITEM, "마물정수", 0, 0));

                        if (((Quset_info)QuestForm).CollectStuff())
                            ((Quset_info)QuestForm).DiscountQuest();
                    }
                    player.playerinven.AddItem(item);

                    lb_Text.Text += string.Format("{0}를 얻었다\n", item.ObjInfo.Name);
                }
                else
                {
                    lb_Text.Text += string.Format("치트키사용!!!!!!");
                    if (eCurStage == STAGETYPE.BOSS)
                        ((Quset_info)QuestForm).clearboss();
                    if (((Quset_info)QuestForm).KillMonster())
                        ((Quset_info)QuestForm).DiscountQuest();
                }

            }

            if (test == true)
            {
                ++testcnt;
                if (testcnt > 2)
                {
                    test2 = true;
                    testcnt = 0;
                }

            }
            if (test2 == true)
            {
                test2 = false;
                HelperImg.Location = new Point(HelperImg.Location.X + 18, HelperImg.Location.Y);
            }

            if (prealdie == true)
            {
                prealdie = false;
                Thread.Sleep(1800);
                Close();
            }
            if (playerdie == true)
            {
                playerdie = false;
                prealdie = true;
                lb_Text.Text = string.Format("{0}는 눈앞이 캄캄해졌다...", player.ObjInfo.Name);
                player.Reset();
            }





        }


        private void lb_Run_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndnum = rnd.Next(0, 10);
            lb_Text.Visible = true;

            if (rndnum == 0 || rndnum == 1 || rndnum == 2)
            {
                Lboff();
                lb_Text.Text = "도망칠 수 없다..!";
            }
            else
            {
                Lboff();
                lb_Text.Text = "성공적으로 도망쳤다..!";
                PlayerImg.Image = Resources.player_walkRight;
                Runcheck = true;
            }

            RunTime.Start();
            RunTime.Interval = 2000;
        }

        private void RunTime_Tick(object sender, EventArgs e)
        {
            if (Runcheck == true)
            {
                lb_Text.Visible = false;
                Runcheck = false;
                Close();
                return;
            }
            MonsterAtk();
            Runcheck = false;
        }

        private void lb_Skill1_Click(object sender, EventArgs e)
        {
            PlayerImg.Image = Resources.Player_Skill;
            Lboff();
            lb_Text.Visible = true;
            lb_Text.Text = string.Format("{0}가 {1}의 스킬데미지를 주었다..!", player.ObjInfo.Name, player.ObjInfo.Atk * 3);
            PlayerSkillTime.Start();
            PlayerSkillTime.Interval = 4000;
        }

        private void PlayerSkillTime_Tick(object sender, EventArgs e)
        {
            PlayerImg.Image = Resources.player_idle;
            PlayerSkillTime.Stop();

            if (monster.CurHp > player.ObjInfo.Atk * 3)
            {
                monster.CurHp -= player.ObjInfo.Atk * 3;
                monsterhpbar.Value -= player.ObjInfo.Atk * 3;
                MonsterAtk();
            }
            else
            {
                monster.CurHp = 0;
                monsterhpbar.Value = 0;
                monsterdie = true;
            }
        }



        private void lb_skill2_Click(object sender, EventArgs e)
        {
            HelperImg.Visible = true;
            HelperImg.Image = Resources.helper_walk;
            Lboff();
            HelperWalkTime.Start();
            HelperWalkTime.Interval = 1000;
            PlayerImg.Visible = false;

            test = true;
        }

        private void HelperWalkTime_Tick(object sender, EventArgs e)
        {
            HelperWalkTime.Stop();
            HelperImg.Image = Resources.helper_attack;
            HelperAtkTime.Start();
            HelperAtkTime.Interval = 3400;
            test = false;
            lb_Text.Visible = true;
            lb_Text.Text = string.Format("{0}가 {1}의 데미지를 주었다..!", "Helper", 100000);
        }

        private void HelperAtkTime_Tick(object sender, EventArgs e)
        {
            HelperImg.Location = helperstart;
            HelperImg.Visible = false;
            PlayerImg.Visible = true;
            HelperAtkTime.Stop();

            if (monster.CurHp > 100000)
            {
                monster.CurHp -= 100000;
                monsterhpbar.Value -= 100000;
                MonsterAtk();
            }
            else
            {
                monster.CurHp = 0;
                monsterhpbar.Value = 0;
                monsterdie = true;
                Helper = true;
            }
        }

        private void lb_Text_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
