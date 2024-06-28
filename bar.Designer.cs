namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class bar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bar));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            lb_say = new System.Windows.Forms.Label();
            pc_roll = new System.Windows.Forms.PictureBox();
            my_roll = new System.Windows.Forms.PictureBox();
            button4 = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_roll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)my_roll).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(250, 46);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(215, 311);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(267, 418);
            button2.Margin = new System.Windows.Forms.Padding(2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(162, 62);
            button2.TabIndex = 2;
            button2.Text = "시도하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(8, 7);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(117, 29);
            button3.TabIndex = 3;
            button3.Text = "나가기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lb_say
            // 
            lb_say.AutoSize = true;
            lb_say.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_say.Location = new System.Drawing.Point(250, 312);
            lb_say.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_say.Name = "lb_say";
            lb_say.Size = new System.Drawing.Size(42, 21);
            lb_say.TabIndex = 4;
            lb_say.Text = "대사";
            // 
            // pc_roll
            // 
            pc_roll.BackColor = System.Drawing.Color.Transparent;
            pc_roll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pc_roll.Location = new System.Drawing.Point(568, 96);
            pc_roll.Margin = new System.Windows.Forms.Padding(2);
            pc_roll.Name = "pc_roll";
            pc_roll.Size = new System.Drawing.Size(83, 68);
            pc_roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pc_roll.TabIndex = 5;
            pc_roll.TabStop = false;
            // 
            // my_roll
            // 
            my_roll.BackColor = System.Drawing.Color.Transparent;
            my_roll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            my_roll.Location = new System.Drawing.Point(568, 303);
            my_roll.Margin = new System.Windows.Forms.Padding(2);
            my_roll.Name = "my_roll";
            my_roll.Size = new System.Drawing.Size(83, 68);
            my_roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            my_roll.TabIndex = 6;
            my_roll.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(444, 418);
            button4.Margin = new System.Windows.Forms.Padding(2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(83, 28);
            button4.TabIndex = 7;
            button4.Text = "설득하기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "dice_1.png");
            imageList1.Images.SetKeyName(1, "dice_2.png");
            imageList1.Images.SetKeyName(2, "dice_3.png");
            imageList1.Images.SetKeyName(3, "dice_4.png");
            imageList1.Images.SetKeyName(4, "dice_5.png");
            imageList1.Images.SetKeyName(5, "dice_6.png");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("PokemonGSK2Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(359, 383);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(295, 20);
            label1.TabIndex = 8;
            label1.Text = "주사위 숫자가 같거나 높으면 설득됩니다.";
            // 
            // bar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(724, 524);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(my_roll);
            Controls.Add(pc_roll);
            Controls.Add(lb_say);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "bar";
            Text = "bar";
            FormClosing += bar_FormClosing;
            Paint += bar_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_roll).EndInit();
            ((System.ComponentModel.ISupportInitialize)my_roll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_say;
        private System.Windows.Forms.PictureBox pc_roll;
        private System.Windows.Forms.PictureBox my_roll;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}