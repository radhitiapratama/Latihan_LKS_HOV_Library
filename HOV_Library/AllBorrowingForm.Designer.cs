namespace HOV_Library
{
    partial class AllBorrowingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookdetailsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastupdatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Borrowing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(685, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(359, 27);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(799, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1013, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "and";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Borrow Date  (between)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borrow Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.MemberColumn,
            this.bookTitleColumn,
            this.bookCodeColumn,
            this.borrow_dateColumn,
            this.return_dateColumn,
            this.fineColumn,
            this.btnReturnColumn,
            this.idDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.bookdetailsidDataGridViewTextBoxColumn,
            this.borrowdateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.lastupdatedatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn,
            this.bookDetailDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(59, 318);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // MemberColumn
            // 
            this.MemberColumn.DataPropertyName = "Member";
            this.MemberColumn.HeaderText = "Member Name";
            this.MemberColumn.MinimumWidth = 6;
            this.MemberColumn.Name = "MemberColumn";
            this.MemberColumn.ReadOnly = true;
            // 
            // bookTitleColumn
            // 
            this.bookTitleColumn.HeaderText = "Book Title";
            this.bookTitleColumn.MinimumWidth = 6;
            this.bookTitleColumn.Name = "bookTitleColumn";
            this.bookTitleColumn.ReadOnly = true;
            // 
            // bookCodeColumn
            // 
            this.bookCodeColumn.HeaderText = "Book Code";
            this.bookCodeColumn.MinimumWidth = 6;
            this.bookCodeColumn.Name = "bookCodeColumn";
            this.bookCodeColumn.ReadOnly = true;
            // 
            // borrow_dateColumn
            // 
            this.borrow_dateColumn.DataPropertyName = "borrow_date";
            this.borrow_dateColumn.HeaderText = "Borrow Date";
            this.borrow_dateColumn.MinimumWidth = 6;
            this.borrow_dateColumn.Name = "borrow_dateColumn";
            this.borrow_dateColumn.ReadOnly = true;
            // 
            // return_dateColumn
            // 
            this.return_dateColumn.DataPropertyName = "return_date";
            this.return_dateColumn.HeaderText = "Return Date";
            this.return_dateColumn.MinimumWidth = 6;
            this.return_dateColumn.Name = "return_dateColumn";
            this.return_dateColumn.ReadOnly = true;
            // 
            // fineColumn
            // 
            this.fineColumn.DataPropertyName = "fine";
            this.fineColumn.HeaderText = "Fine";
            this.fineColumn.MinimumWidth = 6;
            this.fineColumn.Name = "fineColumn";
            this.fineColumn.ReadOnly = true;
            // 
            // btnReturnColumn
            // 
            this.btnReturnColumn.HeaderText = "";
            this.btnReturnColumn.MinimumWidth = 6;
            this.btnReturnColumn.Name = "btnReturnColumn";
            this.btnReturnColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "member_id";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookdetailsidDataGridViewTextBoxColumn
            // 
            this.bookdetailsidDataGridViewTextBoxColumn.DataPropertyName = "bookdetails_id";
            this.bookdetailsidDataGridViewTextBoxColumn.HeaderText = "bookdetails_id";
            this.bookdetailsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookdetailsidDataGridViewTextBoxColumn.Name = "bookdetailsidDataGridViewTextBoxColumn";
            this.bookdetailsidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookdetailsidDataGridViewTextBoxColumn.Visible = false;
            // 
            // borrowdateDataGridViewTextBoxColumn
            // 
            this.borrowdateDataGridViewTextBoxColumn.DataPropertyName = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.HeaderText = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowdateDataGridViewTextBoxColumn.Name = "borrowdateDataGridViewTextBoxColumn";
            this.borrowdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "return_date";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "return_date";
            this.returndateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            this.returndateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returndateDataGridViewTextBoxColumn.Visible = false;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "fine";
            this.fineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            this.fineDataGridViewTextBoxColumn.ReadOnly = true;
            this.fineDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastupdatedatDataGridViewTextBoxColumn
            // 
            this.lastupdatedatDataGridViewTextBoxColumn.DataPropertyName = "last_updated_at";
            this.lastupdatedatDataGridViewTextBoxColumn.HeaderText = "last_updated_at";
            this.lastupdatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastupdatedatDataGridViewTextBoxColumn.Name = "lastupdatedatDataGridViewTextBoxColumn";
            this.lastupdatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastupdatedatDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            this.deletedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedatDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookDetailDataGridViewTextBoxColumn
            // 
            this.bookDetailDataGridViewTextBoxColumn.DataPropertyName = "BookDetail";
            this.bookDetailDataGridViewTextBoxColumn.HeaderText = "BookDetail";
            this.bookDetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookDetailDataGridViewTextBoxColumn.Name = "bookDetailDataGridViewTextBoxColumn";
            this.bookDetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            this.memberDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            this.memberDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(HOV_Library.Borrowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Member";
            this.dataGridViewTextBoxColumn1.HeaderText = "Member Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Member";
            this.dataGridViewTextBoxColumn2.HeaderText = "Member Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Member";
            this.dataGridViewTextBoxColumn3.HeaderText = "Member Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Member";
            this.dataGridViewTextBoxColumn4.HeaderText = "Member Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // AllBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AllBorrowingForm";
            this.Text = "AllBorrowingForm";
            this.Load += new System.EventHandler(this.AllBorrowingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnReturnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookdetailsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}