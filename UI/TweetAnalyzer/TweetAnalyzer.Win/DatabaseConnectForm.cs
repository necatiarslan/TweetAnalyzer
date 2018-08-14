using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetAnalyzer.Database;

namespace TweetAnalyzer.Win
{
    public partial class DatabaseConnectForm : Form
    {
        public DatabaseConnectForm()
        {
            InitializeComponent();
        }

        private void SelectDatabaseFileLocation_Load(object sender, EventArgs e)
        {
            if(Dac.Current != null)
            {
                DatabaseFileLocationTextBox.Text = Dac.Current.DatabaseFileLocation;
            }
        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sqlite Database (*.db)|*.db";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DatabaseFileLocationTextBox.Text = openFileDialog.FileName;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            MethodResult<bool> result = Dac.TestDatabaseConnection(DatabaseFileLocationTextBox.Text);
            if(result.IsSuccessful)
            {
                MessageBox.Show("Database Connection Ok :-)");
            }
            else
            {
                MessageBox.Show("Database Connection Error :-(" + Environment.NewLine + result.Exception.ToString());
            }
        }

        private void OkeyButton_Click(object sender, EventArgs e)
        {
            Dac dac = new Dac();
            dac.DatabaseFileLocation = DatabaseFileLocationTextBox.Text;

            MethodResult<bool> result = Dac.TestDatabaseConnection(DatabaseFileLocationTextBox.Text);
            if (result.IsSuccessful)
            {
                dac.SaveDatabaseFileLocationToReqistry();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Database Connection Error :-(" + Environment.NewLine + result.Exception.ToString());
            }
        }
    }
}
