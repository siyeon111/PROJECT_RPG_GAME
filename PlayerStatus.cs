using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class PlayerStatus : Form
    {
        Player player;
        public PlayerStatus()
        {
            InitializeComponent();
        }

        public PlayerStatus(Player p)
        {
            InitializeComponent();

            player = p;

            lb_Name.Parent = StatUIImg;
            lb_Exp.Parent = StatUIImg;
            lb_Level.Parent = StatUIImg;
            lb_Hp.Parent = StatUIImg;
            lb_Attack.Parent = StatUIImg;

            lb_Name.Text = player.ObjInfo.Name;
            lb_Exp.Text = player.ObjInfo.Exp.ToString();
            lb_Level.Text = player.Lv.ToString();
            lb_Hp.Text = player.ObjInfo.Hp.ToString();
            lb_Attack.Text = player.ObjInfo.Atk.ToString();

        }




       
    }
}
