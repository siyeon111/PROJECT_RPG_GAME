using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{

    public enum OBJJTYPE
    {
        PLAYER,
        MONSTER,
        EQUIP,
        NONPLAYER,
        ITEM
    }


    public struct INFO
    {

        public INFO(OBJJTYPE t, string str, int hp, int atk, int gold, int exp, (int x, int y) pos )
        {
            this.Type = t;
            this.Name = str;
            this.Hp = hp;
            this.Atk = atk;
            this.Gold =gold;
            this.Exp = exp;
            this.Position = pos;
        }

        public INFO(OBJJTYPE t, string str, int hp, int atk)
        {
            this.Type = t;
            this.Name = str;
            this.Hp = hp;
            this.Atk = atk;
            this.Gold = 0;
            this.Exp = 0;
            this.Position = (0, 0);
        }

        public INFO(OBJJTYPE t, string str, int hp, int atk,int gold)
        {
            this.Type = t;
            this.Name = str;
            this.Hp = hp;
            this.Atk = atk;
            this.Gold = gold;
            this.Exp = 0;
            this.Position = (0, 0);
        }

        public INFO(OBJJTYPE t, string str, int hp, int atk, int gold, int exp)
        {
            this.Type = t;
            this.Name = str;
            this.Hp = hp;
            this.Atk = atk;
            this.Gold = gold;
            this.Exp = exp;
            this.Position = (0, 0);
        }
        public OBJJTYPE Type { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }
        public (int x, int y) Position { get; set; }
    }

    public abstract class Obj
    {
        public Obj() { }
        public Obj(INFO info) { ObjInfo = info; }


        protected abstract void Initialize();







        public INFO ObjInfo;
    }
}
