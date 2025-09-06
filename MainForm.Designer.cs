namespace MunicipalityApp;

partial class MainForm : System.Windows.Forms.Form
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
        // Theme Colors and Fonts
        var primaryBlue = System.Drawing.Color.FromArgb(0, 30, 60);
        var accentGold = System.Drawing.Color.FromArgb(255, 215, 0);
        var lightTextColor = System.Drawing.Color.WhiteSmoke;
        var controlBackColor = System.Drawing.Color.FromArgb(0, 50, 100);
        var titleFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
        var buttonFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

        // Control Declarations
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnReportIssue = new System.Windows.Forms.Button();
        this.btnViewIssues = new System.Windows.Forms.Button();
        this.btnServiceStatus = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // Form Styling
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        this.BackColor = primaryBlue;
        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Text = "Municipality Services Portal";
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Name = "MainForm";

        // Title Label
        this.lblTitle.Text = "Welcome";
        this.lblTitle.Font = titleFont;
        this.lblTitle.ForeColor = accentGold;
        this.lblTitle.AutoSize = true;
        this.lblTitle.Location = new System.Drawing.Point(220, 40);
        this.lblTitle.Name = "lblTitle";

        // Report Issue Button
        this.btnReportIssue.Text = "Report a New Issue";
        this.btnReportIssue.Font = buttonFont;
        this.btnReportIssue.Size = new System.Drawing.Size(250, 60);
        this.btnReportIssue.Location = new System.Drawing.Point(175, 110);
        this.btnReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReportIssue.BackColor = accentGold;
        this.btnReportIssue.ForeColor = primaryBlue;
        this.btnReportIssue.FlatAppearance.BorderSize = 0;
        this.btnReportIssue.Name = "btnReportIssue";
        this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);

        // View Issues Button
        this.btnViewIssues.Text = "View Submitted Issues";
        this.btnViewIssues.Font = buttonFont;
        this.btnViewIssues.Size = new System.Drawing.Size(250, 60);
        this.btnViewIssues.Location = new System.Drawing.Point(175, 180);
        this.btnViewIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnViewIssues.BackColor = accentGold;
        this.btnViewIssues.ForeColor = primaryBlue;
        this.btnViewIssues.FlatAppearance.BorderColor = accentGold;
        this.btnViewIssues.FlatAppearance.BorderSize = 1;
        this.btnViewIssues.Name = "btnViewIssues";
        this.btnViewIssues.Enabled = false; // Feature not yet implemented
                                            // this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);

        // Service Status Button
        this.btnServiceStatus.Text = "Service Status";
        this.btnServiceStatus.Font = buttonFont;
        this.btnServiceStatus.Size = new System.Drawing.Size(250, 60);
        this.btnServiceStatus.Location = new System.Drawing.Point(175, 250);
        this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnServiceStatus.BackColor = accentGold;
        this.btnServiceStatus.ForeColor = primaryBlue;
        this.btnServiceStatus.FlatAppearance.BorderSize = 0;
        this.btnServiceStatus.FlatAppearance.BorderColor = accentGold;
        this.btnServiceStatus.FlatAppearance.BorderSize = 1;
        this.btnServiceStatus.Name = "btnServiceStatus";
        this.btnServiceStatus.Enabled = false; // Feature not yet implemented
                                            // this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

        // Exit Button
        this.btnExit.Text = "Exit";
        this.btnExit.Font = buttonFont;
        this.btnExit.Size = new System.Drawing.Size(250, 60);
        this.btnExit.Location = new System.Drawing.Point(175, 320);
        this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExit.BackColor = controlBackColor;
        this.btnExit.ForeColor = lightTextColor;
        this.btnExit.FlatAppearance.BorderColor = accentGold;
        this.btnExit.FlatAppearance.BorderSize = 1;
        this.btnExit.Name = "btnExit";
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

        // Logo PictureBox
        this.pbLogo = new System.Windows.Forms.PictureBox();
        this.pbLogo.Size = new System.Drawing.Size(100, 50);
        this.pbLogo.Location = new System.Drawing.Point(10, 340);
        this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pbLogo.BackColor = primaryBlue;
        this.pbLogo.Name = "pbLogo";

        // Add controls to form
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.btnReportIssue);
        this.Controls.Add(this.btnViewIssues);
        this.Controls.Add(this.btnServiceStatus);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.pbLogo);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnReportIssue;
    private System.Windows.Forms.Button btnViewIssues;
    private System.Windows.Forms.Button btnServiceStatus;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.PictureBox pbLogo;
}
