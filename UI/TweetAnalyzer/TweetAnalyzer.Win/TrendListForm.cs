using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweetAnalyzer.Win
{
    public partial class TrendListForm : Form
    {
        public TrendListForm()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            MainDataGridView.DataSource = TwitterEngine.Trend.GetTrends();
        }
    }
}
