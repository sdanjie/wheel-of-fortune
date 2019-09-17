namespace WheelOfFortune
{
    partial class frmSolve
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
            this.txtEnterPuzzle = new System.Windows.Forms.TextBox();
            this.lblEnterPuzzleHint = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnterPuzzle
            // 
            this.txtEnterPuzzle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnterPuzzle.Location = new System.Drawing.Point(40, 90);
            this.txtEnterPuzzle.MaxLength = 15;
            this.txtEnterPuzzle.Name = "txtEnterPuzzle";
            this.txtEnterPuzzle.Size = new System.Drawing.Size(200, 26);
            this.txtEnterPuzzle.TabIndex = 0;
            this.txtEnterPuzzle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsAndSpaceOnly);
            // 
            // lblEnterPuzzleHint
            // 
            this.lblEnterPuzzleHint.AutoSize = true;
            this.lblEnterPuzzleHint.BackColor = System.Drawing.Color.Navy;
            this.lblEnterPuzzleHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnterPuzzleHint.ForeColor = System.Drawing.Color.White;
            this.lblEnterPuzzleHint.Location = new System.Drawing.Point(55, 30);
            this.lblEnterPuzzleHint.Name = "lblEnterPuzzleHint";
            this.lblEnterPuzzleHint.Padding = new System.Windows.Forms.Padding(5);
            this.lblEnterPuzzleHint.Size = new System.Drawing.Size(173, 35);
            this.lblEnterPuzzleHint.TabIndex = 1;
            this.lblEnterPuzzleHint.Text = "Enter your puzzle";
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(86, 150);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 40);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 224);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblEnterPuzzleHint);
            this.Controls.Add(this.txtEnterPuzzle);
            this.Name = "frmSolve";
            this.Text = "Solve the Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterPuzzle;
        private System.Windows.Forms.Label lblEnterPuzzleHint;
        private System.Windows.Forms.Button btnCheck;
    }
}