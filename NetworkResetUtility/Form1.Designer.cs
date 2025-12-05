namespace NetworkResetUtility
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressFlush = new System.Windows.Forms.ProgressBar();
            this.progressRelease = new System.Windows.Forms.ProgressBar();
            this.progressWait = new System.Windows.Forms.ProgressBar();
            this.progressRenew = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRenew = new System.Windows.Forms.Label();
            this.labelWait = new System.Windows.Forms.Label();
            this.labelRelease = new System.Windows.Forms.Label();
            this.labelFlush = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Honeydew;
            this.btnStart.Location = new System.Drawing.Point(316, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Azure;
            this.btnRedo.Enabled = false;
            this.btnRedo.Location = new System.Drawing.Point(316, 73);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(141, 30);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.Location = new System.Drawing.Point(316, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressFlush
            // 
            this.progressFlush.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.progressFlush.Location = new System.Drawing.Point(6, 27);
            this.progressFlush.Name = "progressFlush";
            this.progressFlush.Size = new System.Drawing.Size(280, 25);
            this.progressFlush.TabIndex = 7;
            // 
            // progressRelease
            // 
            this.progressRelease.Location = new System.Drawing.Point(6, 72);
            this.progressRelease.Name = "progressRelease";
            this.progressRelease.Size = new System.Drawing.Size(280, 25);
            this.progressRelease.TabIndex = 8;
            // 
            // progressWait
            // 
            this.progressWait.Location = new System.Drawing.Point(6, 118);
            this.progressWait.Name = "progressWait";
            this.progressWait.Size = new System.Drawing.Size(280, 25);
            this.progressWait.TabIndex = 9;
            // 
            // progressRenew
            // 
            this.progressRenew.Location = new System.Drawing.Point(6, 164);
            this.progressRenew.Name = "progressRenew";
            this.progressRenew.Size = new System.Drawing.Size(280, 25);
            this.progressRenew.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRenew);
            this.groupBox1.Controls.Add(this.labelWait);
            this.groupBox1.Controls.Add(this.labelRelease);
            this.groupBox1.Controls.Add(this.labelFlush);
            this.groupBox1.Controls.Add(this.progressRenew);
            this.groupBox1.Controls.Add(this.progressWait);
            this.groupBox1.Controls.Add(this.progressRelease);
            this.groupBox1.Controls.Add(this.progressFlush);
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Reset Steps";
            // 
            // labelRenew
            // 
            this.labelRenew.AutoSize = true;
            this.labelRenew.Location = new System.Drawing.Point(336, 171);
            this.labelRenew.Name = "labelRenew";
            this.labelRenew.Size = new System.Drawing.Size(54, 13);
            this.labelRenew.TabIndex = 14;
            this.labelRenew.Text = "Renew IP";
            this.labelRenew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.labelRenew.Click += new System.EventHandler(this.labelRenew_Click);
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Location = new System.Drawing.Point(332, 126);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(64, 13);
            this.labelWait.TabIndex = 13;
            this.labelWait.Text = "Wait 30 sec";
            this.labelWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRelease
            // 
            this.labelRelease.AutoSize = true;
            this.labelRelease.Location = new System.Drawing.Point(334, 79);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(59, 13);
            this.labelRelease.TabIndex = 12;
            this.labelRelease.Text = "Release IP";
            this.labelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFlush
            // 
            this.labelFlush.AutoSize = true;
            this.labelFlush.Location = new System.Drawing.Point(335, 35);
            this.labelFlush.Name = "labelFlush";
            this.labelFlush.Size = new System.Drawing.Size(58, 13);
            this.labelFlush.TabIndex = 11;
            this.labelFlush.Text = "Flush DNS";
            this.labelFlush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 380);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(445, 60);
            this.txtOutput.TabIndex = 14;
            this.txtOutput.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIntro);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 136);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Welcome to Network Reset Utility! ";
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(18, 39);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(253, 79);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Click Start to flush DNS, release and renew IP addresses. Progress and output are" +
    " displayed below.";
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(0, 443);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(469, 20);
            this.lblFooter.TabIndex = 16;
            this.lblFooter.Text = "© 2025 Jesrey Macasero";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(469, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Reset Utility";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnExit;
        
        private System.Windows.Forms.ProgressBar progressFlush;
        private System.Windows.Forms.ProgressBar progressRelease;
        private System.Windows.Forms.ProgressBar progressWait;
        private System.Windows.Forms.ProgressBar progressRenew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRenew;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Label labelFlush;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIntro;

        private System.Windows.Forms.Label lblFooter;

    }
}
