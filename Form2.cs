using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class Form2 : Form
    {
        List<PictureBox> piclist;
        List<Equip> equips;


        List<Label> labellist3;
        List<Label> labellist;
        List<Label> labellist1;
        List<Label> labellist2;
        Equip equip;
        public Equip currentEquip1;
        public Equip currentEquip2;

        Player player;

        public void PlayerSet(Player p)
        {
            player = p;
        }


        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;//윈도우테두리제거방법
           
            piclist = new List<PictureBox>();
            equips = new List<Equip>();
            labellist = new List<Label>();
            labellist1 = new List<Label>();
            labellist2 = new List<Label>();
            labellist3 = new List<Label>();




            Equip equip = new Equip(new INFO(OBJJTYPE.EQUIP, "노멀소드", 0, 1, 1)); // 공격력, 방어력, 골드//0노멀소드 공격력8노멀실드 방어1노멀소드 골드
            Equip equip1 = new Equip(new INFO(OBJJTYPE.EQUIP, "노멀실드", 3, 0, 1));//바스타드소드 공격력//플레임 실드 방어//노멀실드 골드
            Equip equip2 = new Equip(new INFO(OBJJTYPE.EQUIP, "바스타드소드", 0, 10, 1));//스톰 블레이드 공격//아이스실드 방어//마스타드소드 골드
            Equip equip3 = new Equip(new INFO(OBJJTYPE.EQUIP, "플레임실드", 15, 0, 1));//저주받은거 공격//드래곤 실드 방어//플레임실드 골드
            Equip equip4 = new Equip(new INFO(OBJJTYPE.EQUIP, "스톰 블레이드", 0, 50, 11));
            Equip equip5 = new Equip(new INFO(OBJJTYPE.EQUIP, "아이스 실드", 100, 0, 1));
            Equip equip6 = new Equip(new INFO(OBJJTYPE.EQUIP, "저주받은 검", 0, 1000, 1));
            Equip equip7 = new Equip(new INFO(OBJJTYPE.EQUIP, "드래곤 실드", 10000, 0, 1));


            equips.Add(equip);
            equips.Add(equip1);
            equips.Add(equip2);
            equips.Add(equip3);
            equips.Add(equip4);
            equips.Add(equip5);
            equips.Add(equip6);
            equips.Add(equip7);

            revice1.Parent = pictureBox1;
            revice1.Location = new Point(30, 40);
            revice2.Parent = pictureBox2;
            revice2.Location = new Point(30, 40);
            revice3.Parent = pictureBox3;
            revice3.Location = new Point(30, 40);
            revice4.Parent = pictureBox4;
            revice4.Location = new Point(30, 40);
            revice5.Parent = pictureBox5;
            revice5.Location = new Point(30, 40);
            revice6.Parent = pictureBox6;
            revice6.Location = new Point(30, 40);
            revice7.Parent = pictureBox7;
            revice7.Location = new Point(30, 40);
            revice8.Parent = pictureBox8;
            revice8.Location = new Point(30, 40);
            //revice5.Parent = pictureBox7;
            //revice5.Location = new Point(30, 40);
            //revice6.Parent = pictureBox8;
            //revice6.Location = new Point(30, 40);
            //revice7.Parent = pictureBox6;
            //revice7.Location = new Point(30, 40);
            //revice8.Parent = pictureBox5;
            //revice8.Location = new Point(30, 40);

            piclist.Add(revice1);
            piclist.Add(revice2);
            piclist.Add(revice3);
            piclist.Add(revice4);
            piclist.Add(revice5);
            piclist.Add(revice6);
            piclist.Add(revice7);
            piclist.Add(revice8);

            pbInventory1.Parent = Inventory1;
            pbInventory1.Location = new Point(30, 40);
            pbInventory2.Parent = Inventory2;
            pbInventory2.Location = new Point(30, 40);





            labellist3.Add(tbrevice1);
            labellist3.Add(tbrevice2);
            labellist3.Add(tbrevice3);
            labellist3.Add(tbrevice4);
            labellist3.Add(tbrevice5);
            labellist3.Add(tbrevice6);
            labellist3.Add(tbrevice7);
            labellist3.Add(tbrevice8);



            labellist.Add(lbHp1);
            labellist.Add(lbHp2);
            labellist.Add(lbHp3);
            labellist.Add(lbHp4);


            labellist1.Add(lbAtk1);
            labellist1.Add(lbAtk2);
            labellist1.Add(lbAtk3);
            labellist1.Add(lbAtk4);


            labellist2.Add(lbGold1);
            labellist2.Add(lbGold2);
            labellist2.Add(lbGold3);
            labellist2.Add(lbGold4);
            labellist2.Add(lbGold5);
            labellist2.Add(lbGold6);
            labellist2.Add(lbGold7);
            labellist2.Add(lbGold8);


            piclist[5].Image = equips[5].GetImg();
            for (int i = 0; i < 8; ++i)//왜++i
            {
                piclist[i].Image = equips[i].GetImg();

                labellist2[i].Text = equips[i].ObjInfo.Gold.ToString();
                labellist3[i].Text = equips[i].ObjInfo.Name;

            }


            labellist[0].Text = equips[1].ObjInfo.Hp.ToString();
            labellist[1].Text = equips[3].ObjInfo.Hp.ToString();
            labellist[2].Text = equips[5].ObjInfo.Hp.ToString();
            labellist[3].Text = equips[7].ObjInfo.Hp.ToString();
            labellist1[0].Text = equips[0].ObjInfo.Atk.ToString();
            labellist1[1].Text = equips[2].ObjInfo.Atk.ToString();
            labellist1[2].Text = equips[4].ObjInfo.Atk.ToString();
            labellist1[3].Text = equips[6].ObjInfo.Atk.ToString();









        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbrevice5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public bool BuyItme(int idx)
        {
            if (player.ObjInfo.Gold >= equips[idx].ObjInfo.Gold)
            {
                player.ObjInfo.Gold -= equips[idx].ObjInfo.Gold;

                player.ObjInfo.Atk += equips[idx].ObjInfo.Atk;
                player.PlusHp(equips[idx].ObjInfo.Hp);


                return true;
            }
            else
                return false;
        }

        public void SellItem(int idx)
        {
            player.ObjInfo.Gold += equips[idx].ObjInfo.Gold;

            lb_stext.Text = "판매 성공";
            player.ObjInfo.Atk -= equips[idx].ObjInfo.Atk;
            player.MinusHp(equips[idx].ObjInfo.Hp);

            if (idx % 2 == 0)
                SellSworldLbchange();
            else
                SellSheildLbchange();

        }


        public void SellSworldLbchange()
        {
            btnget1.Text = "구매";
            btnget3.Text = "구매";
            btnget5.Text = "구매";
            btnget7.Text = "구매";
        }

        public void SellSheildLbchange()
        {
            btnget2.Text = "구매";
            btnget4.Text = "구매";
            btnget6.Text = "구매";
            btnget8.Text = "구매";
        }

        private void btnget1_Click(object sender, EventArgs e)//장비1
        {
            if (currentEquip1 != null)
            {
                if (currentEquip1 == equips[0])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory1.Image = null;
                    lbrevicename1.Text = "";
                    lbInvenatk.Text = "";
                    lbInvengold1.Text = "";
                    currentEquip1 = null; // 선택된 장비 초기화
                    SellItem(0);
                }
            }
            else
            {
                if (BuyItme(0))
                {
                    btnget1.Text = "판매";
                    // 새 장비 선택
                    currentEquip1 = equips[0];
                    pbInventory1.Image = revice1.Image;
                    lbrevicename1.Text = tbrevice1.Text;
                    lbInvenatk.Text = lbAtk1.Text;
                    lbInvengold1.Text = lbGold1.Text;
                    lb_stext.Text = "구매 성공";
                }
                else
                {
                    lb_stext.Text = "소지금 부족";
                }
            }

        }

        private void btnget2_Click(object sender, EventArgs e)//방어1
        {
            if (currentEquip2 != null)
            {
                if (currentEquip2 == equips[1]) // 이미 선택된 방어 장비가 이 장비라면 초기화
                {
                    pbInventory2.Image = null;
                    lbrevicename2.Text = "";
                    lbInvenhp.Text = "";
                    lbInvengold2.Text = "";
                    currentEquip2 = null;
                    SellItem(1);
                }
            }
            else
            {

                // 방어 장비가 아직 선택되지 않았다면 선택
                if (BuyItme(1))
                {
                    btnget2.Text = "판매";
                    currentEquip2 = equips[1];
                    pbInventory2.Image = revice2.Image;
                    lbrevicename2.Text = tbrevice2.Text;
                    lbInvenhp.Text = lbHp1.Text;
                    lbInvengold2.Text = lbGold2.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }




        }
        private void button3_Click(object sender, EventArgs e)//장비2
        {

            if (currentEquip1 != null)
            {
                if (currentEquip1 == equips[2])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory1.Image = null;
                    lbrevicename1.Text = "";
                    lbInvenatk.Text = "";
                    lbInvengold1.Text = "";
                    currentEquip1 = null; // 선택된 장비 초기화
                    SellItem(2);
                }
            }
            else
            {

                // 새 장비 선택
                if (BuyItme(2))
                {
                    btnget3.Text = "판매"; currentEquip1 = equips[2];
                    pbInventory1.Image = revice3.Image;
                    lbrevicename1.Text = tbrevice3.Text;
                    lbInvenatk.Text = lbAtk2.Text;
                    lbInvengold1.Text = lbGold3.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }


        }

        private void btnget4_Click(object sender, EventArgs e)//방어2
        {
            if (currentEquip2 != null)
            {


                if (currentEquip2 == equips[3])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory2.Image = null;
                    lbrevicename2.Text = "";
                    lbInvenhp.Text = "";
                    lbInvengold2.Text = "";
                    currentEquip2 = null; // 선택된 장비 초기화
                    SellItem(3);
                }

            }
            else
            {
                // 새 장비 선택
                if (BuyItme(3))
                {
                    btnget4.Text = "판매"; currentEquip2 = equips[3];
                    pbInventory2.Image = revice4.Image;
                    lbrevicename2.Text = tbrevice4.Text;
                    lbInvenhp.Text = lbHp2.Text;
                    lbInvengold2.Text = lbGold4.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }

        }

        private void btnget5_Click(object sender, EventArgs e)//장비3
        {
            if (currentEquip1 != null)
            {
                if (currentEquip1 == equips[4])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory1.Image = null;
                    lbrevicename1.Text = "";
                    lbInvenatk.Text = "";
                    lbInvengold1.Text = "";
                    currentEquip1 = null; // 선택된 장비 초기화
                    SellItem(4);
                }

            }
            else
            {
                // 새 장비 선택
                if (BuyItme(4))
                {
                    btnget5.Text = "판매"; currentEquip1 = equips[4];
                    pbInventory1.Image = revice5.Image;
                    lbrevicename1.Text = tbrevice5.Text;
                    lbInvenatk.Text = lbAtk3.Text;
                    lbInvengold1.Text = lbGold5.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }

            //this.equip = equips[4];
            //Image reviceImage = revice5.Image;
            //string equipName = tbrevice5.Text;
            //string atkValue = lbAtk3.Text;
            //string goldValue = lbGold5.Text;


            //pbInventory1.Image = reviceImage;
            //lbrevicename1.Text = equipName;
            //lbInvenatk.Text = atkValue;
            //lbInvengold1.Text = goldValue;
        }

        private void btnget6_Click(object sender, EventArgs e)//방어3
        {
            // UpdateEquipmentSelection(pbInventory2, lbrevicename2, lbInvenhp, lbInvengold2, equips[5], ref currentEquip2);
            if (currentEquip2 != null)
            {
                if (currentEquip2 == equips[5])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory2.Image = null;
                    lbrevicename2.Text = "";
                    lbInvenhp.Text = "";
                    lbInvengold2.Text = "";
                    currentEquip2 = null; // 선택된 장비 초기화
                    SellItem(5);
                }

            }
            else
            {
                // 새 장비 선택
                if (BuyItme(5))
                {
                    btnget6.Text = "판매"; currentEquip2 = equips[5];
                    pbInventory2.Image = revice6.Image;
                    lbrevicename2.Text = tbrevice6.Text;
                    lbInvenhp.Text = lbHp3.Text;
                    lbInvengold2.Text = lbGold6.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }


        }

        private void btnget7_Click(object sender, EventArgs e)//장비4
        {
            // UpdateEquipmentSelection(pbInventory1, lbrevicename1, lbInvenatk, lbInvengold1, equips[6], ref currentEquip1);
            if (currentEquip1 != null)
            {
                if (currentEquip1 == equips[6])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory1.Image = null;
                    lbrevicename1.Text = "";
                    lbInvenatk.Text = "";
                    lbInvengold1.Text = "";
                    currentEquip1 = null; // 선택된 장비 초기화
                    SellItem(6);
                }

            }
            else
            {
                // 새 장비 선택
                if (BuyItme(6))
                {
                    btnget7.Text = "판매"; currentEquip1 = equips[6];
                    pbInventory1.Image = revice7.Image;
                    lbrevicename1.Text = tbrevice7.Text;
                    lbInvenatk.Text = lbAtk4.Text;
                    lbInvengold1.Text = lbGold7.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }
            //this.equip = equips[6];
            //Image reviceImage = revice7.Image;
            //string equipName = tbrevice7.Text;
            //string atkValue = lbAtk4.Text;
            //string goldValue = lbGold7.Text;


            //pbInventory1.Image = reviceImage;
            //lbrevicename1.Text = equipName;
            //lbInvenatk.Text = atkValue;
            //lbInvengold1.Text = goldValue;
        }

        private void btnget8_Click(object sender, EventArgs e)//방어4
        {
            // UpdateEquipmentSelection(pbInventory2, lbrevicename2, lbInvenhp, lbInvengold2, equips[7], ref currentEquip2);
            if (currentEquip2 != null)
            {


                if (currentEquip2 == equips[7])
                {
                    // 현재 선택된 장비가 이미 이 장비라면 초기화
                    pbInventory2.Image = null;
                    lbrevicename2.Text = "";
                    lbInvenhp.Text = "";
                    lbInvengold2.Text = "";
                    currentEquip2 = null; // 선택된 장비 초기화
                    SellItem(7);
                }

            }
            else
            {
                // 새 장비 선택
                if (BuyItme(7))
                {
                    btnget8.Text = "판매"; currentEquip2 = equips[7];
                    pbInventory2.Image = revice8.Image;
                    lbrevicename2.Text = tbrevice8.Text;
                    lbInvenhp.Text = lbHp4.Text;
                    lbInvengold2.Text = lbGold8.Text;
                }
                else
                    lb_stext.Text = "소지금 부족";
            }
            //equip = equips[7];
            //Image reviceImage = revice8.Image;
            //string equipName = tbrevice8.Text;
            //string hpValue = lbHp4.Text;
            //string goldValue = lbGold8.Text;

            //pbInventory2.Image = reviceImage;
            //lbrevicename2.Text = equipName;
            //lbInvenhp.Text = hpValue;
            //lbInvengold2.Text = goldValue;
        }

        private void revice5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            lb_pGold.Text = player.ObjInfo.Name + "의 소유골드:  " + player.ObjInfo.Gold;

        }
    }
}
