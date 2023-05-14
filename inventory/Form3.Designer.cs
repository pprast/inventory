namespace inventory
{
    partial class Form3
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
            System.Windows.Forms.Label room_nameLabel;
            System.Windows.Forms.Label equipment_quantityLabel;
            System.Windows.Forms.Label equipment_nameLabel;
            System.Windows.Forms.Label equipment_inventory_numberLabel;
            System.Windows.Forms.Label equipment_typeLabel;
            this.inventory_cabinetsDataSet = new inventory.inventory_cabinetsDataSet();
            this.equipment_info_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipment_info_viewTableAdapter = new inventory.inventory_cabinetsDataSetTableAdapters.equipment_info_viewTableAdapter();
            this.tableAdapterManager = new inventory.inventory_cabinetsDataSetTableAdapters.TableAdapterManager();
            this.equipment_info_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment_inventory_number_checkBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.room_nameTextBox = new System.Windows.Forms.TextBox();
            this.equipment_typeTextBox = new System.Windows.Forms.TextBox();
            this.equipment_quantityTextBox = new System.Windows.Forms.TextBox();
            this.equipment_inventory_numberTextBox = new System.Windows.Forms.TextBox();
            this.equipment_nameTextBox = new System.Windows.Forms.TextBox();
            this.equipment_name_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_type_checkBox = new System.Windows.Forms.CheckBox();
            this.equipment_quantity_checkBox = new System.Windows.Forms.CheckBox();
            this.room_name_checkBox = new System.Windows.Forms.CheckBox();
            this.insert_equipment = new System.Windows.Forms.Button();
            this.delete_equipment = new System.Windows.Forms.Button();
            room_nameLabel = new System.Windows.Forms.Label();
            equipment_quantityLabel = new System.Windows.Forms.Label();
            equipment_nameLabel = new System.Windows.Forms.Label();
            equipment_inventory_numberLabel = new System.Windows.Forms.Label();
            equipment_typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_info_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_info_viewDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventory_cabinetsDataSet
            // 
            this.inventory_cabinetsDataSet.DataSetName = "inventory_cabinetsDataSet";
            this.inventory_cabinetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipment_info_viewBindingSource
            // 
            this.equipment_info_viewBindingSource.DataMember = "equipment_info_view";
            this.equipment_info_viewBindingSource.DataSource = this.inventory_cabinetsDataSet;
            // 
            // equipment_info_viewTableAdapter
            // 
            this.equipment_info_viewTableAdapter.ClearBeforeFill = true;
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
            // equipment_info_viewDataGridView
            // 
            this.equipment_info_viewDataGridView.AutoGenerateColumns = false;
            this.equipment_info_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipment_info_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.equipment_info_viewDataGridView.DataSource = this.equipment_info_viewBindingSource;
            this.equipment_info_viewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_info_viewDataGridView.Location = new System.Drawing.Point(3, 3);
            this.equipment_info_viewDataGridView.Name = "equipment_info_viewDataGridView";
            this.equipment_info_viewDataGridView.RowHeadersWidth = 51;
            this.equipment_info_viewDataGridView.RowTemplate.Height = 24;
            this.equipment_info_viewDataGridView.Size = new System.Drawing.Size(1294, 394);
            this.equipment_info_viewDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.equipment_info_viewDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 400);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "equipment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "equipment_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "equipment_inventory_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "equipment_inventory_number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "equipment_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "equipment_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "equipment_type";
            this.dataGridViewTextBoxColumn4.HeaderText = "equipment_type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "equipment_quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "equipment_quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "room_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "room_name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // equipment_inventory_number_checkBox
            // 
            this.equipment_inventory_number_checkBox.AutoSize = true;
            this.equipment_inventory_number_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_inventory_number_checkBox.Location = new System.Drawing.Point(3, 63);
            this.equipment_inventory_number_checkBox.Name = "equipment_inventory_number_checkBox";
            this.equipment_inventory_number_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_inventory_number_checkBox.TabIndex = 4;
            this.equipment_inventory_number_checkBox.Text = "checkBox1";
            this.equipment_inventory_number_checkBox.UseVisualStyleBackColor = true;
            this.equipment_inventory_number_checkBox.CheckedChanged += new System.EventHandler(this.equipment_inventory_number_checkBox_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.room_name_checkBox, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_quantity_checkBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_type_checkBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.equipment_name_checkBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(room_nameLabel, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.equipment_inventory_number_checkBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(equipment_quantityLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.room_nameTextBox, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.equipment_typeTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.equipment_quantityTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(equipment_nameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.equipment_inventory_numberTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.equipment_nameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(equipment_inventory_numberLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(equipment_typeLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.insert_equipment, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.delete_equipment, 4, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 130);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // room_nameLabel
            // 
            room_nameLabel.AutoSize = true;
            room_nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            room_nameLabel.Location = new System.Drawing.Point(1043, 0);
            room_nameLabel.Name = "room_nameLabel";
            room_nameLabel.Size = new System.Drawing.Size(254, 30);
            room_nameLabel.TabIndex = 3;
            room_nameLabel.Text = "room name:";
            room_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_quantityLabel
            // 
            equipment_quantityLabel.AutoSize = true;
            equipment_quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_quantityLabel.Location = new System.Drawing.Point(783, 0);
            equipment_quantityLabel.Name = "equipment_quantityLabel";
            equipment_quantityLabel.Size = new System.Drawing.Size(254, 30);
            equipment_quantityLabel.TabIndex = 3;
            equipment_quantityLabel.Text = "equipment quantity:";
            equipment_quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // room_nameTextBox
            // 
            this.room_nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_nameTextBox.Location = new System.Drawing.Point(1043, 33);
            this.room_nameTextBox.Name = "room_nameTextBox";
            this.room_nameTextBox.Size = new System.Drawing.Size(254, 22);
            this.room_nameTextBox.TabIndex = 4;
            this.room_nameTextBox.TextChanged += new System.EventHandler(this.room_nameTextBox_TextChanged);
            // 
            // equipment_typeTextBox
            // 
            this.equipment_typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_typeTextBox.Location = new System.Drawing.Point(523, 33);
            this.equipment_typeTextBox.Name = "equipment_typeTextBox";
            this.equipment_typeTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_typeTextBox.TabIndex = 4;
            this.equipment_typeTextBox.TextChanged += new System.EventHandler(this.equipment_typeTextBox_TextChanged);
            // 
            // equipment_quantityTextBox
            // 
            this.equipment_quantityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_quantityTextBox.Location = new System.Drawing.Point(783, 33);
            this.equipment_quantityTextBox.Name = "equipment_quantityTextBox";
            this.equipment_quantityTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_quantityTextBox.TabIndex = 4;
            this.equipment_quantityTextBox.TextChanged += new System.EventHandler(this.equipment_quantityTextBox_TextChanged);
            // 
            // equipment_nameLabel
            // 
            equipment_nameLabel.AutoSize = true;
            equipment_nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_nameLabel.Location = new System.Drawing.Point(263, 0);
            equipment_nameLabel.Name = "equipment_nameLabel";
            equipment_nameLabel.Size = new System.Drawing.Size(254, 30);
            equipment_nameLabel.TabIndex = 3;
            equipment_nameLabel.Text = "equipment name:";
            equipment_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_inventory_numberTextBox
            // 
            this.equipment_inventory_numberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_inventory_numberTextBox.Location = new System.Drawing.Point(3, 33);
            this.equipment_inventory_numberTextBox.Name = "equipment_inventory_numberTextBox";
            this.equipment_inventory_numberTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_inventory_numberTextBox.TabIndex = 4;
            this.equipment_inventory_numberTextBox.TextChanged += new System.EventHandler(this.equipment_inventory_numberTextBox_TextChanged);
            // 
            // equipment_nameTextBox
            // 
            this.equipment_nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_nameTextBox.Location = new System.Drawing.Point(263, 33);
            this.equipment_nameTextBox.Name = "equipment_nameTextBox";
            this.equipment_nameTextBox.Size = new System.Drawing.Size(254, 22);
            this.equipment_nameTextBox.TabIndex = 4;
            this.equipment_nameTextBox.TextChanged += new System.EventHandler(this.equipment_nameTextBox_TextChanged);
            // 
            // equipment_inventory_numberLabel
            // 
            equipment_inventory_numberLabel.AutoSize = true;
            equipment_inventory_numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_inventory_numberLabel.Location = new System.Drawing.Point(3, 0);
            equipment_inventory_numberLabel.Name = "equipment_inventory_numberLabel";
            equipment_inventory_numberLabel.Size = new System.Drawing.Size(254, 30);
            equipment_inventory_numberLabel.TabIndex = 3;
            equipment_inventory_numberLabel.Text = "equipment inventory number:";
            equipment_inventory_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_typeLabel
            // 
            equipment_typeLabel.AutoSize = true;
            equipment_typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            equipment_typeLabel.Location = new System.Drawing.Point(523, 0);
            equipment_typeLabel.Name = "equipment_typeLabel";
            equipment_typeLabel.Size = new System.Drawing.Size(254, 30);
            equipment_typeLabel.TabIndex = 3;
            equipment_typeLabel.Text = "equipment type:";
            equipment_typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipment_name_checkBox
            // 
            this.equipment_name_checkBox.AutoSize = true;
            this.equipment_name_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_name_checkBox.Location = new System.Drawing.Point(263, 63);
            this.equipment_name_checkBox.Name = "equipment_name_checkBox";
            this.equipment_name_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_name_checkBox.TabIndex = 5;
            this.equipment_name_checkBox.Text = "checkBox2";
            this.equipment_name_checkBox.UseVisualStyleBackColor = true;
            this.equipment_name_checkBox.CheckedChanged += new System.EventHandler(this.equipment_name_checkBox_CheckedChanged);
            // 
            // equipment_type_checkBox
            // 
            this.equipment_type_checkBox.AutoSize = true;
            this.equipment_type_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_type_checkBox.Location = new System.Drawing.Point(523, 63);
            this.equipment_type_checkBox.Name = "equipment_type_checkBox";
            this.equipment_type_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_type_checkBox.TabIndex = 6;
            this.equipment_type_checkBox.Text = "checkBox3";
            this.equipment_type_checkBox.UseVisualStyleBackColor = true;
            this.equipment_type_checkBox.CheckedChanged += new System.EventHandler(this.equipment_type_checkBox_CheckedChanged);
            // 
            // equipment_quantity_checkBox
            // 
            this.equipment_quantity_checkBox.AutoSize = true;
            this.equipment_quantity_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipment_quantity_checkBox.Location = new System.Drawing.Point(783, 63);
            this.equipment_quantity_checkBox.Name = "equipment_quantity_checkBox";
            this.equipment_quantity_checkBox.Size = new System.Drawing.Size(254, 24);
            this.equipment_quantity_checkBox.TabIndex = 7;
            this.equipment_quantity_checkBox.Text = "checkBox4";
            this.equipment_quantity_checkBox.UseVisualStyleBackColor = true;
            this.equipment_quantity_checkBox.CheckedChanged += new System.EventHandler(this.equipment_quantity_checkBox_CheckedChanged);
            // 
            // room_name_checkBox
            // 
            this.room_name_checkBox.AutoSize = true;
            this.room_name_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_name_checkBox.Location = new System.Drawing.Point(1043, 63);
            this.room_name_checkBox.Name = "room_name_checkBox";
            this.room_name_checkBox.Size = new System.Drawing.Size(254, 24);
            this.room_name_checkBox.TabIndex = 8;
            this.room_name_checkBox.Text = "checkBox5";
            this.room_name_checkBox.UseVisualStyleBackColor = true;
            this.room_name_checkBox.CheckedChanged += new System.EventHandler(this.room_name_checkBox_CheckedChanged);
            // 
            // insert_equipment
            // 
            this.insert_equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert_equipment.Location = new System.Drawing.Point(783, 93);
            this.insert_equipment.Name = "insert_equipment";
            this.insert_equipment.Size = new System.Drawing.Size(254, 34);
            this.insert_equipment.TabIndex = 9;
            this.insert_equipment.Text = "добавить";
            this.insert_equipment.UseVisualStyleBackColor = true;
            this.insert_equipment.Click += new System.EventHandler(this.insert_equipment_Click);
            // 
            // delete_equipment
            // 
            this.delete_equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_equipment.Location = new System.Drawing.Point(1043, 93);
            this.delete_equipment.Name = "delete_equipment";
            this.delete_equipment.Size = new System.Drawing.Size(254, 34);
            this.delete_equipment.TabIndex = 10;
            this.delete_equipment.Text = "удалить";
            this.delete_equipment.UseVisualStyleBackColor = true;
            this.delete_equipment.Click += new System.EventHandler(this.delete_equipment_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_cabinetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_info_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipment_info_viewDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private inventory_cabinetsDataSet inventory_cabinetsDataSet;
        private System.Windows.Forms.BindingSource equipment_info_viewBindingSource;
        private inventory_cabinetsDataSetTableAdapters.equipment_info_viewTableAdapter equipment_info_viewTableAdapter;
        private inventory_cabinetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView equipment_info_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox equipment_inventory_number_checkBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox room_name_checkBox;
        private System.Windows.Forms.CheckBox equipment_quantity_checkBox;
        private System.Windows.Forms.CheckBox equipment_type_checkBox;
        private System.Windows.Forms.CheckBox equipment_name_checkBox;
        private System.Windows.Forms.TextBox room_nameTextBox;
        private System.Windows.Forms.TextBox equipment_typeTextBox;
        private System.Windows.Forms.TextBox equipment_quantityTextBox;
        private System.Windows.Forms.TextBox equipment_inventory_numberTextBox;
        private System.Windows.Forms.TextBox equipment_nameTextBox;
        private System.Windows.Forms.Button insert_equipment;
        private System.Windows.Forms.Button delete_equipment;
    }
}