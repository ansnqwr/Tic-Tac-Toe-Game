namespace Tic_Tac_Toe_Game
{
    partial class StartGame
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
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Title.Location = new System.Drawing.Point(352, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(484, 75);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Tic-Tac-Toe Game";
            // 
            // btn_startGame
            // 
            this.btn_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startGame.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_startGame.Location = new System.Drawing.Point(478, 480);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(207, 49);
            this.btn_startGame.TabIndex = 7;
            this.btn_startGame.Text = "Start Game";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            this.btn_startGame.MouseEnter += new System.EventHandler(this.btn_startGame_MouseEnter);
            this.btn_startGame.MouseLeave += new System.EventHandler(this.btn_startGame_MouseLeave);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Logo.Image = global::Tic_Tac_Toe_Game.Properties.Resources.Logo_X__O;
            this.pb_Logo.Location = new System.Drawing.Point(301, 107);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(575, 315);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 8;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Tag = "";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1205, 640);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.btn_startGame);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}