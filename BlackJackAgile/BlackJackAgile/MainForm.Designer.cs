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
            this.button_pick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bet = new System.Windows.Forms.Button();
            this.pictureBox_j50 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j10 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j25 = new System.Windows.Forms.PictureBox();
            this.pictureBox_j5 = new System.Windows.Forms.PictureBox();
            this.buttonReste = new System.Windows.Forms.Button();
            this.label_compte = new System.Windows.Forms.Label();
            this.label_mise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j5)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pick
            // 
            this.button_pick.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_pick.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pick.FlatAppearance.BorderSize = 0;
            this.button_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pick.Location = new System.Drawing.Point(120, 292);
            this.button_pick.Name = "button_pick";
            this.button_pick.Size = new System.Drawing.Size(102, 30);
            this.button_pick.TabIndex = 0;
            this.button_pick.Text = "Carte !";
            this.button_pick.UseVisualStyleBackColor = false;
            this.button_pick.Visible = false;
            this.button_pick.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma mise :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mon compte :";
            // 
            // button_bet
            // 
            this.button_bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(165)))), ((int)(((byte)(28)))));
            this.button_bet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bet.FlatAppearance.BorderSize = 0;
            this.button_bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_bet.Location = new System.Drawing.Point(533, 247);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(102, 30);
            this.button_bet.TabIndex = 7;
            this.button_bet.Text = "Miser !";
            this.button_bet.UseVisualStyleBackColor = false;
            this.button_bet.Click += new System.EventHandler(this.button_bet_Click);
            // 
            // pictureBox_j50
            // 
            this.pictureBox_j50.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_j50.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j50.Image = global::BlackJackAgile.Properties.Resources.jeton50;
            this.pictureBox_j50.Location = new System.Drawing.Point(591, 292);
            this.pictureBox_j50.Name = "pictureBox_j50";
            this.pictureBox_j50.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j50.TabIndex = 9;
            this.pictureBox_j50.TabStop = false;
            // 
            // pictureBox_j10
            // 
            this.pictureBox_j10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_j10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j10.Image = global::BlackJackAgile.Properties.Resources.jeton10;
            this.pictureBox_j10.Location = new System.Drawing.Point(469, 292);
            this.pictureBox_j10.Name = "pictureBox_j10";
            this.pictureBox_j10.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j10.TabIndex = 10;
            this.pictureBox_j10.TabStop = false;
            // 
            // pictureBox_j25
            // 
            this.pictureBox_j25.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_j25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j25.Image = global::BlackJackAgile.Properties.Resources.jeton25;
            this.pictureBox_j25.Location = new System.Drawing.Point(529, 292);
            this.pictureBox_j25.Name = "pictureBox_j25";
            this.pictureBox_j25.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j25.TabIndex = 11;
            this.pictureBox_j25.TabStop = false;
            // 
            // pictureBox_j5
            // 
            this.pictureBox_j5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox_j5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j5.Image = global::BlackJackAgile.Properties.Resources.jeton5;
            this.pictureBox_j5.Location = new System.Drawing.Point(407, 292);
            this.pictureBox_j5.Name = "pictureBox_j5";
            this.pictureBox_j5.Size = new System.Drawing.Size(42, 38);
            this.pictureBox_j5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j5.TabIndex = 12;
            this.pictureBox_j5.TabStop = false;
            // 
            // buttonReste
            // 
            this.buttonReste.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReste.FlatAppearance.BorderSize = 0;
            this.buttonReste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReste.Location = new System.Drawing.Point(12, 292);
            this.buttonReste.Name = "buttonReste";
            this.buttonReste.Size = new System.Drawing.Size(102, 30);
            this.buttonReste.TabIndex = 13;
            this.buttonReste.Text = "Je reste !";
            this.buttonReste.UseVisualStyleBackColor = false;
            this.buttonReste.Visible = false;
            this.buttonReste.Click += new System.EventHandler(this.buttonReste_Click);
            // 
            // label_compte
            // 
            this.label_compte.AutoSize = true;
            this.label_compte.BackColor = System.Drawing.Color.Transparent;
            this.label_compte.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_compte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_compte.Location = new System.Drawing.Point(127, 3);
            this.label_compte.Name = "label_compte";
            this.label_compte.Size = new System.Drawing.Size(33, 22);
            this.label_compte.TabIndex = 14;
            this.label_compte.Text = "0€";
            this.label_compte.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_mise
            // 
            this.label_mise.AutoSize = true;
            this.label_mise.BackColor = System.Drawing.Color.Transparent;
            this.label_mise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_mise.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_mise.Location = new System.Drawing.Point(127, 29);
            this.label_mise.Name = "label_mise";
            this.label_mise.Size = new System.Drawing.Size(33, 22);
            this.label_mise.TabIndex = 15;
            this.label_mise.Text = "0€";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackAgile.Properties.Resources.table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 342);
            this.Controls.Add(this.label_mise);
            this.Controls.Add(this.label_compte);
            this.Controls.Add(this.buttonReste);
            this.Controls.Add(this.pictureBox_j5);
            this.Controls.Add(this.pictureBox_j25);
            this.Controls.Add(this.pictureBox_j10);
            this.Controls.Add(this.pictureBox_j50);
            this.Controls.Add(this.button_bet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_pick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.PictureBox pictureBox_j50;
        private System.Windows.Forms.PictureBox pictureBox_j10;
        private System.Windows.Forms.PictureBox pictureBox_j25;
        private System.Windows.Forms.PictureBox pictureBox_j5;
        private System.Windows.Forms.Button buttonReste;
        private System.Windows.Forms.Label label_compte;
        private System.Windows.Forms.Label label_mise;
    }
}

