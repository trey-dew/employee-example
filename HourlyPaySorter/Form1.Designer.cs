namespace HourlyPaySorter
{
    partial class Form1
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelDataSet = new HourlyPaySorter.PersonnelDataSet();
            this.employeeTableAdapter = new HourlyPaySorter.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new HourlyPaySorter.PersonnelDataSetTableAdapters.TableAdapterManager();
            this.sortAscToolStrip = new System.Windows.Forms.ToolStrip();
            this.sortAscToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortDesc1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.sortDesc1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            this.sortAscToolStrip.SuspendLayout();
            this.sortDesc1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(191, 120);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(452, 220);
            this.employeeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Position";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HourlyRate";
            this.dataGridViewTextBoxColumn4.HeaderText = "HourlyRate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.personnelDataSet;
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = HourlyPaySorter.PersonnelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sortAscToolStrip
            // 
            this.sortAscToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortAscToolStripButton});
            this.sortAscToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sortAscToolStrip.Name = "sortAscToolStrip";
            this.sortAscToolStrip.Size = new System.Drawing.Size(800, 25);
            this.sortAscToolStrip.TabIndex = 4;
            this.sortAscToolStrip.Text = "sortAscToolStrip";
            // 
            // sortAscToolStripButton
            // 
            this.sortAscToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortAscToolStripButton.Name = "sortAscToolStripButton";
            this.sortAscToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.sortAscToolStripButton.Text = "sortAsc";
            this.sortAscToolStripButton.Click += new System.EventHandler(this.sortAscToolStripButton_Click);
            // 
            // sortDesc1ToolStrip
            // 
            this.sortDesc1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortDesc1ToolStripButton});
            this.sortDesc1ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.sortDesc1ToolStrip.Name = "sortDesc1ToolStrip";
            this.sortDesc1ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.sortDesc1ToolStrip.TabIndex = 5;
            this.sortDesc1ToolStrip.Text = "sortDesc1ToolStrip";
            // 
            // sortDesc1ToolStripButton
            // 
            this.sortDesc1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortDesc1ToolStripButton.Name = "sortDesc1ToolStripButton";
            this.sortDesc1ToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.sortDesc1ToolStripButton.Text = "sortDesc1";
            this.sortDesc1ToolStripButton.Click += new System.EventHandler(this.sortDesc1ToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortDesc1ToolStrip);
            this.Controls.Add(this.sortAscToolStrip);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            this.sortAscToolStrip.ResumeLayout(false);
            this.sortAscToolStrip.PerformLayout();
            this.sortDesc1ToolStrip.ResumeLayout(false);
            this.sortDesc1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private PersonnelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip sortAscToolStrip;
        private System.Windows.Forms.ToolStripButton sortAscToolStripButton;
        private System.Windows.Forms.ToolStrip sortDesc1ToolStrip;
        private System.Windows.Forms.ToolStripButton sortDesc1ToolStripButton;
    }
}

