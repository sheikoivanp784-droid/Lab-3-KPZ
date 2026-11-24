using System.Drawing;
using System.Windows.Forms;

namespace SingletonDemoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblHashes;
        private TextBox txtSql;
        private Button btnExecuteSql;
        private Button btnCloseConn;
        private TextBox txtDocName;
        private TextBox txtDocContent;
        private Button btnSaveDoc;
        private Button btnClearLogs;
        private Button btnOpenForm2;
        private ListBox lstQueries;
        private TextBox txtLogs;

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
            this.lblHashes = new Label();
            this.txtSql = new TextBox();
            this.btnExecuteSql = new Button();
            this.btnCloseConn = new Button();
            this.txtDocName = new TextBox();
            this.txtDocContent = new TextBox();
            this.btnSaveDoc = new Button();
            this.btnClearLogs = new Button();
            this.btnOpenForm2 = new Button();
            this.lstQueries = new ListBox();
            this.txtLogs = new TextBox();
            this.SuspendLayout();

            // lblHashes
            this.lblHashes.AutoSize = true;
            this.lblHashes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblHashes.Location = new Point(12, 9);
            this.lblHashes.Name = "lblHashes";
            this.lblHashes.Size = new Size(120, 15);
            this.lblHashes.Text = "HashCodes:";

            // txtSql
            this.txtSql.Location = new Point(12, 35);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new Size(340, 23);
            this.txtSql.Text = "SELECT * FROM Users";

            // btnExecuteSql
            this.btnExecuteSql.Location = new Point(360, 34);
            this.btnExecuteSql.Name = "btnExecuteSql";
            this.btnExecuteSql.Size = new Size(130, 25);
            this.btnExecuteSql.Text = "Виконати SQL";
            this.btnExecuteSql.Click += new System.EventHandler(this.btnExecuteSql_Click);

            // btnCloseConn
            this.btnCloseConn.Location = new Point(496, 34);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new Size(140, 25);
            this.btnCloseConn.Text = "Закрити з'єднання";
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);

            // lstQueries
            this.lstQueries.Location = new Point(12, 65);
            this.lstQueries.Name = "lstQueries";
            this.lstQueries.Size = new Size(624, 95);

            // txtDocName
            this.txtDocName.Location = new Point(12, 175);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new Size(180, 23);
            this.txtDocName.Text = "zvit.txt";

            // txtDocContent
            this.txtDocContent.Location = new Point(198, 175);
            this.txtDocContent.Name = "txtDocContent";
            this.txtDocContent.Size = new Size(292, 23);
            this.txtDocContent.Text = "Текст документа для збереження";

            // btnSaveDoc
            this.btnSaveDoc.Location = new Point(496, 174);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new Size(140, 25);
            this.btnSaveDoc.Text = "Зберегти документ";
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);

            // txtLogs
            this.txtLogs.Location = new Point(12, 210);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = ScrollBars.Vertical;
            this.txtLogs.Size = new Size(624, 150);

            // btnClearLogs
            this.btnClearLogs.Location = new Point(12, 370);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new Size(140, 28);
            this.btnClearLogs.Text = "Очистити логи";
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);

            // btnOpenForm2
            this.btnOpenForm2.Location = new Point(476, 370);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new Size(160, 28);
            this.btnOpenForm2.Text = "Відкрити Form2";
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);

            // Form1
            this.ClientSize = new Size(650, 412);
            this.Controls.Add(this.lblHashes);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.btnExecuteSql);
            this.Controls.Add(this.btnCloseConn);
            this.Controls.Add(this.lstQueries);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.txtDocContent);
            this.Controls.Add(this.btnSaveDoc);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.btnOpenForm2);
            this.Name = "Form1";
            this.Text = "Лаб 3 - Патерн Singleton (Form1)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}