namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playerImg = new System.Windows.Forms.PictureBox();
            MountainStage = new System.Windows.Forms.PictureBox();
            BossStage = new System.Windows.Forms.PictureBox();
            SpecialStage = new System.Windows.Forms.PictureBox();
            PlainStage = new System.Windows.Forms.PictureBox();
            DesertStage = new System.Windows.Forms.PictureBox();
            AbyssStage = new System.Windows.Forms.PictureBox();
            IslandStage = new System.Windows.Forms.PictureBox();
            ForestStage = new System.Windows.Forms.PictureBox();
            bt_Quest = new System.Windows.Forms.Button();
            MonDexImg = new System.Windows.Forms.PictureBox();
            bt_inven = new System.Windows.Forms.Button();
            LogText = new System.Windows.Forms.ListBox();
            playerhpbar = new System.Windows.Forms.ProgressBar();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)playerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MountainStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BossStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpecialStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlainStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DesertStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AbyssStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IslandStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForestStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MonDexImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // playerImg
            // 
            playerImg.BackColor = System.Drawing.Color.Transparent;
            playerImg.Image = Resources.player_walkRight;
            playerImg.Location = new System.Drawing.Point(835, 133);
            playerImg.Name = "playerImg";
            playerImg.Size = new System.Drawing.Size(150, 140);
            playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            playerImg.TabIndex = 0;
            playerImg.TabStop = false;
            playerImg.Click += playerImg_Click;
            // 
            // MountainStage
            // 
            MountainStage.BackColor = System.Drawing.Color.Transparent;
            MountainStage.Location = new System.Drawing.Point(385, 58);
            MountainStage.Name = "MountainStage";
            MountainStage.Size = new System.Drawing.Size(406, 167);
            MountainStage.TabIndex = 5;
            MountainStage.TabStop = false;
            MountainStage.Click += MountainStage_Click;
            // 
            // BossStage
            // 
            BossStage.BackColor = System.Drawing.Color.Transparent;
            BossStage.Location = new System.Drawing.Point(180, 446);
            BossStage.Name = "BossStage";
            BossStage.Size = new System.Drawing.Size(224, 219);
            BossStage.TabIndex = 6;
            BossStage.TabStop = false;
            BossStage.Click += BossStage_Click;
            // 
            // SpecialStage
            // 
            SpecialStage.BackColor = System.Drawing.Color.Transparent;
            SpecialStage.Location = new System.Drawing.Point(180, 280);
            SpecialStage.Name = "SpecialStage";
            SpecialStage.Size = new System.Drawing.Size(214, 160);
            SpecialStage.TabIndex = 6;
            SpecialStage.TabStop = false;
            SpecialStage.Click += SpecialStage_Click;
            // 
            // PlainStage
            // 
            PlainStage.BackColor = System.Drawing.Color.Transparent;
            PlainStage.Location = new System.Drawing.Point(410, 270);
            PlainStage.Name = "PlainStage";
            PlainStage.Size = new System.Drawing.Size(244, 213);
            PlainStage.TabIndex = 6;
            PlainStage.TabStop = false;
            PlainStage.Click += PlainStage_Click;
            // 
            // DesertStage
            // 
            DesertStage.BackColor = System.Drawing.Color.Transparent;
            DesertStage.Location = new System.Drawing.Point(542, 509);
            DesertStage.Name = "DesertStage";
            DesertStage.Size = new System.Drawing.Size(249, 137);
            DesertStage.TabIndex = 6;
            DesertStage.TabStop = false;
            DesertStage.Click += DesertStage_Click;
            // 
            // AbyssStage
            // 
            AbyssStage.BackColor = System.Drawing.Color.Transparent;
            AbyssStage.Location = new System.Drawing.Point(438, 661);
            AbyssStage.Name = "AbyssStage";
            AbyssStage.Size = new System.Drawing.Size(260, 124);
            AbyssStage.TabIndex = 6;
            AbyssStage.TabStop = false;
            AbyssStage.Click += AbyssStage_Click;
            // 
            // IslandStage
            // 
            IslandStage.BackColor = System.Drawing.Color.Transparent;
            IslandStage.Location = new System.Drawing.Point(826, 534);
            IslandStage.Name = "IslandStage";
            IslandStage.Size = new System.Drawing.Size(159, 230);
            IslandStage.TabIndex = 6;
            IslandStage.TabStop = false;
            IslandStage.Click += IslandStage_Click;
            // 
            // ForestStage
            // 
            ForestStage.BackColor = System.Drawing.Color.Transparent;
            ForestStage.Location = new System.Drawing.Point(684, 270);
            ForestStage.Name = "ForestStage";
            ForestStage.Size = new System.Drawing.Size(247, 213);
            ForestStage.TabIndex = 6;
            ForestStage.TabStop = false;
            ForestStage.Click += ForestStage_Click;
            // 
            // bt_Quest
            // 
            bt_Quest.BackColor = System.Drawing.Color.Transparent;
            bt_Quest.Image = Resources.quest;
            bt_Quest.Location = new System.Drawing.Point(1043, 114);
            bt_Quest.Name = "bt_Quest";
            bt_Quest.Size = new System.Drawing.Size(80, 80);
            bt_Quest.TabIndex = 8;
            bt_Quest.UseVisualStyleBackColor = false;
            bt_Quest.Click += bt_Quest_Click;
            // 
            // MonDexImg
            // 
            MonDexImg.BackColor = System.Drawing.Color.Transparent;
            MonDexImg.Image = Resources.Mondex;
            MonDexImg.Location = new System.Drawing.Point(1014, 23);
            MonDexImg.Name = "MonDexImg";
            MonDexImg.Size = new System.Drawing.Size(150, 85);
            MonDexImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            MonDexImg.TabIndex = 11;
            MonDexImg.TabStop = false;
            MonDexImg.Click += MonDexImg_Click;
            // 
            // bt_inven
            // 
            bt_inven.Image = Resources.inven;
            bt_inven.Location = new System.Drawing.Point(1043, 200);
            bt_inven.Name = "bt_inven";
            bt_inven.Size = new System.Drawing.Size(80, 80);
            bt_inven.TabIndex = 8;
            bt_inven.UseVisualStyleBackColor = true;
            bt_inven.Click += bt_inven_Click;
            // 
            // LogText
            // 
            LogText.BackColor = System.Drawing.Color.Gray;
            LogText.FormattingEnabled = true;
            LogText.ItemHeight = 15;
            LogText.Location = new System.Drawing.Point(991, 286);
            LogText.Name = "LogText";
            LogText.Size = new System.Drawing.Size(193, 469);
            LogText.TabIndex = 13;
            // 
            // playerhpbar
            // 
            playerhpbar.Location = new System.Drawing.Point(848, 114);
            playerhpbar.Name = "playerhpbar";
            playerhpbar.Size = new System.Drawing.Size(117, 23);
            playerhpbar.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Resources.Shop;
            pictureBox1.Location = new System.Drawing.Point(22, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(109, 106);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Location = new System.Drawing.Point(942, 786);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(222, 77);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Resources.World;
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(playerhpbar);
            Controls.Add(playerImg);
            Controls.Add(LogText);
            Controls.Add(MonDexImg);
            Controls.Add(bt_inven);
            Controls.Add(bt_Quest);
            Controls.Add(MountainStage);
            Controls.Add(PlainStage);
            Controls.Add(ForestStage);
            Controls.Add(SpecialStage);
            Controls.Add(BossStage);
            Controls.Add(IslandStage);
            Controls.Add(AbyssStage);
            Controls.Add(DesertStage);
            KeyPreview = true;
            Name = "MainGame";
            Text = "RPG";
            Load += MainGame_Load;
            Paint += MainGame_Paint;
            KeyDown += MainGame_KeyDown;
            KeyPress += MainGame_KeyPress;
            ((System.ComponentModel.ISupportInitialize)playerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)MountainStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)BossStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpecialStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlainStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)DesertStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)AbyssStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)IslandStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForestStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)MonDexImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox playerImg;
        private System.Windows.Forms.PictureBox MountainStage;
        private System.Windows.Forms.PictureBox BossStage;
        private System.Windows.Forms.PictureBox SpecialStage;
        private System.Windows.Forms.PictureBox PlainStage;
        private System.Windows.Forms.PictureBox DesertStage;
        private System.Windows.Forms.PictureBox AbyssStage;
        private System.Windows.Forms.PictureBox IslandStage;
        private System.Windows.Forms.PictureBox ForestStage;
        private System.Windows.Forms.Button bt_Quest;
        private System.Windows.Forms.PictureBox MonDexImg;
        private System.Windows.Forms.Button bt_inven;
        private System.Windows.Forms.ListBox LogText;
        private System.Windows.Forms.ProgressBar playerhpbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
