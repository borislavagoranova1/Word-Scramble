namespace wordScramble
{
    partial class WordScramble
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
            lblTitle = new Label();
            labelAttemptsCount = new Label();
            label2 = new Label();
            labelScrambledWord = new Label();
            label4 = new Label();
            btnCheck = new Button();
            btnSkip = new Button();
            textBoxInput = new TextBox();
            textBoxFailedAttempts = new TextBox();
            txtAttempts = new TextBox();
            labelGuessedWordsValue = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Schoolbook", 26F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(278, 78);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Word Scramble";
            // 
            // labelAttemptsCount
            // 
            labelAttemptsCount.AutoSize = true;
            labelAttemptsCount.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAttemptsCount.Location = new Point(156, 221);
            labelAttemptsCount.Name = "labelAttemptsCount";
            labelAttemptsCount.Size = new Size(144, 31);
            labelAttemptsCount.TabIndex = 1;
            labelAttemptsCount.Text = "Attempts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(603, 221);
            label2.Name = "label2";
            label2.Size = new Size(223, 31);
            label2.TabIndex = 2;
            label2.Text = "Guessed words:";
            // 
            // labelScrambledWord
            // 
            labelScrambledWord.AutoSize = true;
            labelScrambledWord.Font = new Font("Century Schoolbook", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelScrambledWord.Location = new Point(382, 297);
            labelScrambledWord.Name = "labelScrambledWord";
            labelScrambledWord.Size = new Size(251, 34);
            labelScrambledWord.TabIndex = 3;
            labelScrambledWord.Text = "scrambled word";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(364, 465);
            label4.Name = "label4";
            label4.Size = new Size(233, 31);
            label4.TabIndex = 4;
            label4.Text = "Failed attempts:";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.PeachPuff;
            btnCheck.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCheck.Location = new Point(477, 363);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(147, 43);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.PeachPuff;
            btnSkip.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSkip.Location = new Point(630, 363);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(143, 43);
            btnSkip.TabIndex = 6;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.FromArgb(255, 224, 192);
            textBoxInput.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxInput.Location = new Point(254, 363);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(200, 43);
            textBoxInput.TabIndex = 1;
            // 
            // textBoxFailedAttempts
            // 
            textBoxFailedAttempts.BackColor = Color.FromArgb(255, 224, 192);
            textBoxFailedAttempts.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxFailedAttempts.Location = new Point(179, 512);
            textBoxFailedAttempts.Multiline = true;
            textBoxFailedAttempts.Name = "textBoxFailedAttempts";
            textBoxFailedAttempts.ReadOnly = true;
            textBoxFailedAttempts.Size = new Size(670, 116);
            textBoxFailedAttempts.TabIndex = 2;
            // 
            // txtAttempts
            // 
            txtAttempts.BackColor = Color.FromArgb(255, 224, 192);
            txtAttempts.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold);
            txtAttempts.Location = new Point(306, 221);
            txtAttempts.Multiline = true;
            txtAttempts.Name = "txtAttempts";
            txtAttempts.Size = new Size(34, 43);
            txtAttempts.TabIndex = 9;
            // 
            // labelGuessedWordsValue
            // 
            labelGuessedWordsValue.BackColor = Color.FromArgb(255, 224, 192);
            labelGuessedWordsValue.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold);
            labelGuessedWordsValue.Location = new Point(832, 209);
            labelGuessedWordsValue.Multiline = true;
            labelGuessedWordsValue.Name = "labelGuessedWordsValue";
            labelGuessedWordsValue.Size = new Size(32, 43);
            labelGuessedWordsValue.TabIndex = 10;
            // 
            // WordScramble
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(980, 640);
            Controls.Add(labelGuessedWordsValue);
            Controls.Add(txtAttempts);
            Controls.Add(textBoxFailedAttempts);
            Controls.Add(textBoxInput);
            Controls.Add(btnSkip);
            Controls.Add(btnCheck);
            Controls.Add(label4);
            Controls.Add(labelScrambledWord);
            Controls.Add(label2);
            Controls.Add(labelAttemptsCount);
            Controls.Add(lblTitle);
            Name = "WordScramble";
            Text = "Word Scramble";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label labelAttemptsCount;
        private Label label2;
        private Label labelScrambledWord;
        private Label label4;
        private Button btnCheck;
        private Button btnSkip;
        private TextBox textBoxInput;
        private TextBox textBoxFailedAttempts;
        private TextBox txtAttempts;
        private TextBox labelGuessedWordsValue;
    }
}
