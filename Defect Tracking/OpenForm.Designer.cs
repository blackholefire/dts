namespace Defect_Tracking
{
    partial class OpenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addBug_btn = new System.Windows.Forms.Button();
            this.updateBugs_btn = new System.Windows.Forms.Button();
            this.bug_DatabaseDataSet = new Defect_Tracking.Bug_DatabaseDataSet();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsTableAdapter = new Defect_Tracking.Bug_DatabaseDataSetTableAdapters.BugsTableAdapter();
            this.tableAdapterManager = new Defect_Tracking.Bug_DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bug_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBug_btn
            // 
            this.addBug_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBug_btn.Location = new System.Drawing.Point(12, 41);
            this.addBug_btn.Name = "addBug_btn";
            this.addBug_btn.Size = new System.Drawing.Size(115, 69);
            this.addBug_btn.TabIndex = 0;
            this.addBug_btn.Text = "Add New Bug";
            this.addBug_btn.UseVisualStyleBackColor = true;
            this.addBug_btn.Click += new System.EventHandler(this.addBug_btn_Click);
            // 
            // updateBugs_btn
            // 
            this.updateBugs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBugs_btn.Location = new System.Drawing.Point(136, 41);
            this.updateBugs_btn.Name = "updateBugs_btn";
            this.updateBugs_btn.Size = new System.Drawing.Size(115, 69);
            this.updateBugs_btn.TabIndex = 1;
            this.updateBugs_btn.Text = "Update Bugs";
            this.updateBugs_btn.UseVisualStyleBackColor = true;
            this.updateBugs_btn.Click += new System.EventHandler(this.updateBugs_btn_Click);
            // 
            // bug_DatabaseDataSet
            // 
            this.bug_DatabaseDataSet.DataSetName = "Bug_DatabaseDataSet";
            this.bug_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.bug_DatabaseDataSet;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = this.bugsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Defect_Tracking.Bug_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 145);
            this.Controls.Add(this.updateBugs_btn);
            this.Controls.Add(this.addBug_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OpenForm";
            this.Text = "Defect Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.bug_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBug_btn;
        private System.Windows.Forms.Button updateBugs_btn;
        private Bug_DatabaseDataSet bug_DatabaseDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private Bug_DatabaseDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private Bug_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

