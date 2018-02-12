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
    public partial class AddForm : Form
    {

        public AddForm()
        {
            InitializeComponent();
            this.dateTime.Format = DateTimePickerFormat.Custom;
            
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            //Create new row
            
            try {
                if (string.IsNullOrWhiteSpace(description_text.Text))
                    throw new Exception("Must include a description");
                if (string.IsNullOrWhiteSpace(severity_dropdown.Text))
                    throw new Exception("Must give a severtiy ranking");

                Bug_DatabaseDataSet bugSet = new Bug_DatabaseDataSet();
                Bug_DatabaseDataSetTableAdapters.BugsTableAdapter bugTableAdapter = new Bug_DatabaseDataSetTableAdapters.BugsTableAdapter();
                Bug_DatabaseDataSet.BugsRow newBugRow;
                newBugRow = bugSet.Bugs.NewBugsRow();
                newBugRow.Cause_Crash = crash_checkbox.Checked;
                newBugRow.Date_and_Time = dateTime.Value;
                newBugRow.Severity = severity_dropdown.Text;
                newBugRow.Description = description_text.Text;

                newBugRow.Status = "New";
                newBugRow.Assigned_To = "Unassigned";


                bugSet.Bugs.Rows.Add(newBugRow);
                bugTableAdapter.Update(bugSet.Bugs);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

    }
}
