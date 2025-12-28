namespace Tic_Tac_Toe_Game
{
    partial class ChoiceMode
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
            this.label_Mode = new System.Windows.Forms.Label();
            this.btn_OneVSOne = new System.Windows.Forms.Button();
            this.btn_OneVSPC = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Mode.Location = new System.Drawing.Point(412, 20);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(276, 41);
            this.label_Mode.TabIndex = 2;
            this.label_Mode.Text = "Choice Your Mode";
            // 
            // btn_OneVSOne
            // 
            this.btn_OneVSOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneVSOne.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OneVSOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OneVSOne.Location = new System.Drawing.Point(194, 113);
            this.btn_OneVSOne.Name = "btn_OneVSOne";
            this.btn_OneVSOne.Size = new System.Drawing.Size(286, 155);
            this.btn_OneVSOne.TabIndex = 3;
            this.btn_OneVSOne.Text = "One  VS  One";
            this.btn_OneVSOne.UseVisualStyleBackColor = true;
            this.btn_OneVSOne.Click += new System.EventHandler(this.btn_OneVSOne_Click);
            this.btn_OneVSOne.MouseEnter += new System.EventHandler(this.btn_OneVSOne_MouseEnter);
            this.btn_OneVSOne.MouseLeave += new System.EventHandler(this.btn_OneVSOne_MouseLeave);
            // 
            // btn_OneVSPC
            // 
            this.btn_OneVSPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OneVSPC.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OneVSPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OneVSPC.Location = new System.Drawing.Point(676, 113);
            this.btn_OneVSPC.Name = "btn_OneVSPC";
            this.btn_OneVSPC.Size = new System.Drawing.Size(286, 155);
            this.btn_OneVSPC.TabIndex = 4;
            this.btn_OneVSPC.Text = " One VS PC";
            this.btn_OneVSPC.UseVisualStyleBackColor = true;
            this.btn_OneVSPC.Click += new System.EventHandler(this.btn_OneVSPC_Click);
            this.btn_OneVSPC.MouseEnter += new System.EventHandler(this.btn_OneVSPC_MouseEnter);
            this.btn_OneVSPC.MouseLeave += new System.EventHandler(this.btn_OneVSPC_MouseLeave);
            // 
            // btn_Go
            // 
            this.btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Go.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Go.Location = new System.Drawing.Point(456, 471);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(207, 49);
            this.btn_Go.TabIndex = 7;
            this.btn_Go.Text = "GO";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            this.btn_Go.MouseEnter += new System.EventHandler(this.btn_Go_MouseEnter);
            this.btn_Go.MouseLeave += new System.EventHandler(this.btn_Go_MouseLeave);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(343, 382);
            this.progressBar1.Minimum = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 40;
            // 
            // ChoiceMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1165, 578);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.btn_OneVSPC);
            this.Controls.Add(this.btn_OneVSOne);
            this.Controls.Add(this.label_Mode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChoiceMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Button btn_OneVSOne;
        private System.Windows.Forms.Button btn_OneVSPC;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}