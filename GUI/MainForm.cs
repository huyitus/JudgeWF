using Core;
using System.Diagnostics.Eventing.Reader;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Context context;

        public MainForm()
        {
            InitializeComponent();
            context = Context.GetInstance();
        }

        private void TestCaseStripButton_Click(object sender, EventArgs e)
        {
            string folderPath = BrowseFolder();

            if (string.IsNullOrEmpty(folderPath))
            {
                return;
            }

            context.LoadTestCase(folderPath);
            lblTestCase.Text = context.TestCases.Count + " " + Resource.TestCase;
        }

        private string BrowseFolder()
        {
            using var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }

            return string.Empty;
        }

        private string BrowseFile()
        {
            using var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }

            return string.Empty;
        }

        private void SubmissionStripButton_Click(object sender, EventArgs e)
        {
            string filePath = BrowseFile();

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            context.SubmissionFilePath = filePath;
            lblSubmission.Text = Path.GetFileName(filePath);
        }

        private void JudgerButton_Click(object sender, EventArgs e)
        {
            Form form = new JudgerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lblJudger.Text = context.JudgeStrategy.DisplayName;
                lblChecker.Text = context.CheckStrategy.DisplayName;
            }
        }

        private void JudgeStripButton_Click(object sender, EventArgs e)
        {
            if (!context.IsValid())
            {
                MessageBox.Show(Resource.NotEnoughConfig, Resource.Message);
                return;
            }

            if (MessageBox.Show(Resource.ReallyJudge, Resource.Message, MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            lvwResult.Items.Clear();

            Submission submission = new Submission()
            {
                SourceCode = File.ReadAllText(context.SubmissionFilePath),
                Language = context.SubmissionLanguage
            };

            for (int i = 0; i < context.TestCases.Count; i++)
            {
                JudgeResult result = Judger.Judge(submission, context.TestCases[i],
                    context.JudgeStrategy, context.CheckStrategy);

                AddResult(result);
            }

            MessageBox.Show(Resource.Completed, Resource.Message, MessageBoxButtons.OK);
        }

        private void AddResult(JudgeResult result)
        {
            ListViewItem item = new ListViewItem(lvwResult.Items.Count + 1 + "");
            item.SubItems.Add(result.Time.ToString());
            item.SubItems.Add(result.Memory.ToString());

            string message = result.IsPassed ? Resource.Correct
                : result.HasError ? result.Message : Resource.Incorrect;

            item.SubItems.Add(message);

            lvwResult.Items.Add(item);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }

        private void InitializeListView()
        {
            lvwResult.View = View.Details;
            lvwResult.GridLines = true;

            int totalWidth = lvwResult.Width;

            lvwResult.Columns.Add("#", totalWidth * 10 / 100);
            lvwResult.Columns.Add(Resource.ExecutionTime, totalWidth * 30 / 100);
            lvwResult.Columns.Add(Resource.MemoryUsed, totalWidth * 30 / 100);
            lvwResult.Columns.Add(Resource.Message, totalWidth * 30 / 100);
        }

        private void AboutStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resource.Author + "\n" + Resource.SID, Resource.Message);
        }
    }
}
