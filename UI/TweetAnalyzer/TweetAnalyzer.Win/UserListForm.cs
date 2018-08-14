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
    public partial class UserListForm : Form, IStandardToolbar
    {
        public UserListForm(ShowMode showMode = ShowMode.List)
        {
            InitializeComponent();
            this.showMode = showMode;
        }

        public decimal SelectedUserId { get; private set; }

        private ShowMode showMode;

        public bool CanAddItem => true;

        public bool CanDeleteItem => true;

        public bool CanEditItem => true;

        public bool CanViewItem => true;

        public bool CanRefreshList => true;

        public void AddItem()
        {
            UserForm userForm = new UserForm(ShowMode.Add);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        public void DeleteItem()
        {
            if(!HasSelectedRow())
                return;

            UserForm userForm = new UserForm(GetSelectedUserId(), ShowMode.Delete);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        public void EditItem()
        {
            if (!HasSelectedRow())
                return;

            UserForm userForm = new UserForm(GetSelectedUserId(), ShowMode.Edit);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private decimal GetSelectedUserId()
        {
            decimal result=0;

            if(HasSelectedRow())
            {
                DataGridViewSelectedRowCollection selectedRowCollection = MainDataGridView.SelectedRows;
                result = (decimal)selectedRowCollection[0].Cells["Id"].Value;
            }


            return result;
        }

        private bool HasSelectedRow()
        {
            return MainDataGridView.SelectedRows.Count > 0;
        }

        public void RefreshList()
        {
            MainDataGridView.DataSource = new Dac().ExecuteDataTable("select * from User").Result;
        }

        public void ViewItem()
        {
            if (!HasSelectedRow())
                return;

            UserForm userForm = new UserForm(GetSelectedUserId(), ShowMode.View);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void MainDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.showMode == ShowMode.Select && this.HasSelectedRow())
            {
                this.SelectedUserId = this.GetSelectedUserId();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
