namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    partial class PlayerStatus
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
            StatUIImg = new System.Windows.Forms.PictureBox();
            lb_Name = new System.Windows.Forms.Label();
            lb_Exp = new System.Windows.Forms.Label();
            lb_Level = new System.Windows.Forms.Label();
            lb_Attack = new System.Windows.Forms.Label();
            lb_Hp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)StatUIImg).BeginInit();
            SuspendLayout();
            // 
            // StatUIImg
            // 
            StatUIImg.BackColor = System.Drawing.Color.Transparent;
            StatUIImg.Image = Resources.StatUI;
            StatUIImg.Location = new System.Drawing.Point(3, 1);
            StatUIImg.Name = "StatUIImg";
            StatUIImg.Size = new System.Drawing.Size(190, 125);
            StatUIImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            StatUIImg.TabIndex = 0;
            StatUIImg.TabStop = false;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new System.Drawing.Font("PokemonGSK2Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Name.ForeColor = System.Drawing.SystemColors.InfoText;
            lb_Name.Location = new System.Drawing.Point(102, 27);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(81, 19);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "label1";
            // 
            // lb_Exp
            // 
            lb_Exp.AutoSize = true;
            lb_Exp.Font = new System.Drawing.Font("PokemonGSK2Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Exp.ForeColor = System.Drawing.SystemColors.InfoText;
            lb_Exp.Location = new System.Drawing.Point(102, 46);
            lb_Exp.Name = "lb_Exp";
            lb_Exp.Size = new System.Drawing.Size(81, 19);
            lb_Exp.TabIndex = 1;
            lb_Exp.Text = "label1";
            // 
            // lb_Level
            // 
            lb_Level.AutoSize = true;
            lb_Level.Font = new System.Drawing.Font("PokemonGSK2Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Level.ForeColor = System.Drawing.SystemColors.InfoText;
            lb_Level.Location = new System.Drawing.Point(102, 65);
            lb_Level.Name = "lb_Level";
            lb_Level.Size = new System.Drawing.Size(81, 19);
            lb_Level.TabIndex = 1;
            lb_Level.Text = "label1";
            // 
            // lb_Attack
            // 
            lb_Attack.AutoSize = true;
            lb_Attack.Font = new System.Drawing.Font("PokemonGSK2Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Attack.ForeColor = System.Drawing.SystemColors.InfoText;
            lb_Attack.Location = new System.Drawing.Point(102, 84);
            lb_Attack.Name = "lb_Attack";
            lb_Attack.Size = new System.Drawing.Size(81, 19);
            lb_Attack.TabIndex = 1;
            lb_Attack.Text = "label1";
            // 
            // lb_Hp
            // 
            lb_Hp.AutoSize = true;
            lb_Hp.Font = new System.Drawing.Font("PokemonGSK2Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Hp.ForeColor = System.Drawing.SystemColors.InfoText;
            lb_Hp.Location = new System.Drawing.Point(102, 103);
            lb_Hp.Name = "lb_Hp";
            lb_Hp.Size = new System.Drawing.Size(81, 19);
            lb_Hp.TabIndex = 1;
            lb_Hp.Text = "label1";
            // 
            // PlayerStatus
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(192, 126);
            Controls.Add(lb_Hp);
            Controls.Add(lb_Attack);
            Controls.Add(lb_Level);
            Controls.Add(lb_Exp);
            Controls.Add(lb_Name);
            Controls.Add(StatUIImg);
            Name = "PlayerStatus";
            Text = "PlayerStatus";
            ((System.ComponentModel.ISupportInitialize)StatUIImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox StatUIImg;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Exp;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_Attack;
        private System.Windows.Forms.Label lb_Hp;
    }
}