using System;
using System.Windows.Forms;
using SingletonLibrary;

namespace SingletonDemoApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            lblSecondHashes.Text = $"HashCodes (Form2): " +
                                   $"DBManager={DBManager.getInstance().GetHashCode()} | " +
                                   $"Logger={Logger.getInstance().GetHashCode()} | " +
                                   $"DocumentSaver={DocumentSaver.getInstance().GetHashCode()}";
            RefreshHistory();
        }

        private void btnSecondExec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondSql.Text)) return;

            DBManager.getInstance().executeQuery($"[Form2] {txtSecondSql.Text}");
            txtSecondSql.Clear();
            RefreshHistory();
        }

        private void RefreshHistory()
        {
            lstSecondHistory.Items.Clear();
            foreach (var q in DBManager.getInstance().getQueryHistory())
            {
                lstSecondHistory.Items.Add(q);
            }
        }
    }
}