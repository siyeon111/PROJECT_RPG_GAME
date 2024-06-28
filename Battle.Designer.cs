namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class Battle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ConverseImg = new System.Windows.Forms.PictureBox();
            PlayerImg = new System.Windows.Forms.PictureBox();
            MonsterImg = new System.Windows.Forms.PictureBox();
            lb_Atk = new System.Windows.Forms.Label();
            lb_Skill1 = new System.Windows.Forms.Label();
            lb_Run = new System.Windows.Forms.Label();
            lb_skill2 = new System.Windows.Forms.Label();
            lb_Text = new System.Windows.Forms.Label();
            PlayerAtkTime = new System.Windows.Forms.Timer(components);
            MonsterAtkTime = new System.Windows.Forms.Timer(components);
            playerhpbar = new System.Windows.Forms.ProgressBar();
            monsterhpbar = new System.Windows.Forms.ProgressBar();
            RunTime = new System.Windows.Forms.Timer(components);
            PlayerSkillTime = new System.Windows.Forms.Timer(components);
            HelperImg = new System.Windows.Forms.PictureBox();
            HelperWalkTime = new System.Windows.Forms.Timer(components);
            HelperAtkTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ConverseImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonsterImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HelperImg).BeginInit();
            SuspendLayout();
            // 
            // ConverseImg
            // 
            ConverseImg.Image = Resources.converse;
            ConverseImg.Location = new System.Drawing.Point(1, 313);
            ConverseImg.Name = "ConverseImg";
            ConverseImg.Size = new System.Drawing.Size(780, 150);
            ConverseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ConverseImg.TabIndex = 0;
            ConverseImg.TabStop = false;
            // 
            // PlayerImg
            // 
            PlayerImg.BackColor = System.Drawing.Color.Transparent;
            PlayerImg.Location = new System.Drawing.Point(156, 69);
            PlayerImg.Name = "PlayerImg";
            PlayerImg.Size = new System.Drawing.Size(145, 191);
            PlayerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            PlayerImg.TabIndex = 1;
            PlayerImg.TabStop = false;
            // 
            // MonsterImg
            // 
            MonsterImg.BackColor = System.Drawing.Color.Transparent;
            MonsterImg.Location = new System.Drawing.Point(426, 41);
            MonsterImg.Name = "MonsterImg";
            MonsterImg.Size = new System.Drawing.Size(274, 266);
            MonsterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            MonsterImg.TabIndex = 1;
            MonsterImg.TabStop = false;
            // 
            // lb_Atk
            // 
            lb_Atk.AutoSize = true;
            lb_Atk.BackColor = System.Drawing.Color.Transparent;
            lb_Atk.Font = new System.Drawing.Font("PokemonGSK2Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Atk.Location = new System.Drawing.Point(156, 340);
            lb_Atk.Name = "lb_Atk";
            lb_Atk.Size = new System.Drawing.Size(149, 37);
            lb_Atk.TabIndex = 2;
            lb_Atk.Text = "Attack";
            lb_Atk.Click += lb_Atk_Click;
            // 
            // lb_Skill1
            // 
            lb_Skill1.AutoSize = true;
            lb_Skill1.BackColor = System.Drawing.Color.Transparent;
            lb_Skill1.Font = new System.Drawing.Font("PokemonGSK2Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Skill1.Location = new System.Drawing.Point(156, 402);
            lb_Skill1.Name = "lb_Skill1";
            lb_Skill1.Size = new System.Drawing.Size(149, 37);
            lb_Skill1.TabIndex = 2;
            lb_Skill1.Text = "Skill1";
            lb_Skill1.Click += lb_Skill1_Click;
            // 
            // lb_Run
            // 
            lb_Run.AutoSize = true;
            lb_Run.BackColor = System.Drawing.Color.Transparent;
            lb_Run.Font = new System.Drawing.Font("PokemonGSK2Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Run.Location = new System.Drawing.Point(449, 340);
            lb_Run.Name = "lb_Run";
            lb_Run.Size = new System.Drawing.Size(83, 37);
            lb_Run.TabIndex = 2;
            lb_Run.Text = "Run";
            lb_Run.Click += lb_Run_Click;
            // 
            // lb_skill2
            // 
            lb_skill2.AutoSize = true;
            lb_skill2.BackColor = System.Drawing.Color.Transparent;
            lb_skill2.Font = new System.Drawing.Font("PokemonGSK2Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_skill2.Location = new System.Drawing.Point(449, 402);
            lb_skill2.Name = "lb_skill2";
            lb_skill2.Size = new System.Drawing.Size(149, 37);
            lb_skill2.TabIndex = 2;
            lb_skill2.Text = "Helper";
            lb_skill2.Click += lb_skill2_Click;
            // 
            // lb_Text
            // 
            lb_Text.AutoSize = true;
            lb_Text.BackColor = System.Drawing.Color.Transparent;
            lb_Text.Font = new System.Drawing.Font("PokemonGSK2Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Text.Location = new System.Drawing.Point(36, 340);
            lb_Text.Name = "lb_Text";
            lb_Text.Size = new System.Drawing.Size(33, 32);
            lb_Text.TabIndex = 3;
            lb_Text.Text = "-";
            lb_Text.Paint += lb_Text_Paint;
            // 
            // PlayerAtkTime
            // 
            PlayerAtkTime.Tick += PlayerAtkTime_Tick;
            // 
            // MonsterAtkTime
            // 
            MonsterAtkTime.Tick += MonsterAtkTime_Tick;
            // 
            // playerhpbar
            // 
            playerhpbar.Location = new System.Drawing.Point(156, 27);
            playerhpbar.Name = "playerhpbar";
            playerhpbar.Size = new System.Drawing.Size(145, 23);
            playerhpbar.TabIndex = 4;
            // 
            // monsterhpbar
            // 
            monsterhpbar.Location = new System.Drawing.Point(494, 12);
            monsterhpbar.Name = "monsterhpbar";
            monsterhpbar.Size = new System.Drawing.Size(145, 23);
            monsterhpbar.TabIndex = 5;
            // 
            // RunTime
            // 
            RunTime.Tick += RunTime_Tick;
            // 
            // PlayerSkillTime
            // 
            PlayerSkillTime.Tick += PlayerSkillTime_Tick;
            // 
            // HelperImg
            // 
            HelperImg.BackColor = System.Drawing.Color.Transparent;
            HelperImg.Location = new System.Drawing.Point(1, 69);
            HelperImg.Name = "HelperImg";
            HelperImg.Size = new System.Drawing.Size(140, 190);
            HelperImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            HelperImg.TabIndex = 1;
            HelperImg.TabStop = false;
            // 
            // HelperWalkTime
            // 
            HelperWalkTime.Tick += HelperWalkTime_Tick;
            // 
            // HelperAtkTime
            // 
            HelperAtkTime.Tick += HelperAtkTime_Tick;
            // 
            // Battle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(monsterhpbar);
            Controls.Add(playerhpbar);
            Controls.Add(lb_Text);
            Controls.Add(lb_skill2);
            Controls.Add(lb_Run);
            Controls.Add(lb_Skill1);
            Controls.Add(lb_Atk);
            Controls.Add(MonsterImg);
            Controls.Add(HelperImg);
            Controls.Add(PlayerImg);
            Controls.Add(ConverseImg);
            Name = "Battle";
            Text = "Battle";
            TopMost = true;
            FormClosed += Battle_FormClosed;
            Load += Battle_Load;
            Paint += Battle_Paint;
            ((System.ComponentModel.ISupportInitialize)ConverseImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)MonsterImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)HelperImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox ConverseImg;
        private System.Windows.Forms.PictureBox PlayerImg;
        private System.Windows.Forms.PictureBox MonsterImg;
        private System.Windows.Forms.Label lb_Atk;
        private System.Windows.Forms.Label lb_Skill1;
        private System.Windows.Forms.Label lb_Run;
        private System.Windows.Forms.Label lb_skill2;
        private System.Windows.Forms.Label lb_Text;
        private System.Windows.Forms.Timer PlayerAtkTime;
        private System.Windows.Forms.Timer MonsterAtkTime;
        private System.Windows.Forms.ProgressBar playerhpbar;
        private System.Windows.Forms.ProgressBar monsterhpbar;
        private System.Windows.Forms.Timer RunTime;
        private System.Windows.Forms.Timer PlayerSkillTime;
        private System.Windows.Forms.PictureBox HelperImg;
        private System.Windows.Forms.Timer HelperWalkTime;
        private System.Windows.Forms.Timer HelperAtkTime;
    }
}