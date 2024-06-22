
namespace shop1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kkk = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghimatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mojodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new shop1.shopDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labry2DataSet = new shop1.Labry2DataSet();
            this.labry2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.madrakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.madrakTableAdapter = new shop1.Labry2DataSetTableAdapters.MadrakTableAdapter();
            this.kalaTableAdapter = new shop1.shopDataSetTableAdapters.kalaTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labry2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labry2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madrakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kkk);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // kkk
            // 
            this.kkk.Location = new System.Drawing.Point(4, 25);
            this.kkk.Name = "kkk";
            this.kkk.Padding = new System.Windows.Forms.Padding(3);
            this.kkk.Size = new System.Drawing.Size(1085, 419);
            this.kkk.TabIndex = 2;
            this.kkk.Text = "برگه خرید";
            this.kkk.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1085, 419);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "کالا";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ghimatDataGridViewTextBoxColumn,
            this.mojodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kalaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 410);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghimatDataGridViewTextBoxColumn
            // 
            this.ghimatDataGridViewTextBoxColumn.DataPropertyName = "ghimat";
            this.ghimatDataGridViewTextBoxColumn.HeaderText = "ghimat";
            this.ghimatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghimatDataGridViewTextBoxColumn.Name = "ghimatDataGridViewTextBoxColumn";
            this.ghimatDataGridViewTextBoxColumn.Width = 125;
            // 
            // mojodiDataGridViewTextBoxColumn
            // 
            this.mojodiDataGridViewTextBoxColumn.DataPropertyName = "mojodi";
            this.mojodiDataGridViewTextBoxColumn.HeaderText = "mojodi";
            this.mojodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mojodiDataGridViewTextBoxColumn.Name = "mojodiDataGridViewTextBoxColumn";
            this.mojodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalaBindingSource
            // 
            this.kalaBindingSource.DataMember = "kala";
            this.kalaBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(708, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 291);
            this.panel1.TabIndex = 1;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(191, 227);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(52, 44);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(245, 227);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(52, 44);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "ویرایش";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(304, 227);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(52, 44);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "ثبت جدید";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid1);
            this.groupBox1.Controls.Add(this.txtname1);
            this.groupBox1.Location = new System.Drawing.Point(708, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کالا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد کالا";
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(52, 21);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(235, 22);
            this.txtid1.TabIndex = 4;
            // 
            // txtname1
            // 
            this.txtname1.Location = new System.Drawing.Point(52, 73);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(235, 22);
            this.txtname1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1085, 419);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "مشتری";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1085, 419);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "گزارش";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labry2DataSet
            // 
            this.labry2DataSet.DataSetName = "Labry2DataSet";
            this.labry2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labry2DataSetBindingSource
            // 
            this.labry2DataSetBindingSource.DataSource = this.labry2DataSet;
            this.labry2DataSetBindingSource.Position = 0;
            // 
            // madrakBindingSource
            // 
            this.madrakBindingSource.DataMember = "Madrak";
            this.madrakBindingSource.DataSource = this.labry2DataSet;
            // 
            // madrakTableAdapter
            // 
            this.madrakTableAdapter.ClearBeforeFill = true;
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labry2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labry2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madrakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kkk;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource labry2DataSetBindingSource;
        private Labry2DataSet labry2DataSet;
        private System.Windows.Forms.BindingSource madrakBindingSource;
        private Labry2DataSetTableAdapters.MadrakTableAdapter madrakTableAdapter;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource kalaBindingSource;
        private shopDataSetTableAdapters.kalaTableAdapter kalaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghimatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mojodiDataGridViewTextBoxColumn;
    }
}

