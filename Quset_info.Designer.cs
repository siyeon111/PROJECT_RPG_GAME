namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class Quset_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quset_info));
            quest_1 = new System.Windows.Forms.Label();
            quest_2 = new System.Windows.Forms.Label();
            quest_3 = new System.Windows.Forms.Label();
            quest_4 = new System.Windows.Forms.Label();
            Dice = new System.Windows.Forms.ImageList(components);
            q_1_c = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            roll_cut = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            lb_monster_cont = new System.Windows.Forms.Label();
            bt_bar = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // quest_1
            // 
            quest_1.AutoSize = true;
            quest_1.BackColor = System.Drawing.Color.Transparent;
            quest_1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quest_1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            quest_1.Location = new System.Drawing.Point(62, 82);
            quest_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quest_1.Name = "quest_1";
            quest_1.Size = new System.Drawing.Size(366, 21);
            quest_1.TabIndex = 0;
            quest_1.Text = "-------------잠김-------------";
            // 
            // quest_2
            // 
            quest_2.AutoSize = true;
            quest_2.BackColor = System.Drawing.Color.Transparent;
            quest_2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quest_2.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            quest_2.Location = new System.Drawing.Point(62, 182);
            quest_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quest_2.Name = "quest_2";
            quest_2.Size = new System.Drawing.Size(366, 21);
            quest_2.TabIndex = 1;
            quest_2.Text = "-------------잠김-------------";
            // 
            // quest_3
            // 
            quest_3.AutoSize = true;
            quest_3.BackColor = System.Drawing.Color.Transparent;
            quest_3.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quest_3.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            quest_3.Location = new System.Drawing.Point(62, 282);
            quest_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quest_3.Name = "quest_3";
            quest_3.Size = new System.Drawing.Size(366, 21);
            quest_3.TabIndex = 2;
            quest_3.Text = "-------------잠김-------------";
            // 
            // quest_4
            // 
            quest_4.AutoSize = true;
            quest_4.BackColor = System.Drawing.Color.Transparent;
            quest_4.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quest_4.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            quest_4.Location = new System.Drawing.Point(62, 382);
            quest_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quest_4.Name = "quest_4";
            quest_4.Size = new System.Drawing.Size(366, 21);
            quest_4.TabIndex = 3;
            quest_4.Text = "-------------잠김-------------";
            // 
            // Dice
            // 
            Dice.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            Dice.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("Dice.ImageStream");
            Dice.TransparentColor = System.Drawing.Color.Transparent;
            Dice.Images.SetKeyName(0, "dice_1.png");
            Dice.Images.SetKeyName(1, "dice_2.png");
            Dice.Images.SetKeyName(2, "dice_3.png");
            Dice.Images.SetKeyName(3, "dice_4.png");
            Dice.Images.SetKeyName(4, "dice_5.png");
            Dice.Images.SetKeyName(5, "dice_6.png");
            // 
            // q_1_c
            // 
            q_1_c.BackColor = System.Drawing.SystemColors.ButtonShadow;
            q_1_c.BackgroundImage = (System.Drawing.Image)resources.GetObject("q_1_c.BackgroundImage");
            q_1_c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            q_1_c.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            q_1_c.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            q_1_c.Location = new System.Drawing.Point(482, 82);
            q_1_c.Margin = new System.Windows.Forms.Padding(2);
            q_1_c.Name = "q_1_c";
            q_1_c.Size = new System.Drawing.Size(100, 33);
            q_1_c.TabIndex = 4;
            q_1_c.Text = "변경";
            q_1_c.UseVisualStyleBackColor = false;
            q_1_c.Click += Dice_button_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            button1.Location = new System.Drawing.Point(482, 182);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 33);
            button1.TabIndex = 5;
            button1.Text = "변경";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            button2.Location = new System.Drawing.Point(482, 282);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 34);
            button2.TabIndex = 6;
            button2.Text = "변경";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // roll_cut
            // 
            roll_cut.AutoSize = true;
            roll_cut.BackColor = System.Drawing.Color.Transparent;
            roll_cut.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            roll_cut.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            roll_cut.Location = new System.Drawing.Point(23, 440);
            roll_cut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            roll_cut.Name = "roll_cut";
            roll_cut.Size = new System.Drawing.Size(106, 21);
            roll_cut.TabIndex = 8;
            roll_cut.Text = "변경 횟수";
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button4.BackgroundImage = (System.Drawing.Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button4.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            button4.Location = new System.Drawing.Point(491, 461);
            button4.Margin = new System.Windows.Forms.Padding(2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(100, 33);
            button4.TabIndex = 9;
            button4.Text = "치트";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lb_monster_cont
            // 
            lb_monster_cont.AutoSize = true;
            lb_monster_cont.BackColor = System.Drawing.Color.Transparent;
            lb_monster_cont.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_monster_cont.ForeColor = System.Drawing.Color.White;
            lb_monster_cont.Location = new System.Drawing.Point(23, 488);
            lb_monster_cont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_monster_cont.Name = "lb_monster_cont";
            lb_monster_cont.Size = new System.Drawing.Size(232, 21);
            lb_monster_cont.TabIndex = 10;
            lb_monster_cont.Text = "잡아야 하는 몬스터 수";
            // 
            // bt_bar
            // 
            bt_bar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            bt_bar.BackgroundImage = (System.Drawing.Image)resources.GetObject("bt_bar.BackgroundImage");
            bt_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            bt_bar.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bt_bar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            bt_bar.Location = new System.Drawing.Point(482, 382);
            bt_bar.Margin = new System.Windows.Forms.Padding(2);
            bt_bar.Name = "bt_bar";
            bt_bar.Size = new System.Drawing.Size(100, 33);
            bt_bar.TabIndex = 12;
            bt_bar.Text = "선술집";
            bt_bar.UseVisualStyleBackColor = false;
            bt_bar.Click += bt_bar_Click_1;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button3.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192);
            button3.Location = new System.Drawing.Point(306, 461);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(169, 33);
            button3.TabIndex = 13;
            button3.Text = "퀘스트 완료";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Quset_info
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(635, 524);
            Controls.Add(button3);
            Controls.Add(bt_bar);
            Controls.Add(lb_monster_cont);
            Controls.Add(button4);
            Controls.Add(roll_cut);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(q_1_c);
            Controls.Add(quest_4);
            Controls.Add(quest_3);
            Controls.Add(quest_2);
            Controls.Add(quest_1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Quset_info";
            Text = "Quset_info";
            Load += Quset_info_Load;
            Paint += Quset_info_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label quest_1;
        private System.Windows.Forms.Label quest_2;
        private System.Windows.Forms.Label quest_3;
        private System.Windows.Forms.Label quest_4;
        private System.Windows.Forms.ImageList Dice;
        private System.Windows.Forms.Button q_1_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label roll_cut;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_monster_cont;
        private System.Windows.Forms.Button bt_bar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}