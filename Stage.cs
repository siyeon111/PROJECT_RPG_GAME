using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8618 

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public enum STAGETYPE
    {
        FOREST,
        MOUNTAIN,
        PLAIN,
        DESERT,
        ABYSS,
        ISLAND,
        SPECAIL,
        BOSS
    }

    public class Stage
    {
        public STAGETYPE eStage { get; set; }
        public PictureBox StageImg { get; set; }
        public Battle battleform;

        public Form Questform;


        public Stage(Player p, STAGETYPE est, PictureBox img ,Form quest) { player = p; eStage = est; StageImg = img; Questform = quest; Initalize(); }

        public void Initalize() //여기서 몬스터 생성.
        {
            Random r=   new Random();
            int rnd =  r.Next(0,2);
            switch (eStage)
            {
                case STAGETYPE.FOREST:
                    if(rnd == 0)
                    monster = new Monster(Monster.MONTYPE.MON0);
                   else
                        monster = new Monster(Monster.MONTYPE.MON1);
                    break;
                case STAGETYPE.MOUNTAIN:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON2);
                    else
                        monster = new Monster(Monster.MONTYPE.MON3);
                    break;
                case STAGETYPE.DESERT:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON4);
                    else
                        monster = new Monster(Monster.MONTYPE.MON5);
                    break;
                case STAGETYPE.ISLAND:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON6);
                    else
                        monster = new Monster(Monster.MONTYPE.MON7);
                    break;
                case STAGETYPE.PLAIN:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON8);
                    else
                        monster = new Monster(Monster.MONTYPE.MON9);
                    break;
                case STAGETYPE.ABYSS:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON10);
                    else
                        monster = new Monster(Monster.MONTYPE.MON11);
                    break;
                case STAGETYPE.SPECAIL:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON12);
                    else
                        monster = new Monster(Monster.MONTYPE.MON13);
                    break;
                case STAGETYPE.BOSS:
                    if (rnd == 0)
                        monster = new Monster(Monster.MONTYPE.MON14);
                    else
                        monster = new Monster(Monster.MONTYPE.MON15);
                    break;
                default:
                    break;

            }

           
            battleform = new Battle(eStage, player,monster,Questform);
            battleform.Show();

        }



        Player player;
        Monster monster;
    }
}
