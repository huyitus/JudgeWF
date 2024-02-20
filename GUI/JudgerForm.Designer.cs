namespace GUI
{
    partial class JudgerForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            cboJudgeStrategy = new ComboBox();
            cboSubmissionLanguage = new ComboBox();
            label3 = new Label();
            cboCheckStrategy = new ComboBox();
            btnCommit = new Button();
            cboCheckerLanguage = new ComboBox();
            chkUseCustomChecker = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtCheckerPath = new TextBox();
            btnBrowseChecker = new Button();
            label5 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(cboJudgeStrategy, 1, 0);
            tableLayoutPanel1.Controls.Add(cboSubmissionLanguage, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(cboCheckStrategy, 1, 2);
            tableLayoutPanel1.Controls.Add(btnCommit, 1, 6);
            tableLayoutPanel1.Controls.Add(cboCheckerLanguage, 1, 5);
            tableLayoutPanel1.Controls.Add(chkUseCustomChecker, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(552, 224);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 0;
            label1.Text = "Chiến lược chấm bài";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(3, 34);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 1;
            label2.Text = "Ngôn ngữ bài làm";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboJudgeStrategy
            // 
            cboJudgeStrategy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboJudgeStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJudgeStrategy.FormattingEnabled = true;
            cboJudgeStrategy.Location = new Point(158, 3);
            cboJudgeStrategy.Margin = new Padding(3, 3, 3, 0);
            cboJudgeStrategy.Name = "cboJudgeStrategy";
            cboJudgeStrategy.Size = new Size(391, 28);
            cboJudgeStrategy.TabIndex = 2;
            cboJudgeStrategy.SelectedIndexChanged += JudgeStrategy_SelectedIndexChanged;
            // 
            // cboSubmissionLanguage
            // 
            cboSubmissionLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboSubmissionLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubmissionLanguage.FormattingEnabled = true;
            cboSubmissionLanguage.Location = new Point(158, 34);
            cboSubmissionLanguage.Margin = new Padding(3, 3, 3, 0);
            cboSubmissionLanguage.Name = "cboSubmissionLanguage";
            cboSubmissionLanguage.Size = new Size(391, 28);
            cboSubmissionLanguage.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(3, 65);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 4;
            label3.Text = "Chiến lược so đáp án";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboCheckStrategy
            // 
            cboCheckStrategy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCheckStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCheckStrategy.FormattingEnabled = true;
            cboCheckStrategy.Location = new Point(158, 65);
            cboCheckStrategy.Margin = new Padding(3, 3, 3, 0);
            cboCheckStrategy.Name = "cboCheckStrategy";
            cboCheckStrategy.Size = new Size(391, 28);
            cboCheckStrategy.TabIndex = 5;
            // 
            // btnCommit
            // 
            btnCommit.AutoSize = true;
            btnCommit.Location = new Point(158, 190);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(71, 30);
            btnCommit.TabIndex = 11;
            btnCommit.Text = "Đồng ý";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += CommitButton_Click;
            // 
            // cboCheckerLanguage
            // 
            cboCheckerLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCheckerLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCheckerLanguage.Enabled = false;
            cboCheckerLanguage.FormattingEnabled = true;
            cboCheckerLanguage.Location = new Point(158, 159);
            cboCheckerLanguage.Margin = new Padding(3, 3, 3, 0);
            cboCheckerLanguage.Name = "cboCheckerLanguage";
            cboCheckerLanguage.Size = new Size(391, 28);
            cboCheckerLanguage.TabIndex = 9;
            // 
            // chkUseCustomChecker
            // 
            chkUseCustomChecker.AutoSize = true;
            chkUseCustomChecker.Location = new Point(158, 96);
            chkUseCustomChecker.Name = "chkUseCustomChecker";
            chkUseCustomChecker.Size = new Size(184, 24);
            chkUseCustomChecker.TabIndex = 12;
            chkUseCustomChecker.Text = "Dùng checker tùy chỉnh";
            chkUseCustomChecker.UseVisualStyleBackColor = true;
            chkUseCustomChecker.CheckedChanged += UseCustomChecker_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(txtCheckerPath, 0, 0);
            tableLayoutPanel2.Controls.Add(btnBrowseChecker, 1, 0);
            tableLayoutPanel2.Location = new Point(155, 126);
            tableLayoutPanel2.Margin = new Padding(0, 3, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(397, 30);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // txtCheckerPath
            // 
            txtCheckerPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCheckerPath.Enabled = false;
            txtCheckerPath.Location = new Point(3, 0);
            txtCheckerPath.Margin = new Padding(3, 0, 0, 0);
            txtCheckerPath.Name = "txtCheckerPath";
            txtCheckerPath.ReadOnly = true;
            txtCheckerPath.Size = new Size(335, 27);
            txtCheckerPath.TabIndex = 0;
            // 
            // btnBrowseChecker
            // 
            btnBrowseChecker.AutoSize = true;
            btnBrowseChecker.Enabled = false;
            btnBrowseChecker.Location = new Point(341, 0);
            btnBrowseChecker.Margin = new Padding(3, 0, 3, 0);
            btnBrowseChecker.Name = "btnBrowseChecker";
            btnBrowseChecker.Size = new Size(53, 30);
            btnBrowseChecker.TabIndex = 1;
            btnBrowseChecker.Text = "Chọn";
            btnBrowseChecker.UseVisualStyleBackColor = true;
            btnBrowseChecker.Click += BrowseCheckerButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 159);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 8;
            label5.Text = "Ngôn ngữ checker";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(3, 126);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 6;
            label4.Text = "File checker tùy chỉnh";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // JudgerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 230);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JudgerForm";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Trình chấm";
            Load += JudgerForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox cboJudgeStrategy;
        private ComboBox cboSubmissionLanguage;
        private Label label3;
        private ComboBox cboCheckStrategy;
        private Label label4;
        private Label label5;
        private ComboBox cboCheckerLanguage;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtCheckerPath;
        private Button btnBrowseChecker;
        private Button btnCommit;
        private CheckBox chkUseCustomChecker;
    }
}