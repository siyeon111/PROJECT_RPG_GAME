namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blackjack));
            bt_hit = new System.Windows.Forms.Button();
            bt_stand = new System.Windows.Forms.Button();
            lb_my = new System.Windows.Forms.Label();
            lb_pc = new System.Windows.Forms.Label();
            bt_exit = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_hit
            // 
            bt_hit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_hit.Location = new System.Drawing.Point(690, 369);
            bt_hit.Margin = new System.Windows.Forms.Padding(2);
            bt_hit.Name = "bt_hit";
            bt_hit.Size = new System.Drawing.Size(78, 20);
            bt_hit.TabIndex = 10;
            bt_hit.Text = "HIT";
            bt_hit.UseVisualStyleBackColor = true;
            bt_hit.Click += bt_hit_Click;
            // 
            // bt_stand
            // 
            bt_stand.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_stand.Location = new System.Drawing.Point(690, 399);
            bt_stand.Margin = new System.Windows.Forms.Padding(2);
            bt_stand.Name = "bt_stand";
            bt_stand.Size = new System.Drawing.Size(78, 20);
            bt_stand.TabIndex = 11;
            bt_stand.Text = "스탠드";
            bt_stand.UseVisualStyleBackColor = true;
            bt_stand.Click += bt_stand_Click;
            // 
            // lb_my
            // 
            lb_my.AutoSize = true;
            lb_my.BackColor = System.Drawing.Color.Transparent;
            lb_my.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_my.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lb_my.Location = new System.Drawing.Point(333, 333);
            lb_my.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_my.Name = "lb_my";
            lb_my.Size = new System.Drawing.Size(57, 30);
            lb_my.TabIndex = 13;
            lb_my.Text = "합계";
            // 
            // lb_pc
            // 
            lb_pc.AutoSize = true;
            lb_pc.BackColor = System.Drawing.Color.Transparent;
            lb_pc.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_pc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lb_pc.Location = new System.Drawing.Point(410, 187);
            lb_pc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_pc.Name = "lb_pc";
            lb_pc.Size = new System.Drawing.Size(57, 30);
            lb_pc.TabIndex = 14;
            lb_pc.Text = "합계";
            // 
            // bt_exit
            // 
            bt_exit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_exit.Location = new System.Drawing.Point(690, 493);
            bt_exit.Margin = new System.Windows.Forms.Padding(2);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new System.Drawing.Size(78, 20);
            bt_exit.TabIndex = 15;
            bt_exit.Text = "종료";
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(248, 187);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 30);
            label1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(510, 333);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 30);
            label2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(342, 223);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(120, 109);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // blackjack
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1019, 700);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_exit);
            Controls.Add(lb_pc);
            Controls.Add(lb_my);
            Controls.Add(bt_stand);
            Controls.Add(bt_hit);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "blackjack";
            Text = "game";
            FormClosing += blackjack_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button bt_hit;
        private System.Windows.Forms.Button bt_stand;
        private System.Windows.Forms.Label lb_my;
        private System.Windows.Forms.Label lb_pc;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}