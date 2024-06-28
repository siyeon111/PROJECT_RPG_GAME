using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8618 

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public class Player : Obj
    {
        public int CurHp;
        public int Lv { get; set; }
        public int LvUpValue;
        public bool Battle { get; set; }

        public Inven playerinven { get; set; }


        public enum PlayerState
        {
            Idle,
            Walk,
            WalkR,
            Attack
        }

        public Player() { }
        public Player(PictureBox p, INFO info) : base(info) { SetPicture(p); Initialize(); CurHp = ObjInfo.Hp; }

        protected override void Initialize()
        {
            PlayerImg = new Dictionary<string, Image>();
            PlayerImg.Add("Idle", Resources.player_idle);
            PlayerImg.Add("Walk", Resources.player_walk);
            PlayerImg.Add("Attack", Resources.player_atk);
            PlayerImg.Add("WalkR", Resources.player_walkRight);
            SetState(PlayerState.WalkR);
            Lv = 1;
            LvUpValue = 3;
            Battle = false;
        }

        public void SetPicture(PictureBox p)
        {
            playerpicbox = p;
        }

        public Image GetImg()
        {
            return playerpicbox.Image;
        }


        public void SetState(PlayerState estate)
        {
            switch (estate)
            {
                case PlayerState.Idle:
                    playerpicbox.Image = PlayerImg["Idle"];
                    break;
                case PlayerState.Walk:
                    playerpicbox.Image = PlayerImg["Walk"];
                    break;
                case PlayerState.WalkR:
                    playerpicbox.Image = PlayerImg["WalkR"];
                    break;
                case PlayerState.Attack:
                    playerpicbox.Image = PlayerImg["Attack"];
                    break;
                default:
                    break;

            }

        }

        public void Move(int x, int y)
        {
            ObjInfo.Position = (x, y);
            playerpicbox.Location = new Point(x, y);
            if (x < 400)
                SetState(PlayerState.Walk);
            else
                SetState(PlayerState.WalkR);
        }


        public void CheckLR()
        {
            if (ObjInfo.Position.x < 400)
                SetState(PlayerState.Walk);
            else
                SetState(PlayerState.WalkR);
        }

        public PictureBox GetPicBox()
        {
            return playerpicbox;
        }

        public bool LvUp(int exp)
        {
            ObjInfo.Exp += exp;
            if (ObjInfo.Exp >= LvUpValue)
            {
                ObjInfo.Exp = 0;
                ++Lv;
                LvUpValue *= 2;
                ObjInfo.Hp += 2;
                ObjInfo.Atk += 1;

                return true;
            }
            return false;
        }

        public void Reset()
        {
            CurHp = ObjInfo.Hp;
            Move(846, 144);
        }

        public void CureHp(int hp)
        {
            CurHp += hp;
            if (CurHp >= ObjInfo.Hp)
                CurHp = ObjInfo.Hp;
        }

        public void PlusHp(int hp)
        {
            ObjInfo.Hp += hp;
            CurHp = ObjInfo.Hp;
        }
        public void MinusHp(int hp)
        {
            ObjInfo.Hp -= hp;
            CurHp = ObjInfo.Hp;
        }


        Image NpcImg;
        PictureBox playerpicbox;
        Dictionary<string, Image> PlayerImg;

    }
}
