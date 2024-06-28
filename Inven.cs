using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8618 
#pragma warning disable CS8619 
#pragma warning disable CS8602 

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class Inven : Form
    {

        int colcnt = 5;
        int rowcnt = 4;
        List<Item?>[] Itemlist;
        List<PictureBox>[] ivlist;
        ListBox LogText;
        Player player;

        Form Questform;

        public Inven(Player p, ListBox log, Form quest)
        {
            InitializeComponent();
            Questform = quest;
            this.FormBorderStyle = FormBorderStyle.None;//윈도우테두리제거방법

            Itemlist = new List<Item>[5];

            Itemlist[0] = new List<Item>();
            Itemlist[1] = new List<Item>();
            Itemlist[2] = new List<Item>();
            Itemlist[3] = new List<Item>();
            Itemlist[4] = new List<Item>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Itemlist[i].Add(null);
                }
            }

            LogText = log;
            player = p;
            Listcontrl();



        }
        private void Listcontrl()
        {
            ivlist = new List<PictureBox>[5];

            ivlist[0] = new List<PictureBox>();
            ivlist[1] = new List<PictureBox>();
            ivlist[2] = new List<PictureBox>();
            ivlist[3] = new List<PictureBox>();
            ivlist[4] = new List<PictureBox>();

            ivlist[0].Add(iv0);
            ivlist[0].Add(iv1);
            ivlist[0].Add(iv2);
            ivlist[0].Add(iv3);
            ivlist[1].Add(iv4);
            ivlist[1].Add(iv5);
            ivlist[1].Add(iv6);
            ivlist[1].Add(iv7);
            ivlist[2].Add(iv8);
            ivlist[2].Add(iv9);
            ivlist[2].Add(iv10);
            ivlist[2].Add(iv11);
            ivlist[3].Add(iv12);
            ivlist[3].Add(iv13);
            ivlist[3].Add(iv14);
            ivlist[3].Add(iv15);
            ivlist[4].Add(iv16);
            ivlist[4].Add(iv17);
            ivlist[4].Add(iv18);
            ivlist[4].Add(iv19);

        }

        public void AddItem(Item it)
        {
            int i = 0;
            int k = 0;
            while (true)
            {
                if (Itemlist[i][k] == null)
                {
                    Itemlist[i][k] = it;
                    it.idx = 5 * i + k;
                    it.ItemImg = ivlist[i][k];
                    break;
                }
                ++k;
                if (k == rowcnt)
                {
                    k = 0;
                    ++i;
                }
                if (i == colcnt) { break; }
            }

            it.ItemSet();

        }



        private void Inven_Load(object sender, EventArgs e)
        {
            this.Location = new Point(1300, 520);
        }


        public int checknumStuff()
        {
            int num = 0;
            for (int i = 0; i < colcnt; ++i)
            {
                for (int k = 0; k < rowcnt; ++k)
                {
                    if (Itemlist[i][k] != null)
                    {
                        if (Itemlist[i][k].eType == ITEMTYPE.STUFF)
                            ++num;
                    }
                }
            }
            return num;
        }

        public void deleteStuff(int cnt)
        {
            if (cnt == 0)
                return;
            int discnt = cnt;
            for (int i = 0; i < colcnt; ++i)
            {
                if (discnt == 0)
                {
                    LogText.Items.Add(string.Format("퀘스트{0}만큼의 마물정수 소모", cnt));
                    break;
                }
                for (int k = 0; k < rowcnt; ++k)
                {
                    if (Itemlist[i][k] != null)
                    {
                        if (Itemlist[i][k].eType == ITEMTYPE.STUFF)
                        {
                            Itemlist[i][k] = null;
                            ivlist[i][k].Image = null;
                            --discnt;
                            if (discnt == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }


        private void iv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < colcnt; ++i)
            {
                for (int k = 0; k < rowcnt; ++k)
                {
                    if (Itemlist[i][k] != null)
                    {
                        if (Itemlist[i][k].ItemImg == ((PictureBox)sender))
                        {
                            //실행해라 아이템 효과를 .
                            Item? it = Itemlist[i][k];
                            if (it.eType == ITEMTYPE.STUFF)
                            {
                                LogText.Items.Add(string.Format("{0}는 사용할 수 없는 아이템 입니다..", it.ObjInfo.Name));
                            }
                            else if (it.eType == ITEMTYPE.POTION)
                            {
                                LogText.Items.Add(string.Format("{0}을 사용하여 {1}만큼 회복했습니다.", it.ObjInfo.Name, it.ObjInfo.Hp));
                                Itemlist[i][k] = null;
                                ivlist[i][k].Image = null;
                                player.CureHp(it.ObjInfo.Hp);
                            }

                            return;
                        }
                    }
                }
            }
        }

        private void Inven_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}


