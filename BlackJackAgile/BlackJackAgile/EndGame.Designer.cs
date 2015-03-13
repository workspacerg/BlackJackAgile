namespace BlackJackAgile
{
    partial class EndGame
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
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Quit
            // 
            this.button_Quit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Quit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Quit.FlatAppearance.BorderSize = 0;
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quit.ForeColor = System.Drawing.Color.Teal;
            this.button_Quit.Location = new System.Drawing.Point(12, 117);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(102, 30);
            this.button_Quit.TabIndex = 1;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Restart
            // 
            this.button_Restart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Restart.BackColor = System.Drawing.Color.Teal;
            this.button_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Restart.FlatAppearance.BorderSize = 0;
            this.button_Restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Restart.Location = new System.Drawing.Point(217, 117);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(102, 30);
            this.button_Restart.TabIndex = 2;
            this.button_Restart.Text = "Rejouer !";
            this.button_Restart.UseVisualStyleBackColor = false;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vous avez perdu !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(331, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.button_Quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.Label label1;
    }
}