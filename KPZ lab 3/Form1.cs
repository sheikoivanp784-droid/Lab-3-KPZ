using KPZ_lab_3;
using SingletonLibrary;
using System;
using System.Text;
using System.Windows.Forms;

namespace SingletonDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Logger.getInstance().logAction("Form1", "Відкрито головну форму.");
            UpdateHashesLabel();
            RefreshUI();
        }

        private void UpdateHashesLabel()
        {
            lblHashes.Text = $"HashCodes (Form1): " +
                             $"DBManager={DBManager.getInstance().GetHashCode()} | " +
                             $"Logger={Logger.getInstance().GetHashCode()} | " +
                             $"DocumentSaver={DocumentSaver.getInstance().GetHashCode()}";
        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSql.Text)) return;

            DBManager.getInstance().executeQuery(txtSql.Text);
            txtSql.Clear();
            RefreshUI();
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            DBManager.getInstance().closeConnection();
            RefreshUI();
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            string name = string.IsNullOrWhiteSpace(txtDocName.Text) ? "document.txt" : txtDocName.Text;
            byte[] data = Encoding.UTF8.GetBytes(txtDocContent.Text);

            bool ok = DocumentSaver.getInstance().saveDocument(name, data);
            if (ok)
            {
                Logger.getInstance().logAction("Form1", $"Збережено документ '{name}' ({data.Length} байт)");
                MessageBox.Show("Документ успішно збережено!", "DocumentSaver");
                RefreshUI();
            }
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            Logger.getInstance().clearLogs();
            RefreshUI();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Logger.getInstance().logAction("Form1", "Відкрито другу форму (Form2).");
            var form2 = new Form2();
            form2.FormClosed += (s, args) => RefreshUI();
            form2.Show();
        }

        private void RefreshUI()
        {
            lstQueries.Items.Clear();
            foreach (var q in DBManager.getInstance().getQueryHistory())
            {
                lstQueries.Items.Add(q);
            }

            txtLogs.Text = Logger.getInstance().readLogsText();
        }
    }
}