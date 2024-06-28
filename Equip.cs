using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public class Equip : Obj
    {

        Image image1;
        int Atk;
        int Hp;
        int Gold;

        public Equip(INFO equip)
        {
            this.ObjInfo = equip;


            if (ObjInfo.Name == "노멀소드")
            {
                image1 = Resources.노멀소드_이거_removebg_preview;
                Atk = ObjInfo.Atk;            
                Gold = ObjInfo.Gold;

            }
            if (ObjInfo.Name == "노멀실드")
            {
                image1 = Resources.노멀실드_removebg_preview;
                Hp = ObjInfo.Hp;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "바스타드소드")
            {
                image1 = Resources.바스타드_소드_이거_removebg_preview;
                Atk = ObjInfo.Atk;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "플레임실드")
            {
                image1 = Resources.플레임_실드_removebg_preview;
                Hp = ObjInfo.Hp;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "스톰 블레이드")
            {
                image1 = Resources.스톰블레이드11_removebg_preview;
                Atk = ObjInfo.Atk;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "아이스 실드")
            {
                image1 = Resources.아이스_실드_removebg_preview;
                Hp = ObjInfo.Hp;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "저주받은 검")
            {
                image1 = Resources.저주받은검_removebg_preview;
                Atk = ObjInfo.Atk;
                Gold = ObjInfo.Gold;
            }
            if (ObjInfo.Name == "드래곤 실드")
            {
                image1 = Resources.드래곤_실드_removebg_preview;
                Hp = ObjInfo.Hp;
                Gold = ObjInfo.Gold;
            }
        }

        public void Equipdata(string name, int hp, int atk, int gold)
        {
            ObjInfo.Name = name;
            ObjInfo.Hp = hp;
            ObjInfo.Atk = atk;
            ObjInfo.Gold = gold;



        }
        public class Equipdata1
        {

        }

        public Image GetImg()
        { return image1; }

        protected override void Initialize()
        {
            throw new NotImplementedException();
        }
      

        


    }

}
