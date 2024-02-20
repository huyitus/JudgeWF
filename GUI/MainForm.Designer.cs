namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            sbTestCase = new ToolStripButton();
            sbSubmission = new ToolStripButton();
            sbJudger = new ToolStripButton();
            sbJudge = new ToolStripButton();
            sbAbout = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTestCase = new ToolStripStatusLabel();
            lblSubmission = new ToolStripStatusLabel();
            lblJudger = new ToolStripStatusLabel();
            lblChecker = new ToolStripStatusLabel();
            lvwResult = new ListView();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { sbTestCase, sbSubmission, sbJudger, sbJudge, sbAbout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(789, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // sbTestCase
            // 
            sbTestCase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sbTestCase.Image = (Image)resources.GetObject("sbTestCase.Image");
            sbTestCase.ImageTransparentColor = Color.Magenta;
            sbTestCase.Name = "sbTestCase";
            sbTestCase.Size = new Size(59, 24);
            sbTestCase.Text = "Bộ test";
            sbTestCase.Click += TestCaseStripButton_Click;
            // 
            // sbSubmission
            // 
            sbSubmission.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sbSubmission.Image = (Image)resources.GetObject("sbSubmission.Image");
            sbSubmission.ImageTransparentColor = Color.Magenta;
            sbSubmission.Name = "sbSubmission";
            sbSubmission.Size = new Size(63, 24);
            sbSubmission.Text = "Bài làm";
            sbSubmission.Click += SubmissionStripButton_Click;
            // 
            // sbJudger
            // 
            sbJudger.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sbJudger.Image = (Image)resources.GetObject("sbJudger.Image");
            sbJudger.ImageTransparentColor = Color.Magenta;
            sbJudger.Name = "sbJudger";
            sbJudger.Size = new Size(85, 24);
            sbJudger.Text = "Trình chấm";
            sbJudger.Click += JudgerButton_Click;
            // 
            // sbJudge
            // 
            sbJudge.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sbJudge.Image = (Image)resources.GetObject("sbJudge.Image");
            sbJudge.ImageTransparentColor = Color.Magenta;
            sbJudge.Name = "sbJudge";
            sbJudge.Size = new Size(76, 24);
            sbJudge.Text = "Chấm bài";
            sbJudge.Click += JudgeStripButton_Click;
            // 
            // sbAbout
            // 
            sbAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sbAbout.Image = (Image)resources.GetObject("sbAbout.Image");
            sbAbout.ImageTransparentColor = Color.Magenta;
            sbAbout.Name = "sbAbout";
            sbAbout.Size = new Size(77, 24);
            sbAbout.Text = "Giới thiệu";
            sbAbout.Click += AboutStripButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTestCase, lblSubmission, lblJudger, lblChecker });
            statusStrip1.Location = new Point(0, 451);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(789, 30);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTestCase
            // 
            lblTestCase.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblTestCase.BorderStyle = Border3DStyle.SunkenOuter;
            lblTestCase.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblTestCase.Name = "lblTestCase";
            lblTestCase.Size = new Size(40, 24);
            lblTestCase.Text = "N/A";
            // 
            // lblSubmission
            // 
            lblSubmission.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblSubmission.BorderStyle = Border3DStyle.SunkenOuter;
            lblSubmission.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblSubmission.Name = "lblSubmission";
            lblSubmission.Size = new Size(40, 24);
            lblSubmission.Text = "N/A";
            // 
            // lblJudger
            // 
            lblJudger.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblJudger.BorderStyle = Border3DStyle.SunkenOuter;
            lblJudger.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblJudger.Name = "lblJudger";
            lblJudger.Size = new Size(40, 24);
            lblJudger.Text = "N/A";
            // 
            // lblChecker
            // 
            lblChecker.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblChecker.BorderStyle = Border3DStyle.SunkenOuter;
            lblChecker.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblChecker.Name = "lblChecker";
            lblChecker.Size = new Size(40, 24);
            lblChecker.Text = "N/A";
            // 
            // lvwResult
            // 
            lvwResult.Dock = DockStyle.Fill;
            lvwResult.Location = new Point(0, 27);
            lvwResult.Name = "lvwResult";
            lvwResult.Size = new Size(789, 424);
            lvwResult.TabIndex = 2;
            lvwResult.UseCompatibleStateImageBehavior = false;
            lvwResult.View = View.Details;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 481);
            Controls.Add(lvwResult);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Công cụ chấm bài lập trình";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton sbTestCase;
        private ToolStripButton sbSubmission;
        private ToolStripButton sbJudger;
        private ToolStripButton sbAbout;
        private StatusStrip statusStrip1;
        private ListView lvwResult;
        private ToolStripButton sbJudge;
        private ToolStripStatusLabel lblTestCase;
        private ToolStripStatusLabel lblSubmission;
        private ToolStripStatusLabel lblJudger;
        private ToolStripStatusLabel lblChecker;
    }
}
