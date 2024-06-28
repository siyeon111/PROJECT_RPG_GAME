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
    partial class CardMatching
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardMatching));
            label_Status = new Label();
            label_Left = new Label();
            button_Restart = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.BackColor = Color.Transparent;
            label_Status.Font = new Font("돋움", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_Status.ForeColor = Color.Transparent;
            label_Status.Image = (Image)resources.GetObject("label_Status.Image");
            label_Status.Location = new Point(380, 740);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(164, 22);
            label_Status.TabIndex = 0;
            label_Status.Text = "맞춤 틀림 횟수";
            // 
            // label_Left
            // 
            label_Left.AutoSize = true;
            label_Left.BackColor = Color.Transparent;
            label_Left.Font = new Font("돋움", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label_Left.ForeColor = Color.Transparent;
            label_Left.Image = (Image)resources.GetObject("label_Left.Image");
            label_Left.Location = new Point(380, 793);
            label_Left.Name = "label_Left";
            label_Left.Size = new Size(125, 22);
            label_Left.TabIndex = 0;
            label_Left.Text = "남은 시간 :\r\n";
            // 
            // button_Restart
            // 
            button_Restart.BackColor = Color.Transparent;
            button_Restart.BackgroundImageLayout = ImageLayout.Zoom;
            button_Restart.Font = new Font("돋움", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button_Restart.ForeColor = Color.Black;
            button_Restart.Image = (Image)resources.GetObject("button_Restart.Image");
            button_Restart.Location = new Point(260, 740);
            button_Restart.Name = "button_Restart";
            button_Restart.Size = new Size(100, 100);
            button_Restart.TabIndex = 1;
            button_Restart.Text = "시작";
            button_Restart.UseVisualStyleBackColor = false;
            button_Restart.Click += RestartGameEvent;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 859);
            Controls.Add(button_Restart);
            Controls.Add(label_Left);
            Controls.Add(label_Status);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Status;
        private Label label_Left;
        private Button button_Restart;
        private System.Windows.Forms.Timer timer;
    }
}
