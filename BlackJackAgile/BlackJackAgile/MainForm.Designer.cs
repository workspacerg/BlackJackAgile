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
            this.button_double = new System.Windows.Forms.Button();
            this.score_banque = new System.Windows.Forms.Label();
            this.score_joueur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_j5)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pick
            // 
            this.button_pick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_pick.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_pick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pick.FlatAppearance.BorderSize = 0;
            this.button_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pick.Location = new System.Drawing.Point(120, 359);
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
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma mise :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mon compte :";
            // 
            // button_bet
            // 
            this.button_bet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(165)))), ((int)(((byte)(28)))));
            this.button_bet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bet.FlatAppearance.BorderSize = 0;
            this.button_bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_bet.Location = new System.Drawing.Point(557, 314);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(102, 30);
            this.button_bet.TabIndex = 7;
            this.button_bet.Text = "Miser !";
            this.button_bet.UseVisualStyleBackColor = false;
            this.button_bet.Click += new System.EventHandler(this.button_bet_Click);
            // 
            // pictureBox_j50
            // 
            this.pictureBox_j50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_j50.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j50.Image = global::BlackJackAgile.Properties.Resources.jeton50;
            this.pictureBox_j50.Location = new System.Drawing.Point(615, 359);
            this.pictureBox_j50.Name = "pictureBox_j50";
            this.pictureBox_j50.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j50.TabIndex = 9;
            this.pictureBox_j50.TabStop = false;
            // 
            // pictureBox_j10
            // 
            this.pictureBox_j10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_j10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j10.Image = global::BlackJackAgile.Properties.Resources.jeton10;
            this.pictureBox_j10.Location = new System.Drawing.Point(493, 359);
            this.pictureBox_j10.Name = "pictureBox_j10";
            this.pictureBox_j10.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j10.TabIndex = 10;
            this.pictureBox_j10.TabStop = false;
            // 
            // pictureBox_j25
            // 
            this.pictureBox_j25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_j25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j25.Image = global::BlackJackAgile.Properties.Resources.jeton25;
            this.pictureBox_j25.Location = new System.Drawing.Point(553, 359);
            this.pictureBox_j25.Name = "pictureBox_j25";
            this.pictureBox_j25.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_j25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j25.TabIndex = 11;
            this.pictureBox_j25.TabStop = false;
            // 
            // pictureBox_j5
            // 
            this.pictureBox_j5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_j5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_j5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_j5.Image = global::BlackJackAgile.Properties.Resources.jeton5;
            this.pictureBox_j5.Location = new System.Drawing.Point(431, 359);
            this.pictureBox_j5.Name = "pictureBox_j5";
            this.pictureBox_j5.Size = new System.Drawing.Size(42, 38);
            this.pictureBox_j5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_j5.TabIndex = 12;
            this.pictureBox_j5.TabStop = false;
            // 
            // buttonReste
            // 
            this.buttonReste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReste.FlatAppearance.BorderSize = 0;
            this.buttonReste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReste.Location = new System.Drawing.Point(12, 359);
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
            this.label_compte.Location = new System.Drawing.Point(127, 45);
            this.label_compte.Name = "label_compte";
            this.label_compte.Size = new System.Drawing.Size(33, 22);
            this.label_compte.TabIndex = 14;
            this.label_compte.Text = "0€";
            // 
            // label_mise
            // 
            this.label_mise.AutoSize = true;
            this.label_mise.BackColor = System.Drawing.Color.Transparent;
            this.label_mise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_mise.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_mise.Location = new System.Drawing.Point(127, 71);
            this.label_mise.Name = "label_mise";
            this.label_mise.Size = new System.Drawing.Size(33, 22);
            this.label_mise.TabIndex = 15;
            this.label_mise.Text = "0€";
            // 
            // button_double
            // 
            this.button_double.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_double.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(165)))), ((int)(((byte)(28)))));
            this.button_double.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_double.FlatAppearance.BorderSize = 0;
            this.button_double.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_double.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_double.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_double.Location = new System.Drawing.Point(228, 359);
            this.button_double.Name = "button_double";
            this.button_double.Size = new System.Drawing.Size(102, 30);
            this.button_double.TabIndex = 16;
            this.button_double.Text = "Doubler !";
            this.button_double.UseVisualStyleBackColor = false;
            this.button_double.Visible = false;
            this.button_double.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // score_banque
            // 
            this.score_banque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score_banque.AutoSize = true;
            this.score_banque.BackColor = System.Drawing.Color.Transparent;
            this.score_banque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_banque.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_banque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score_banque.Location = new System.Drawing.Point(427, 45);
            this.score_banque.Name = "score_banque";
            this.score_banque.Size = new System.Drawing.Size(96, 22);
            this.score_banque.TabIndex = 17;
            this.score_banque.Text = "Banque : 0";
            // 
            // score_joueur
            // 
            this.score_joueur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score_joueur.AutoSize = true;
            this.score_joueur.BackColor = System.Drawing.Color.Transparent;
            this.score_joueur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_joueur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_joueur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score_joueur.Location = new System.Drawing.Point(553, 45);
            this.score_joueur.Name = "score_joueur";
            this.score_joueur.Size = new System.Drawing.Size(89, 22);
            this.score_joueur.TabIndex = 18;
            this.score_joueur.Text = "Joueur : 0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(676, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Vous avez gagné ! ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(553, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Continuer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackAgile.Properties.Resources.tapis_de_black_jack_francais;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.score_joueur);
            this.Controls.Add(this.score_banque);
            this.Controls.Add(this.button_double);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
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
        private System.Windows.Forms.PictureBox pictureBox_j50;
        private System.Windows.Forms.PictureBox pictureBox_j10;
        private System.Windows.Forms.PictureBox pictureBox_j25;
        private System.Windows.Forms.PictureBox pictureBox_j5;
        private System.Windows.Forms.Button buttonReste;
        private System.Windows.Forms.Label label_compte;
        private System.Windows.Forms.Label label_mise;
        private System.Windows.Forms.Button button_double;
        private System.Windows.Forms.Label score_banque;
        private System.Windows.Forms.Label score_joueur;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

