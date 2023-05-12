namespace inventory
{
    partial class Form2
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
            System.Windows.Forms.Label room_idLabel;
            System.Windows.Forms.Label teacher_idLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inventory_cabinetsDataSet = new inventory.inventory_cabinetsDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.teachersTableAdapter();
            this.tableAdapterManager = new inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.room_info_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_info_viewTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.room_info_viewTableAdapter();
            this.room_info_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.teacher_phone = new System.Windows.Forms.TextBox();
            this.room_name = new System.Windows.Forms.TextBox();
            this.floors = new System.Windows.Forms.TextBox();
            this.teachers_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_insert = new System.Windows.Forms.Button();
            this.room_insert = new System.Windows.Forms.Button();
            this.room_idTextBox = new System.Windows.Forms.TextBox();
            this.teacher_idTextBox = new System.Windows.Forms.TextBox();
            this.teacher_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            room_idLabel = new System.Windows.Forms.Label();
            teacher_idLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.room_info_viewDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.teachersDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inventory_cabinetsDataSet
            // 
            this.inventory_cabinetsDataSet.DataSetName = "inventory_cabinetsDataSet";
            this.inventory_cabinetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.inventory_cabinetsDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.equipmentTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.RowHeadersWidth = 51;
            this.teachersDataGridView.RowTemplate.Height = 24;
            this.teachersDataGridView.Size = new System.Drawing.Size(514, 282);
            this.teachersDataGridView.TabIndex = 2;
            // 
            // room_info_viewBindingSource
            // 
            this.room_info_viewBindingSource.DataMember = "room_info_view";
            this.room_info_viewBindingSource.DataSource = this.inventory_cabinetsDataSet;
            // 
            // room_info_viewTableAdapter
            // 
            this.room_info_viewTableAdapter.ClearBeforeFill = true;
            // 
            // room_info_viewDataGridView
            // 
            this.room_info_viewDataGridView.AutoGenerateColumns = false;
            this.room_info_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_info_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.room_info_viewDataGridView.DataSource = this.room_info_viewBindingSource;
            this.room_info_viewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_info_viewDataGridView.Location = new System.Drawing.Point(523, 3);
            this.room_info_viewDataGridView.Name = "room_info_viewDataGridView";
            this.room_info_viewDataGridView.RowHeadersWidth = 51;
            this.room_info_viewDataGridView.RowTemplate.Height = 24;
            this.room_info_viewDataGridView.Size = new System.Drawing.Size(774, 282);
            this.room_info_viewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "teacher_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "teacher_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teacher_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "teacher_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "teacher_phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "teacher_phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "room_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "room_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "room_name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "floor";
            this.dataGridViewTextBoxColumn6.HeaderText = "floor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "teacher_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "teacher_name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(163, 381);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(100, 22);
            this.teacher_name.TabIndex = 1;
            // 
            // teacher_phone
            // 
            this.teacher_phone.Location = new System.Drawing.Point(269, 381);
            this.teacher_phone.Name = "teacher_phone";
            this.teacher_phone.Size = new System.Drawing.Size(100, 22);
            this.teacher_phone.TabIndex = 2;
            // 
            // room_name
            // 
            this.room_name.Location = new System.Drawing.Point(604, 381);
            this.room_name.Name = "room_name";
            this.room_name.Size = new System.Drawing.Size(100, 22);
            this.room_name.TabIndex = 3;
            // 
            // floors
            // 
            this.floors.Location = new System.Drawing.Point(710, 381);
            this.floors.Name = "floors";
            this.floors.Size = new System.Drawing.Size(100, 22);
            this.floors.TabIndex = 4;
            // 
            // teachers_name
            // 
            this.teachers_name.Location = new System.Drawing.Point(815, 381);
            this.teachers_name.Name = "teachers_name";
            this.teachers_name.Size = new System.Drawing.Size(100, 22);
            this.teachers_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // teacher_insert
            // 
            this.teacher_insert.Location = new System.Drawing.Point(163, 409);
            this.teacher_insert.Name = "teacher_insert";
            this.teacher_insert.Size = new System.Drawing.Size(75, 23);
            this.teacher_insert.TabIndex = 11;
            this.teacher_insert.Text = "button1";
            this.teacher_insert.UseVisualStyleBackColor = true;
            this.teacher_insert.Click += new System.EventHandler(this.teacher_insert_Click);
            // 
            // room_insert
            // 
            this.room_insert.Location = new System.Drawing.Point(604, 409);
            this.room_insert.Name = "room_insert";
            this.room_insert.Size = new System.Drawing.Size(75, 23);
            this.room_insert.TabIndex = 12;
            this.room_insert.Text = "button2";
            this.room_insert.UseVisualStyleBackColor = true;
            this.room_insert.Click += new System.EventHandler(this.room_insert_Click);
            // 
            // room_idLabel
            // 
            room_idLabel.AutoSize = true;
            room_idLabel.Location = new System.Drawing.Point(543, 441);
            room_idLabel.Name = "room_idLabel";
            room_idLabel.Size = new System.Drawing.Size(55, 16);
            room_idLabel.TabIndex = 13;
            room_idLabel.Text = "room id:";
            // 
            // room_idTextBox
            // 
            this.room_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.room_info_viewBindingSource, "room_id", true));
            this.room_idTextBox.Location = new System.Drawing.Point(604, 438);
            this.room_idTextBox.Name = "room_idTextBox";
            this.room_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.room_idTextBox.TabIndex = 14;
            // 
            // teacher_idLabel
            // 
            teacher_idLabel.AutoSize = true;
            teacher_idLabel.Location = new System.Drawing.Point(88, 444);
            teacher_idLabel.Name = "teacher_idLabel";
            teacher_idLabel.Size = new System.Drawing.Size(69, 16);
            teacher_idLabel.TabIndex = 15;
            teacher_idLabel.Text = "teacher id:";
            // 
            // teacher_idTextBox
            // 
            this.teacher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "teacher_id", true));
            this.teacher_idTextBox.Location = new System.Drawing.Point(163, 441);
            this.teacher_idTextBox.Name = "teacher_idTextBox";
            this.teacher_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.teacher_idTextBox.TabIndex = 16;
            // 
            // teacher_delete
            // 
            this.teacher_delete.Location = new System.Drawing.Point(269, 441);
            this.teacher_delete.Name = "teacher_delete";
            this.teacher_delete.Size = new System.Drawing.Size(75, 23);
            this.teacher_delete.TabIndex = 17;
            this.teacher_delete.Text = "button3";
            this.teacher_delete.UseVisualStyleBackColor = true;
            this.teacher_delete.Click += new System.EventHandler(this.teacher_delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.teacher_delete);
            this.Controls.Add(teacher_idLabel);
            this.Controls.Add(this.teacher_idTextBox);
            this.Controls.Add(room_idLabel);
            this.Controls.Add(this.room_idTextBox);
            this.Controls.Add(this.room_insert);
            this.Controls.Add(this.teacher_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teachers_name);
            this.Controls.Add(this.floors);
            this.Controls.Add(this.room_name);
            this.Controls.Add(this.teacher_phone);
            this.Controls.Add(this.teacher_name);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private inventory_cabinetsDataSet inventory_cabinetsDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private inventory_cabinetsDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private inventory_cabinetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.BindingSource room_info_viewBindingSource;
        private inventory_cabinetsDataSetTableAdapters.room_info_viewTableAdapter room_info_viewTableAdapter;
        private System.Windows.Forms.DataGridView room_info_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.TextBox teacher_phone;
        private System.Windows.Forms.TextBox room_name;
        private System.Windows.Forms.TextBox floors;
        private System.Windows.Forms.TextBox teachers_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button teacher_insert;
        private System.Windows.Forms.Button room_insert;
        private System.Windows.Forms.TextBox room_idTextBox;
        private System.Windows.Forms.TextBox teacher_idTextBox;
        private System.Windows.Forms.Button teacher_delete;
        private System.Windows.Forms.Button button4;
    }
}