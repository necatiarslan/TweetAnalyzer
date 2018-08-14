using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TweetAnalyzer.Win
{
    class UIHelper
    {
        public static void SetGridColumns(DataGridView dataGridView, params string[] columnNames)
        {
            List<string> columnList = columnNames.ToList<string>();

            foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                if (!columnList.Contains(column.Name))
                    column.Visible = false;
                else
                {
                    column.DisplayIndex = columnList.IndexOf(column.Name);  
                }
            }
        }
    }
}
