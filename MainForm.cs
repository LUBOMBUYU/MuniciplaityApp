using System;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReportIssue_Click(object? sender, EventArgs e)
        {
            this.Hide();
            using (var reportForm = new ReportIssueForm())
            {
                reportForm.ShowDialog();
            }
            this.Show();
        }

        // private void btnViewIssues_Click(object? sender, EventArgs e)
        // {
        //     using (var viewForm = new ViewIssuesForm())
        //     {
        //         viewForm.ShowDialog();
        //     }
        // }

        //   private void btnServiceStatus_Click(object? sender, EventArgs e)
        //{
          //  MessageBox.Show("Service Status feature is under development.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
       // }
        private void btnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}