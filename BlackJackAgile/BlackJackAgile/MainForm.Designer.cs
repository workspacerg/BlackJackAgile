namespace BlackJackAgile
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_pick = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBoxMise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.button_bet = new System.Windows.Forms.Button();
            this.pictureBox_j5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j50 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j10 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j25)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pick
            // 
            this.button_pick.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pick.FlatAppearance.BorderSize = 0;
            this.button_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pick.Location = new System.Drawing.Point(70, 207);
            this.button_pick.Name = "button_pick";
            this.button_pick.Size = new System.Drawing.Size(102, 30);
            this.button_pick.TabIndex = 0;
            this.button_pick.Text = "Carte !";
            this.button_pick.UseVisualStyleBackColor = false;
            this.button_pick.Visible = false;
            this.button_pick.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_close
            // 
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(600, 13);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(35, 30);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBoxMise
            // 
            this.textBoxMise.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxMise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxMise.Location = new System.Drawing.Point(72, 12);
            this.textBoxMise.Name = "textBoxMise";
            this.textBoxMise.Size = new System.Drawing.Size(100, 20);
            this.textBoxMise.TabIndex = 3;
            this.textBoxMise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma mise :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(445, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mon compte :";
            // 
            // textBox_Account
            // 
            this.textBox_Account.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Account.Location = new System.Drawing.Point(535, 282);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(100, 20);
            this.textBox_Account.TabIndex = 6;
            this.textBox_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_bet
            // 
            this.button_bet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_bet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bet.FlatAppearance.BorderSize = 0;
            this.button_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_bet.Location = new System.Drawing.Point(533, 189);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(102, 30);
            this.button_bet.TabIndex = 7;
            this.button_bet.Text = "Miser (20€)";
            this.button_bet.UseVisualStyleBackColor = false;
            this.button_bet.Click += new System.EventHandler(this.button_bet_Click);
            // 
            // pictureBox_j5
            // 
            this.pictureBox_j5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j5.Location = new System.Drawing.Point(180, 260);
            this.pictureBox_j5.Name = "pictureBox_j5";
            this.pictureBox_j5.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j5.TabIndex = 8;
            this.pictureBox_j5.TabStop = false;
            // 
            // pictureBox_j50
            // 
            this.pictureBox_j50.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j50.Location = new System.Drawing.Point(363, 260);
            this.pictureBox_j50.Name = "pictureBox_j50";
            this.pictureBox_j50.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j50.TabIndex = 9;
            this.pictureBox_j50.TabStop = false;
            // 
            // pictureBox_j10
            // 
            this.pictureBox_j10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j10.Location = new System.Drawing.Point(241, 260);
            this.pictureBox_j10.Name = "pictureBox_j10";
            this.pictureBox_j10.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j10.TabIndex = 10;
            this.pictureBox_j10.TabStop = false;
            // 
            // pictureBox_j25
            // 
            this.pictureBox_j25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j25.Location = new System.Drawing.Point(301, 260);
            this.pictureBox_j25.Name = "pictureBox_j25";
            this.pictureBox_j25.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j25.TabIndex = 11;
            this.pictureBox_j25.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackAgile.Properties.Resources.table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 310);
            this.Controls.Add(this.pictureBox_j25);
            this.Controls.Add(this.pictureBox_j10);
            this.Controls.Add(this.pictureBox_j50);
            this.Controls.Add(this.pictureBox_j5);
            this.Controls.Add(this.button_bet);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMise);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_pick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pick;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBoxMise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.PictureBox pictureBox_j5;
        private System.Windows.Forms.PictureBox pictureBox_j50;
        private System.Windows.Forms.PictureBox pictureBox_j10;
        private System.Windows.Forms.PictureBox pictureBox_j25;
    }
}

