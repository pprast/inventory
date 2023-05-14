namespace inventory
{
    partial class Form4
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
            System.Windows.Forms.Label teacher_nameLabel;
            System.Windows.Forms.Label equipment_inventory_numberLabel;
            System.Windows.Forms.Label equipment_nameLabel;
            System.Windows.Forms.Label equipment_typeLabel;
            System.Windows.Forms.Label equipment_quantityLabel;
            this.inventory_cabinetsDataSet = new inventory.inventory_cabinetsDataSet();
            this.inventory_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_viewTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.inventory_viewTableAdapter();
            this.tableAdapterManager = new inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager();
            this.inventory_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.equipment_quantity_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_type_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_name_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_inventory_number_checkBox = new System.Windows.Forms.CheckBox();
            this.teacher_name_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_quantityTextBox = new System.Windows.Forms.TextBox();
            this.equipment_typeTextBox = new System.Windows.Forms.TextBox();
            this.equipment_inventory_numberTextBox = new System.Windows.Forms.TextBox();
            this.equipment_nameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_nameTextBox = new System.Windows.Forms.TextBox();
            teacher_nameLabel = new System.Windows.Forms.Label();
            equipment_inventory_numberLabel = new System.Windows.Forms.Label();
            equipment_nameLabel = new System.Windows.Forms.Label();
            equipment_typeLabel = new System.Windows.Forms.Label();
            equipment_quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_viewDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacher_nameLabel
            // 
            teacher_nameLabel.AutoSize = true;
            teacher_nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            teacher_nameLabel.Location = new System.Drawing.Point(3, 0);
            teacher_nameLabel.Name = "teacher_nameLabel";
            teacher_nameLabel.Size = new System.Drawing.Size(254, 30);
            teacher_nameLabel.TabIndex = 3;
            teacher_nameLabel.Text = "teacher name:";
            teacher_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_inventory_numberLabel
            // 
            equipment_inventory_numberLabel.AutoSize = true;
            equipment_inventory_numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_inventory_numberLabel.Location = new System.Drawing.Point(263, 0);
            equipment_inventory_numberLabel.Name = "equipment_inventory_numberLabel";
            equipment_inventory_numberLabel.Size = new System.Drawing.Size(254, 30);
            equipment_inventory_numberLabel.TabIndex = 3;
            equipment_inventory_numberLabel.Text = "equipment inventory number:";
            equipment_inventory_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_nameLabel
            // 
            equipment_nameLabel.AutoSize = true;
            equipment_nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_nameLabel.Location = new System.Drawing.Point(523, 0);
            equipment_nameLabel.Name = "equipment_nameLabel";
            equipment_nameLabel.Size = new System.Drawing.Size(254, 30);
            equipment_nameLabel.TabIndex = 3;
            equipment_nameLabel.Text = "equipment name:";
            equipment_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_typeLabel
            // 
            equipment_typeLabel.AutoSize = true;
            equipment_typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_typeLabel.Location = new System.Drawing.Point(783, 0);
            equipment_typeLabel.Name = "equipment_typeLabel";
            equipment_typeLabel.Size = new System.Drawing.Size(254, 30);
            equipment_typeLabel.TabIndex = 3;
            equipment_typeLabel.Text = "equipment type:";
            equipment_typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_quantityLabel
            // 
            equipment_quantityLabel.AutoSize = true;
            equipment_quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_quantityLabel.Location = new System.Drawing.Point(1043, 0);
            equipment_quantityLabel.Name = "equipment_quantityLabel";
            equipment_quantityLabel.Size = new System.Drawing.Size(254, 30);
            equipment_quantityLabel.TabIndex = 3;
            equipment_quantityLabel.Text = "equipment quantity:";
            equipment_quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventory_cabinetsDataSet
            // 
            this.inventory_cabinetsDataSet.DataSetName = "inventory_cabinetsDataSet";
            this.inventory_cabinetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventory_viewBindingSource
            // 
            this.inventory_viewBindingSource.DataMember = "inventory_view";
            this.inventory_viewBindingSource.DataSource = this.inventory_cabinetsDataSet;
            // 
            // inventory_viewTableAdapter
            // 
            this.inventory_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.equipmentTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventory_viewDataGridView
            // 
            this.inventory_viewDataGridView.AllowUserToAddRows = false;
            this.inventory_viewDataGridView.AllowUserToDeleteRows = false;
            this.inventory_viewDataGridView.AutoGenerateColumns = false;
            this.inventory_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.inventory_viewDataGridView.DataSource = this.inventory_viewBindingSource;
            this.inventory_viewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory_viewDataGridView.Location = new System.Drawing.Point(3, 3);
            this.inventory_viewDataGridView.Name = "inventory_viewDataGridView";
            this.inventory_viewDataGridView.RowHeadersWidth = 51;
            this.inventory_viewDataGridView.RowTemplate.Height = 24;
            this.inventory_viewDataGridView.Size = new System.Drawing.Size(1294, 494);
            this.inventory_viewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "room_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "room_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "equipment_inventory_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "equipment_inventory_number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "equipment_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "equipment_name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "equipment_type";
            this.dataGridViewTextBoxColumn5.HeaderText = "equipment_type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "equipment_quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "equipment_quantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inventory_viewDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 500);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.equipment_quantity_checkBox, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_type_checkBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_name_checkBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_inventory_number_checkBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.teacher_name_checkBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(equipment_quantityLabel, 4, 0);
            this.tableLayoutPanel2.Controls.Add(equipment_typeLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.equipment_quantityTextBox, 4, 1);
            this.tableLayoutPanel2.Controls.Add(equipment_nameLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.equipment_typeTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.equipment_inventory_numberTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.equipment_nameTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(equipment_inventory_numberLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.teacher_nameTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(teacher_nameLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 90);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // equipment_quantity_checkBox
            // 
            this.equipment_quantity_checkBox.AutoSize = true;
            this.equipment_quantity_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_quantity_checkBox.Location = new System.Drawing.Point(1043, 63);
            this.equipment_quantity_checkBox.Name = "equipment_quantity_checkBox";
            this.equipment_quantity_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_quantity_checkBox.TabIndex = 8;
            this.equipment_quantity_checkBox.Text = "checkBox5";
            this.equipment_quantity_checkBox.UseVisualStyleBackColor = true;
            this.equipment_quantity_checkBox.CheckedChanged += new System.EventHandler(this.equipment_quantity_checkBox_CheckedChanged);
            // 
            // equipment_type_checkBox
            // 
            this.equipment_type_checkBox.AutoSize = true;
            this.equipment_type_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_type_checkBox.Location = new System.Drawing.Point(783, 63);
            this.equipment_type_checkBox.Name = "equipment_type_checkBox";
            this.equipment_type_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_type_checkBox.TabIndex = 7;
            this.equipment_type_checkBox.Text = "checkBox4";
            this.equipment_type_checkBox.UseVisualStyleBackColor = true;
            this.equipment_type_checkBox.CheckedChanged += new System.EventHandler(this.equipment_type_checkBox_CheckedChanged);
            // 
            // equipment_name_checkBox
            // 
            this.equipment_name_checkBox.AutoSize = true;
            this.equipment_name_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_name_checkBox.Location = new System.Drawing.Point(523, 63);
            this.equipment_name_checkBox.Name = "equipment_name_checkBox";
            this.equipment_name_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_name_checkBox.TabIndex = 6;
            this.equipment_name_checkBox.Text = "checkBox3";
            this.equipment_name_checkBox.UseVisualStyleBackColor = true;
            this.equipment_name_checkBox.CheckedChanged += new System.EventHandler(this.equipment_name_checkBox_CheckedChanged);
            // 
            // equipment_inventory_number_checkBox
            // 
            this.equipment_inventory_number_checkBox.AutoSize = true;
            this.equipment_inventory_number_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_inventory_number_checkBox.Location = new System.Drawing.Point(263, 63);
            this.equipment_inventory_number_checkBox.Name = "equipment_inventory_number_checkBox";
            this.equipment_inventory_number_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_inventory_number_checkBox.TabIndex = 5;
            this.equipment_inventory_number_checkBox.Text = "checkBox2";
            this.equipment_inventory_number_checkBox.UseVisualStyleBackColor = true;
            this.equipment_inventory_number_checkBox.CheckedChanged += new System.EventHandler(this.equipment_inventory_number_checkBox_CheckedChanged);
            // 
            // teacher_name_checkBox
            // 
            this.teacher_name_checkBox.AutoSize = true;
            this.teacher_name_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_name_checkBox.Location = new System.Drawing.Point(3, 63);
            this.teacher_name_checkBox.Name = "teacher_name_checkBox";
            this.teacher_name_checkBox.Size = new System.Drawing.Size(254, 24);
            this.teacher_name_checkBox.TabIndex = 4;
            this.teacher_name_checkBox.Text = "checkBox1";
            this.teacher_name_checkBox.UseVisualStyleBackColor = true;
            this.teacher_name_checkBox.CheckedChanged += new System.EventHandler(this.teacher_name_checkBox_CheckedChanged);
            // 
            // equipment_quantityTextBox
            // 
            this.equipment_quantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_quantityTextBox.Location = new System.Drawing.Point(1043, 33);
            this.equipment_quantityTextBox.Name = "equipment_quantityTextBox";
            this.equipment_quantityTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_quantityTextBox.TabIndex = 4;
            this.equipment_quantityTextBox.TextChanged += new System.EventHandler(this.equipment_quantityTextBox_TextChanged);
            // 
            // equipment_typeTextBox
            // 
            this.equipment_typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_typeTextBox.Location = new System.Drawing.Point(783, 33);
            this.equipment_typeTextBox.Name = "equipment_typeTextBox";
            this.equipment_typeTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_typeTextBox.TabIndex = 4;
            this.equipment_typeTextBox.TextChanged += new System.EventHandler(this.equipment_typeTextBox_TextChanged);
            // 
            // equipment_inventory_numberTextBox
            // 
            this.equipment_inventory_numberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_inventory_numberTextBox.Location = new System.Drawing.Point(263, 33);
            this.equipment_inventory_numberTextBox.Name = "equipment_inventory_numberTextBox";
            this.equipment_inventory_numberTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_inventory_numberTextBox.TabIndex = 4;
            this.equipment_inventory_numberTextBox.TextChanged += new System.EventHandler(this.equipment_inventory_numberTextBox_TextChanged);
            // 
            // equipment_nameTextBox
            // 
            this.equipment_nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_nameTextBox.Location = new System.Drawing.Point(523, 33);
            this.equipment_nameTextBox.Name = "equipment_nameTextBox";
            this.equipment_nameTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_nameTextBox.TabIndex = 4;
            this.equipment_nameTextBox.TextChanged += new System.EventHandler(this.equipment_nameTextBox_TextChanged);
            // 
            // teacher_nameTextBox
            // 
            this.teacher_nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_nameTextBox.Location = new System.Drawing.Point(3, 33);
            this.teacher_nameTextBox.Name = "teacher_nameTextBox";
            this.teacher_nameTextBox.Size = new System.Drawing.Size(254, 22);
            this.teacher_nameTextBox.TabIndex = 4;
            this.teacher_nameTextBox.TextChanged += new System.EventHandler(this.teacher_nameTextBox_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_viewDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private inventory_cabinetsDataSet inventory_cabinetsDataSet;
        private System.Windows.Forms.BindingSource inventory_viewBindingSource;
        private inventory_cabinetsDataSetTableAdapters.inventory_viewTableAdapter inventory_viewTableAdapter;
        private inventory_cabinetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventory_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox equipment_quantity_checkBox;
        private System.Windows.Forms.CheckBox equipment_type_checkBox;
        private System.Windows.Forms.CheckBox equipment_name_checkBox;
        private System.Windows.Forms.CheckBox equipment_inventory_number_checkBox;
        private System.Windows.Forms.CheckBox teacher_name_checkBox;
        private System.Windows.Forms.TextBox equipment_quantityTextBox;
        private System.Windows.Forms.TextBox equipment_typeTextBox;
        private System.Windows.Forms.TextBox equipment_inventory_numberTextBox;
        private System.Windows.Forms.TextBox equipment_nameTextBox;
        private System.Windows.Forms.TextBox teacher_nameTextBox;
    }
}