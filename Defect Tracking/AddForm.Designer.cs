namespace Defect_Tracking
{
    partial class AddForm
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
            this.description_text = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTime_label = new System.Windows.Forms.Label();
            this.severity_label = new System.Windows.Forms.Label();
            this.severity_dropdown = new System.Windows.Forms.ComboBox();
            this.crash_checkbox = new System.Windows.Forms.CheckBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description_text
            // 
            this.description_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_text.Location = new System.Drawing.Point(12, 39);
            this.description_text.Multiline = true;
            this.description_text.Name = "description_text";
            this.description_text.Size = new System.Drawing.Size(506, 168);
            this.description_text.TabIndex = 0;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(8, 16);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(179, 20);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "Describe the bug below:";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(135, 213);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(194, 26);
            this.dateTime.TabIndex = 2;
            // 
            // dateTime_label
            // 
            this.dateTime_label.AutoSize = true;
            this.dateTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_label.Location = new System.Drawing.Point(12, 213);
            this.dateTime_label.Name = "dateTime_label";
            this.dateTime_label.Size = new System.Drawing.Size(117, 20);
            this.dateTime_label.TabIndex = 3;
            this.dateTime_label.Text = "Date and Time:";
            // 
            // severity_label
            // 
            this.severity_label.AutoSize = true;
            this.severity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severity_label.Location = new System.Drawing.Point(335, 213);
            this.severity_label.Name = "severity_label";
            this.severity_label.Size = new System.Drawing.Size(69, 20);
            this.severity_label.TabIndex = 4;
            this.severity_label.Text = "Severity:";
            // 
            // severity_dropdown
            // 
            this.severity_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severity_dropdown.FormattingEnabled = true;
            this.severity_dropdown.Items.AddRange(new object[] {
            "Minor",
            "Major",
            "Critical"});
            this.severity_dropdown.Location = new System.Drawing.Point(410, 210);
            this.severity_dropdown.Name = "severity_dropdown";
            this.severity_dropdown.Size = new System.Drawing.Size(108, 28);
            this.severity_dropdown.TabIndex = 5;
            // 
            // crash_checkbox
            // 
            this.crash_checkbox.AutoSize = true;
            this.crash_checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crash_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crash_checkbox.Location = new System.Drawing.Point(389, 244);
            this.crash_checkbox.Name = "crash_checkbox";
            this.crash_checkbox.Size = new System.Drawing.Size(129, 24);
            this.crash_checkbox.TabIndex = 6;
            this.crash_checkbox.Text = "Caused Crash";
            this.crash_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crash_checkbox.UseVisualStyleBackColor = true;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(172, 265);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(182, 47);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Submit Bug Report";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 324);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.crash_checkbox);
            this.Controls.Add(this.severity_dropdown);
            this.Controls.Add(this.severity_label);
            this.Controls.Add(this.dateTime_label);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.description_text);
            this.Name = "AddForm";
            this.Text = "Defect Tracking | Add Bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_text;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label dateTime_label;
        private System.Windows.Forms.Label severity_label;
        private System.Windows.Forms.ComboBox severity_dropdown;
        private System.Windows.Forms.CheckBox crash_checkbox;
        private System.Windows.Forms.Button submit_btn;
    }
}