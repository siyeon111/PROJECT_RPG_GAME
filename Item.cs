using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS8618 
namespace MINI_TEAM6_PROJECT_RPG_GAME
{

    public enum ITEMTYPE
    {
        STUFF,
        POTION
    }


    public class Item : Obj
    {

        public ITEMTYPE eType;
        public PictureBox ItemImg;
        public int idx;
        public Item() { }

        public Item(ITEMTYPE type, INFO info) : base(info)
        {
            eType = type;
            ItemImg = new PictureBox();
            idx = 0;
        }

        protected override void Initialize()
        {


        }


       public void ItemSet()
        {
            switch (eType)
            {
                case ITEMTYPE.STUFF:
                    ItemImg.Image = Resources.stone;
                    break;
                case ITEMTYPE.POTION:
                    ItemImg.Image = Resources.potion;
                    break;
            }
        }

    }
}
