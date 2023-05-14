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
            this.room_info_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_cabinetsDataSet = new inventory.inventory_cabinetsDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.teachersTableAdapter();
            this.tableAdapterManager = new inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager();
            this.room_info_viewTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.room_info_viewTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.room_info_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.teacher_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teachers_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.floors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.room_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.teacher_insert = new System.Windows.Forms.Button();
            this.room_delete = new System.Windows.Forms.Button();
            this.teacher_delete = new System.Windows.Forms.Button();
            this.room_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // room_info_viewBindingSource
            // 
            this.room_info_viewBindingSource.DataMember = "room_info_view";
            this.room_info_viewBindingSource.DataSource = this.inventory_cabinetsDataSet;
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
            // room_info_viewTableAdapter
            // 
            this.room_info_viewTableAdapter.ClearBeforeFill = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 500);
            this.tableLayoutPanel1.TabIndex = 22;
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
            this.room_info_viewDataGridView.Size = new System.Drawing.Size(774, 494);
            this.room_info_viewDataGridView.TabIndex = 1;
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
            this.teachersDataGridView.Size = new System.Drawing.Size(514, 494);
            this.teachersDataGridView.TabIndex = 2;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.teacher_name, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.teacher_phone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.teachers_name, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.floors, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.room_name, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 60);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "имя преподавателя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(265, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "контактный телефон";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teacher_name
            // 
            this.teacher_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_name.Location = new System.Drawing.Point(3, 33);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(254, 22);
            this.teacher_name.TabIndex = 1;
            // 
            // teacher_phone
            // 
            this.teacher_phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_phone.Location = new System.Drawing.Point(263, 33);
            this.teacher_phone.Name = "teacher_phone";
            this.teacher_phone.Size = new System.Drawing.Size(254, 22);
            this.teacher_phone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(525, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "номер кабинета";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teachers_name
            // 
            this.teachers_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachers_name.Location = new System.Drawing.Point(1043, 33);
            this.teachers_name.Name = "teachers_name";
            this.teachers_name.Size = new System.Drawing.Size(254, 22);
            this.teachers_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(1045, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "ответственное лицо";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // floors
            // 
            this.floors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floors.Location = new System.Drawing.Point(783, 33);
            this.floors.Name = "floors";
            this.floors.Size = new System.Drawing.Size(254, 22);
            this.floors.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(785, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "этаж";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // room_name
            // 
            this.room_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_name.Location = new System.Drawing.Point(523, 33);
            this.room_name.Name = "room_name";
            this.room_name.Size = new System.Drawing.Size(254, 22);
            this.room_name.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.teacher_insert, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.room_delete, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.teacher_delete, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.room_insert, 8, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 560);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1300, 40);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // teacher_insert
            // 
            this.teacher_insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_insert.Location = new System.Drawing.Point(263, 3);
            this.teacher_insert.Name = "teacher_insert";
            this.teacher_insert.Size = new System.Drawing.Size(124, 34);
            this.teacher_insert.TabIndex = 11;
            this.teacher_insert.Text = "добавить";
            this.teacher_insert.UseVisualStyleBackColor = true;
            this.teacher_insert.Click += new System.EventHandler(this.teacher_insert_Click);
            // 
            // room_delete
            // 
            this.room_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_delete.Location = new System.Drawing.Point(1173, 3);
            this.room_delete.Name = "room_delete";
            this.room_delete.Size = new System.Drawing.Size(124, 34);
            this.room_delete.TabIndex = 18;
            this.room_delete.Text = "удалить";
            this.room_delete.UseVisualStyleBackColor = true;
            this.room_delete.Click += new System.EventHandler(this.room_delete_Click);
            // 
            // teacher_delete
            // 
            this.teacher_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_delete.Location = new System.Drawing.Point(393, 3);
            this.teacher_delete.Name = "teacher_delete";
            this.teacher_delete.Size = new System.Drawing.Size(124, 34);
            this.teacher_delete.TabIndex = 17;
            this.teacher_delete.Text = "удалить";
            this.teacher_delete.UseVisualStyleBackColor = true;
            this.teacher_delete.Click += new System.EventHandler(this.teacher_delete_Click);
            // 
            // room_insert
            // 
            this.room_insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_insert.Location = new System.Drawing.Point(1043, 3);
            this.room_insert.Name = "room_insert";
            this.room_insert.Size = new System.Drawing.Size(124, 34);
            this.room_insert.TabIndex = 12;
            this.room_insert.Text = "добавить";
            this.room_insert.UseVisualStyleBackColor = true;
            this.room_insert.Click += new System.EventHandler(this.room_insert_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room_info_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private inventory_cabinetsDataSet inventory_cabinetsDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private inventory_cabinetsDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private inventory_cabinetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource room_info_viewBindingSource;
        private inventory_cabinetsDataSetTableAdapters.room_info_viewTableAdapter room_info_viewTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView room_info_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.TextBox teacher_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teachers_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox floors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox room_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button teacher_insert;
        private System.Windows.Forms.Button room_delete;
        private System.Windows.Forms.Button teacher_delete;
        private System.Windows.Forms.Button room_insert;
    }
}