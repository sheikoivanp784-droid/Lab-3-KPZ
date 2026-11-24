using System.Drawing;
using System.Windows.Forms;

namespace SingletonDemoApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblSecondHashes;
        private TextBox txtSecondSql;
        private Button btnSecondExec;
        private ListBox lstSecondHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSecondHashes = new Label();
            this.txtSecondSql = new TextBox();
            this.btnSecondExec = new Button();
            this.lstSecondHistory = new ListBox();
            this.SuspendLayout();

            // lblSecondHashes
            this.lblSecondHashes.AutoSize = true;
            this.lblSecondHashes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSecondHashes.Location = new Point(12, 9);
            this.lblSecondHashes.Name = "lblSecondHashes";
            this.lblSecondHashes.Size = new Size(120, 15);
            this.lblSecondHashes.Text = "HashCodes (Form2):";

            // txtSecondSql
            this.txtSecondSql.Location = new Point(12, 35);
            this.txtSecondSql.Name = "txtSecondSql";
            this.txtSecondSql.Size = new Size(410, 23);
            this.txtSecondSql.Text = "INSERT INTO Orders VALUES (1, 'Book')";

            // btnSecondExec
            this.btnSecondExec.Location = new Point(430, 34);
            this.btnSecondExec.Name = "btnSecondExec";
            this.btnSecondExec.Size = new Size(150, 25);
            this.btnSecondExec.Text = "Виконати з Form2";
            this.btnSecondExec.Click += new System.EventHandler(this.btnSecondExec_Click);

            // lstSecondHistory
            this.lstSecondHistory.Location = new Point(12, 70);
            this.lstSecondHistory.Name = "lstSecondHistory";
            this.lstSecondHistory.Size = new Size(568, 180);

            // Form2
            this.ClientSize = new Size(595, 265);
            this.Controls.Add(this.lblSecondHashes);
            this.Controls.Add(this.txtSecondSql);
            this.Controls.Add(this.btnSecondExec);
            this.Controls.Add(this.lstSecondHistory);
            this.Name = "Form2";
            this.Text = "Лаб 3 - Патерн Singleton (Form2)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}