namespace Course_Managment.Instructor.Upd_del
{
    partial class DelCrs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSHIDDENDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eXAMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CrsManagementDataSet = new Course_Managment.CrsManagementDataSet();
            this.cOURSETableAdapter = new Course_Managment.CrsManagementDataSetTableAdapters.COURSETableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(151, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Delete course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "show data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.eXAMNAMEDataGridViewTextBoxColumn,
            this.cRSNAMEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.iSHIDDENDataGridViewCheckBoxColumn,
            this.eXAMCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOURSEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(547, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(559, 265);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eXAMNAMEDataGridViewTextBoxColumn
            // 
            this.eXAMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.HeaderText = "EXAMNAME";
            this.eXAMNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eXAMNAMEDataGridViewTextBoxColumn.Name = "eXAMNAMEDataGridViewTextBoxColumn";
            this.eXAMNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cRSNAMEDataGridViewTextBoxColumn
            // 
            this.cRSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.HeaderText = "CRSNAME";
            this.cRSNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cRSNAMEDataGridViewTextBoxColumn.Name = "cRSNAMEDataGridViewTextBoxColumn";
            this.cRSNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSHIDDENDataGridViewCheckBoxColumn
            // 
            this.iSHIDDENDataGridViewCheckBoxColumn.DataPropertyName = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.HeaderText = "ISHIDDEN";
            this.iSHIDDENDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.iSHIDDENDataGridViewCheckBoxColumn.Name = "iSHIDDENDataGridViewCheckBoxColumn";
            this.iSHIDDENDataGridViewCheckBoxColumn.Width = 150;
            // 
            // eXAMCIDDataGridViewTextBoxColumn
            // 
            this.eXAMCIDDataGridViewTextBoxColumn.DataPropertyName = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.HeaderText = "EXAMCID";
            this.eXAMCIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eXAMCIDDataGridViewTextBoxColumn.Name = "eXAMCIDDataGridViewTextBoxColumn";
            this.eXAMCIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.CrsManagementDataSet;
            // 
            // CrsManagementDataSet
            // 
            this.CrsManagementDataSet.DataSetName = "CrsManagementDataSet";
            this.CrsManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 446);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DelCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DelCrs";
            this.Text = "Delete course";
            this.Load += new System.EventHandler(this.DelCrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrsManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrsManagementDataSet CrsManagementDataSet;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private CrsManagementDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSHIDDENDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAMCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}
