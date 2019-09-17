namespace WheelOfFortune
{
    partial class frmGuess
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
            this.lblEnterHint = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblAvailLetters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterHint
            // 
            this.lblEnterHint.AutoSize = true;
            this.lblEnterHint.BackColor = System.Drawing.Color.Navy;
            this.lblEnterHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHint.ForeColor = System.Drawing.Color.White;
            this.lblEnterHint.Location = new System.Drawing.Point(50, 75);
            this.lblEnterHint.Name = "lblEnterHint";
            this.lblEnterHint.Padding = new System.Windows.Forms.Padding(5);
            this.lblEnterHint.Size = new System.Drawing.Size(219, 35);
            this.lblEnterHint.TabIndex = 0;
            this.lblEnterHint.Text = "Player 1 - Enter a letter";
            // 
            // txtLetter
            // 
            this.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetter.Location = new System.Drawing.Point(109, 135);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 26);
            this.txtLetter.TabIndex = 1;
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetsOnly);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(109, 180);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 40);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblAvailLetters
            // 
            this.lblAvailLetters.AutoSize = true;
            this.lblAvailLetters.Location = new System.Drawing.Point(16, 25);
            this.lblAvailLetters.Name = "lblAvailLetters";
            this.lblAvailLetters.Size = new System.Drawing.Size(0, 20);
            this.lblAvailLetters.TabIndex = 3;
            this.lblAvailLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.lblAvailLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblEnterHint);
            this.Name = "frmGuess";
            this.Text = "Guess Letter";
            this.Load += new System.EventHandler(this.frmGuess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterHint;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblAvailLetters;
    }
}