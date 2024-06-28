using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    
    public class NPC : Obj
    {
        public NPC() { }
        public Image NPCImg;
        public int CurHp;

        public NPC(int type)
        {
            switch (type)
            {
                case 1:
                    NPCImg = Resources.NPC1;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
                case 2:
                    NPCImg = Resources.NPC2;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
                case 3:
                    NPCImg = Resources.NPC3;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
                case 4:
                    NPCImg = Resources.NPC4;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
                case 5:
                    NPCImg = Resources.NPC5;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
                case 6:
                    NPCImg = Resources.NPC6;
                    ObjInfo = new INFO
                    (OBJJTYPE.NONPLAYER, "NPC", 5, 5, 5, 5);
                    break;
            }
            CurHp = ObjInfo.Hp;
        }

        public Image GetImg()
        {
            return NPCImg;
        }

        protected override void Initialize()
        {


        }
    }
}
