using System.Timers;
using System;
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







namespace CardMatching1
{
    public partial class CardMatching : Form
    {
        List<int> numbers = new List<int>()
        { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16 };
        string FirstChoice;
        string SecondChioce;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int TotalTime = 120;
        int CountDownTime;
        bool gameOver = false;
        public CardMatching()
        {
            InitializeComponent();
            Loadpictures();
        }
        private void TimerEvent(object sender, EventArgs e)
        {
            CountDownTime--;
            label_Left.Text = "남은 시간:\n" + CountDownTime;
            if (CountDownTime < 1)
            {
                GameOver("Times Up, You Lose");
                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("1/" + (string)x.Tag + ".png");
                    }
                }
            }
        }
        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void Loadpictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;

            for (int i = 0; i < 32; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 100;
                newPic.Width = 100;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.BackColor = Color.Transparent;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);
                if (rows < 5)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 120;
                }
                if (rows == 5)
                {
                    leftPos = 20;
                    topPos += 120;
                    rows = 0;
                }
            }
            RestartGame();
        }
        private void NewPic_Click(object? sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (FirstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("1/" + (string)picA.Tag + ".png");
                    FirstChoice = (string)picA.Tag;
                }
            }
            else if (SecondChioce == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("1/" + (string)picB.Tag + ".png");
                    SecondChioce = (string)picB.Tag;
                }
            }
            else
                {
                    CheckPictures(picA, picB);
                }
        }
        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;
            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }
            tries = 0;
            label_Status.Text = "틀림 횟수: \n" + tries + " 번";
            label_Left.Text = "남은 시간:\n " + TotalTime;
            gameOver = false;
            timer.Start();
            CountDownTime = TotalTime;
        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (FirstChoice == SecondChioce)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                tries++;
                label_Status.Text = "Mismatched \n" + tries + " times";
            }
            FirstChoice = null;
            SecondChioce = null;
            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }
            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("Great Work, You Win!!!!");
            }
        }
        private void GameOver(string msg)
        {
            timer.Stop();
            gameOver = true;
            MessageBox.Show(" Click Restart to Play Again.");
        }
    }
}
