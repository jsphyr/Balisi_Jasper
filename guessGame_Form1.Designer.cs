namespace guessGame
{
    partial class Form1
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
            lblWord = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lstWrongGuesses = new ListBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.BackColor = Color.DarkSeaGreen;
            lblWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWord.ForeColor = Color.White;
            lblWord.Location = new Point(20, 20);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(695, 135);
            lblWord.TabIndex = 0;
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            txtGuess.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGuess.BackColor = Color.White;
            txtGuess.Cursor = Cursors.IBeam;
            txtGuess.Font = new Font("Segoe UI", 14F);
            txtGuess.ForeColor = Color.Black;
            txtGuess.Location = new Point(126, 160);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(466, 39);
            txtGuess.TabIndex = 1;
            txtGuess.TextAlign = HorizontalAlignment.Center;
            txtGuess.TextChanged += txtGuess_TextChanged;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.DarkSeaGreen;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Font = new Font("Segoe UI", 12F);
            btnGuess.ForeColor = Color.White;
            btnGuess.Location = new Point(251, 203);
            btnGuess.Name = "btnGuess";
            btnGuess.RightToLeft = RightToLeft.No;
            btnGuess.Size = new Size(225, 41);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // lstWrongGuesses
            // 
            lstWrongGuesses.FormattingEnabled = true;
            lstWrongGuesses.Location = new Point(721, 53);
            lstWrongGuesses.Name = "lstWrongGuesses";
            lstWrongGuesses.Size = new Size(230, 184);
            lstWrongGuesses.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.DarkSeaGreen;
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(721, 19);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(230, 27);
            txtResult.TabIndex = 4;
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(963, 255);
            Controls.Add(txtResult);
            Controls.Add(lstWrongGuesses);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblWord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private TextBox txtGuess;
        private Button btnGuess;
        private ListBox lstWrongGuesses;
        private TextBox txtResult;
    }
}
