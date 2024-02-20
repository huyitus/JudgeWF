using Core;
using Core.CheckStrategies;
using Core.JudgeStrategies;

namespace GUI
{
    public partial class JudgerForm : Form
    {
        private Context context;

        public JudgerForm()
        {
            InitializeComponent();
            context = Context.GetInstance();
        }

        private void JudgerForm_Load(object sender, EventArgs e)
        {
            cboJudgeStrategy.DataSource = Judger.GetAvailabelJudgeStrategies("Configurations\\API");
            cboJudgeStrategy.DisplayMember = "DisplayName";
            cboJudgeStrategy.Text = context.JudgeStrategy != null
                ? context.JudgeStrategy.DisplayName : "";

            cboCheckStrategy.DataSource = Judger.GetAvailableCheckStrategies();
            cboCheckStrategy.DisplayMember = "DisplayName";
            if (context.CheckStrategy != null)
            {
                if (context.CheckStrategy.DisplayName == "Custom")
                {
                    chkUseCustomChecker.Checked = true;
                    txtCheckerPath.Text = context.CheckerFilePath;
                    cboCheckerLanguage.Text = context.CheckerLanguage;
                }
                else
                {
                    chkUseCustomChecker.Checked = false;
                    cboCheckStrategy.Text = context.CheckStrategy.DisplayName;
                }
            }

            cboSubmissionLanguage.Text = context.SubmissionLanguage ?? "";
        }

        private void JudgeStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJudgeStrategy.SelectedItem is IJudgeStrategy selectedStrategy)
            {
                cboSubmissionLanguage.DataSource = selectedStrategy.GetSupportLanguages();
                cboCheckerLanguage.DataSource = selectedStrategy.GetSupportLanguages();
            }
            else
            {
                cboSubmissionLanguage.DataSource = null;
            }
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            context.JudgeStrategy = (IJudgeStrategy)cboJudgeStrategy.SelectedItem;
            context.SubmissionLanguage = cboSubmissionLanguage.Text;
            if (chkUseCustomChecker.Checked)
            {
                if (!File.Exists(txtCheckerPath.Text))
                {
                    MessageBox.Show(Resource.CheckerNotExists, Resource.Message);
                    return;
                }
                context.CheckerFilePath = txtCheckerPath.Text;
                context.CheckerLanguage = cboCheckerLanguage.Text;
                string sourceCode = File.ReadAllText(txtCheckerPath.Text);
                context.CheckStrategy = new CustomCheckStrategy(sourceCode, context.CheckerLanguage, context.JudgeStrategy);
            }
            else
            {
                context.CheckStrategy = (ICheckStrategy)cboCheckStrategy.SelectedItem;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UseCustomChecker_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckerPath.Enabled = chkUseCustomChecker.Checked;
            btnBrowseChecker.Enabled = chkUseCustomChecker.Checked;
            cboCheckerLanguage.Enabled = chkUseCustomChecker.Checked;
            cboCheckStrategy.Enabled = !chkUseCustomChecker.Checked;
        }

        private void BrowseCheckerButton_Click(object sender, EventArgs e)
        {
            string filePath = BrowseFile();

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            txtCheckerPath.Text = filePath;
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
    }
}
