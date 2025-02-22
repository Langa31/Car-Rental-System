namespace CarsDatabase
{
    partial class frmcars
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVRN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblENG = new System.Windows.Forms.Label();
            this.lblDR = new System.Windows.Forms.Label();
            this.lblRPD = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet1 = new CarsDatabase.HireDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtENG = new System.Windows.Forms.TextBox();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.txtRPD = new System.Windows.Forms.TextBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtVRN = new System.Windows.Forms.TextBox();
            this.tableTableAdapter1 = new CarsDatabase.HireDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager1 = new CarsDatabase.HireDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblVRN
            // 
            this.lblVRN.AutoSize = true;
            this.lblVRN.Location = new System.Drawing.Point(31, 74);
            this.lblVRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVRN.Name = "lblVRN";
            this.lblVRN.Size = new System.Drawing.Size(132, 16);
            this.lblVRN.TabIndex = 1;
            this.lblVRN.Text = "Vehicle Reg Number";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(31, 111);
            this.lblM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(41, 16);
            this.lblM.TabIndex = 2;
            this.lblM.Text = "Make";
            // 
            // lblENG
            // 
            this.lblENG.AutoSize = true;
            this.lblENG.Location = new System.Drawing.Point(31, 154);
            this.lblENG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblENG.Name = "lblENG";
            this.lblENG.Size = new System.Drawing.Size(78, 16);
            this.lblENG.TabIndex = 3;
            this.lblENG.Text = "Engine Size";
            // 
            // lblDR
            // 
            this.lblDR.AutoSize = true;
            this.lblDR.Location = new System.Drawing.Point(31, 201);
            this.lblDR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDR.Name = "lblDR";
            this.lblDR.Size = new System.Drawing.Size(106, 16);
            this.lblDR.TabIndex = 4;
            this.lblDR.Text = "Date Registered";
            this.lblDR.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRPD
            // 
            this.lblRPD.AutoSize = true;
            this.lblRPD.Location = new System.Drawing.Point(31, 249);
            this.lblRPD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPD.Name = "lblRPD";
            this.lblRPD.Size = new System.Drawing.Size(98, 16);
            this.lblRPD.TabIndex = 5;
            this.lblRPD.Text = "Rental Per Day";
            this.lblRPD.Click += new System.EventHandler(this.lblRPD_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(31, 292);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(64, 16);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "Available";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.hireDataSet1;
            // 
            // hireDataSet1
            // 
            this.hireDataSet1.DataSetName = "HireDataSet1";
            this.hireDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hireDataSet1;
            // 
            // txtM
            // 
            this.txtM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Make", true));
            this.txtM.Location = new System.Drawing.Point(351, 102);
            this.txtM.Margin = new System.Windows.Forms.Padding(4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(176, 22);
            this.txtM.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtM, "enter vehicle make");
            // 
            // txtENG
            // 
            this.txtENG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "EngineSize", true));
            this.txtENG.Location = new System.Drawing.Point(351, 145);
            this.txtENG.Margin = new System.Windows.Forms.Padding(4);
            this.txtENG.Name = "txtENG";
            this.txtENG.Size = new System.Drawing.Size(176, 22);
            this.txtENG.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtENG, "enter engine size");
            // 
            // txtDR
            // 
            this.txtDR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "DateRegistered", true));
            this.txtDR.Location = new System.Drawing.Point(351, 192);
            this.txtDR.Margin = new System.Windows.Forms.Padding(4);
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(176, 22);
            this.txtDR.TabIndex = 10;
            // 
            // txtRPD
            // 
            this.txtRPD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "RentalPerDay", true));
            this.txtRPD.Location = new System.Drawing.Point(351, 222);
            this.txtRPD.Margin = new System.Windows.Forms.Padding(4);
            this.txtRPD.Name = "txtRPD";
            this.txtRPD.Size = new System.Drawing.Size(176, 22);
            this.txtRPD.TabIndex = 11;
            this.txtRPD.TextChanged += new System.EventHandler(this.txtRPD_TextChanged);
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Available", true));
            this.chkA.Location = new System.Drawing.Point(351, 290);
            this.chkA.Margin = new System.Windows.Forms.Padding(4);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(18, 17);
            this.chkA.TabIndex = 12;
            this.chkA.UseVisualStyleBackColor = true;
            this.chkA.CheckedChanged += new System.EventHandler(this.chkA_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpdate.Location = new System.Drawing.Point(784, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 48);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(784, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(784, 295);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = " &Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(784, 240);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 48);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(784, 185);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 48);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(784, 129);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 48);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(16, 411);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(100, 36);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(468, 411);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(100, 36);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(360, 411);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 36);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(124, 411);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(100, 36);
            this.btnPre.TabIndex = 22;
            this.btnPre.Text = "Previous";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 417);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 22);
            this.textBox6.TabIndex = 23;
            // 
            // txtVRN
            // 
            this.txtVRN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "VehicleRegNo", true));
            this.txtVRN.Location = new System.Drawing.Point(351, 65);
            this.txtVRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtVRN.Name = "txtVRN";
            this.txtVRN.Size = new System.Drawing.Size(176, 22);
            this.txtVRN.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtVRN, "enter vehicle registration ");
            this.txtVRN.TextChanged += new System.EventHandler(this.txtVRN_TextChanged);
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TableTableAdapter = this.tableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CarsDatabase.HireDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmcars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.txtVRN);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkA);
            this.Controls.Add(this.txtRPD);
            this.Controls.Add(this.txtDR);
            this.Controls.Add(this.txtENG);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblRPD);
            this.Controls.Add(this.lblDR);
            this.Controls.Add(this.lblENG);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblVRN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmcars";
            this.Text = "TaskA Langa ";
            this.Load += new System.EventHandler(this.frmcars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVRN;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblENG;
        private System.Windows.Forms.Label lblDR;
        private System.Windows.Forms.Label lblRPD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtENG;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.TextBox txtRPD;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox textBox6;
        private HireDataSet1 hireDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private HireDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private HireDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolTip toolTip1;
        private HireDataSet1 hireDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private HireDataSet1TableAdapters.TableTableAdapter tableTableAdapter1;
        private HireDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtVRN;
    }
}