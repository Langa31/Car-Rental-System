namespace CarsDatabase
{
    partial class Frmsearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDatabase.HireDataSet1();
            this.tableTableAdapter = new CarsDatabase.HireDataSet1TableAdapters.TableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cboOperator);
            this.groupBox1.Controls.Add(this.cboField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblOperator);
            this.groupBox1.Controls.Add(this.lblField);
            this.groupBox1.Location = new System.Drawing.Point(67, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(645, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "=>",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(213, 66);
            this.cboOperator.Margin = new System.Windows.Forms.Padding(4);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(73, 24);
            this.cboOperator.TabIndex = 4;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Make",
            "Engine Size",
            "Rental Per Day",
            "Available"});
            this.cboField.Location = new System.Drawing.Point(8, 66);
            this.cboField.Margin = new System.Windows.Forms.Padding(4);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(151, 24);
            this.cboField.TabIndex = 3;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(209, 20);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 16);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(37, 20);
            this.lblField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(37, 16);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Field";
            this.lblField.Click += new System.EventHandler(this.lblField_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(773, 71);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 59);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(773, 138);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 59);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegNoDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(857, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // vehicleRegNoDataGridViewTextBoxColumn
            // 
            this.vehicleRegNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.HeaderText = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleRegNoDataGridViewTextBoxColumn.Name = "vehicleRegNoDataGridViewTextBoxColumn";
            this.vehicleRegNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Width = 125;
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            this.engineSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            this.dateRegisteredDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalPerDayDataGridViewTextBoxColumn
            // 
            this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
            this.rentalPerDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            this.availableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hireDataSet;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Frmsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmsearch";
            this.Text = "Task A Search";
            this.Load += new System.EventHandler(this.Frmsearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HireDataSet1 hireDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private HireDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}