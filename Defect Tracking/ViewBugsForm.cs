using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defect_Tracking
{
    public partial class ViewBugsForm : Form
    {

        public ViewBugsForm()
        {
            InitializeComponent();
            bugsDataGridView.ReadOnly = false;
            bugsDataGridView.Columns[0].ReadOnly = true;
            bugsDataGridView.Columns[1].ReadOnly = true;
            bugsDataGridView.Columns[2].ReadOnly = true;
            bugsDataGridView.Columns[3].ReadOnly = true;
            bugsDataGridView.Columns[4].ReadOnly = true;
            bugsDataGridView.Columns[5].ReadOnly = false;
            bugsDataGridView.Columns[6].ReadOnly = false;

        }

        private void ViewBugsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bug_DatabaseDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.bug_DatabaseDataSet.Bugs);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bug_DatabaseDataSet);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (bug_DatabaseDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show(" Are you sure you want to close without saving changes", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
            


        }
    }
}
