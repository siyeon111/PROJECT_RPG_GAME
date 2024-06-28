using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8618 

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public class Monster : Obj
    {
        Random rand = new Random();
        public Image MonsterImg;
        public int CurHp;

        public enum MONTYPE
        {
            MON0, MON1, MON2, MON3, MON4, MON5, MON6, MON7, MON8, MON9, MON10, MON11, MON12, MON13, MON14, MON15
        }

        public Monster() { }
        public Monster(MONTYPE type)
        {
            switch (type)
            {
                case MONTYPE.MON0:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "우와아 하는 털뭉치", rand.Next(1, 3), rand.Next(1, 3), rand.Next(1, 3), rand.Next(1, 3));
                    MonsterImg = Resources._0_우와아하는털뭉치;
                    break;
                case MONTYPE.MON1:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "알미라즈", rand.Next(1, 3), rand.Next(1, 3), rand.Next(1, 3), rand.Next(1, 3));
                    MonsterImg = Resources._1_Almiraj;
                    break;
                case MONTYPE.MON2:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "심연의 닭", rand.Next(3, 5), rand.Next(3, 5), rand.Next(3, 4), rand.Next(3, 4));
                    MonsterImg = Resources._2_AbyssalChicken;
                    break;
                case MONTYPE.MON3:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "꼬꼬댁", rand.Next(2, 5), rand.Next(2, 4), rand.Next(3, 4), rand.Next(3, 4));
                    MonsterImg = Resources._3_Cackler;
                    break;
                case MONTYPE.MON4:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "다크멘틀", rand.Next(6, 8), rand.Next(6, 8), rand.Next(6, 8), rand.Next(6, 8));
                    MonsterImg = Resources._4_Darkmantle;
                    break;
                case MONTYPE.MON5:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "본리스", rand.Next(7, 13), rand.Next(7, 13), rand.Next(7, 13), rand.Next(7, 13));
                    MonsterImg = Resources._5_Boneless;
                    break;
                case MONTYPE.MON6:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "앙크헤그", rand.Next(11, 21), rand.Next(11, 21), rand.Next(11, 21), rand.Next(11, 21));
                    MonsterImg = Resources._6_Ankheg;
                    break;
                case MONTYPE.MON7:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "스펙터", rand.Next(17, 34), rand.Next(17, 34), rand.Next(17, 34), rand.Next(17, 34));
                    MonsterImg = Resources._7_Spectator;
                    break;
                case MONTYPE.MON8:
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "뼈 나가", rand.Next(28, 55), rand.Next(28, 55), rand.Next(28, 55), rand.Next(28, 55));
                    MonsterImg = Resources._8_BoneNaga;
                    break;
                case MONTYPE.MON9:
                    MonsterImg = Resources._9_ShamblingMound;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "꾸물거리는 둔덕", rand.Next(45, 89), rand.Next(45, 89), rand.Next(45, 89), rand.Next(45, 89));
                    break;
                case MONTYPE.MON10:
                    MonsterImg = Resources._10_Chasme;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "캐스미", rand.Next(72, 144), rand.Next(72, 144), rand.Next(72, 144), rand.Next(72, 144));
                    break;
                case MONTYPE.MON11:
                    MonsterImg = Resources._11_BlueSlaad;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "블루 슬라드", rand.Next(114, 233), rand.Next(114, 233), rand.Next(114, 233), rand.Next(114, 233));
                    break;
                case MONTYPE.MON12:
                    MonsterImg = Resources._12_YoungGreenDragon;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "어런 초록 용", rand.Next(189, 377), rand.Next(189, 377), rand.Next(189, 377), rand.Next(189, 377));
                    break;
                case MONTYPE.MON13:
                    MonsterImg = Resources._13_BoneDevil;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "뼈 악마", rand.Next(305, 610), rand.Next(305, 610), rand.Next(305, 610), rand.Next(305, 610));
                    break;
                case MONTYPE.MON14:
                    MonsterImg = Resources._14_Aboleth;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "아볼레스", rand.Next(1001, 1223), rand.Next(494, 987), rand.Next(494, 987), rand.Next(494, 987));
                    break;
                case MONTYPE.MON15:
                    MonsterImg = Resources._15_Remorhaz;
                    ObjInfo = new INFO
                        (OBJJTYPE.MONSTER, "라모레즈", rand.Next(1001, 1597), rand.Next(799, 1597), rand.Next(799, 1597), rand.Next(799, 1597));
                    break;
            }
            CurHp = ObjInfo.Hp;
        }

        public Image GetImg()
        {
            return MonsterImg;
        }




        protected override void Initialize()
        {


        }




    }
}
