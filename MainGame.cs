using System;
using System.Collections;
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

using CardMatching1;



namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class MainGame : Form
    {
        Quset_info quest;
        Inven inventory;
        Player player;
        PictureBox LastStage;




        Form2 Shop;

        bool questopenfirst = false;
        bool questvisible = false;

        bool Invenopenfirst = false;
        bool Invenvisible = false;


        bool Mondexopenfirst = false;
        bool Mondexvisible = false;

        bool shopopenfirst = false;
        bool shopvisible = false;

        bool clear = false;


        Stage CurStage;
        Monster_Form1 Mondex;
        ///////////////////////////////////////////////////////////////////초기화
        public MainGame()      //폼관련
        {
            InitializeComponent();

        }

        private void MainGame_Load(object sender, EventArgs e)     //사용자 정의 객체들 관련
        {
            this.Location = new Point(100, 0);
            player = new Player(playerImg, new INFO(OBJJTYPE.PLAYER, "플레이어", 10, 2, 10, 0, (846, 144)));   //start pos 846 144

            quest = new Quset_info();
            inventory = new Inven(player, LogText, quest);
            quest.SetInv(inventory);
            Item item = new Item(ITEMTYPE.POTION, new INFO(OBJJTYPE.ITEM, "포션", 5, 0));

            Mondex = new Monster_Form1();
            Shop = new Form2();
            Shop.PlayerSet(player);
            inventory.AddItem(item);


            player.playerinven = inventory;
            playerhpbar.Maximum = player.ObjInfo.Hp;
            playerhpbar.Value = player.CurHp;
        }


        ///////////////////////////////////////////////////////////////////스탯창 및 인벤등 조작.
        private void playerImg_Click(object sender, EventArgs e)
        {

            PlayerStatus StatUI = new PlayerStatus(player);
            StatUI.Show();
            StatUI.Location = new Point(player.ObjInfo.Position.x + 300, player.ObjInfo.Position.y - 30);
        }



        /////////////////////////////////////////////////////////////////// 전투

        //public void Battle()


        ///////////////////////////////////////////////////////////////////맵이동

        public void MovePoint(PictureBox stage, Player player, Point p)
        {
            if (LastStage != null)
                LastStage.Visible = true;
            player.Move(p.X, p.Y);
            stage.Visible = false;
            LastStage = stage;

        }


        private void MountainStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(MountainStage, player, MountainStage.Location);
            CurStage = new Stage(player, STAGETYPE.MOUNTAIN, MountainStage, quest);
        }

        private void PlainStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(PlainStage, player, PlainStage.Location);
            CurStage = new Stage(player, STAGETYPE.PLAIN, PlainStage, quest);
        }

        private void SpecialStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(SpecialStage, player, SpecialStage.Location);
            CurStage = new Stage(player, STAGETYPE.SPECAIL, SpecialStage, quest);
        }

        private void BossStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(BossStage, player, BossStage.Location);
            CurStage = new Stage(player, STAGETYPE.BOSS, BossStage, quest);
        }

        private void DesertStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(DesertStage, player, DesertStage.Location);
            CurStage = new Stage(player, STAGETYPE.DESERT, DesertStage, quest);
        }

        private void AbyssStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(AbyssStage, player, AbyssStage.Location);
            CurStage = new Stage(player, STAGETYPE.ABYSS, AbyssStage, quest);
        }

        private void IslandStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(IslandStage, player, IslandStage.Location);
            CurStage = new Stage(player, STAGETYPE.ISLAND, IslandStage, quest);
        }

        private void ForestStage_Click(object sender, EventArgs e)
        {
            player.Battle = true;
            MovePoint(ForestStage, player, ForestStage.Location);
            CurStage = new Stage(player, STAGETYPE.FOREST, ForestStage, quest);
        }

        private void bt_Quest_Click(object sender, EventArgs e)
        {

            if (questopenfirst == false)
                quest.Show();

            questopenfirst = true;


            if (questvisible == false)
                quest.Visible = true;
            else
                quest.Visible = false;

            questvisible = !questvisible;
        }

        private void bt_inven_Click(object sender, EventArgs e)
        {
            if (Invenopenfirst == false)
                inventory.Show();

            Invenopenfirst = true;


            if (Invenvisible == false)
                inventory.Visible = true;
            else
                inventory.Visible = false;

            Invenvisible = !Invenvisible;

        }

        private void MainGame_Paint(object sender, PaintEventArgs e)
        {

            if (clear == true)
            {
                this.Close();
            }

            if (quest.GameClear() == true)
            {
                clear = true;
                MessageBox.Show("게임클리어");
                Thread.Sleep(1000);
            }




            if (player.Battle == false)
            {
                playerhpbar.Visible = true;
                if (LastStage != null)
                    LastStage.Visible = true;
            }
            else
                playerhpbar.Visible = false;


            playerhpbar.Location = new Point(player.ObjInfo.Position.x, player.ObjInfo.Position.y - 40);
            playerhpbar.Maximum = player.ObjInfo.Hp;
            playerhpbar.Value = player.CurHp;





        }

        private void MonDexImg_Click(object sender, EventArgs e)
        {
            if (Mondexopenfirst == false)
                Mondex.Show();

            Mondexopenfirst = true;


            if (Mondexvisible == false)
                Mondex.Visible = true;
            else
                Mondex.Visible = false;

            Mondexvisible = !Mondexvisible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (shopopenfirst == false)
            { Shop.Show(); Shop.Location = new Point(300, 300); }

            shopopenfirst = true;


            if (shopvisible == false)
                Shop.Visible = true;
            else
                Shop.Visible = false;

            shopvisible = !shopvisible;
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
                inventory.AddItem(new Item(ITEMTYPE.POTION, new INFO(OBJJTYPE.ITEM, "포션", 100, 0)));
            if (e.KeyData == Keys.F2)
                inventory.AddItem(new Item(ITEMTYPE.POTION, new INFO(OBJJTYPE.ITEM, "포션", 500, 0)));
            if (e.KeyData == Keys.F3)
                inventory.AddItem(new Item(ITEMTYPE.POTION, new INFO(OBJJTYPE.ITEM, "포션", 5000, 0)));
            if (e.KeyData == Keys.F4)
            {
                inventory.AddItem(new Item(ITEMTYPE.STUFF, new INFO(OBJJTYPE.ITEM, "마물정수", 0, 0)));
                if (quest.CollectStuff())
                    quest.DiscountQuest();
            }
        }

        private void MainGame_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            taza t = new taza();
            t.Show();
        }





        ///////////////////////////////////////////////////////////////////





    }
}
